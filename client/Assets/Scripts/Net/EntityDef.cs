/*
	Generated by KBEngine!
	Please do not modify this file!
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class EntityDef
	{
		public static Dictionary<string, UInt16> datatype2id = new Dictionary<string, UInt16>();
		public static Dictionary<string, DATATYPE_BASE> datatypes = new Dictionary<string, DATATYPE_BASE>();
		public static Dictionary<UInt16, DATATYPE_BASE> id2datatypes = new Dictionary<UInt16, DATATYPE_BASE>();
		public static Dictionary<string, Int32> entityclass = new Dictionary<string, Int32>();
		public static Dictionary<string, ScriptModule> moduledefs = new Dictionary<string, ScriptModule>();
		public static Dictionary<UInt16, ScriptModule> idmoduledefs = new Dictionary<UInt16, ScriptModule>();

		public static bool init()
		{
			initDataTypes();
			initDefTypes();
			initScriptModules();
			return true;
		}

		public static bool reset()
		{
			clear();
			return init();
		}

		public static void clear()
		{
			datatype2id.Clear();
			datatypes.Clear();
			id2datatypes.Clear();
			entityclass.Clear();
			moduledefs.Clear();
			idmoduledefs.Clear();
		}

		public static void initDataTypes()
		{
			datatypes["UINT8"] = new DATATYPE_UINT8();
			datatypes["UINT16"] = new DATATYPE_UINT16();
			datatypes["UINT32"] = new DATATYPE_UINT32();
			datatypes["UINT64"] = new DATATYPE_UINT64();

			datatypes["INT8"] = new DATATYPE_INT8();
			datatypes["INT16"] = new DATATYPE_INT16();
			datatypes["INT32"] = new DATATYPE_INT32();
			datatypes["INT64"] = new DATATYPE_INT64();

			datatypes["FLOAT"] = new DATATYPE_FLOAT();
			datatypes["DOUBLE"] = new DATATYPE_DOUBLE();

			datatypes["STRING"] = new DATATYPE_STRING();
			datatypes["VECTOR2"] = new DATATYPE_VECTOR2();

			datatypes["VECTOR3"] = new DATATYPE_VECTOR3();

			datatypes["VECTOR4"] = new DATATYPE_VECTOR4();
			datatypes["PYTHON"] = new DATATYPE_PYTHON();

			datatypes["UNICODE"] = new DATATYPE_UNICODE();
			datatypes["ENTITYCALL"] = new DATATYPE_ENTITYCALL();

			datatypes["BLOB"] = new DATATYPE_BLOB();
		}

		public static void initScriptModules()
		{
			ScriptModule pAccountModule = new ScriptModule("Account");
			EntityDef.moduledefs["Account"] = pAccountModule;
			EntityDef.idmoduledefs[1] = pAccountModule;

			Property pAccount_position = new Property();
			pAccount_position.name = "position";
			pAccount_position.properUtype = 40000;
			pAccount_position.properFlags = 4;
			pAccount_position.aliasID = 1;
			Vector3 Account_position_defval = new Vector3();
			pAccount_position.defaultVal = Account_position_defval;
			pAccountModule.propertys["position"] = pAccount_position; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_position.aliasID] = pAccount_position;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(position / 40000).");

			Property pAccount_direction = new Property();
			pAccount_direction.name = "direction";
			pAccount_direction.properUtype = 40001;
			pAccount_direction.properFlags = 4;
			pAccount_direction.aliasID = 2;
			Vector3 Account_direction_defval = new Vector3();
			pAccount_direction.defaultVal = Account_direction_defval;
			pAccountModule.propertys["direction"] = pAccount_direction; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_direction.aliasID] = pAccount_direction;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(direction / 40001).");

			Property pAccount_spaceID = new Property();
			pAccount_spaceID.name = "spaceID";
			pAccount_spaceID.properUtype = 40002;
			pAccount_spaceID.properFlags = 16;
			pAccount_spaceID.aliasID = 3;
			UInt32 Account_spaceID_defval;
			UInt32.TryParse("", out Account_spaceID_defval);
			pAccount_spaceID.defaultVal = Account_spaceID_defval;
			pAccountModule.propertys["spaceID"] = pAccount_spaceID; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_spaceID.aliasID] = pAccount_spaceID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(spaceID / 40002).");

			Property pAccount_CampType = new Property();
			pAccount_CampType.name = "CampType";
			pAccount_CampType.properUtype = 5;
			pAccount_CampType.properFlags = 32;
			pAccount_CampType.aliasID = 4;
			Int16 Account_CampType_defval;
			Int16.TryParse("0", out Account_CampType_defval);
			pAccount_CampType.defaultVal = Account_CampType_defval;
			pAccountModule.propertys["CampType"] = pAccount_CampType; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_CampType.aliasID] = pAccount_CampType;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(CampType / 5).");

			Property pAccount_MineChess = new Property();
			pAccount_MineChess.name = "MineChess";
			pAccount_MineChess.properUtype = 3;
			pAccount_MineChess.properFlags = 32;
			pAccount_MineChess.aliasID = 5;
			pAccount_MineChess.defaultVal = EntityDef.id2datatypes[23].parseDefaultValStr("");
			pAccountModule.propertys["MineChess"] = pAccount_MineChess; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_MineChess.aliasID] = pAccount_MineChess;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(MineChess / 3).");

			Property pAccount_RoleName = new Property();
			pAccount_RoleName.name = "RoleName";
			pAccount_RoleName.properUtype = 2;
			pAccount_RoleName.properFlags = 32;
			pAccount_RoleName.aliasID = 6;
			string Account_RoleName_defval = "";
			pAccount_RoleName.defaultVal = Account_RoleName_defval;
			pAccountModule.propertys["RoleName"] = pAccount_RoleName; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_RoleName.aliasID] = pAccount_RoleName;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(RoleName / 2).");

			Property pAccount_RoleType = new Property();
			pAccount_RoleType.name = "RoleType";
			pAccount_RoleType.properUtype = 1;
			pAccount_RoleType.properFlags = 32;
			pAccount_RoleType.aliasID = 7;
			Int16 Account_RoleType_defval;
			Int16.TryParse("0", out Account_RoleType_defval);
			pAccount_RoleType.defaultVal = Account_RoleType_defval;
			pAccountModule.propertys["RoleType"] = pAccount_RoleType; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_RoleType.aliasID] = pAccount_RoleType;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(RoleType / 1).");

			List<DATATYPE_BASE> pAccount_EntryFB_args = new List<DATATYPE_BASE>();

			Method pAccount_EntryFB = new Method();
			pAccount_EntryFB.name = "EntryFB";
			pAccount_EntryFB.methodUtype = 17;
			pAccount_EntryFB.aliasID = 1;
			pAccount_EntryFB.args = pAccount_EntryFB_args;

			pAccountModule.methods["EntryFB"] = pAccount_EntryFB; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_EntryFB.aliasID] = pAccount_EntryFB;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(EntryFB / 17).");

			List<DATATYPE_BASE> pAccount_OnAttack_args = new List<DATATYPE_BASE>();
			pAccount_OnAttack_args.Add(EntityDef.id2datatypes[8]);
			pAccount_OnAttack_args.Add(EntityDef.id2datatypes[8]);

			Method pAccount_OnAttack = new Method();
			pAccount_OnAttack.name = "OnAttack";
			pAccount_OnAttack.methodUtype = 20;
			pAccount_OnAttack.aliasID = 2;
			pAccount_OnAttack.args = pAccount_OnAttack_args;

			pAccountModule.methods["OnAttack"] = pAccount_OnAttack; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_OnAttack.aliasID] = pAccount_OnAttack;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(OnAttack / 20).");

			List<DATATYPE_BASE> pAccount_OnExitFb_args = new List<DATATYPE_BASE>();

			Method pAccount_OnExitFb = new Method();
			pAccount_OnExitFb.name = "OnExitFb";
			pAccount_OnExitFb.methodUtype = 21;
			pAccount_OnExitFb.aliasID = 3;
			pAccount_OnExitFb.args = pAccount_OnExitFb_args;

			pAccountModule.methods["OnExitFb"] = pAccount_OnExitFb; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_OnExitFb.aliasID] = pAccount_OnExitFb;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(OnExitFb / 21).");

			List<DATATYPE_BASE> pAccount_OnMove_args = new List<DATATYPE_BASE>();
			pAccount_OnMove_args.Add(EntityDef.id2datatypes[8]);
			pAccount_OnMove_args.Add(EntityDef.id2datatypes[8]);
			pAccount_OnMove_args.Add(EntityDef.id2datatypes[8]);

			Method pAccount_OnMove = new Method();
			pAccount_OnMove.name = "OnMove";
			pAccount_OnMove.methodUtype = 19;
			pAccount_OnMove.aliasID = 4;
			pAccount_OnMove.args = pAccount_OnMove_args;

			pAccountModule.methods["OnMove"] = pAccount_OnMove; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_OnMove.aliasID] = pAccount_OnMove;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(OnMove / 19).");

			List<DATATYPE_BASE> pAccount_OnStartRound_args = new List<DATATYPE_BASE>();
			pAccount_OnStartRound_args.Add(EntityDef.id2datatypes[7]);
			pAccount_OnStartRound_args.Add(EntityDef.id2datatypes[8]);

			Method pAccount_OnStartRound = new Method();
			pAccount_OnStartRound.name = "OnStartRound";
			pAccount_OnStartRound.methodUtype = 18;
			pAccount_OnStartRound.aliasID = 5;
			pAccount_OnStartRound.args = pAccount_OnStartRound_args;

			pAccountModule.methods["OnStartRound"] = pAccount_OnStartRound; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_OnStartRound.aliasID] = pAccount_OnStartRound;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(OnStartRound / 18).");

			List<DATATYPE_BASE> pAccount_ReNameResult_args = new List<DATATYPE_BASE>();
			pAccount_ReNameResult_args.Add(EntityDef.id2datatypes[7]);

			Method pAccount_ReNameResult = new Method();
			pAccount_ReNameResult.name = "ReNameResult";
			pAccount_ReNameResult.methodUtype = 16;
			pAccount_ReNameResult.aliasID = 6;
			pAccount_ReNameResult.args = pAccount_ReNameResult_args;

			pAccountModule.methods["ReNameResult"] = pAccount_ReNameResult; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_ReNameResult.aliasID] = pAccount_ReNameResult;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(ReNameResult / 16).");

			List<DATATYPE_BASE> pAccount_AttackChess_args = new List<DATATYPE_BASE>();
			pAccount_AttackChess_args.Add(EntityDef.id2datatypes[8]);
			pAccount_AttackChess_args.Add(EntityDef.id2datatypes[8]);
			pAccount_AttackChess_args.Add(EntityDef.id2datatypes[8]);
			pAccount_AttackChess_args.Add(EntityDef.id2datatypes[8]);

			Method pAccount_AttackChess = new Method();
			pAccount_AttackChess.name = "AttackChess";
			pAccount_AttackChess.methodUtype = 7;
			pAccount_AttackChess.aliasID = -1;
			pAccount_AttackChess.args = pAccount_AttackChess_args;

			pAccountModule.methods["AttackChess"] = pAccount_AttackChess; 
			pAccountModule.base_methods["AttackChess"] = pAccount_AttackChess;

			pAccountModule.idbase_methods[pAccount_AttackChess.methodUtype] = pAccount_AttackChess;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(AttackChess / 7).");

			List<DATATYPE_BASE> pAccount_ChessMove_args = new List<DATATYPE_BASE>();
			pAccount_ChessMove_args.Add(EntityDef.id2datatypes[8]);
			pAccount_ChessMove_args.Add(EntityDef.id2datatypes[8]);
			pAccount_ChessMove_args.Add(EntityDef.id2datatypes[8]);

			Method pAccount_ChessMove = new Method();
			pAccount_ChessMove.name = "ChessMove";
			pAccount_ChessMove.methodUtype = 5;
			pAccount_ChessMove.aliasID = -1;
			pAccount_ChessMove.args = pAccount_ChessMove_args;

			pAccountModule.methods["ChessMove"] = pAccount_ChessMove; 
			pAccountModule.base_methods["ChessMove"] = pAccount_ChessMove;

			pAccountModule.idbase_methods[pAccount_ChessMove.methodUtype] = pAccount_ChessMove;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(ChessMove / 5).");

			List<DATATYPE_BASE> pAccount_ClientReady_args = new List<DATATYPE_BASE>();

			Method pAccount_ClientReady = new Method();
			pAccount_ClientReady.name = "ClientReady";
			pAccount_ClientReady.methodUtype = 4;
			pAccount_ClientReady.aliasID = -1;
			pAccount_ClientReady.args = pAccount_ClientReady_args;

			pAccountModule.methods["ClientReady"] = pAccount_ClientReady; 
			pAccountModule.base_methods["ClientReady"] = pAccount_ClientReady;

			pAccountModule.idbase_methods[pAccount_ClientReady.methodUtype] = pAccount_ClientReady;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(ClientReady / 4).");

			List<DATATYPE_BASE> pAccount_EntryFBScene_args = new List<DATATYPE_BASE>();

			Method pAccount_EntryFBScene = new Method();
			pAccount_EntryFBScene.name = "EntryFBScene";
			pAccount_EntryFBScene.methodUtype = 3;
			pAccount_EntryFBScene.aliasID = -1;
			pAccount_EntryFBScene.args = pAccount_EntryFBScene_args;

			pAccountModule.methods["EntryFBScene"] = pAccount_EntryFBScene; 
			pAccountModule.base_methods["EntryFBScene"] = pAccount_EntryFBScene;

			pAccountModule.idbase_methods[pAccount_EntryFBScene.methodUtype] = pAccount_EntryFBScene;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(EntryFBScene / 3).");

			List<DATATYPE_BASE> pAccount_ExitFBScene_args = new List<DATATYPE_BASE>();
			pAccount_ExitFBScene_args.Add(EntityDef.id2datatypes[8]);

			Method pAccount_ExitFBScene = new Method();
			pAccount_ExitFBScene.name = "ExitFBScene";
			pAccount_ExitFBScene.methodUtype = 12;
			pAccount_ExitFBScene.aliasID = -1;
			pAccount_ExitFBScene.args = pAccount_ExitFBScene_args;

			pAccountModule.methods["ExitFBScene"] = pAccount_ExitFBScene; 
			pAccountModule.base_methods["ExitFBScene"] = pAccount_ExitFBScene;

			pAccountModule.idbase_methods[pAccount_ExitFBScene.methodUtype] = pAccount_ExitFBScene;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(ExitFBScene / 12).");

			List<DATATYPE_BASE> pAccount_KillChess_args = new List<DATATYPE_BASE>();
			pAccount_KillChess_args.Add(EntityDef.id2datatypes[8]);

			Method pAccount_KillChess = new Method();
			pAccount_KillChess.name = "KillChess";
			pAccount_KillChess.methodUtype = 11;
			pAccount_KillChess.aliasID = -1;
			pAccount_KillChess.args = pAccount_KillChess_args;

			pAccountModule.methods["KillChess"] = pAccount_KillChess; 
			pAccountModule.base_methods["KillChess"] = pAccount_KillChess;

			pAccountModule.idbase_methods[pAccount_KillChess.methodUtype] = pAccount_KillChess;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(KillChess / 11).");

			List<DATATYPE_BASE> pAccount_ReCreateAccountRequest_args = new List<DATATYPE_BASE>();
			pAccount_ReCreateAccountRequest_args.Add(EntityDef.id2datatypes[7]);
			pAccount_ReCreateAccountRequest_args.Add(EntityDef.id2datatypes[12]);

			Method pAccount_ReCreateAccountRequest = new Method();
			pAccount_ReCreateAccountRequest.name = "ReCreateAccountRequest";
			pAccount_ReCreateAccountRequest.methodUtype = 1;
			pAccount_ReCreateAccountRequest.aliasID = -1;
			pAccount_ReCreateAccountRequest.args = pAccount_ReCreateAccountRequest_args;

			pAccountModule.methods["ReCreateAccountRequest"] = pAccount_ReCreateAccountRequest; 
			pAccountModule.base_methods["ReCreateAccountRequest"] = pAccount_ReCreateAccountRequest;

			pAccountModule.idbase_methods[pAccount_ReCreateAccountRequest.methodUtype] = pAccount_ReCreateAccountRequest;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(ReCreateAccountRequest / 1).");

			List<DATATYPE_BASE> pAccount_StartMatch_args = new List<DATATYPE_BASE>();

			Method pAccount_StartMatch = new Method();
			pAccount_StartMatch.name = "StartMatch";
			pAccount_StartMatch.methodUtype = 14;
			pAccount_StartMatch.aliasID = -1;
			pAccount_StartMatch.args = pAccount_StartMatch_args;

			pAccountModule.methods["StartMatch"] = pAccount_StartMatch; 
			pAccountModule.base_methods["StartMatch"] = pAccount_StartMatch;

			pAccountModule.idbase_methods[pAccount_StartMatch.methodUtype] = pAccount_StartMatch;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(StartMatch / 14).");

			List<DATATYPE_BASE> pAccount_TestChessEntity_args = new List<DATATYPE_BASE>();
			pAccount_TestChessEntity_args.Add(EntityDef.id2datatypes[5]);

			Method pAccount_TestChessEntity = new Method();
			pAccount_TestChessEntity.name = "TestChessEntity";
			pAccount_TestChessEntity.methodUtype = 2;
			pAccount_TestChessEntity.aliasID = -1;
			pAccount_TestChessEntity.args = pAccount_TestChessEntity_args;

			pAccountModule.methods["TestChessEntity"] = pAccount_TestChessEntity; 
			pAccountModule.base_methods["TestChessEntity"] = pAccount_TestChessEntity;

			pAccountModule.idbase_methods[pAccount_TestChessEntity.methodUtype] = pAccount_TestChessEntity;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(TestChessEntity / 2).");

			List<DATATYPE_BASE> pAccount_UnStartMatch_args = new List<DATATYPE_BASE>();

			Method pAccount_UnStartMatch = new Method();
			pAccount_UnStartMatch.name = "UnStartMatch";
			pAccount_UnStartMatch.methodUtype = 15;
			pAccount_UnStartMatch.aliasID = -1;
			pAccount_UnStartMatch.args = pAccount_UnStartMatch_args;

			pAccountModule.methods["UnStartMatch"] = pAccount_UnStartMatch; 
			pAccountModule.base_methods["UnStartMatch"] = pAccount_UnStartMatch;

			pAccountModule.idbase_methods[pAccount_UnStartMatch.methodUtype] = pAccount_UnStartMatch;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(UnStartMatch / 15).");

			ScriptModule pChessModule = new ScriptModule("Chess");
			EntityDef.moduledefs["Chess"] = pChessModule;
			EntityDef.idmoduledefs[2] = pChessModule;

			Property pChess_position = new Property();
			pChess_position.name = "position";
			pChess_position.properUtype = 40000;
			pChess_position.properFlags = 4;
			pChess_position.aliasID = 1;
			Vector3 Chess_position_defval = new Vector3();
			pChess_position.defaultVal = Chess_position_defval;
			pChessModule.propertys["position"] = pChess_position; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_position.aliasID] = pChess_position;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(position / 40000).");

			Property pChess_direction = new Property();
			pChess_direction.name = "direction";
			pChess_direction.properUtype = 40001;
			pChess_direction.properFlags = 4;
			pChess_direction.aliasID = 2;
			Vector3 Chess_direction_defval = new Vector3();
			pChess_direction.defaultVal = Chess_direction_defval;
			pChessModule.propertys["direction"] = pChess_direction; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_direction.aliasID] = pChess_direction;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(direction / 40001).");

			Property pChess_spaceID = new Property();
			pChess_spaceID.name = "spaceID";
			pChess_spaceID.properUtype = 40002;
			pChess_spaceID.properFlags = 16;
			pChess_spaceID.aliasID = 3;
			UInt32 Chess_spaceID_defval;
			UInt32.TryParse("", out Chess_spaceID_defval);
			pChess_spaceID.defaultVal = Chess_spaceID_defval;
			pChessModule.propertys["spaceID"] = pChess_spaceID; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_spaceID.aliasID] = pChess_spaceID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(spaceID / 40002).");

			Property pChess_chess_attack = new Property();
			pChess_chess_attack.name = "chess_attack";
			pChess_chess_attack.properUtype = 11;
			pChess_chess_attack.properFlags = 4;
			pChess_chess_attack.aliasID = 4;
			UInt64 Chess_chess_attack_defval;
			UInt64.TryParse("0", out Chess_chess_attack_defval);
			pChess_chess_attack.defaultVal = Chess_chess_attack_defval;
			pChessModule.propertys["chess_attack"] = pChess_chess_attack; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_attack.aliasID] = pChess_chess_attack;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_attack / 11).");

			Property pChess_chess_defense = new Property();
			pChess_chess_defense.name = "chess_defense";
			pChess_chess_defense.properUtype = 12;
			pChess_chess_defense.properFlags = 4;
			pChess_chess_defense.aliasID = 5;
			UInt64 Chess_chess_defense_defval;
			UInt64.TryParse("0", out Chess_chess_defense_defval);
			pChess_chess_defense.defaultVal = Chess_chess_defense_defval;
			pChessModule.propertys["chess_defense"] = pChess_chess_defense; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_defense.aliasID] = pChess_chess_defense;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_defense / 12).");

			Property pChess_chess_id = new Property();
			pChess_chess_id.name = "chess_id";
			pChess_chess_id.properUtype = 6;
			pChess_chess_id.properFlags = 4;
			pChess_chess_id.aliasID = 6;
			UInt64 Chess_chess_id_defval;
			UInt64.TryParse("0", out Chess_chess_id_defval);
			pChess_chess_id.defaultVal = Chess_chess_id_defval;
			pChessModule.propertys["chess_id"] = pChess_chess_id; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_id.aliasID] = pChess_chess_id;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_id / 6).");

			Property pChess_chess_index_x = new Property();
			pChess_chess_index_x.name = "chess_index_x";
			pChess_chess_index_x.properUtype = 9;
			pChess_chess_index_x.properFlags = 4;
			pChess_chess_index_x.aliasID = 7;
			UInt64 Chess_chess_index_x_defval;
			UInt64.TryParse("0", out Chess_chess_index_x_defval);
			pChess_chess_index_x.defaultVal = Chess_chess_index_x_defval;
			pChessModule.propertys["chess_index_x"] = pChess_chess_index_x; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_index_x.aliasID] = pChess_chess_index_x;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_index_x / 9).");

			Property pChess_chess_index_z = new Property();
			pChess_chess_index_z.name = "chess_index_z";
			pChess_chess_index_z.properUtype = 10;
			pChess_chess_index_z.properFlags = 4;
			pChess_chess_index_z.aliasID = 8;
			UInt64 Chess_chess_index_z_defval;
			UInt64.TryParse("0", out Chess_chess_index_z_defval);
			pChess_chess_index_z.defaultVal = Chess_chess_index_z_defval;
			pChessModule.propertys["chess_index_z"] = pChess_chess_index_z; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_index_z.aliasID] = pChess_chess_index_z;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_index_z / 10).");

			Property pChess_chess_level = new Property();
			pChess_chess_level.name = "chess_level";
			pChess_chess_level.properUtype = 7;
			pChess_chess_level.properFlags = 4;
			pChess_chess_level.aliasID = 9;
			UInt64 Chess_chess_level_defval;
			UInt64.TryParse("0", out Chess_chess_level_defval);
			pChess_chess_level.defaultVal = Chess_chess_level_defval;
			pChessModule.propertys["chess_level"] = pChess_chess_level; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_level.aliasID] = pChess_chess_level;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_level / 7).");

			Property pChess_chess_name = new Property();
			pChess_chess_name.name = "chess_name";
			pChess_chess_name.properUtype = 8;
			pChess_chess_name.properFlags = 4;
			pChess_chess_name.aliasID = 10;
			string Chess_chess_name_defval = "";
			pChess_chess_name.defaultVal = Chess_chess_name_defval;
			pChessModule.propertys["chess_name"] = pChess_chess_name; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_name.aliasID] = pChess_chess_name;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_name / 8).");

			Property pChess_chess_owner_player = new Property();
			pChess_chess_owner_player.name = "chess_owner_player";
			pChess_chess_owner_player.properUtype = 13;
			pChess_chess_owner_player.properFlags = 4;
			pChess_chess_owner_player.aliasID = 11;
			UInt64 Chess_chess_owner_player_defval;
			UInt64.TryParse("0", out Chess_chess_owner_player_defval);
			pChess_chess_owner_player.defaultVal = Chess_chess_owner_player_defval;
			pChessModule.propertys["chess_owner_player"] = pChess_chess_owner_player; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_chess_owner_player.aliasID] = pChess_chess_owner_player;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(chess_owner_player / 13).");

			Property pChess_max_hp = new Property();
			pChess_max_hp.name = "max_hp";
			pChess_max_hp.properUtype = 14;
			pChess_max_hp.properFlags = 4;
			pChess_max_hp.aliasID = 12;
			UInt64 Chess_max_hp_defval;
			UInt64.TryParse("0", out Chess_max_hp_defval);
			pChess_max_hp.defaultVal = Chess_max_hp_defval;
			pChessModule.propertys["max_hp"] = pChess_max_hp; 

			pChessModule.usePropertyDescrAlias = true;
			pChessModule.idpropertys[(UInt16)pChess_max_hp.aliasID] = pChess_max_hp;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Chess), property(max_hp / 14).");

		}

		public static void initDefTypes()
		{
			{
				UInt16 utype = 2;
				string typeName = "UINT8";
				string name = "UINT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 3;
				string typeName = "UINT16";
				string name = "UINT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 5;
				string typeName = "UINT64";
				string name = "UINT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 4;
				string typeName = "UINT32";
				string name = "UINT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 6;
				string typeName = "INT8";
				string name = "INT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 7;
				string typeName = "INT16";
				string name = "INT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 8;
				string typeName = "INT32";
				string name = "INT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 9;
				string typeName = "INT64";
				string name = "INT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 1;
				string typeName = "STRING";
				string name = "STRING";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 12;
				string typeName = "UNICODE";
				string name = "UNICODE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 13;
				string typeName = "FLOAT";
				string name = "FLOAT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 14;
				string typeName = "DOUBLE";
				string name = "DOUBLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PYTHON";
				string name = "PYTHON";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_DICT";
				string name = "PY_DICT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_TUPLE";
				string name = "PY_TUPLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_LIST";
				string name = "PY_LIST";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "ENTITYCALL";
				string name = "ENTITYCALL";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 11;
				string typeName = "BLOB";
				string name = "BLOB";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 15;
				string typeName = "VECTOR2";
				string name = "VECTOR2";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 16;
				string typeName = "VECTOR3";
				string name = "VECTOR3";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 17;
				string typeName = "VECTOR4";
				string name = "VECTOR4";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 22;
				string typeName = "CHESS_INFO";
				DATATYPE_CHESS_INFO datatype = new DATATYPE_CHESS_INFO();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 23;
				string typeName = "CHESS_INFO_LIST";
				DATATYPE_CHESS_INFO_LIST datatype = new DATATYPE_CHESS_INFO_LIST();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			foreach(string datatypeStr in EntityDef.datatypes.Keys)
			{
				DATATYPE_BASE dataType = EntityDef.datatypes[datatypeStr];
				if(dataType != null)
				{
					dataType.bind();
				}
			}
		}

	}


}