using System;
using System.Collections.Generic;

namespace Jass {

	public class CheatsJ {

		//
		//
		//
		//
		public const float bj_DEBUG_CAMFIELD_SPEED = 0;//constant real     bj_DEBUG_CAMFIELD_SPEED     = 0
		public const string bj_DEBUG_CHAT_GIMME = "gimme";//constant string   bj_DEBUG_CHAT_GIMME         = "gimme"
		public const string bj_DEBUG_CHAT_DEMO = "demo";//constant string   bj_DEBUG_CHAT_DEMO          = "demo"
		public const string bj_DEBUG_CHAT_TELEPORT = "teleport";//constant string   bj_DEBUG_CHAT_TELEPORT      = "teleport"
		public const string bj_DEBUG_CHAT_UNITINFO = "unitinfo";//constant string   bj_DEBUG_CHAT_UNITINFO      = "unitinfo"
		public const string bj_DEBUG_CHAT_UNITINFO2 = "ui";//constant string   bj_DEBUG_CHAT_UNITINFO2     = "ui"
		public const string bj_DEBUG_CHAT_CAMINFO = "caminfo";//constant string   bj_DEBUG_CHAT_CAMINFO       = "caminfo"
		public const string bj_DEBUG_CHAT_CAMINFO2 = "ci";//constant string   bj_DEBUG_CHAT_CAMINFO2      = "ci"
		public const string bj_DEBUG_CHAT_CAMDIST = "camdist";//constant string   bj_DEBUG_CHAT_CAMDIST       = "camdist"
		public const string bj_DEBUG_CHAT_CAMFARZ = "camfarz";//constant string   bj_DEBUG_CHAT_CAMFARZ       = "camfarz"
		public const string bj_DEBUG_CHAT_CAMAOA = "camaoa";//constant string   bj_DEBUG_CHAT_CAMAOA        = "camaoa"
		public const string bj_DEBUG_CHAT_CAMFOV = "camfov";//constant string   bj_DEBUG_CHAT_CAMFOV        = "camfov"
		public const string bj_DEBUG_CHAT_CAMROLL = "camroll";//constant string   bj_DEBUG_CHAT_CAMROLL       = "camroll"
		public const string bj_DEBUG_CHAT_CAMROT = "camrot";//constant string   bj_DEBUG_CHAT_CAMROT        = "camrot"
		public const string bj_DEBUG_CHAT_CAMRESET = "camreset";//constant string   bj_DEBUG_CHAT_CAMRESET      = "camreset"
		public const string bj_DEBUG_CHAT_REMOVEUNIT = "ru";//constant string   bj_DEBUG_CHAT_REMOVEUNIT    = "ru"
		public const string bj_DEBUG_CHAT_GOTOX = "gotox";//constant string   bj_DEBUG_CHAT_GOTOX         = "gotox"
		public const string bj_DEBUG_CHAT_GOTOY = "gotoy";//constant string   bj_DEBUG_CHAT_GOTOY         = "gotoy"
		public const string bj_DEBUG_CHAT_GOTOXY = "gotoxy";//constant string   bj_DEBUG_CHAT_GOTOXY        = "gotoxy"
		public const string bj_DEBUG_CHAT_GOTOUNIT = "gotounit";//constant string   bj_DEBUG_CHAT_GOTOUNIT      = "gotounit"
		public const string bj_DEBUG_CHAT_DIFFICULTY = "difficulty";//constant string   bj_DEBUG_CHAT_DIFFICULTY    = "difficulty"
		public const string bj_DEBUG_CHAT_FINGEROFDEATH = "fingerofdeath";//constant string   bj_DEBUG_CHAT_FINGEROFDEATH = "fingerofdeath"
		public static trigger bj_debugGimmeTrig;//trigger           bj_debugGimmeTrig
		public static trigger bj_debugDemoTrig;//trigger           bj_debugDemoTrig
		public static trigger bj_debugTeleportTrig;//trigger           bj_debugTeleportTrig
		public static trigger bj_debugUnitInfoTrig;//trigger           bj_debugUnitInfoTrig
		public static trigger bj_debugCamInfoTrig;//trigger           bj_debugCamInfoTrig
		public static trigger bj_debugCamDistTrig;//trigger           bj_debugCamDistTrig
		public static trigger bj_debugCamFarzTrig;//trigger           bj_debugCamFarzTrig
		public static trigger bj_debugCamAoaTrig;//trigger           bj_debugCamAoaTrig
		public static trigger bj_debugCamFovTrig;//trigger           bj_debugCamFovTrig
		public static trigger bj_debugCamRollTrig;//trigger           bj_debugCamRollTrig
		public static trigger bj_debugCamRotTrig;//trigger           bj_debugCamRotTrig
		public static trigger bj_debugCamResetTrig;//trigger           bj_debugCamResetTrig
		public static trigger bj_debugRuTrig;//trigger           bj_debugRuTrig
		public static trigger bj_debugGotoXTrig;//trigger           bj_debugGotoXTrig
		public static trigger bj_debugGotoYTrig;//trigger           bj_debugGotoYTrig
		public static trigger bj_debugGotoXYTrig;//trigger           bj_debugGotoXYTrig
		public static trigger bj_debugGotoUnitTrig;//trigger           bj_debugGotoUnitTrig
		public static trigger bj_debugDifficultyTrig;//trigger           bj_debugDifficultyTrig
		public static trigger[] bj_debugFingerOfDeathTrig;//trigger  array    bj_debugFingerOfDeathTrig
		public static trigger[] bj_debugToolOfDeathTrig;//trigger  array    bj_debugToolOfDeathTrig
		public static bool[] bj_debugFingerOfDeathEnabled;//boolean  array    bj_debugFingerOfDeathEnabled
		public static float bj_debugGotoUnitX = 0;//real              bj_debugGotoUnitX = 0
		public static float bj_debugGotoUnitY = 0;//real              bj_debugGotoUnitY = 0
		public static int bj_debugGotoUnits = 0;//integer           bj_debugGotoUnits = 0
		//
		//
		//
		//
		//
		//
		private void DebugGimmeEnum() {//function DebugGimmeEnum takes nothing returns nothing
			player thePlayer = GetEnumPlayer();//local player thePlayer = GetEnumPlayer()
			DisplayTextToPlayer(thePlayer, 0, 0, "Player "+I2S(GetPlayerId(GetTriggerPlayer())+1)+" cheated: Give 5000 gold and 5000 lumber to all players");//call DisplayTextToPlayer(thePlayer, 0, 0, "Player "+I2S(GetPlayerId(GetTriggerPlayer())+1)+" cheated: Give 5000 gold and 5000 lumber to all players")
			SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD, GetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD) + 5000);//call SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD, GetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD) + 5000)
			SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER, GetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER) + 5000);//call SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER, GetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER) + 5000)
		}//endfunction
		//
		private void DebugGimme() {//function DebugGimme takes nothing returns nothing
			ForForce(bj_FORCE_ALL_PLAYERS, function DebugGimmeEnum);//call ForForce(bj_FORCE_ALL_PLAYERS, function DebugGimmeEnum)
		}//endfunction
		//
		private void DebugDemoEnum() {//function DebugDemoEnum takes nothing returns nothing
			player thePlayer = GetEnumPlayer();//local player thePlayer = GetEnumPlayer()
			SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD, 0);//call SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD, 0)
			SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER, 0);//call SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER, 0)
		}//endfunction
		//
		private void DebugDemo() {//function DebugDemo takes nothing returns nothing
			player thePlayer = GetTriggerPlayer();//local player thePlayer = GetTriggerPlayer()
			int gold = GetRandomInt(750, 1500);//local integer gold = GetRandomInt(750, 1500)
			int lumber = GetRandomInt(200, 450);//local integer lumber = GetRandomInt(200, 450)
			ForForce(bj_FORCE_ALL_PLAYERS, function DebugDemoEnum);//call ForForce(bj_FORCE_ALL_PLAYERS, function DebugDemoEnum)
			if ((GetLocalPlayer() == GetTriggerPlayer())) {//if (GetLocalPlayer() == GetTriggerPlayer()) then
				Cheat("warnings");//call Cheat("warnings")
				Cheat("fastbuild");//call Cheat("fastbuild")
				Cheat("techtree");//call Cheat("techtree")
				Cheat("research");//call Cheat("research")
				Cheat("food");//call Cheat("food")
				Cheat("mana");//call Cheat("mana")
				Cheat("dawn");//call Cheat("dawn")
				Cheat("gold " + I2S(gold));//call Cheat("gold " + I2S(gold))
				Cheat("lumber " + I2S(lumber));//call Cheat("lumber " + I2S(lumber))
			}//endif
		}//endfunction
		//
		private void DebugTeleportEnum() {//function DebugTeleportEnum takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u = GetEnumUnit()
			SetUnitPosition(u, GetCameraTargetPositionX(), GetCameraTargetPositionY());//call SetUnitPosition(u, GetCameraTargetPositionX(), GetCameraTargetPositionY())
		}//endfunction
		//
		private void DebugTeleport() {//function DebugTeleport takes nothing returns nothing
			group g = CreateGroup();//local group g = CreateGroup()
			SyncSelections();//call SyncSelections()
			GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);//call GroupEnumUnitsSelected(g, GetTriggerPlayer(), null)
			ForGroup(g, function DebugTeleportEnum);//call ForGroup(g, function DebugTeleportEnum)
		}//endfunction
		//
		private string TertiaryStringOp(bool expr, string a, string b) {//function TertiaryStringOp takes boolean expr, string a, string b returns string
			if ((expr)) {//if (expr) then
				return a;//return a
			} else {//else
				return b;//return b
			}//endif
		}//endfunction
		//
		//
		//
		private string DebugIdInteger2IdString(int value) {//function DebugIdInteger2IdString takes integer value returns string
			string charMap = ".................................!.#$%&'()*+,-./0123456789:;<=>.@ABCDEFGHIJKLMNOPQRSTUVWXYZ[.]^_`abcdefghijklmnopqrstuvwxyz{|}~.................................................................................................................................";//local string charMap = ".................................!.#$%&'()*+,-./0123456789:;<=>.@ABCDEFGHIJKLMNOPQRSTUVWXYZ[.]^_`abcdefghijklmnopqrstuvwxyz{|}~................................................................................................................................."
			string result = "";//local string result = ""
			int remainingValue = value;//local integer remainingValue = value
			int charValue;//local integer charValue
			int byteno;//local integer byteno
			byteno = 0;//set byteno = 0
			while (true) {//loop
				charValue = ModuloInteger(remainingValue, 256);//set charValue = ModuloInteger(remainingValue, 256)
				remainingValue = remainingValue / 256;//set remainingValue = remainingValue / 256
				result = SubString(charMap, charValue, charValue + 1) + result;//set result = SubString(charMap, charValue, charValue + 1) + result
				byteno = byteno + 1;//set byteno = byteno + 1
				if (byteno == 4) { break; }//exitwhen byteno == 4
			}//endloop
			return result;//return result
		}//endfunction
		//
		private void DebugUnitInfoEnum() {//function DebugUnitInfoEnum takes nothing returns nothing
			player thePlayer = GetTriggerPlayer();//local player thePlayer = GetTriggerPlayer()
			unit theUnit = GetEnumUnit();//local unit   theUnit   = GetEnumUnit()
			string message;//local string message
			message = "Player" + I2S(GetPlayerId(GetOwningPlayer(theUnit)));//set message = "Player" + I2S(GetPlayerId(GetOwningPlayer(theUnit)))
			message = message + " '" + DebugIdInteger2IdString(GetUnitTypeId(theUnit)) + "'";//set message = message + " '" + DebugIdInteger2IdString(GetUnitTypeId(theUnit)) + "'"
			message = message + " " + GetUnitName(theUnit);//set message = message + " " + GetUnitName(theUnit)
			message = message + " (" + R2SW(GetUnitX(theUnit), 0, 0) + ", " + R2SW(GetUnitY(theUnit), 0, 0);//set message = message + " (" + R2SW(GetUnitX(theUnit), 0, 0) + ", " + R2SW(GetUnitY(theUnit), 0, 0)
			message = message + ": " + R2SW(GetUnitFacing(theUnit), 0, 0) + ") ";//set message = message + ": " + R2SW(GetUnitFacing(theUnit), 0, 0) + ") "
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_HERO),            " Hero",      "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_HERO),            " Hero",      "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_DEAD),            " Dead",      "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_DEAD),            " Dead",      "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_STRUCTURE),       " Structure", "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_STRUCTURE),       " Structure", "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_GROUND),          " Grnd",      "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_GROUND),          " Grnd",      "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_FLYING),          " Air",       "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_FLYING),          " Air",       "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_ATTACKS_GROUND),  " VsGrnd",    "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_ATTACKS_GROUND),  " VsGrnd",    "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_ATTACKS_FLYING),  " VsAir",     "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_ATTACKS_FLYING),  " VsAir",     "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_MELEE_ATTACKER),  " Melee",     "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_MELEE_ATTACKER),  " Melee",     "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_RANGED_ATTACKER), " Ranged",    "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_RANGED_ATTACKER), " Ranged",    "")
			message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_SUMMONED),        " Summoned",  "");//set message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_SUMMONED),        " Summoned",  "")
			DisplayTextToPlayer(thePlayer, 0, 0, message);//call DisplayTextToPlayer(thePlayer, 0, 0, message)
		}//endfunction
		//
		private void DebugUnitInfo() {//function DebugUnitInfo takes nothing returns nothing
			group g = CreateGroup();//local group g = CreateGroup()
			SyncSelections();//call SyncSelections()
			GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);//call GroupEnumUnitsSelected(g, GetTriggerPlayer(), null)
			ForGroup(g, function DebugUnitInfoEnum);//call ForGroup(g, function DebugUnitInfoEnum)
		}//endfunction
		//
		private void DebugCamInfo() {//function DebugCamInfo takes nothing returns nothing
			player thePlayer = GetTriggerPlayer();//local player thePlayer = GetTriggerPlayer()
			string message;//local string message
			message = "Targ(" + R2SW(GetCameraTargetPositionX(), 0, 0);//set message = "Targ(" + R2SW(GetCameraTargetPositionX(), 0, 0)
			message = message + "," + R2SW(GetCameraTargetPositionY(), 0, 0);//set message = message + "," + R2SW(GetCameraTargetPositionY(), 0, 0)
			message = message + "," + R2SW(GetCameraTargetPositionZ(), 0, 0);//set message = message + "," + R2SW(GetCameraTargetPositionZ(), 0, 0)
			message = message + ")";//set message = message + ")"
			message = message + ", Dist=" + R2SW(GetCameraField(CAMERA_FIELD_TARGET_DISTANCE), 0, 0);//set message = message + ", Dist=" + R2SW(GetCameraField(CAMERA_FIELD_TARGET_DISTANCE), 0, 0)
			message = message + ", FarZ=" + R2SW(GetCameraField(CAMERA_FIELD_FARZ), 0, 0);//set message = message + ", FarZ=" + R2SW(GetCameraField(CAMERA_FIELD_FARZ), 0, 0)
			message = message + ", AoA=" + R2SW(GetCameraField(CAMERA_FIELD_ANGLE_OF_ATTACK) * bj_RADTODEG, 0, 2);//set message = message + ", AoA=" + R2SW(GetCameraField(CAMERA_FIELD_ANGLE_OF_ATTACK) * bj_RADTODEG, 0, 2)
			message = message + ", FoV=" + R2SW(GetCameraField(CAMERA_FIELD_FIELD_OF_VIEW) * bj_RADTODEG, 0, 2);//set message = message + ", FoV=" + R2SW(GetCameraField(CAMERA_FIELD_FIELD_OF_VIEW) * bj_RADTODEG, 0, 2)
			message = message + ", Roll=" + R2SW(GetCameraField(CAMERA_FIELD_ROLL) * bj_RADTODEG, 0, 2);//set message = message + ", Roll=" + R2SW(GetCameraField(CAMERA_FIELD_ROLL) * bj_RADTODEG, 0, 2)
			message = message + ", Rot=" + R2SW(GetCameraField(CAMERA_FIELD_ROTATION) * bj_RADTODEG, 0, 2);//set message = message + ", Rot=" + R2SW(GetCameraField(CAMERA_FIELD_ROTATION) * bj_RADTODEG, 0, 2)
			DisplayTextToPlayer(thePlayer, 0, 0, message);//call DisplayTextToPlayer(thePlayer, 0, 0, message)
		}//endfunction
		//
		private void DebugCamField(camerafield whichField, int cheatLength, float defaultValue) {//function DebugCamField takes camerafield whichField, integer cheatLength, real defaultValue returns nothing
			string param = SubString(GetEventPlayerChatString(), cheatLength, 50);//local string param        = SubString(GetEventPlayerChatString(), cheatLength, 50)
			float value = S2R(param);//local real   value        = S2R(param)
			//
			while (true) {//loop
				if (!(SubString(param, 0, 1) == " ")) { break; }//exitwhen not (SubString(param, 0, 1) == " ")
				param = SubString(param, 1, 50);//set param = SubString(param, 1, 50)
			}//endloop
			if (param == "") {//if param == "" then
				value = defaultValue;//set value = defaultValue
			}//endif
			if ((whichField == CAMERA_FIELD_FARZ) && (value <= bj_CAMERA_MIN_FARZ)) {//if (whichField == CAMERA_FIELD_FARZ) and (value <= bj_CAMERA_MIN_FARZ) then
				return;//return
			}//endif
			SetCameraFieldForPlayer(GetTriggerPlayer(), whichField, value, bj_DEBUG_CAMFIELD_SPEED);//call SetCameraFieldForPlayer(GetTriggerPlayer(), whichField, value, bj_DEBUG_CAMFIELD_SPEED)
		}//endfunction
		//
		private void DebugCamDist() {//function DebugCamDist takes nothing returns nothing
			DebugCamField(CAMERA_FIELD_TARGET_DISTANCE, 7, 1600);//call DebugCamField(CAMERA_FIELD_TARGET_DISTANCE, 7, 1600)
		}//endfunction
		//
		private void DebugCamFarZ() {//function DebugCamFarZ takes nothing returns nothing
			DebugCamField(CAMERA_FIELD_FARZ, 7, 4000);//call DebugCamField(CAMERA_FIELD_FARZ, 7, 4000)
		}//endfunction
		//
		private void DebugCamFOV() {//function DebugCamFOV takes nothing returns nothing
			DebugCamField(CAMERA_FIELD_FIELD_OF_VIEW, 6, 65);//call DebugCamField(CAMERA_FIELD_FIELD_OF_VIEW, 6, 65)
		}//endfunction
		//
		private void DebugCamAOA() {//function DebugCamAOA takes nothing returns nothing
			DebugCamField(CAMERA_FIELD_ANGLE_OF_ATTACK, 6, 310);//call DebugCamField(CAMERA_FIELD_ANGLE_OF_ATTACK, 6, 310)
		}//endfunction
		//
		private void DebugCamRoll() {//function DebugCamRoll takes nothing returns nothing
			DebugCamField(CAMERA_FIELD_ROLL, 7, 0);//call DebugCamField(CAMERA_FIELD_ROLL, 7, 0)
		}//endfunction
		//
		private void DebugCamRot() {//function DebugCamRot takes nothing returns nothing
			DebugCamField(CAMERA_FIELD_ROTATION, 6, 90);//call DebugCamField(CAMERA_FIELD_ROTATION, 6, 90)
		}//endfunction
		//
		private void DebugCamReset() {//function DebugCamReset takes nothing returns nothing
			ResetToGameCamera(0);//call ResetToGameCamera(0)
			EnableUserControl(true);//call EnableUserControl(true)
		}//endfunction
		//
		private void DebugRemoveUnitEnum() {//function DebugRemoveUnitEnum takes nothing returns nothing
			RemoveUnit(GetEnumUnit());//call RemoveUnit(GetEnumUnit())
		}//endfunction
		//
		private void DebugRemoveUnit() {//function DebugRemoveUnit takes nothing returns nothing
			group g = CreateGroup();//local group g = CreateGroup()
			SyncSelections();//call SyncSelections()
			GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);//call GroupEnumUnitsSelected(g, GetTriggerPlayer(), null)
			ForGroup(g, function DebugRemoveUnitEnum);//call ForGroup(g, function DebugRemoveUnitEnum)
		}//endfunction
		//
		private void DebugGotoX() {//function DebugGotoX takes nothing returns nothing
			string chatString = GetEventPlayerChatString();//local string chatString = GetEventPlayerChatString()
			if ((bj_DEBUG_CHAT_GOTOX + " " == SubString(chatString, 0, 6))) {//if (bj_DEBUG_CHAT_GOTOX + " " == SubString(chatString, 0, 6)) then
				SetCameraPositionForPlayer(GetTriggerPlayer(), S2R(SubString(chatString, 6, 50)), GetCameraTargetPositionY());//call SetCameraPositionForPlayer(GetTriggerPlayer(), S2R(SubString(chatString, 6, 50)), GetCameraTargetPositionY())
			}//endif
		}//endfunction
		//
		private void DebugGotoY() {//function DebugGotoY takes nothing returns nothing
			string chatString = GetEventPlayerChatString();//local string chatString = GetEventPlayerChatString()
			if ((bj_DEBUG_CHAT_GOTOY + " " == SubString(chatString, 0, 6))) {//if (bj_DEBUG_CHAT_GOTOY + " " == SubString(chatString, 0, 6)) then
				SetCameraPositionForPlayer(GetTriggerPlayer(), GetCameraTargetPositionX(), S2R(SubString(chatString, 6, 50)));//call SetCameraPositionForPlayer(GetTriggerPlayer(), GetCameraTargetPositionX(), S2R(SubString(chatString, 6, 50)))
			}//endif
		}//endfunction
		//
		private void DebugGotoXY() {//function DebugGotoXY takes nothing returns nothing
			string chatString = GetEventPlayerChatString();//local string chatString = GetEventPlayerChatString()
			int index;//local integer index
			bool inParam1;//local boolean inParam1
			if ((bj_DEBUG_CHAT_GOTOXY + " " == SubString(chatString, 0, 7))) {//if (bj_DEBUG_CHAT_GOTOXY + " " == SubString(chatString, 0, 7)) then
				inParam1 = false;//set inParam1 = false
				index = 7;//set index = 7
				while (true) {//loop
					if ((SubString(chatString, index, index + 1) != " ")) {//if (SubString(chatString, index, index + 1) != " ") then
						inParam1 = true;//set inParam1 = true
					}//endif
					if ((inParam1 && SubString(chatString, index, index + 1) == " ")) { break; }//exitwhen (inParam1 and SubString(chatString, index, index + 1) == " ")
					if (index > 50) { break; }//exitwhen index > 50
					index = index + 1;//set index = index + 1
				}//endloop
				if ((index > 50)) {//if (index > 50) then
					DisplayTextToPlayer(GetTriggerPlayer(), 0, 0, "Usage:  GotoXY x y");//call DisplayTextToPlayer(GetTriggerPlayer(), 0, 0, "Usage:  GotoXY x y")
				} else {//else
					if ((GetLocalPlayer() == GetTriggerPlayer())) {//if (GetLocalPlayer() == GetTriggerPlayer()) then
						SetCameraPositionForPlayer(GetTriggerPlayer(), S2R(SubString(chatString, 7, index)), S2R(SubString(chatString, index, 50)));//call SetCameraPositionForPlayer(GetTriggerPlayer(), S2R(SubString(chatString, 7, index)), S2R(SubString(chatString, index, 50)))
					}//endif
				}//endif
			}//endif
		}//endfunction
		//
		private void DebugGotoUnitEnum() {//function DebugGotoUnitEnum takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u = GetEnumUnit()
			bj_debugGotoUnitX = bj_debugGotoUnitX + GetUnitX(u);//set bj_debugGotoUnitX = bj_debugGotoUnitX + GetUnitX(u)
			bj_debugGotoUnitY = bj_debugGotoUnitY + GetUnitY(u);//set bj_debugGotoUnitY = bj_debugGotoUnitY + GetUnitY(u)
			bj_debugGotoUnits = bj_debugGotoUnits + 1;//set bj_debugGotoUnits = bj_debugGotoUnits + 1
		}//endfunction
		//
		private void DebugGotoUnit() {//function DebugGotoUnit takes nothing returns nothing
			group g = CreateGroup();//local group g = CreateGroup()
			bj_debugGotoUnitX = 0;//set bj_debugGotoUnitX = 0
			bj_debugGotoUnitY = 0;//set bj_debugGotoUnitY = 0
			bj_debugGotoUnits = 0;//set bj_debugGotoUnits = 0
			SyncSelections();//call SyncSelections()
			GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);//call GroupEnumUnitsSelected(g, GetTriggerPlayer(), null)
			ForGroup(g, function DebugGotoUnitEnum);//call ForGroup(g, function DebugGotoUnitEnum)
			if ((bj_debugGotoUnits != 0)) {//if (bj_debugGotoUnits != 0) then
				bj_debugGotoUnitX = bj_debugGotoUnitX / bj_debugGotoUnits;//set bj_debugGotoUnitX = bj_debugGotoUnitX / bj_debugGotoUnits
				bj_debugGotoUnitY = bj_debugGotoUnitY / bj_debugGotoUnits;//set bj_debugGotoUnitY = bj_debugGotoUnitY / bj_debugGotoUnits
				SetCameraPositionForPlayer(GetTriggerPlayer(), bj_debugGotoUnitX, bj_debugGotoUnitY);//call SetCameraPositionForPlayer(GetTriggerPlayer(), bj_debugGotoUnitX, bj_debugGotoUnitY)
			}//endif
		}//endfunction
		//
		private void DebugDifficulty() {//function DebugDifficulty takes nothing returns nothing
			player thePlayer = GetTriggerPlayer();//local player         thePlayer = GetTriggerPlayer()
			gamedifficulty theDiff = GetGameDifficulty();//local gamedifficulty theDiff   = GetGameDifficulty()
			if ((theDiff == MAP_DIFFICULTY_EASY)) {//if (theDiff == MAP_DIFFICULTY_EASY) then
				DisplayTextToPlayer(thePlayer, 0, 0, "Easy Difficulty");//call DisplayTextToPlayer(thePlayer, 0, 0, "Easy Difficulty")
			} else if ((theDiff == MAP_DIFFICULTY_NORMAL)) {//elseif (theDiff == MAP_DIFFICULTY_NORMAL) then
				DisplayTextToPlayer(thePlayer, 0, 0, "Normal Difficulty");//call DisplayTextToPlayer(thePlayer, 0, 0, "Normal Difficulty")
			} else if ((theDiff == MAP_DIFFICULTY_HARD)) {//elseif (theDiff == MAP_DIFFICULTY_HARD) then
				DisplayTextToPlayer(thePlayer, 0, 0, "Hard Difficulty");//call DisplayTextToPlayer(thePlayer, 0, 0, "Hard Difficulty")
			} else {//else
				DisplayTextToPlayer(thePlayer, 0, 0, "ERROR!  Unrecognized Difficulty");//call DisplayTextToPlayer(thePlayer, 0, 0, "ERROR!  Unrecognized Difficulty")
			}//endif
		}//endfunction
		//
		private void DebugToolOfDeath() {//function DebugToolOfDeath takes nothing returns nothing
			KillUnit(GetTriggerUnit());//call KillUnit(GetTriggerUnit())
		}//endfunction
		//
		private void DebugToggleFingerOfDeath() {//function DebugToggleFingerOfDeath takes nothing returns nothing
			int index = GetPlayerId(GetTriggerPlayer());//local integer index = GetPlayerId(GetTriggerPlayer())
			if ((bj_debugFingerOfDeathEnabled[index])) {//if (bj_debugFingerOfDeathEnabled[index]) then
				DisplayTextToPlayer(Player(index), 0, 0, "Finger Of Death Disabled");//call DisplayTextToPlayer(Player(index), 0, 0, "Finger Of Death Disabled")
				DisableTrigger(bj_debugToolOfDeathTrig[index]);//call DisableTrigger(bj_debugToolOfDeathTrig[index])
			} else {//else
				DisplayTextToPlayer(Player(index), 0, 0, "Finger Of Death Enabled");//call DisplayTextToPlayer(Player(index), 0, 0, "Finger Of Death Enabled")
				EnableTrigger(bj_debugToolOfDeathTrig[index]);//call EnableTrigger(bj_debugToolOfDeathTrig[index])
			}//endif
			bj_debugFingerOfDeathEnabled[index] = !bj_debugFingerOfDeathEnabled[index];//set bj_debugFingerOfDeathEnabled[index] = not bj_debugFingerOfDeathEnabled[index]
		}//endfunction
		//
		private bool InitDebugTriggers() {//function InitDebugTriggers takes nothing returns boolean
			player indexPlayer;//local player  indexPlayer
			int index;//local integer index
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING) then
					bj_debugGimmeTrig = CreateTrigger();//set bj_debugGimmeTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugGimmeTrig, indexPlayer, bj_DEBUG_CHAT_GIMME, true);//call TriggerRegisterPlayerChatEvent(bj_debugGimmeTrig, indexPlayer, bj_DEBUG_CHAT_GIMME, true)
					TriggerAddAction(bj_debugGimmeTrig, function DebugGimme);//call TriggerAddAction(bj_debugGimmeTrig, function DebugGimme)
					bj_debugDemoTrig = CreateTrigger();//set bj_debugDemoTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugDemoTrig, indexPlayer, bj_DEBUG_CHAT_DEMO, true);//call TriggerRegisterPlayerChatEvent(bj_debugDemoTrig, indexPlayer, bj_DEBUG_CHAT_DEMO, true)
					TriggerAddAction(bj_debugDemoTrig, function DebugDemo);//call TriggerAddAction(bj_debugDemoTrig, function DebugDemo)
					bj_debugTeleportTrig = CreateTrigger();//set bj_debugTeleportTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugTeleportTrig, indexPlayer, bj_DEBUG_CHAT_TELEPORT, true);//call TriggerRegisterPlayerChatEvent(bj_debugTeleportTrig, indexPlayer, bj_DEBUG_CHAT_TELEPORT, true)
					TriggerAddAction(bj_debugTeleportTrig, function DebugTeleport);//call TriggerAddAction(bj_debugTeleportTrig, function DebugTeleport)
					bj_debugUnitInfoTrig = CreateTrigger();//set bj_debugUnitInfoTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugUnitInfoTrig, indexPlayer, bj_DEBUG_CHAT_UNITINFO, true);//call TriggerRegisterPlayerChatEvent(bj_debugUnitInfoTrig, indexPlayer, bj_DEBUG_CHAT_UNITINFO, true)
					TriggerRegisterPlayerChatEvent(bj_debugUnitInfoTrig, indexPlayer, bj_DEBUG_CHAT_UNITINFO2, true);//call TriggerRegisterPlayerChatEvent(bj_debugUnitInfoTrig, indexPlayer, bj_DEBUG_CHAT_UNITINFO2, true)
					TriggerAddAction(bj_debugUnitInfoTrig, function DebugUnitInfo);//call TriggerAddAction(bj_debugUnitInfoTrig, function DebugUnitInfo)
					bj_debugCamInfoTrig = CreateTrigger();//set bj_debugCamInfoTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamInfoTrig, indexPlayer, bj_DEBUG_CHAT_CAMINFO, true);//call TriggerRegisterPlayerChatEvent(bj_debugCamInfoTrig, indexPlayer, bj_DEBUG_CHAT_CAMINFO, true)
					TriggerRegisterPlayerChatEvent(bj_debugCamInfoTrig, indexPlayer, bj_DEBUG_CHAT_CAMINFO2, true);//call TriggerRegisterPlayerChatEvent(bj_debugCamInfoTrig, indexPlayer, bj_DEBUG_CHAT_CAMINFO2, true)
					TriggerAddAction(bj_debugCamInfoTrig, function DebugCamInfo);//call TriggerAddAction(bj_debugCamInfoTrig, function DebugCamInfo)
					bj_debugCamDistTrig = CreateTrigger();//set bj_debugCamDistTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamDistTrig, indexPlayer, bj_DEBUG_CHAT_CAMDIST, false);//call TriggerRegisterPlayerChatEvent(bj_debugCamDistTrig, indexPlayer, bj_DEBUG_CHAT_CAMDIST, false)
					TriggerAddAction(bj_debugCamDistTrig, function DebugCamDist);//call TriggerAddAction(bj_debugCamDistTrig, function DebugCamDist)
					bj_debugCamFarzTrig = CreateTrigger();//set bj_debugCamFarzTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamFarzTrig, indexPlayer, bj_DEBUG_CHAT_CAMFARZ, false);//call TriggerRegisterPlayerChatEvent(bj_debugCamFarzTrig, indexPlayer, bj_DEBUG_CHAT_CAMFARZ, false)
					TriggerAddAction(bj_debugCamFarzTrig, function DebugCamFarZ);//call TriggerAddAction(bj_debugCamFarzTrig, function DebugCamFarZ)
					bj_debugCamFovTrig = CreateTrigger();//set bj_debugCamFovTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamFovTrig, indexPlayer, bj_DEBUG_CHAT_CAMFOV, false);//call TriggerRegisterPlayerChatEvent(bj_debugCamFovTrig, indexPlayer, bj_DEBUG_CHAT_CAMFOV, false)
					TriggerAddAction(bj_debugCamFovTrig, function DebugCamFOV);//call TriggerAddAction(bj_debugCamFovTrig, function DebugCamFOV)
					bj_debugCamAoaTrig = CreateTrigger();//set bj_debugCamAoaTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamAoaTrig, indexPlayer, bj_DEBUG_CHAT_CAMAOA, false);//call TriggerRegisterPlayerChatEvent(bj_debugCamAoaTrig, indexPlayer, bj_DEBUG_CHAT_CAMAOA, false)
					TriggerAddAction(bj_debugCamAoaTrig, function DebugCamAOA);//call TriggerAddAction(bj_debugCamAoaTrig, function DebugCamAOA)
					bj_debugCamRollTrig = CreateTrigger();//set bj_debugCamRollTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamRollTrig, indexPlayer, bj_DEBUG_CHAT_CAMROLL, false);//call TriggerRegisterPlayerChatEvent(bj_debugCamRollTrig, indexPlayer, bj_DEBUG_CHAT_CAMROLL, false)
					TriggerAddAction(bj_debugCamRollTrig, function DebugCamRoll);//call TriggerAddAction(bj_debugCamRollTrig, function DebugCamRoll)
					bj_debugCamRotTrig = CreateTrigger();//set bj_debugCamRotTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamRotTrig, indexPlayer, bj_DEBUG_CHAT_CAMROT, false);//call TriggerRegisterPlayerChatEvent(bj_debugCamRotTrig, indexPlayer, bj_DEBUG_CHAT_CAMROT, false)
					TriggerAddAction(bj_debugCamRotTrig, function DebugCamRot);//call TriggerAddAction(bj_debugCamRotTrig, function DebugCamRot)
					bj_debugCamResetTrig = CreateTrigger();//set bj_debugCamResetTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugCamResetTrig, indexPlayer, bj_DEBUG_CHAT_CAMRESET, true);//call TriggerRegisterPlayerChatEvent(bj_debugCamResetTrig, indexPlayer, bj_DEBUG_CHAT_CAMRESET, true)
					TriggerAddAction(bj_debugCamResetTrig, function DebugCamReset);//call TriggerAddAction(bj_debugCamResetTrig, function DebugCamReset)
					bj_debugRuTrig = CreateTrigger();//set bj_debugRuTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugRuTrig, indexPlayer, bj_DEBUG_CHAT_REMOVEUNIT, true);//call TriggerRegisterPlayerChatEvent(bj_debugRuTrig, indexPlayer, bj_DEBUG_CHAT_REMOVEUNIT, true)
					TriggerAddAction(bj_debugRuTrig, function DebugRemoveUnit);//call TriggerAddAction(bj_debugRuTrig, function DebugRemoveUnit)
					bj_debugGotoXTrig = CreateTrigger();//set bj_debugGotoXTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugGotoXTrig, indexPlayer, bj_DEBUG_CHAT_GOTOX, false);//call TriggerRegisterPlayerChatEvent(bj_debugGotoXTrig, indexPlayer, bj_DEBUG_CHAT_GOTOX, false)
					TriggerAddAction(bj_debugGotoXTrig, function DebugGotoX);//call TriggerAddAction(bj_debugGotoXTrig, function DebugGotoX)
					bj_debugGotoYTrig = CreateTrigger();//set bj_debugGotoYTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugGotoYTrig, indexPlayer, bj_DEBUG_CHAT_GOTOY, false);//call TriggerRegisterPlayerChatEvent(bj_debugGotoYTrig, indexPlayer, bj_DEBUG_CHAT_GOTOY, false)
					TriggerAddAction(bj_debugGotoYTrig, function DebugGotoY);//call TriggerAddAction(bj_debugGotoYTrig, function DebugGotoY)
					bj_debugGotoXYTrig = CreateTrigger();//set bj_debugGotoXYTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugGotoXYTrig, indexPlayer, bj_DEBUG_CHAT_GOTOXY, false);//call TriggerRegisterPlayerChatEvent(bj_debugGotoXYTrig, indexPlayer, bj_DEBUG_CHAT_GOTOXY, false)
					TriggerAddAction(bj_debugGotoXYTrig, function DebugGotoXY);//call TriggerAddAction(bj_debugGotoXYTrig, function DebugGotoXY)
					bj_debugGotoUnitTrig = CreateTrigger();//set bj_debugGotoUnitTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugGotoUnitTrig, indexPlayer, bj_DEBUG_CHAT_GOTOUNIT, true);//call TriggerRegisterPlayerChatEvent(bj_debugGotoUnitTrig, indexPlayer, bj_DEBUG_CHAT_GOTOUNIT, true)
					TriggerAddAction(bj_debugGotoUnitTrig, function DebugGotoUnit);//call TriggerAddAction(bj_debugGotoUnitTrig, function DebugGotoUnit)
					bj_debugDifficultyTrig = CreateTrigger();//set bj_debugDifficultyTrig = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugDifficultyTrig, indexPlayer, bj_DEBUG_CHAT_DIFFICULTY, true);//call TriggerRegisterPlayerChatEvent(bj_debugDifficultyTrig, indexPlayer, bj_DEBUG_CHAT_DIFFICULTY, true)
					TriggerAddAction(bj_debugDifficultyTrig, function DebugDifficulty);//call TriggerAddAction(bj_debugDifficultyTrig, function DebugDifficulty)
					bj_debugFingerOfDeathEnabled[index] = false;//set bj_debugFingerOfDeathEnabled[index] = false
					bj_debugToolOfDeathTrig[index] = CreateTrigger();//set bj_debugToolOfDeathTrig[index] = CreateTrigger()
					TriggerRegisterPlayerUnitEvent(bj_debugToolOfDeathTrig[index], indexPlayer, EVENT_PLAYER_UNIT_SELECTED, null);//call TriggerRegisterPlayerUnitEvent(bj_debugToolOfDeathTrig[index], indexPlayer, EVENT_PLAYER_UNIT_SELECTED, null)
					TriggerAddAction(bj_debugToolOfDeathTrig[index], function DebugToolOfDeath);//call TriggerAddAction(bj_debugToolOfDeathTrig[index], function DebugToolOfDeath)
					DisableTrigger(bj_debugToolOfDeathTrig[index]);//call DisableTrigger(bj_debugToolOfDeathTrig[index])
					bj_debugFingerOfDeathTrig[index] = CreateTrigger();//set bj_debugFingerOfDeathTrig[index] = CreateTrigger()
					TriggerRegisterPlayerChatEvent(bj_debugFingerOfDeathTrig[index], indexPlayer, bj_DEBUG_CHAT_FINGEROFDEATH, true);//call TriggerRegisterPlayerChatEvent(bj_debugFingerOfDeathTrig[index], indexPlayer, bj_DEBUG_CHAT_FINGEROFDEATH, true)
					TriggerAddAction(bj_debugFingerOfDeathTrig[index], function DebugToggleFingerOfDeath);//call TriggerAddAction(bj_debugFingerOfDeathTrig[index], function DebugToggleFingerOfDeath)
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
			return true;//return true
		}//endfunction

	
	}
}

