﻿using NLog;
using NLog.Fluent;
using System.Net;
using System.Net.Sockets;

namespace ServerCore
{
    public class Listener
    {
        private Socket _listenSocket;
        private Action<Socket> _onAcceptHandler;

        public void Initialize(IPEndPoint endPoint, Action<Socket> onAcceptHandler)
        {
            _listenSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _onAcceptHandler += onAcceptHandler;

            _listenSocket.Bind(endPoint);
            _listenSocket.Listen(10);

            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            args.Completed += new EventHandler<SocketAsyncEventArgs>(OnAcceptCompleted);
            RegisterAccept(args, GetListenSocket());
        }

        private Socket? GetListenSocket()
        {
            return _listenSocket;
        }

        void RegisterAccept(SocketAsyncEventArgs args, Socket? _listenSocket)
        {
            args.AcceptSocket = null;

            bool pending = _listenSocket.AcceptAsync(args);
            if (!pending)
                OnAcceptCompleted(null, args);
        }

        void OnAcceptCompleted(object? sender, SocketAsyncEventArgs args)
        {
            if (args.SocketError == SocketError.Success)
            {
                _onAcceptHandler?.Invoke(args.AcceptSocket);
            }
            else
            {
                Log.Warn(args.SocketError.ToString());
            }

            RegisterAccept(args, GetListenSocket());
        }

        public Socket Accept()
        {
            return _listenSocket.Accept();
        }
    }
}
