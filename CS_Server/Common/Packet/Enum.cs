// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Enum.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.Enum {

  /// <summary>Holder for reflection information generated from Enum.proto</summary>
  public static partial class EnumReflection {

    #region Descriptor
    /// <summary>File descriptor for Enum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpFbnVtLnByb3RvEghQcm90b2NvbCp0Cg1DcmVhdHVyZVN0YXRlEhcKE0Ny",
            "ZWF0dXJlX1N0YXRlX0lkbGUQABIXChNDcmVhdHVyZV9TdGF0ZV9Nb3ZlEAES",
            "GAoUQ3JlYXR1cmVfU3RhdGVfU2tpbGwQAhIXChNDcmVhdHVyZV9TdGF0ZV9E",
            "ZWFkEAMqVAoHTW92ZURpchIPCgtNb3ZlX0Rpcl9VcBAAEhEKDU1vdmVfRGly",
            "X0Rvd24QARIRCg1Nb3ZlX0Rpcl9MZWZ0EAISEgoOTW92ZV9EaXJfUmlnaHQQ",
            "AyqHAQoOR2FtZU9iamVjdFR5cGUSGQoVR2FtZV9PYmplY3RfVHlwZV9Ob25l",
            "EAASGwoXR2FtZV9PYmplY3RfVHlwZV9QbGF5ZXIQARIcChhHYW1lX09iamVj",
            "dF9UeXBlX01vbnN0ZXIQAhIfChtHYW1lX09iamVjdF9UeXBlX1Byb2plY3Rp",
            "bGUQBCpQCglTa2lsbFR5cGUSEwoPU2tpbGxfVHlwZV9Ob25lEAASEwoPU2tp",
            "bGxfVHlwZV9BdXRvEAESGQoVU2tpbGxfVHlwZV9Qcm9qZWN0aWxlEAIqVgoL",
            "U2VydmVyU3RhdGUSFgoSU2VydmVyX1N0YXRlX0xvZ2luEAASFgoSU2VydmVy",
            "X1N0YXRlX0xvYmJ5EAESFwoTU2VydmVyX1N0YXRlX0luR2FtZRACKmMKCEl0",
            "ZW1UeXBlEhIKDkl0ZW1fVHlwZV9Ob25lEAASFAoQSXRlbV9UeXBlX1dlYXBv",
            "bhABEhMKD0l0ZW1fVHlwZV9Bcm1vchACEhgKFEl0ZW1fVHlwZV9Db25zdW1h",
            "YmxlEAMqZQoKV2VhcG9uVHlwZRIUChBXZWFwb25fVHlwZV9Ob25lEAASFQoR",
            "V2VhcG9uX1R5cGVfU3dvcmQQARITCg9XZWFwb25fVHlwZV9Cb3cQAhIVChFX",
            "ZWFwb25fVHlwZV9TdGFmZhADKmMKCUFybW9yVHlwZRITCg9Bcm1vcl9UeXBl",
            "X05vbmUQABIVChFBcm1vcl9UeXBlX0hlbG1ldBABEhQKEEFybW9yX1R5cGVf",
            "QXJtb3IQAhIUChBBcm1vcl9UeXBlX0Jvb3RzEAMqaAoOQ29uc3VtYWJsZVR5",
            "cGUSGAoUQ29uc3VtYWJsZV9UeXBlX05vbmUQABIdChlDb25zdW1hYmxlX1R5",
            "cGVfSHBfUG90aW9uEAESHQoZQ29uc3VtYWJsZV9UeXBlX01wX1BvdGlvbhAC",
            "Ko4BCglFcnJvclR5cGUSCwoHU3VjY2VzcxAAEggKBEZhaWwQARIMCghEYl9F",
            "cnJvchACEhMKD0ludmFsaWRfQWNjb3VudBADEhgKFEludmFsaWRfU2VydmVy",
            "X1N0YXRlEAoSFgoSQWxyZWFkeV9FeGlzdF9OYW1lEBQSFQoRSW52YWxpZF9H",
            "YW1lX0RhdGEQHkIXqgIUR29vZ2xlLlByb3RvYnVmLkVudW1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Protobuf.Enum.CreatureState), typeof(global::Google.Protobuf.Enum.MoveDir), typeof(global::Google.Protobuf.Enum.GameObjectType), typeof(global::Google.Protobuf.Enum.SkillType), typeof(global::Google.Protobuf.Enum.ServerState), typeof(global::Google.Protobuf.Enum.ItemType), typeof(global::Google.Protobuf.Enum.WeaponType), typeof(global::Google.Protobuf.Enum.ArmorType), typeof(global::Google.Protobuf.Enum.ConsumableType), typeof(global::Google.Protobuf.Enum.ErrorType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CreatureState {
    [pbr::OriginalName("Creature_State_Idle")] Idle = 0,
    [pbr::OriginalName("Creature_State_Move")] Move = 1,
    [pbr::OriginalName("Creature_State_Skill")] Skill = 2,
    [pbr::OriginalName("Creature_State_Dead")] Dead = 3,
  }

  public enum MoveDir {
    [pbr::OriginalName("Move_Dir_Up")] Up = 0,
    [pbr::OriginalName("Move_Dir_Down")] Down = 1,
    [pbr::OriginalName("Move_Dir_Left")] Left = 2,
    [pbr::OriginalName("Move_Dir_Right")] Right = 3,
  }

  public enum GameObjectType {
    [pbr::OriginalName("Game_Object_Type_None")] None = 0,
    [pbr::OriginalName("Game_Object_Type_Player")] Player = 1,
    [pbr::OriginalName("Game_Object_Type_Monster")] Monster = 2,
    [pbr::OriginalName("Game_Object_Type_Projectile")] Projectile = 4,
  }

  public enum SkillType {
    [pbr::OriginalName("Skill_Type_None")] None = 0,
    [pbr::OriginalName("Skill_Type_Auto")] Auto = 1,
    [pbr::OriginalName("Skill_Type_Projectile")] Projectile = 2,
  }

  public enum ServerState {
    [pbr::OriginalName("Server_State_Login")] Login = 0,
    [pbr::OriginalName("Server_State_Lobby")] Lobby = 1,
    [pbr::OriginalName("Server_State_InGame")] InGame = 2,
  }

  public enum ItemType {
    [pbr::OriginalName("Item_Type_None")] None = 0,
    [pbr::OriginalName("Item_Type_Weapon")] Weapon = 1,
    [pbr::OriginalName("Item_Type_Armor")] Armor = 2,
    [pbr::OriginalName("Item_Type_Consumable")] Consumable = 3,
  }

  public enum WeaponType {
    [pbr::OriginalName("Weapon_Type_None")] None = 0,
    [pbr::OriginalName("Weapon_Type_Sword")] Sword = 1,
    [pbr::OriginalName("Weapon_Type_Bow")] Bow = 2,
    [pbr::OriginalName("Weapon_Type_Staff")] Staff = 3,
  }

  public enum ArmorType {
    [pbr::OriginalName("Armor_Type_None")] None = 0,
    [pbr::OriginalName("Armor_Type_Helmet")] Helmet = 1,
    [pbr::OriginalName("Armor_Type_Armor")] Armor = 2,
    [pbr::OriginalName("Armor_Type_Boots")] Boots = 3,
  }

  public enum ConsumableType {
    [pbr::OriginalName("Consumable_Type_None")] None = 0,
    [pbr::OriginalName("Consumable_Type_Hp_Potion")] HpPotion = 1,
    [pbr::OriginalName("Consumable_Type_Mp_Potion")] MpPotion = 2,
  }

  public enum ErrorType {
    [pbr::OriginalName("Success")] Success = 0,
    [pbr::OriginalName("Fail")] Fail = 1,
    [pbr::OriginalName("Db_Error")] DbError = 2,
    [pbr::OriginalName("Invalid_Account")] InvalidAccount = 3,
    [pbr::OriginalName("Invalid_Server_State")] InvalidServerState = 10,
    [pbr::OriginalName("Already_Exist_Name")] AlreadyExistName = 20,
    [pbr::OriginalName("Invalid_Game_Data")] InvalidGameData = 30,
  }

  #endregion

}

#endregion Designer generated code
