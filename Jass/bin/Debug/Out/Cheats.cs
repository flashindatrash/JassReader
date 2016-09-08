using System;

namespace Jass {

	public class Cheats {

		//===========================================================================
// Cheats.j
//===========================================================================
// Debug-cheat globals
//***************************************************************************
//*
//*  Debug cheats
//*
//***************************************************************************
//===========================================================================
private void DebugGimmeEnum() {
DisplayTextToPlayer(thePlayer, 0, 0, "Player "+I2S(GetPlayerId(GetTriggerPlayer())+1)+" cheated: Give 5000 gold and 5000 lumber to all players");
SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD, GetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD) + 5000);
SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER, GetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER) + 5000);
}
//===========================================================================
private void DebugGimme() {
ForForce(bj_FORCE_ALL_PLAYERS, function DebugGimmeEnum);
}
//===========================================================================
private void DebugDemoEnum() {
SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_GOLD, 0);
SetPlayerState(thePlayer, PLAYER_STATE_RESOURCE_LUMBER, 0);
}
//===========================================================================
private void DebugDemo() {
ForForce(bj_FORCE_ALL_PLAYERS, function DebugDemoEnum);
if ((GetLocalPlayer() == GetTriggerPlayer())) {
Cheat("warnings");
Cheat("fastbuild");
Cheat("techtree");
Cheat("research");
Cheat("food");
Cheat("mana");
Cheat("dawn");
Cheat("gold " + I2S(gold));
Cheat("lumber " + I2S(lumber));
}
}
//===========================================================================
private void DebugTeleportEnum() {
SetUnitPosition(u, GetCameraTargetPositionX(), GetCameraTargetPositionY());
}
//===========================================================================
private void DebugTeleport() {
SyncSelections();
GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);
ForGroup(g, function DebugTeleportEnum);
}
//===========================================================================
private string TertiaryStringOp(bool expr, string a, string b) {
if ((expr)) {
return a;
} else {
return b;
}
}
//===========================================================================
// Convert a integer id value into a 4-letter id code.
//
private string DebugIdInteger2IdString(int value) {
byteno = 0;
charValue = ModuloInteger(remainingValue, 256);
remainingValue = remainingValue / 256;
result = SubString(charMap, charValue, charValue + 1) + result;
byteno = byteno + 1;
return result;
}
//===========================================================================
private void DebugUnitInfoEnum() {
message = "Player" + I2S(GetPlayerId(GetOwningPlayer(theUnit)));
message = message + " '" + DebugIdInteger2IdString(GetUnitTypeId(theUnit)) + "'";
message = message + " " + GetUnitName(theUnit);
message = message + " (" + R2SW(GetUnitX(theUnit), 0, 0) + ", " + R2SW(GetUnitY(theUnit), 0, 0);
message = message + ": " + R2SW(GetUnitFacing(theUnit), 0, 0) + ") ";
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_HERO),            " Hero",      "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_DEAD),            " Dead",      "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_STRUCTURE),       " Structure", "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_GROUND),          " Grnd",      "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_FLYING),          " Air",       "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_ATTACKS_GROUND),  " VsGrnd",    "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_ATTACKS_FLYING),  " VsAir",     "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_MELEE_ATTACKER),  " Melee",     "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_RANGED_ATTACKER), " Ranged",    "");
message = message + TertiaryStringOp(IsUnitType(theUnit, UNIT_TYPE_SUMMONED),        " Summoned",  "");
DisplayTextToPlayer(thePlayer, 0, 0, message);
}
//===========================================================================
private void DebugUnitInfo() {
SyncSelections();
GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);
ForGroup(g, function DebugUnitInfoEnum);
}
//===========================================================================
private void DebugCamInfo() {
message = "Targ(" + R2SW(GetCameraTargetPositionX(), 0, 0);
message = message + "," + R2SW(GetCameraTargetPositionY(), 0, 0);
message = message + "," + R2SW(GetCameraTargetPositionZ(), 0, 0);
message = message + ")";
message = message + ", Dist=" + R2SW(GetCameraField(CAMERA_FIELD_TARGET_DISTANCE), 0, 0);
message = message + ", FarZ=" + R2SW(GetCameraField(CAMERA_FIELD_FARZ), 0, 0);
message = message + ", AoA=" + R2SW(GetCameraField(CAMERA_FIELD_ANGLE_OF_ATTACK) * bj_RADTODEG, 0, 2);
message = message + ", FoV=" + R2SW(GetCameraField(CAMERA_FIELD_FIELD_OF_VIEW) * bj_RADTODEG, 0, 2);
message = message + ", Roll=" + R2SW(GetCameraField(CAMERA_FIELD_ROLL) * bj_RADTODEG, 0, 2);
message = message + ", Rot=" + R2SW(GetCameraField(CAMERA_FIELD_ROTATION) * bj_RADTODEG, 0, 2);
DisplayTextToPlayer(thePlayer, 0, 0, message);
}
//===========================================================================
private void DebugCamField(camerafield whichField, int cheatLength, real defaultValue) {
// Remove any excess preceding whitespace
param = SubString(param, 1, 50);
if (param == "") {
value = defaultValue;
}
if ((whichField == CAMERA_FIELD_FARZ) && (value <= bj_CAMERA_MIN_FARZ)) {
}
SetCameraFieldForPlayer(GetTriggerPlayer(), whichField, value, bj_DEBUG_CAMFIELD_SPEED);
}
//===========================================================================
private void DebugCamDist() {
DebugCamField(CAMERA_FIELD_TARGET_DISTANCE, 7, 1600);
}
//===========================================================================
private void DebugCamFarZ() {
DebugCamField(CAMERA_FIELD_FARZ, 7, 4000);
}
//===========================================================================
private void DebugCamFOV() {
DebugCamField(CAMERA_FIELD_FIELD_OF_VIEW, 6, 65);
}
//===========================================================================
private void DebugCamAOA() {
DebugCamField(CAMERA_FIELD_ANGLE_OF_ATTACK, 6, 310);
}
//===========================================================================
private void DebugCamRoll() {
DebugCamField(CAMERA_FIELD_ROLL, 7, 0);
}
//===========================================================================
private void DebugCamRot() {
DebugCamField(CAMERA_FIELD_ROTATION, 6, 90);
}
//===========================================================================
private void DebugCamReset() {
ResetToGameCamera(0);
EnableUserControl(true);
}
//===========================================================================
private void DebugRemoveUnitEnum() {
RemoveUnit(GetEnumUnit());
}
//===========================================================================
private void DebugRemoveUnit() {
SyncSelections();
GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);
ForGroup(g, function DebugRemoveUnitEnum);
}
//===========================================================================
private void DebugGotoX() {
if ((bj_DEBUG_CHAT_GOTOX + " " == SubString(chatString, 0, 6))) {
SetCameraPositionForPlayer(GetTriggerPlayer(), S2R(SubString(chatString, 6, 50)), GetCameraTargetPositionY());
}
}
//===========================================================================
private void DebugGotoY() {
if ((bj_DEBUG_CHAT_GOTOY + " " == SubString(chatString, 0, 6))) {
SetCameraPositionForPlayer(GetTriggerPlayer(), GetCameraTargetPositionX(), S2R(SubString(chatString, 6, 50)));
}
}
//===========================================================================
private void DebugGotoXY() {
if ((bj_DEBUG_CHAT_GOTOXY + " " == SubString(chatString, 0, 7))) {
inParam1 = false;
index = 7;
if ((SubString(chatString, index, index + 1) != " ")) {
inParam1 = true;
}
index = index + 1;
if ((index > 50)) {
DisplayTextToPlayer(GetTriggerPlayer(), 0, 0, "Usage:  GotoXY x y");
} else {
if ((GetLocalPlayer() == GetTriggerPlayer())) {
SetCameraPositionForPlayer(GetTriggerPlayer(), S2R(SubString(chatString, 7, index)), S2R(SubString(chatString, index, 50)));
}
}
}
}
//===========================================================================
private void DebugGotoUnitEnum() {
bj_debugGotoUnitX = bj_debugGotoUnitX + GetUnitX(u);
bj_debugGotoUnitY = bj_debugGotoUnitY + GetUnitY(u);
bj_debugGotoUnits = bj_debugGotoUnits + 1;
}
//===========================================================================
private void DebugGotoUnit() {
bj_debugGotoUnitX = 0;
bj_debugGotoUnitY = 0;
bj_debugGotoUnits = 0;
SyncSelections();
GroupEnumUnitsSelected(g, GetTriggerPlayer(), null);
ForGroup(g, function DebugGotoUnitEnum);
if ((bj_debugGotoUnits != 0)) {
bj_debugGotoUnitX = bj_debugGotoUnitX / bj_debugGotoUnits;
bj_debugGotoUnitY = bj_debugGotoUnitY / bj_debugGotoUnits;
SetCameraPositionForPlayer(GetTriggerPlayer(), bj_debugGotoUnitX, bj_debugGotoUnitY);
}
}
//===========================================================================
private void DebugDifficulty() {
if ((theDiff == MAP_DIFFICULTY_EASY)) {
DisplayTextToPlayer(thePlayer, 0, 0, "Easy Difficulty");
} else if ((theDiff == MAP_DIFFICULTY_NORMAL)) {
DisplayTextToPlayer(thePlayer, 0, 0, "Normal Difficulty");
} else if ((theDiff == MAP_DIFFICULTY_HARD)) {
DisplayTextToPlayer(thePlayer, 0, 0, "Hard Difficulty");
} else {
DisplayTextToPlayer(thePlayer, 0, 0, "ERROR!  Unrecognized Difficulty");
}
}
//===========================================================================
private void DebugToolOfDeath() {
KillUnit(GetTriggerUnit());
}
//===========================================================================
private void DebugToggleFingerOfDeath() {
if ((bj_debugFingerOfDeathEnabled[index])) {
DisplayTextToPlayer(Player(index), 0, 0, "Finger Of Death Disabled");
DisableTrigger(bj_debugToolOfDeathTrig[index]);
} else {
DisplayTextToPlayer(Player(index), 0, 0, "Finger Of Death Enabled");
EnableTrigger(bj_debugToolOfDeathTrig[index]);
}
}
//===========================================================================
private bool InitDebugTriggers() {
index = 0;
indexPlayer = Player(index);
if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING)) {
bj_debugGimmeTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugGimmeTrig, indexPlayer, bj_DEBUG_CHAT_GIMME, true);
TriggerAddAction(bj_debugGimmeTrig, function DebugGimme);
bj_debugDemoTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugDemoTrig, indexPlayer, bj_DEBUG_CHAT_DEMO, true);
TriggerAddAction(bj_debugDemoTrig, function DebugDemo);
bj_debugTeleportTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugTeleportTrig, indexPlayer, bj_DEBUG_CHAT_TELEPORT, true);
TriggerAddAction(bj_debugTeleportTrig, function DebugTeleport);
bj_debugUnitInfoTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugUnitInfoTrig, indexPlayer, bj_DEBUG_CHAT_UNITINFO, true);
TriggerRegisterPlayerChatEvent(bj_debugUnitInfoTrig, indexPlayer, bj_DEBUG_CHAT_UNITINFO2, true);
TriggerAddAction(bj_debugUnitInfoTrig, function DebugUnitInfo);
bj_debugCamInfoTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamInfoTrig, indexPlayer, bj_DEBUG_CHAT_CAMINFO, true);
TriggerRegisterPlayerChatEvent(bj_debugCamInfoTrig, indexPlayer, bj_DEBUG_CHAT_CAMINFO2, true);
TriggerAddAction(bj_debugCamInfoTrig, function DebugCamInfo);
bj_debugCamDistTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamDistTrig, indexPlayer, bj_DEBUG_CHAT_CAMDIST, false);
TriggerAddAction(bj_debugCamDistTrig, function DebugCamDist);
bj_debugCamFarzTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamFarzTrig, indexPlayer, bj_DEBUG_CHAT_CAMFARZ, false);
TriggerAddAction(bj_debugCamFarzTrig, function DebugCamFarZ);
bj_debugCamFovTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamFovTrig, indexPlayer, bj_DEBUG_CHAT_CAMFOV, false);
TriggerAddAction(bj_debugCamFovTrig, function DebugCamFOV);
bj_debugCamAoaTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamAoaTrig, indexPlayer, bj_DEBUG_CHAT_CAMAOA, false);
TriggerAddAction(bj_debugCamAoaTrig, function DebugCamAOA);
bj_debugCamRollTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamRollTrig, indexPlayer, bj_DEBUG_CHAT_CAMROLL, false);
TriggerAddAction(bj_debugCamRollTrig, function DebugCamRoll);
bj_debugCamRotTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamRotTrig, indexPlayer, bj_DEBUG_CHAT_CAMROT, false);
TriggerAddAction(bj_debugCamRotTrig, function DebugCamRot);
bj_debugCamResetTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugCamResetTrig, indexPlayer, bj_DEBUG_CHAT_CAMRESET, true);
TriggerAddAction(bj_debugCamResetTrig, function DebugCamReset);
bj_debugRuTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugRuTrig, indexPlayer, bj_DEBUG_CHAT_REMOVEUNIT, true);
TriggerAddAction(bj_debugRuTrig, function DebugRemoveUnit);
bj_debugGotoXTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugGotoXTrig, indexPlayer, bj_DEBUG_CHAT_GOTOX, false);
TriggerAddAction(bj_debugGotoXTrig, function DebugGotoX);
bj_debugGotoYTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugGotoYTrig, indexPlayer, bj_DEBUG_CHAT_GOTOY, false);
TriggerAddAction(bj_debugGotoYTrig, function DebugGotoY);
bj_debugGotoXYTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugGotoXYTrig, indexPlayer, bj_DEBUG_CHAT_GOTOXY, false);
TriggerAddAction(bj_debugGotoXYTrig, function DebugGotoXY);
bj_debugGotoUnitTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugGotoUnitTrig, indexPlayer, bj_DEBUG_CHAT_GOTOUNIT, true);
TriggerAddAction(bj_debugGotoUnitTrig, function DebugGotoUnit);
bj_debugDifficultyTrig = CreateTrigger();
TriggerRegisterPlayerChatEvent(bj_debugDifficultyTrig, indexPlayer, bj_DEBUG_CHAT_DIFFICULTY, true);
TriggerAddAction(bj_debugDifficultyTrig, function DebugDifficulty);
TriggerRegisterPlayerUnitEvent(bj_debugToolOfDeathTrig[index], indexPlayer, EVENT_PLAYER_UNIT_SELECTED, null);
TriggerAddAction(bj_debugToolOfDeathTrig[index], function DebugToolOfDeath);
DisableTrigger(bj_debugToolOfDeathTrig[index]);
TriggerRegisterPlayerChatEvent(bj_debugFingerOfDeathTrig[index], indexPlayer, bj_DEBUG_CHAT_FINGEROFDEATH, true);
TriggerAddAction(bj_debugFingerOfDeathTrig[index], function DebugToggleFingerOfDeath);
}
index = index + 1;
return true;
}

	
	}
}

