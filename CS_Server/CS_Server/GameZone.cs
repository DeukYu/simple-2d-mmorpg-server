﻿using Google.Protobuf;
using Google.Protobuf.Common;
using Google.Protobuf.Enum;
using Google.Protobuf.Protocol;
using ServerCore;

namespace CS_Server;

class GameZone : IJobQueue
{
    List<ClientSession> _sessions = new List<ClientSession>();
    JobQueue _jobQueue = new JobQueue();
    List<ArraySegment<byte>> _pendingList = new List<ArraySegment<byte>>();

    public void Push(Action job)
    {
        _jobQueue.Push(job);
    }

    public void Flush()
    {
        foreach (ClientSession session in _sessions)
        {
            session.Send(_pendingList);
        }
    }

    public void Broadcast(ArraySegment<byte> segment)
    {
        _pendingList.Add(segment);
    }

    public void Enter(ClientSession session)
    {
        _sessions.Add(session);

        session.Zone = this;

        {
            // 모든 플레이어 목록 전송
            S2C_PlayerList res = new S2C_PlayerList();
            foreach (ClientSession s in _sessions)
            {
                res.Players.Add(new TPlayer
                {
                    IsSelf = (s == session),
                    PlayerId = s.SessionId,
                    PosX = s.PosX,
                    PosY = s.PosY,
                    PosZ = s.PosZ
                });
            }
            res.Result = (int)ErrorType.Success;

            ushort size = (ushort)res.CalculateSize();

            byte[] sendBuffer = new byte[size + 4];
            Array.Copy(BitConverter.GetBytes(size + 4), 0, sendBuffer, 0, sizeof(ushort));

            ushort protocolId = PacketManager.Instance.GetMessageId(res.GetType());
            Array.Copy(BitConverter.GetBytes(protocolId), 0, sendBuffer, 2, sizeof(ushort));

            Array.Copy(res.ToByteArray(), 0, sendBuffer, 4, size);
            var buff = new ArraySegment<byte>(sendBuffer);
            session.Send(buff);
        }


        // 새로운 플레이어 입장을 모두에게 알림
        {
            S2C_BroadcastEnterGame enter = new S2C_BroadcastEnterGame();

            enter.PlayerId = session.SessionId;
            enter.PosX = session.PosX;
            enter.PosY = session.PosY;
            enter.PosZ = session.PosZ;

            enter.Result = (int)ErrorType.Success;

            ushort size = (ushort)enter.CalculateSize();

            byte[] sendBuffer = new byte[size + 4];
            Array.Copy(BitConverter.GetBytes(size + 4), 0, sendBuffer, 0, sizeof(ushort));

            ushort protocolId = PacketManager.Instance.GetMessageId(enter.GetType());
            Array.Copy(BitConverter.GetBytes(protocolId), 0, sendBuffer, 2, sizeof(ushort));

            Array.Copy(enter.ToByteArray(), 0, sendBuffer, 4, size);
            var buff = new ArraySegment<byte>(sendBuffer);

            Broadcast(buff);
        }
    }

    public void Leave(ClientSession session)
    {
        // 플레이어 제거
        _sessions.Remove(session);

        // 모두에게 알림
        S2C_BroadcastLeaveGame leave = new S2C_BroadcastLeaveGame();
        leave.PlayerId = session.SessionId;

        leave.Result = (int)ErrorType.Success;

        ushort size = (ushort)leave.CalculateSize();
        byte[] sendBuffer = new byte[size + 4];
        Array.Copy(BitConverter.GetBytes(size + 4), 0, sendBuffer, 0, sizeof(ushort));
        ushort protocolId = (ushort)MsgId.S2CBroadcastleavegame;
        Array.Copy(BitConverter.GetBytes(protocolId), 0, sendBuffer, 2, sizeof(ushort));
        Array.Copy(leave.ToByteArray(), 0, sendBuffer, 4, size);
        var buff = new ArraySegment<byte>(sendBuffer);


        Broadcast(buff);
    }

    public void Move(ClientSession session, C2S_Move packet)
    {
        session.PosX = packet.PosX;
        session.PosY = packet.PosY;
        session.PosZ = packet.PosZ;

        S2C_BroadcastMove move = new S2C_BroadcastMove();
        move.PlayerId = session.SessionId;
        move.PosX = session.PosX;
        move.PosY = session.PosY;
        move.PosZ = session.PosZ;

        // 모두에게 알림
        move.Result = (int)ErrorType.Success;

        ushort size = (ushort)move.CalculateSize();
        byte[] sendBuffer = new byte[size + 4];
        Array.Copy(BitConverter.GetBytes(size + 4), 0, sendBuffer, 0, sizeof(ushort));
        ushort protocolId = (ushort)MsgId.S2CBroadcastmove;
        Array.Copy(BitConverter.GetBytes(protocolId), 0, sendBuffer, 2, sizeof(ushort));
        Array.Copy(move.ToByteArray(), 0, sendBuffer, 4, size);
        var buff = new ArraySegment<byte>(sendBuffer);

        Broadcast(buff);
    }
}