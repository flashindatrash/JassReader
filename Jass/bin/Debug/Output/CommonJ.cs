using System;
using System.Collections.Generic;

namespace Jass {

	public class CommonJ {

		//
		//
		//
		//
		public static race ConvertRace(int i);//constant native ConvertRace                 takes integer i returns race
		public static alliancetype ConvertAllianceType(int i);//constant native ConvertAllianceType         takes integer i returns alliancetype
		public static racepreference ConvertRacePref(int i);//constant native ConvertRacePref             takes integer i returns racepreference
		public static igamestate ConvertIGameState(int i);//constant native ConvertIGameState           takes integer i returns igamestate
		public static fgamestate ConvertFGameState(int i);//constant native ConvertFGameState           takes integer i returns fgamestate
		public static playerstate ConvertPlayerState(int i);//constant native ConvertPlayerState          takes integer i returns playerstate
		public static playerscore ConvertPlayerScore(int i);//constant native ConvertPlayerScore          takes integer i returns playerscore
		public static playergameresult ConvertPlayerGameResult(int i);//constant native ConvertPlayerGameResult     takes integer i returns playergameresult
		public static unitstate ConvertUnitState(int i);//constant native ConvertUnitState            takes integer i returns unitstate
		public static aidifficulty ConvertAIDifficulty(int i);//constant native ConvertAIDifficulty         takes integer i returns aidifficulty
		public static gameevent ConvertGameEvent(int i);//constant native ConvertGameEvent            takes integer i returns gameevent
		public static playerevent ConvertPlayerEvent(int i);//constant native ConvertPlayerEvent          takes integer i returns playerevent
		public static playerunitevent ConvertPlayerUnitEvent(int i);//constant native ConvertPlayerUnitEvent      takes integer i returns playerunitevent
		public static widgetevent ConvertWidgetEvent(int i);//constant native ConvertWidgetEvent          takes integer i returns widgetevent
		public static dialogevent ConvertDialogEvent(int i);//constant native ConvertDialogEvent          takes integer i returns dialogevent
		public static unitevent ConvertUnitEvent(int i);//constant native ConvertUnitEvent            takes integer i returns unitevent
		public static limitop ConvertLimitOp(int i);//constant native ConvertLimitOp              takes integer i returns limitop
		public static unittype ConvertUnitType(int i);//constant native ConvertUnitType             takes integer i returns unittype
		public static gamespeed ConvertGameSpeed(int i);//constant native ConvertGameSpeed            takes integer i returns gamespeed
		public static placement ConvertPlacement(int i);//constant native ConvertPlacement            takes integer i returns placement
		public static startlocprio ConvertStartLocPrio(int i);//constant native ConvertStartLocPrio         takes integer i returns startlocprio
		public static gamedifficulty ConvertGameDifficulty(int i);//constant native ConvertGameDifficulty       takes integer i returns gamedifficulty
		public static gametype ConvertGameType(int i);//constant native ConvertGameType             takes integer i returns gametype
		public static mapflag ConvertMapFlag(int i);//constant native ConvertMapFlag              takes integer i returns mapflag
		public static mapvisibility ConvertMapVisibility(int i);//constant native ConvertMapVisibility        takes integer i returns mapvisibility
		public static mapsetting ConvertMapSetting(int i);//constant native ConvertMapSetting           takes integer i returns mapsetting
		public static mapdensity ConvertMapDensity(int i);//constant native ConvertMapDensity           takes integer i returns mapdensity
		public static mapcontrol ConvertMapControl(int i);//constant native ConvertMapControl           takes integer i returns mapcontrol
		public static playercolor ConvertPlayerColor(int i);//constant native ConvertPlayerColor          takes integer i returns playercolor
		public static playerslotstate ConvertPlayerSlotState(int i);//constant native ConvertPlayerSlotState      takes integer i returns playerslotstate
		public static volumegroup ConvertVolumeGroup(int i);//constant native ConvertVolumeGroup          takes integer i returns volumegroup
		public static camerafield ConvertCameraField(int i);//constant native ConvertCameraField          takes integer i returns camerafield
		public static blendmode ConvertBlendMode(int i);//constant native ConvertBlendMode            takes integer i returns blendmode
		public static raritycontrol ConvertRarityControl(int i);//constant native ConvertRarityControl        takes integer i returns raritycontrol
		public static texmapflags ConvertTexMapFlags(int i);//constant native ConvertTexMapFlags          takes integer i returns texmapflags
		public static fogstate ConvertFogState(int i);//constant native ConvertFogState             takes integer i returns fogstate
		public static effecttype ConvertEffectType(int i);//constant native ConvertEffectType           takes integer i returns effecttype
		public static version ConvertVersion(int i);//constant native ConvertVersion              takes integer i returns version
		public static itemtype ConvertItemType(int i);//constant native ConvertItemType             takes integer i returns itemtype
		public static attacktype ConvertAttackType(int i);//constant native ConvertAttackType           takes integer i returns attacktype
		public static damagetype ConvertDamageType(int i);//constant native ConvertDamageType           takes integer i returns damagetype
		public static weapontype ConvertWeaponType(int i);//constant native ConvertWeaponType           takes integer i returns weapontype
		public static soundtype ConvertSoundType(int i);//constant native ConvertSoundType            takes integer i returns soundtype
		public static pathingtype ConvertPathingType(int i);//constant native ConvertPathingType          takes integer i returns pathingtype
		public static int OrderId(string orderIdString);//constant native OrderId                     takes string  orderIdString     returns integer
		public static string OrderId2String(int orderId);//constant native OrderId2String              takes integer orderId           returns string
		public static int UnitId(string unitIdString);//constant native UnitId                      takes string  unitIdString      returns integer
		public static string UnitId2String(int unitId);//constant native UnitId2String               takes integer unitId            returns string
		//
		public static int AbilityId(string abilityIdString);//constant native AbilityId                   takes string  abilityIdString   returns integer
		public static string AbilityId2String(int abilityId);//constant native AbilityId2String            takes integer abilityId         returns string
		//
		public static string GetObjectName(int objectId);//constant native GetObjectName               takes integer objectId          returns string
		//
		//
		//
		//
		private bool FALSE = false;//constant boolean            FALSE                           = false
		private bool TRUE = true;//constant boolean            TRUE                            = true
		private int JASS_MAX_ARRAY_SIZE = 8192;//constant integer            JASS_MAX_ARRAY_SIZE             = 8192
		private int PLAYER_NEUTRAL_PASSIVE = 15;//constant integer            PLAYER_NEUTRAL_PASSIVE          = 15
		private int PLAYER_NEUTRAL_AGGRESSIVE = 12;//constant integer            PLAYER_NEUTRAL_AGGRESSIVE       = 12
		private playercolor PLAYER_COLOR_RED = ConvertPlayerColor(0);//constant playercolor        PLAYER_COLOR_RED                = ConvertPlayerColor(0)
		private playercolor PLAYER_COLOR_BLUE = ConvertPlayerColor(1);//constant playercolor        PLAYER_COLOR_BLUE               = ConvertPlayerColor(1)
		private playercolor PLAYER_COLOR_CYAN = ConvertPlayerColor(2);//constant playercolor        PLAYER_COLOR_CYAN               = ConvertPlayerColor(2)
		private playercolor PLAYER_COLOR_PURPLE = ConvertPlayerColor(3);//constant playercolor        PLAYER_COLOR_PURPLE             = ConvertPlayerColor(3)
		private playercolor PLAYER_COLOR_YELLOW = ConvertPlayerColor(4);//constant playercolor        PLAYER_COLOR_YELLOW             = ConvertPlayerColor(4)
		private playercolor PLAYER_COLOR_ORANGE = ConvertPlayerColor(5);//constant playercolor        PLAYER_COLOR_ORANGE             = ConvertPlayerColor(5)
		private playercolor PLAYER_COLOR_GREEN = ConvertPlayerColor(6);//constant playercolor        PLAYER_COLOR_GREEN              = ConvertPlayerColor(6)
		private playercolor PLAYER_COLOR_PINK = ConvertPlayerColor(7);//constant playercolor        PLAYER_COLOR_PINK               = ConvertPlayerColor(7)
		private playercolor PLAYER_COLOR_LIGHT_GRAY = ConvertPlayerColor(8);//constant playercolor        PLAYER_COLOR_LIGHT_GRAY         = ConvertPlayerColor(8)
		private playercolor PLAYER_COLOR_LIGHT_BLUE = ConvertPlayerColor(9);//constant playercolor        PLAYER_COLOR_LIGHT_BLUE         = ConvertPlayerColor(9)
		private playercolor PLAYER_COLOR_AQUA = ConvertPlayerColor(10);//constant playercolor        PLAYER_COLOR_AQUA               = ConvertPlayerColor(10)
		private playercolor PLAYER_COLOR_BROWN = ConvertPlayerColor(11);//constant playercolor        PLAYER_COLOR_BROWN              = ConvertPlayerColor(11)
		private race RACE_HUMAN = ConvertRace(1);//constant race               RACE_HUMAN                      = ConvertRace(1)
		private race RACE_ORC = ConvertRace(2);//constant race               RACE_ORC                        = ConvertRace(2)
		private race RACE_UNDEAD = ConvertRace(3);//constant race               RACE_UNDEAD                     = ConvertRace(3)
		private race RACE_NIGHTELF = ConvertRace(4);//constant race               RACE_NIGHTELF                   = ConvertRace(4)
		private race RACE_DEMON = ConvertRace(5);//constant race               RACE_DEMON                      = ConvertRace(5)
		private race RACE_OTHER = ConvertRace(7);//constant race               RACE_OTHER                      = ConvertRace(7)
		private playergameresult PLAYER_GAME_RESULT_VICTORY = ConvertPlayerGameResult(0);//constant playergameresult   PLAYER_GAME_RESULT_VICTORY      = ConvertPlayerGameResult(0)
		private playergameresult PLAYER_GAME_RESULT_DEFEAT = ConvertPlayerGameResult(1);//constant playergameresult   PLAYER_GAME_RESULT_DEFEAT       = ConvertPlayerGameResult(1)
		private playergameresult PLAYER_GAME_RESULT_TIE = ConvertPlayerGameResult(2);//constant playergameresult   PLAYER_GAME_RESULT_TIE          = ConvertPlayerGameResult(2)
		private playergameresult PLAYER_GAME_RESULT_NEUTRAL = ConvertPlayerGameResult(3);//constant playergameresult   PLAYER_GAME_RESULT_NEUTRAL      = ConvertPlayerGameResult(3)
		private alliancetype ALLIANCE_PASSIVE = ConvertAllianceType(0);//constant alliancetype       ALLIANCE_PASSIVE                = ConvertAllianceType(0)
		private alliancetype ALLIANCE_HELP_REQUEST = ConvertAllianceType(1);//constant alliancetype       ALLIANCE_HELP_REQUEST           = ConvertAllianceType(1)
		private alliancetype ALLIANCE_HELP_RESPONSE = ConvertAllianceType(2);//constant alliancetype       ALLIANCE_HELP_RESPONSE          = ConvertAllianceType(2)
		private alliancetype ALLIANCE_SHARED_XP = ConvertAllianceType(3);//constant alliancetype       ALLIANCE_SHARED_XP              = ConvertAllianceType(3)
		private alliancetype ALLIANCE_SHARED_SPELLS = ConvertAllianceType(4);//constant alliancetype       ALLIANCE_SHARED_SPELLS          = ConvertAllianceType(4)
		private alliancetype ALLIANCE_SHARED_VISION = ConvertAllianceType(5);//constant alliancetype       ALLIANCE_SHARED_VISION          = ConvertAllianceType(5)
		private alliancetype ALLIANCE_SHARED_CONTROL = ConvertAllianceType(6);//constant alliancetype       ALLIANCE_SHARED_CONTROL         = ConvertAllianceType(6)
		private alliancetype ALLIANCE_SHARED_ADVANCED_CONTROL = ConvertAllianceType(7);//constant alliancetype       ALLIANCE_SHARED_ADVANCED_CONTROL= ConvertAllianceType(7)
		private alliancetype ALLIANCE_RESCUABLE = ConvertAllianceType(8);//constant alliancetype       ALLIANCE_RESCUABLE              = ConvertAllianceType(8)
		private alliancetype ALLIANCE_SHARED_VISION_FORCED = ConvertAllianceType(9);//constant alliancetype       ALLIANCE_SHARED_VISION_FORCED   = ConvertAllianceType(9)
		private version VERSION_REIGN_OF_CHAOS = ConvertVersion(0);//constant version            VERSION_REIGN_OF_CHAOS          = ConvertVersion(0)
		private version VERSION_FROZEN_THRONE = ConvertVersion(1);//constant version            VERSION_FROZEN_THRONE           = ConvertVersion(1)
		private attacktype ATTACK_TYPE_NORMAL = ConvertAttackType(0);//constant attacktype         ATTACK_TYPE_NORMAL              = ConvertAttackType(0)
		private attacktype ATTACK_TYPE_MELEE = ConvertAttackType(1);//constant attacktype         ATTACK_TYPE_MELEE               = ConvertAttackType(1)
		private attacktype ATTACK_TYPE_PIERCE = ConvertAttackType(2);//constant attacktype         ATTACK_TYPE_PIERCE              = ConvertAttackType(2)
		private attacktype ATTACK_TYPE_SIEGE = ConvertAttackType(3);//constant attacktype         ATTACK_TYPE_SIEGE               = ConvertAttackType(3)
		private attacktype ATTACK_TYPE_MAGIC = ConvertAttackType(4);//constant attacktype         ATTACK_TYPE_MAGIC               = ConvertAttackType(4)
		private attacktype ATTACK_TYPE_CHAOS = ConvertAttackType(5);//constant attacktype         ATTACK_TYPE_CHAOS               = ConvertAttackType(5)
		private attacktype ATTACK_TYPE_HERO = ConvertAttackType(6);//constant attacktype         ATTACK_TYPE_HERO                = ConvertAttackType(6)
		private damagetype DAMAGE_TYPE_UNKNOWN = ConvertDamageType(0);//constant damagetype         DAMAGE_TYPE_UNKNOWN             = ConvertDamageType(0)
		private damagetype DAMAGE_TYPE_NORMAL = ConvertDamageType(4);//constant damagetype         DAMAGE_TYPE_NORMAL              = ConvertDamageType(4)
		private damagetype DAMAGE_TYPE_ENHANCED = ConvertDamageType(5);//constant damagetype         DAMAGE_TYPE_ENHANCED            = ConvertDamageType(5)
		private damagetype DAMAGE_TYPE_FIRE = ConvertDamageType(8);//constant damagetype         DAMAGE_TYPE_FIRE                = ConvertDamageType(8)
		private damagetype DAMAGE_TYPE_COLD = ConvertDamageType(9);//constant damagetype         DAMAGE_TYPE_COLD                = ConvertDamageType(9)
		private damagetype DAMAGE_TYPE_LIGHTNING = ConvertDamageType(10);//constant damagetype         DAMAGE_TYPE_LIGHTNING           = ConvertDamageType(10)
		private damagetype DAMAGE_TYPE_POISON = ConvertDamageType(11);//constant damagetype         DAMAGE_TYPE_POISON              = ConvertDamageType(11)
		private damagetype DAMAGE_TYPE_DISEASE = ConvertDamageType(12);//constant damagetype         DAMAGE_TYPE_DISEASE             = ConvertDamageType(12)
		private damagetype DAMAGE_TYPE_DIVINE = ConvertDamageType(13);//constant damagetype         DAMAGE_TYPE_DIVINE              = ConvertDamageType(13)
		private damagetype DAMAGE_TYPE_MAGIC = ConvertDamageType(14);//constant damagetype         DAMAGE_TYPE_MAGIC               = ConvertDamageType(14)
		private damagetype DAMAGE_TYPE_SONIC = ConvertDamageType(15);//constant damagetype         DAMAGE_TYPE_SONIC               = ConvertDamageType(15)
		private damagetype DAMAGE_TYPE_ACID = ConvertDamageType(16);//constant damagetype         DAMAGE_TYPE_ACID                = ConvertDamageType(16)
		private damagetype DAMAGE_TYPE_FORCE = ConvertDamageType(17);//constant damagetype         DAMAGE_TYPE_FORCE               = ConvertDamageType(17)
		private damagetype DAMAGE_TYPE_DEATH = ConvertDamageType(18);//constant damagetype         DAMAGE_TYPE_DEATH               = ConvertDamageType(18)
		private damagetype DAMAGE_TYPE_MIND = ConvertDamageType(19);//constant damagetype         DAMAGE_TYPE_MIND                = ConvertDamageType(19)
		private damagetype DAMAGE_TYPE_PLANT = ConvertDamageType(20);//constant damagetype         DAMAGE_TYPE_PLANT               = ConvertDamageType(20)
		private damagetype DAMAGE_TYPE_DEFENSIVE = ConvertDamageType(21);//constant damagetype         DAMAGE_TYPE_DEFENSIVE           = ConvertDamageType(21)
		private damagetype DAMAGE_TYPE_DEMOLITION = ConvertDamageType(22);//constant damagetype         DAMAGE_TYPE_DEMOLITION          = ConvertDamageType(22)
		private damagetype DAMAGE_TYPE_SLOW_POISON = ConvertDamageType(23);//constant damagetype         DAMAGE_TYPE_SLOW_POISON         = ConvertDamageType(23)
		private damagetype DAMAGE_TYPE_SPIRIT_LINK = ConvertDamageType(24);//constant damagetype         DAMAGE_TYPE_SPIRIT_LINK         = ConvertDamageType(24)
		private damagetype DAMAGE_TYPE_SHADOW_STRIKE = ConvertDamageType(25);//constant damagetype         DAMAGE_TYPE_SHADOW_STRIKE       = ConvertDamageType(25)
		private damagetype DAMAGE_TYPE_UNIVERSAL = ConvertDamageType(26);//constant damagetype         DAMAGE_TYPE_UNIVERSAL           = ConvertDamageType(26)
		private weapontype WEAPON_TYPE_WHOKNOWS = ConvertWeaponType(0);//constant weapontype         WEAPON_TYPE_WHOKNOWS            = ConvertWeaponType(0)
		private weapontype WEAPON_TYPE_METAL_LIGHT_CHOP = ConvertWeaponType(1);//constant weapontype         WEAPON_TYPE_METAL_LIGHT_CHOP    = ConvertWeaponType(1)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_CHOP = ConvertWeaponType(2);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_CHOP   = ConvertWeaponType(2)
		private weapontype WEAPON_TYPE_METAL_HEAVY_CHOP = ConvertWeaponType(3);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_CHOP    = ConvertWeaponType(3)
		private weapontype WEAPON_TYPE_METAL_LIGHT_SLICE = ConvertWeaponType(4);//constant weapontype         WEAPON_TYPE_METAL_LIGHT_SLICE   = ConvertWeaponType(4)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_SLICE = ConvertWeaponType(5);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_SLICE  = ConvertWeaponType(5)
		private weapontype WEAPON_TYPE_METAL_HEAVY_SLICE = ConvertWeaponType(6);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_SLICE   = ConvertWeaponType(6)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_BASH = ConvertWeaponType(7);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_BASH   = ConvertWeaponType(7)
		private weapontype WEAPON_TYPE_METAL_HEAVY_BASH = ConvertWeaponType(8);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_BASH    = ConvertWeaponType(8)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_STAB = ConvertWeaponType(9);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_STAB   = ConvertWeaponType(9)
		private weapontype WEAPON_TYPE_METAL_HEAVY_STAB = ConvertWeaponType(10);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_STAB    = ConvertWeaponType(10)
		private weapontype WEAPON_TYPE_WOOD_LIGHT_SLICE = ConvertWeaponType(11);//constant weapontype         WEAPON_TYPE_WOOD_LIGHT_SLICE    = ConvertWeaponType(11)
		private weapontype WEAPON_TYPE_WOOD_MEDIUM_SLICE = ConvertWeaponType(12);//constant weapontype         WEAPON_TYPE_WOOD_MEDIUM_SLICE   = ConvertWeaponType(12)
		private weapontype WEAPON_TYPE_WOOD_HEAVY_SLICE = ConvertWeaponType(13);//constant weapontype         WEAPON_TYPE_WOOD_HEAVY_SLICE    = ConvertWeaponType(13)
		private weapontype WEAPON_TYPE_WOOD_LIGHT_BASH = ConvertWeaponType(14);//constant weapontype         WEAPON_TYPE_WOOD_LIGHT_BASH     = ConvertWeaponType(14)
		private weapontype WEAPON_TYPE_WOOD_MEDIUM_BASH = ConvertWeaponType(15);//constant weapontype         WEAPON_TYPE_WOOD_MEDIUM_BASH    = ConvertWeaponType(15)
		private weapontype WEAPON_TYPE_WOOD_HEAVY_BASH = ConvertWeaponType(16);//constant weapontype         WEAPON_TYPE_WOOD_HEAVY_BASH     = ConvertWeaponType(16)
		private weapontype WEAPON_TYPE_WOOD_LIGHT_STAB = ConvertWeaponType(17);//constant weapontype         WEAPON_TYPE_WOOD_LIGHT_STAB     = ConvertWeaponType(17)
		private weapontype WEAPON_TYPE_WOOD_MEDIUM_STAB = ConvertWeaponType(18);//constant weapontype         WEAPON_TYPE_WOOD_MEDIUM_STAB    = ConvertWeaponType(18)
		private weapontype WEAPON_TYPE_CLAW_LIGHT_SLICE = ConvertWeaponType(19);//constant weapontype         WEAPON_TYPE_CLAW_LIGHT_SLICE    = ConvertWeaponType(19)
		private weapontype WEAPON_TYPE_CLAW_MEDIUM_SLICE = ConvertWeaponType(20);//constant weapontype         WEAPON_TYPE_CLAW_MEDIUM_SLICE   = ConvertWeaponType(20)
		private weapontype WEAPON_TYPE_CLAW_HEAVY_SLICE = ConvertWeaponType(21);//constant weapontype         WEAPON_TYPE_CLAW_HEAVY_SLICE    = ConvertWeaponType(21)
		private weapontype WEAPON_TYPE_AXE_MEDIUM_CHOP = ConvertWeaponType(22);//constant weapontype         WEAPON_TYPE_AXE_MEDIUM_CHOP     = ConvertWeaponType(22)
		private weapontype WEAPON_TYPE_ROCK_HEAVY_BASH = ConvertWeaponType(23);//constant weapontype         WEAPON_TYPE_ROCK_HEAVY_BASH     = ConvertWeaponType(23)
		private pathingtype PATHING_TYPE_ANY = ConvertPathingType(0);//constant pathingtype        PATHING_TYPE_ANY                = ConvertPathingType(0)
		private pathingtype PATHING_TYPE_WALKABILITY = ConvertPathingType(1);//constant pathingtype        PATHING_TYPE_WALKABILITY        = ConvertPathingType(1)
		private pathingtype PATHING_TYPE_FLYABILITY = ConvertPathingType(2);//constant pathingtype        PATHING_TYPE_FLYABILITY         = ConvertPathingType(2)
		private pathingtype PATHING_TYPE_BUILDABILITY = ConvertPathingType(3);//constant pathingtype        PATHING_TYPE_BUILDABILITY       = ConvertPathingType(3)
		private pathingtype PATHING_TYPE_PEONHARVESTPATHING = ConvertPathingType(4);//constant pathingtype        PATHING_TYPE_PEONHARVESTPATHING = ConvertPathingType(4)
		private pathingtype PATHING_TYPE_BLIGHTPATHING = ConvertPathingType(5);//constant pathingtype        PATHING_TYPE_BLIGHTPATHING      = ConvertPathingType(5)
		private pathingtype PATHING_TYPE_FLOATABILITY = ConvertPathingType(6);//constant pathingtype        PATHING_TYPE_FLOATABILITY       = ConvertPathingType(6)
		private pathingtype PATHING_TYPE_AMPHIBIOUSPATHING = ConvertPathingType(7);//constant pathingtype        PATHING_TYPE_AMPHIBIOUSPATHING  = ConvertPathingType(7)
		//
		//
		//
		private racepreference RACE_PREF_HUMAN = ConvertRacePref(1);//constant racepreference     RACE_PREF_HUMAN                     = ConvertRacePref(1)
		private racepreference RACE_PREF_ORC = ConvertRacePref(2);//constant racepreference     RACE_PREF_ORC                       = ConvertRacePref(2)
		private racepreference RACE_PREF_NIGHTELF = ConvertRacePref(4);//constant racepreference     RACE_PREF_NIGHTELF                  = ConvertRacePref(4)
		private racepreference RACE_PREF_UNDEAD = ConvertRacePref(8);//constant racepreference     RACE_PREF_UNDEAD                    = ConvertRacePref(8)
		private racepreference RACE_PREF_DEMON = ConvertRacePref(16);//constant racepreference     RACE_PREF_DEMON                     = ConvertRacePref(16)
		private racepreference RACE_PREF_RANDOM = ConvertRacePref(32);//constant racepreference     RACE_PREF_RANDOM                    = ConvertRacePref(32)
		private racepreference RACE_PREF_USER_SELECTABLE = ConvertRacePref(64);//constant racepreference     RACE_PREF_USER_SELECTABLE           = ConvertRacePref(64)
		private mapcontrol MAP_CONTROL_USER = ConvertMapControl(0);//constant mapcontrol         MAP_CONTROL_USER                    = ConvertMapControl(0)
		private mapcontrol MAP_CONTROL_COMPUTER = ConvertMapControl(1);//constant mapcontrol         MAP_CONTROL_COMPUTER                = ConvertMapControl(1)
		private mapcontrol MAP_CONTROL_RESCUABLE = ConvertMapControl(2);//constant mapcontrol         MAP_CONTROL_RESCUABLE               = ConvertMapControl(2)
		private mapcontrol MAP_CONTROL_NEUTRAL = ConvertMapControl(3);//constant mapcontrol         MAP_CONTROL_NEUTRAL                 = ConvertMapControl(3)
		private mapcontrol MAP_CONTROL_CREEP = ConvertMapControl(4);//constant mapcontrol         MAP_CONTROL_CREEP                   = ConvertMapControl(4)
		private mapcontrol MAP_CONTROL_NONE = ConvertMapControl(5);//constant mapcontrol         MAP_CONTROL_NONE                    = ConvertMapControl(5)
		private gametype GAME_TYPE_MELEE = ConvertGameType(1);//constant gametype           GAME_TYPE_MELEE                     = ConvertGameType(1)
		private gametype GAME_TYPE_FFA = ConvertGameType(2);//constant gametype           GAME_TYPE_FFA                       = ConvertGameType(2)
		private gametype GAME_TYPE_USE_MAP_SETTINGS = ConvertGameType(4);//constant gametype           GAME_TYPE_USE_MAP_SETTINGS          = ConvertGameType(4)
		private gametype GAME_TYPE_BLIZ = ConvertGameType(8);//constant gametype           GAME_TYPE_BLIZ                      = ConvertGameType(8)
		private gametype GAME_TYPE_ONE_ON_ONE = ConvertGameType(16);//constant gametype           GAME_TYPE_ONE_ON_ONE                = ConvertGameType(16)
		private gametype GAME_TYPE_TWO_TEAM_PLAY = ConvertGameType(32);//constant gametype           GAME_TYPE_TWO_TEAM_PLAY             = ConvertGameType(32)
		private gametype GAME_TYPE_THREE_TEAM_PLAY = ConvertGameType(64);//constant gametype           GAME_TYPE_THREE_TEAM_PLAY           = ConvertGameType(64)
		private gametype GAME_TYPE_FOUR_TEAM_PLAY = ConvertGameType(128);//constant gametype           GAME_TYPE_FOUR_TEAM_PLAY            = ConvertGameType(128)
		private mapflag MAP_FOG_HIDE_TERRAIN = ConvertMapFlag(1);//constant mapflag            MAP_FOG_HIDE_TERRAIN                = ConvertMapFlag(1)
		private mapflag MAP_FOG_MAP_EXPLORED = ConvertMapFlag(2);//constant mapflag            MAP_FOG_MAP_EXPLORED                = ConvertMapFlag(2)
		private mapflag MAP_FOG_ALWAYS_VISIBLE = ConvertMapFlag(4);//constant mapflag            MAP_FOG_ALWAYS_VISIBLE              = ConvertMapFlag(4)
		private mapflag MAP_USE_HANDICAPS = ConvertMapFlag(8);//constant mapflag            MAP_USE_HANDICAPS                   = ConvertMapFlag(8)
		private mapflag MAP_OBSERVERS = ConvertMapFlag(16);//constant mapflag            MAP_OBSERVERS                       = ConvertMapFlag(16)
		private mapflag MAP_OBSERVERS_ON_DEATH = ConvertMapFlag(32);//constant mapflag            MAP_OBSERVERS_ON_DEATH              = ConvertMapFlag(32)
		private mapflag MAP_FIXED_COLORS = ConvertMapFlag(128);//constant mapflag            MAP_FIXED_COLORS                    = ConvertMapFlag(128)
		private mapflag MAP_LOCK_RESOURCE_TRADING = ConvertMapFlag(256);//constant mapflag            MAP_LOCK_RESOURCE_TRADING           = ConvertMapFlag(256)
		private mapflag MAP_RESOURCE_TRADING_ALLIES_ONLY = ConvertMapFlag(512);//constant mapflag            MAP_RESOURCE_TRADING_ALLIES_ONLY    = ConvertMapFlag(512)
		private mapflag MAP_LOCK_ALLIANCE_CHANGES = ConvertMapFlag(1024);//constant mapflag            MAP_LOCK_ALLIANCE_CHANGES           = ConvertMapFlag(1024)
		private mapflag MAP_ALLIANCE_CHANGES_HIDDEN = ConvertMapFlag(2048);//constant mapflag            MAP_ALLIANCE_CHANGES_HIDDEN         = ConvertMapFlag(2048)
		private mapflag MAP_CHEATS = ConvertMapFlag(4096);//constant mapflag            MAP_CHEATS                          = ConvertMapFlag(4096)
		private mapflag MAP_CHEATS_HIDDEN = ConvertMapFlag(8192);//constant mapflag            MAP_CHEATS_HIDDEN                   = ConvertMapFlag(8192)
		private mapflag MAP_LOCK_SPEED = ConvertMapFlag(8192*2);//constant mapflag            MAP_LOCK_SPEED                      = ConvertMapFlag(8192*2)
		private mapflag MAP_LOCK_RANDOM_SEED = ConvertMapFlag(8192*4);//constant mapflag            MAP_LOCK_RANDOM_SEED                = ConvertMapFlag(8192*4)
		private mapflag MAP_SHARED_ADVANCED_CONTROL = ConvertMapFlag(8192*8);//constant mapflag            MAP_SHARED_ADVANCED_CONTROL         = ConvertMapFlag(8192*8)
		private mapflag MAP_RANDOM_HERO = ConvertMapFlag(8192*16);//constant mapflag            MAP_RANDOM_HERO                     = ConvertMapFlag(8192*16)
		private mapflag MAP_RANDOM_RACES = ConvertMapFlag(8192*32);//constant mapflag            MAP_RANDOM_RACES                    = ConvertMapFlag(8192*32)
		private mapflag MAP_RELOADED = ConvertMapFlag(8192*64);//constant mapflag            MAP_RELOADED                        = ConvertMapFlag(8192*64)
		private placement MAP_PLACEMENT_RANDOM = ConvertPlacement(0);//constant placement          MAP_PLACEMENT_RANDOM                = ConvertPlacement(0)
		private placement MAP_PLACEMENT_FIXED = ConvertPlacement(1);//constant placement          MAP_PLACEMENT_FIXED                 = ConvertPlacement(1)
		private placement MAP_PLACEMENT_USE_MAP_SETTINGS = ConvertPlacement(2);//constant placement          MAP_PLACEMENT_USE_MAP_SETTINGS      = ConvertPlacement(2)
		private placement MAP_PLACEMENT_TEAMS_TOGETHER = ConvertPlacement(3);//constant placement          MAP_PLACEMENT_TEAMS_TOGETHER        = ConvertPlacement(3)
		private startlocprio MAP_LOC_PRIO_LOW = ConvertStartLocPrio(0);//constant startlocprio       MAP_LOC_PRIO_LOW                    = ConvertStartLocPrio(0)
		private startlocprio MAP_LOC_PRIO_HIGH = ConvertStartLocPrio(1);//constant startlocprio       MAP_LOC_PRIO_HIGH                   = ConvertStartLocPrio(1)
		private startlocprio MAP_LOC_PRIO_NOT = ConvertStartLocPrio(2);//constant startlocprio       MAP_LOC_PRIO_NOT                    = ConvertStartLocPrio(2)
		private mapdensity MAP_DENSITY_NONE = ConvertMapDensity(0);//constant mapdensity         MAP_DENSITY_NONE                    = ConvertMapDensity(0)
		private mapdensity MAP_DENSITY_LIGHT = ConvertMapDensity(1);//constant mapdensity         MAP_DENSITY_LIGHT                   = ConvertMapDensity(1)
		private mapdensity MAP_DENSITY_MEDIUM = ConvertMapDensity(2);//constant mapdensity         MAP_DENSITY_MEDIUM                  = ConvertMapDensity(2)
		private mapdensity MAP_DENSITY_HEAVY = ConvertMapDensity(3);//constant mapdensity         MAP_DENSITY_HEAVY                   = ConvertMapDensity(3)
		private gamedifficulty MAP_DIFFICULTY_EASY = ConvertGameDifficulty(0);//constant gamedifficulty     MAP_DIFFICULTY_EASY                 = ConvertGameDifficulty(0)
		private gamedifficulty MAP_DIFFICULTY_NORMAL = ConvertGameDifficulty(1);//constant gamedifficulty     MAP_DIFFICULTY_NORMAL               = ConvertGameDifficulty(1)
		private gamedifficulty MAP_DIFFICULTY_HARD = ConvertGameDifficulty(2);//constant gamedifficulty     MAP_DIFFICULTY_HARD                 = ConvertGameDifficulty(2)
		private gamedifficulty MAP_DIFFICULTY_INSANE = ConvertGameDifficulty(3);//constant gamedifficulty     MAP_DIFFICULTY_INSANE               = ConvertGameDifficulty(3)
		private gamespeed MAP_SPEED_SLOWEST = ConvertGameSpeed(0);//constant gamespeed          MAP_SPEED_SLOWEST                   = ConvertGameSpeed(0)
		private gamespeed MAP_SPEED_SLOW = ConvertGameSpeed(1);//constant gamespeed          MAP_SPEED_SLOW                      = ConvertGameSpeed(1)
		private gamespeed MAP_SPEED_NORMAL = ConvertGameSpeed(2);//constant gamespeed          MAP_SPEED_NORMAL                    = ConvertGameSpeed(2)
		private gamespeed MAP_SPEED_FAST = ConvertGameSpeed(3);//constant gamespeed          MAP_SPEED_FAST                      = ConvertGameSpeed(3)
		private gamespeed MAP_SPEED_FASTEST = ConvertGameSpeed(4);//constant gamespeed          MAP_SPEED_FASTEST                   = ConvertGameSpeed(4)
		private playerslotstate PLAYER_SLOT_STATE_EMPTY = ConvertPlayerSlotState(0);//constant playerslotstate    PLAYER_SLOT_STATE_EMPTY             = ConvertPlayerSlotState(0)
		private playerslotstate PLAYER_SLOT_STATE_PLAYING = ConvertPlayerSlotState(1);//constant playerslotstate    PLAYER_SLOT_STATE_PLAYING           = ConvertPlayerSlotState(1)
		private playerslotstate PLAYER_SLOT_STATE_LEFT = ConvertPlayerSlotState(2);//constant playerslotstate    PLAYER_SLOT_STATE_LEFT              = ConvertPlayerSlotState(2)
		//
		//
		//
		private volumegroup SOUND_VOLUMEGROUP_UNITMOVEMENT = ConvertVolumeGroup(0);//constant volumegroup        SOUND_VOLUMEGROUP_UNITMOVEMENT      = ConvertVolumeGroup(0)
		private volumegroup SOUND_VOLUMEGROUP_UNITSOUNDS = ConvertVolumeGroup(1);//constant volumegroup        SOUND_VOLUMEGROUP_UNITSOUNDS        = ConvertVolumeGroup(1)
		private volumegroup SOUND_VOLUMEGROUP_COMBAT = ConvertVolumeGroup(2);//constant volumegroup        SOUND_VOLUMEGROUP_COMBAT            = ConvertVolumeGroup(2)
		private volumegroup SOUND_VOLUMEGROUP_SPELLS = ConvertVolumeGroup(3);//constant volumegroup        SOUND_VOLUMEGROUP_SPELLS            = ConvertVolumeGroup(3)
		private volumegroup SOUND_VOLUMEGROUP_UI = ConvertVolumeGroup(4);//constant volumegroup        SOUND_VOLUMEGROUP_UI                = ConvertVolumeGroup(4)
		private volumegroup SOUND_VOLUMEGROUP_MUSIC = ConvertVolumeGroup(5);//constant volumegroup        SOUND_VOLUMEGROUP_MUSIC             = ConvertVolumeGroup(5)
		private volumegroup SOUND_VOLUMEGROUP_AMBIENTSOUNDS = ConvertVolumeGroup(6);//constant volumegroup        SOUND_VOLUMEGROUP_AMBIENTSOUNDS     = ConvertVolumeGroup(6)
		private volumegroup SOUND_VOLUMEGROUP_FIRE = ConvertVolumeGroup(7);//constant volumegroup        SOUND_VOLUMEGROUP_FIRE              = ConvertVolumeGroup(7)
		//
		//
		//
		//
		//
		//
		private igamestate GAME_STATE_DIVINE_INTERVENTION = ConvertIGameState(0);//constant igamestate GAME_STATE_DIVINE_INTERVENTION          = ConvertIGameState(0)
		private igamestate GAME_STATE_DISCONNECTED = ConvertIGameState(1);//constant igamestate GAME_STATE_DISCONNECTED                 = ConvertIGameState(1)
		private fgamestate GAME_STATE_TIME_OF_DAY = ConvertFGameState(2);//constant fgamestate GAME_STATE_TIME_OF_DAY                  = ConvertFGameState(2)
		private playerstate PLAYER_STATE_GAME_RESULT = ConvertPlayerState(0);//constant playerstate PLAYER_STATE_GAME_RESULT               = ConvertPlayerState(0)
		//
		//
		private playerstate PLAYER_STATE_RESOURCE_GOLD = ConvertPlayerState(1);//constant playerstate PLAYER_STATE_RESOURCE_GOLD             = ConvertPlayerState(1)
		private playerstate PLAYER_STATE_RESOURCE_LUMBER = ConvertPlayerState(2);//constant playerstate PLAYER_STATE_RESOURCE_LUMBER           = ConvertPlayerState(2)
		private playerstate PLAYER_STATE_RESOURCE_HERO_TOKENS = ConvertPlayerState(3);//constant playerstate PLAYER_STATE_RESOURCE_HERO_TOKENS      = ConvertPlayerState(3)
		private playerstate PLAYER_STATE_RESOURCE_FOOD_CAP = ConvertPlayerState(4);//constant playerstate PLAYER_STATE_RESOURCE_FOOD_CAP         = ConvertPlayerState(4)
		private playerstate PLAYER_STATE_RESOURCE_FOOD_USED = ConvertPlayerState(5);//constant playerstate PLAYER_STATE_RESOURCE_FOOD_USED        = ConvertPlayerState(5)
		private playerstate PLAYER_STATE_FOOD_CAP_CEILING = ConvertPlayerState(6);//constant playerstate PLAYER_STATE_FOOD_CAP_CEILING          = ConvertPlayerState(6)
		private playerstate PLAYER_STATE_GIVES_BOUNTY = ConvertPlayerState(7);//constant playerstate PLAYER_STATE_GIVES_BOUNTY              = ConvertPlayerState(7)
		private playerstate PLAYER_STATE_ALLIED_VICTORY = ConvertPlayerState(8);//constant playerstate PLAYER_STATE_ALLIED_VICTORY            = ConvertPlayerState(8)
		private playerstate PLAYER_STATE_PLACED = ConvertPlayerState(9);//constant playerstate PLAYER_STATE_PLACED                    = ConvertPlayerState(9)
		private playerstate PLAYER_STATE_OBSERVER_ON_DEATH = ConvertPlayerState(10);//constant playerstate PLAYER_STATE_OBSERVER_ON_DEATH         = ConvertPlayerState(10)
		private playerstate PLAYER_STATE_OBSERVER = ConvertPlayerState(11);//constant playerstate PLAYER_STATE_OBSERVER                  = ConvertPlayerState(11)
		private playerstate PLAYER_STATE_UNFOLLOWABLE = ConvertPlayerState(12);//constant playerstate PLAYER_STATE_UNFOLLOWABLE              = ConvertPlayerState(12)
		//
		//
		private playerstate PLAYER_STATE_GOLD_UPKEEP_RATE = ConvertPlayerState(13);//constant playerstate PLAYER_STATE_GOLD_UPKEEP_RATE          = ConvertPlayerState(13)
		private playerstate PLAYER_STATE_LUMBER_UPKEEP_RATE = ConvertPlayerState(14);//constant playerstate PLAYER_STATE_LUMBER_UPKEEP_RATE        = ConvertPlayerState(14)
		//
		//
		private playerstate PLAYER_STATE_GOLD_GATHERED = ConvertPlayerState(15);//constant playerstate PLAYER_STATE_GOLD_GATHERED             = ConvertPlayerState(15)
		private playerstate PLAYER_STATE_LUMBER_GATHERED = ConvertPlayerState(16);//constant playerstate PLAYER_STATE_LUMBER_GATHERED           = ConvertPlayerState(16)
		private playerstate PLAYER_STATE_NO_CREEP_SLEEP = ConvertPlayerState(25);//constant playerstate PLAYER_STATE_NO_CREEP_SLEEP            = ConvertPlayerState(25)
		private unitstate UNIT_STATE_LIFE = ConvertUnitState(0);//constant unitstate UNIT_STATE_LIFE                          = ConvertUnitState(0)
		private unitstate UNIT_STATE_MAX_LIFE = ConvertUnitState(1);//constant unitstate UNIT_STATE_MAX_LIFE                      = ConvertUnitState(1)
		private unitstate UNIT_STATE_MANA = ConvertUnitState(2);//constant unitstate UNIT_STATE_MANA                          = ConvertUnitState(2)
		private unitstate UNIT_STATE_MAX_MANA = ConvertUnitState(3);//constant unitstate UNIT_STATE_MAX_MANA                      = ConvertUnitState(3)
		private aidifficulty AI_DIFFICULTY_NEWBIE = ConvertAIDifficulty(0);//constant aidifficulty AI_DIFFICULTY_NEWBIE                  = ConvertAIDifficulty(0)
		private aidifficulty AI_DIFFICULTY_NORMAL = ConvertAIDifficulty(1);//constant aidifficulty AI_DIFFICULTY_NORMAL                  = ConvertAIDifficulty(1)
		private aidifficulty AI_DIFFICULTY_INSANE = ConvertAIDifficulty(2);//constant aidifficulty AI_DIFFICULTY_INSANE                  = ConvertAIDifficulty(2)
		//
		private playerscore PLAYER_SCORE_UNITS_TRAINED = ConvertPlayerScore(0);//constant playerscore PLAYER_SCORE_UNITS_TRAINED             = ConvertPlayerScore(0)
		private playerscore PLAYER_SCORE_UNITS_KILLED = ConvertPlayerScore(1);//constant playerscore PLAYER_SCORE_UNITS_KILLED              = ConvertPlayerScore(1)
		private playerscore PLAYER_SCORE_STRUCT_BUILT = ConvertPlayerScore(2);//constant playerscore PLAYER_SCORE_STRUCT_BUILT              = ConvertPlayerScore(2)
		private playerscore PLAYER_SCORE_STRUCT_RAZED = ConvertPlayerScore(3);//constant playerscore PLAYER_SCORE_STRUCT_RAZED              = ConvertPlayerScore(3)
		private playerscore PLAYER_SCORE_TECH_PERCENT = ConvertPlayerScore(4);//constant playerscore PLAYER_SCORE_TECH_PERCENT              = ConvertPlayerScore(4)
		private playerscore PLAYER_SCORE_FOOD_MAXPROD = ConvertPlayerScore(5);//constant playerscore PLAYER_SCORE_FOOD_MAXPROD              = ConvertPlayerScore(5)
		private playerscore PLAYER_SCORE_FOOD_MAXUSED = ConvertPlayerScore(6);//constant playerscore PLAYER_SCORE_FOOD_MAXUSED              = ConvertPlayerScore(6)
		private playerscore PLAYER_SCORE_HEROES_KILLED = ConvertPlayerScore(7);//constant playerscore PLAYER_SCORE_HEROES_KILLED             = ConvertPlayerScore(7)
		private playerscore PLAYER_SCORE_ITEMS_GAINED = ConvertPlayerScore(8);//constant playerscore PLAYER_SCORE_ITEMS_GAINED              = ConvertPlayerScore(8)
		private playerscore PLAYER_SCORE_MERCS_HIRED = ConvertPlayerScore(9);//constant playerscore PLAYER_SCORE_MERCS_HIRED               = ConvertPlayerScore(9)
		private playerscore PLAYER_SCORE_GOLD_MINED_TOTAL = ConvertPlayerScore(10);//constant playerscore PLAYER_SCORE_GOLD_MINED_TOTAL          = ConvertPlayerScore(10)
		private playerscore PLAYER_SCORE_GOLD_MINED_UPKEEP = ConvertPlayerScore(11);//constant playerscore PLAYER_SCORE_GOLD_MINED_UPKEEP         = ConvertPlayerScore(11)
		private playerscore PLAYER_SCORE_GOLD_LOST_UPKEEP = ConvertPlayerScore(12);//constant playerscore PLAYER_SCORE_GOLD_LOST_UPKEEP          = ConvertPlayerScore(12)
		private playerscore PLAYER_SCORE_GOLD_LOST_TAX = ConvertPlayerScore(13);//constant playerscore PLAYER_SCORE_GOLD_LOST_TAX             = ConvertPlayerScore(13)
		private playerscore PLAYER_SCORE_GOLD_GIVEN = ConvertPlayerScore(14);//constant playerscore PLAYER_SCORE_GOLD_GIVEN                = ConvertPlayerScore(14)
		private playerscore PLAYER_SCORE_GOLD_RECEIVED = ConvertPlayerScore(15);//constant playerscore PLAYER_SCORE_GOLD_RECEIVED             = ConvertPlayerScore(15)
		private playerscore PLAYER_SCORE_LUMBER_TOTAL = ConvertPlayerScore(16);//constant playerscore PLAYER_SCORE_LUMBER_TOTAL              = ConvertPlayerScore(16)
		private playerscore PLAYER_SCORE_LUMBER_LOST_UPKEEP = ConvertPlayerScore(17);//constant playerscore PLAYER_SCORE_LUMBER_LOST_UPKEEP        = ConvertPlayerScore(17)
		private playerscore PLAYER_SCORE_LUMBER_LOST_TAX = ConvertPlayerScore(18);//constant playerscore PLAYER_SCORE_LUMBER_LOST_TAX           = ConvertPlayerScore(18)
		private playerscore PLAYER_SCORE_LUMBER_GIVEN = ConvertPlayerScore(19);//constant playerscore PLAYER_SCORE_LUMBER_GIVEN              = ConvertPlayerScore(19)
		private playerscore PLAYER_SCORE_LUMBER_RECEIVED = ConvertPlayerScore(20);//constant playerscore PLAYER_SCORE_LUMBER_RECEIVED           = ConvertPlayerScore(20)
		private playerscore PLAYER_SCORE_UNIT_TOTAL = ConvertPlayerScore(21);//constant playerscore PLAYER_SCORE_UNIT_TOTAL                = ConvertPlayerScore(21)
		private playerscore PLAYER_SCORE_HERO_TOTAL = ConvertPlayerScore(22);//constant playerscore PLAYER_SCORE_HERO_TOTAL                = ConvertPlayerScore(22)
		private playerscore PLAYER_SCORE_RESOURCE_TOTAL = ConvertPlayerScore(23);//constant playerscore PLAYER_SCORE_RESOURCE_TOTAL            = ConvertPlayerScore(23)
		private playerscore PLAYER_SCORE_TOTAL = ConvertPlayerScore(24);//constant playerscore PLAYER_SCORE_TOTAL                     = ConvertPlayerScore(24)
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		private gameevent EVENT_GAME_VICTORY = ConvertGameEvent(0);//constant gameevent EVENT_GAME_VICTORY                       = ConvertGameEvent(0)
		private gameevent EVENT_GAME_END_LEVEL = ConvertGameEvent(1);//constant gameevent EVENT_GAME_END_LEVEL                     = ConvertGameEvent(1)
		private gameevent EVENT_GAME_VARIABLE_LIMIT = ConvertGameEvent(2);//constant gameevent EVENT_GAME_VARIABLE_LIMIT                = ConvertGameEvent(2)
		private gameevent EVENT_GAME_STATE_LIMIT = ConvertGameEvent(3);//constant gameevent EVENT_GAME_STATE_LIMIT                   = ConvertGameEvent(3)
		private gameevent EVENT_GAME_TIMER_EXPIRED = ConvertGameEvent(4);//constant gameevent EVENT_GAME_TIMER_EXPIRED                 = ConvertGameEvent(4)
		private gameevent EVENT_GAME_ENTER_REGION = ConvertGameEvent(5);//constant gameevent EVENT_GAME_ENTER_REGION                  = ConvertGameEvent(5)
		private gameevent EVENT_GAME_LEAVE_REGION = ConvertGameEvent(6);//constant gameevent EVENT_GAME_LEAVE_REGION                  = ConvertGameEvent(6)
		private gameevent EVENT_GAME_TRACKABLE_HIT = ConvertGameEvent(7);//constant gameevent EVENT_GAME_TRACKABLE_HIT                 = ConvertGameEvent(7)
		private gameevent EVENT_GAME_TRACKABLE_TRACK = ConvertGameEvent(8);//constant gameevent EVENT_GAME_TRACKABLE_TRACK               = ConvertGameEvent(8)
		private gameevent EVENT_GAME_SHOW_SKILL = ConvertGameEvent(9);//constant gameevent EVENT_GAME_SHOW_SKILL                    = ConvertGameEvent(9)
		private gameevent EVENT_GAME_BUILD_SUBMENU = ConvertGameEvent(10);//constant gameevent EVENT_GAME_BUILD_SUBMENU                 = ConvertGameEvent(10)
		//
		//
		//
		private playerevent EVENT_PLAYER_STATE_LIMIT = ConvertPlayerEvent(11);//constant playerevent EVENT_PLAYER_STATE_LIMIT               = ConvertPlayerEvent(11)
		private playerevent EVENT_PLAYER_ALLIANCE_CHANGED = ConvertPlayerEvent(12);//constant playerevent EVENT_PLAYER_ALLIANCE_CHANGED          = ConvertPlayerEvent(12)
		private playerevent EVENT_PLAYER_DEFEAT = ConvertPlayerEvent(13);//constant playerevent EVENT_PLAYER_DEFEAT                    = ConvertPlayerEvent(13)
		private playerevent EVENT_PLAYER_VICTORY = ConvertPlayerEvent(14);//constant playerevent EVENT_PLAYER_VICTORY                   = ConvertPlayerEvent(14)
		private playerevent EVENT_PLAYER_LEAVE = ConvertPlayerEvent(15);//constant playerevent EVENT_PLAYER_LEAVE                     = ConvertPlayerEvent(15)
		private playerevent EVENT_PLAYER_CHAT = ConvertPlayerEvent(16);//constant playerevent EVENT_PLAYER_CHAT                      = ConvertPlayerEvent(16)
		private playerevent EVENT_PLAYER_END_CINEMATIC = ConvertPlayerEvent(17);//constant playerevent EVENT_PLAYER_END_CINEMATIC             = ConvertPlayerEvent(17)
		//
		//
		//
		private playerunitevent EVENT_PLAYER_UNIT_ATTACKED = ConvertPlayerUnitEvent(18);//constant playerunitevent EVENT_PLAYER_UNIT_ATTACKED                 = ConvertPlayerUnitEvent(18)
		private playerunitevent EVENT_PLAYER_UNIT_RESCUED = ConvertPlayerUnitEvent(19);//constant playerunitevent EVENT_PLAYER_UNIT_RESCUED                  = ConvertPlayerUnitEvent(19)
		private playerunitevent EVENT_PLAYER_UNIT_DEATH = ConvertPlayerUnitEvent(20);//constant playerunitevent EVENT_PLAYER_UNIT_DEATH                    = ConvertPlayerUnitEvent(20)
		private playerunitevent EVENT_PLAYER_UNIT_DECAY = ConvertPlayerUnitEvent(21);//constant playerunitevent EVENT_PLAYER_UNIT_DECAY                    = ConvertPlayerUnitEvent(21)
		private playerunitevent EVENT_PLAYER_UNIT_DETECTED = ConvertPlayerUnitEvent(22);//constant playerunitevent EVENT_PLAYER_UNIT_DETECTED                 = ConvertPlayerUnitEvent(22)
		private playerunitevent EVENT_PLAYER_UNIT_HIDDEN = ConvertPlayerUnitEvent(23);//constant playerunitevent EVENT_PLAYER_UNIT_HIDDEN                   = ConvertPlayerUnitEvent(23)
		private playerunitevent EVENT_PLAYER_UNIT_SELECTED = ConvertPlayerUnitEvent(24);//constant playerunitevent EVENT_PLAYER_UNIT_SELECTED                 = ConvertPlayerUnitEvent(24)
		private playerunitevent EVENT_PLAYER_UNIT_DESELECTED = ConvertPlayerUnitEvent(25);//constant playerunitevent EVENT_PLAYER_UNIT_DESELECTED               = ConvertPlayerUnitEvent(25)
		private playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_START = ConvertPlayerUnitEvent(26);//constant playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_START          = ConvertPlayerUnitEvent(26)
		private playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL = ConvertPlayerUnitEvent(27);//constant playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL         = ConvertPlayerUnitEvent(27)
		private playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_FINISH = ConvertPlayerUnitEvent(28);//constant playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_FINISH         = ConvertPlayerUnitEvent(28)
		private playerunitevent EVENT_PLAYER_UNIT_UPGRADE_START = ConvertPlayerUnitEvent(29);//constant playerunitevent EVENT_PLAYER_UNIT_UPGRADE_START            = ConvertPlayerUnitEvent(29)
		private playerunitevent EVENT_PLAYER_UNIT_UPGRADE_CANCEL = ConvertPlayerUnitEvent(30);//constant playerunitevent EVENT_PLAYER_UNIT_UPGRADE_CANCEL           = ConvertPlayerUnitEvent(30)
		private playerunitevent EVENT_PLAYER_UNIT_UPGRADE_FINISH = ConvertPlayerUnitEvent(31);//constant playerunitevent EVENT_PLAYER_UNIT_UPGRADE_FINISH           = ConvertPlayerUnitEvent(31)
		private playerunitevent EVENT_PLAYER_UNIT_TRAIN_START = ConvertPlayerUnitEvent(32);//constant playerunitevent EVENT_PLAYER_UNIT_TRAIN_START              = ConvertPlayerUnitEvent(32)
		private playerunitevent EVENT_PLAYER_UNIT_TRAIN_CANCEL = ConvertPlayerUnitEvent(33);//constant playerunitevent EVENT_PLAYER_UNIT_TRAIN_CANCEL             = ConvertPlayerUnitEvent(33)
		private playerunitevent EVENT_PLAYER_UNIT_TRAIN_FINISH = ConvertPlayerUnitEvent(34);//constant playerunitevent EVENT_PLAYER_UNIT_TRAIN_FINISH             = ConvertPlayerUnitEvent(34)
		private playerunitevent EVENT_PLAYER_UNIT_RESEARCH_START = ConvertPlayerUnitEvent(35);//constant playerunitevent EVENT_PLAYER_UNIT_RESEARCH_START           = ConvertPlayerUnitEvent(35)
		private playerunitevent EVENT_PLAYER_UNIT_RESEARCH_CANCEL = ConvertPlayerUnitEvent(36);//constant playerunitevent EVENT_PLAYER_UNIT_RESEARCH_CANCEL          = ConvertPlayerUnitEvent(36)
		private playerunitevent EVENT_PLAYER_UNIT_RESEARCH_FINISH = ConvertPlayerUnitEvent(37);//constant playerunitevent EVENT_PLAYER_UNIT_RESEARCH_FINISH          = ConvertPlayerUnitEvent(37)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_ORDER = ConvertPlayerUnitEvent(38);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_ORDER             = ConvertPlayerUnitEvent(38)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER = ConvertPlayerUnitEvent(39);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER       = ConvertPlayerUnitEvent(39)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER = ConvertPlayerUnitEvent(40);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER      = ConvertPlayerUnitEvent(40)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER = ConvertPlayerUnitEvent(40);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER        = ConvertPlayerUnitEvent(40)
		private playerunitevent EVENT_PLAYER_HERO_LEVEL = ConvertPlayerUnitEvent(41);//constant playerunitevent EVENT_PLAYER_HERO_LEVEL                    = ConvertPlayerUnitEvent(41)
		private playerunitevent EVENT_PLAYER_HERO_SKILL = ConvertPlayerUnitEvent(42);//constant playerunitevent EVENT_PLAYER_HERO_SKILL                    = ConvertPlayerUnitEvent(42)
		private playerunitevent EVENT_PLAYER_HERO_REVIVABLE = ConvertPlayerUnitEvent(43);//constant playerunitevent EVENT_PLAYER_HERO_REVIVABLE                = ConvertPlayerUnitEvent(43)
		private playerunitevent EVENT_PLAYER_HERO_REVIVE_START = ConvertPlayerUnitEvent(44);//constant playerunitevent EVENT_PLAYER_HERO_REVIVE_START             = ConvertPlayerUnitEvent(44)
		private playerunitevent EVENT_PLAYER_HERO_REVIVE_CANCEL = ConvertPlayerUnitEvent(45);//constant playerunitevent EVENT_PLAYER_HERO_REVIVE_CANCEL            = ConvertPlayerUnitEvent(45)
		private playerunitevent EVENT_PLAYER_HERO_REVIVE_FINISH = ConvertPlayerUnitEvent(46);//constant playerunitevent EVENT_PLAYER_HERO_REVIVE_FINISH            = ConvertPlayerUnitEvent(46)
		private playerunitevent EVENT_PLAYER_UNIT_SUMMON = ConvertPlayerUnitEvent(47);//constant playerunitevent EVENT_PLAYER_UNIT_SUMMON                   = ConvertPlayerUnitEvent(47)
		private playerunitevent EVENT_PLAYER_UNIT_DROP_ITEM = ConvertPlayerUnitEvent(48);//constant playerunitevent EVENT_PLAYER_UNIT_DROP_ITEM                = ConvertPlayerUnitEvent(48)
		private playerunitevent EVENT_PLAYER_UNIT_PICKUP_ITEM = ConvertPlayerUnitEvent(49);//constant playerunitevent EVENT_PLAYER_UNIT_PICKUP_ITEM              = ConvertPlayerUnitEvent(49)
		private playerunitevent EVENT_PLAYER_UNIT_USE_ITEM = ConvertPlayerUnitEvent(50);//constant playerunitevent EVENT_PLAYER_UNIT_USE_ITEM                 = ConvertPlayerUnitEvent(50)
		private playerunitevent EVENT_PLAYER_UNIT_LOADED = ConvertPlayerUnitEvent(51);//constant playerunitevent EVENT_PLAYER_UNIT_LOADED                   = ConvertPlayerUnitEvent(51)
		//
		//
		//
		private unitevent EVENT_UNIT_DAMAGED = ConvertUnitEvent(52);//constant unitevent EVENT_UNIT_DAMAGED                               = ConvertUnitEvent(52)
		private unitevent EVENT_UNIT_DEATH = ConvertUnitEvent(53);//constant unitevent EVENT_UNIT_DEATH                                 = ConvertUnitEvent(53)
		private unitevent EVENT_UNIT_DECAY = ConvertUnitEvent(54);//constant unitevent EVENT_UNIT_DECAY                                 = ConvertUnitEvent(54)
		private unitevent EVENT_UNIT_DETECTED = ConvertUnitEvent(55);//constant unitevent EVENT_UNIT_DETECTED                              = ConvertUnitEvent(55)
		private unitevent EVENT_UNIT_HIDDEN = ConvertUnitEvent(56);//constant unitevent EVENT_UNIT_HIDDEN                                = ConvertUnitEvent(56)
		private unitevent EVENT_UNIT_SELECTED = ConvertUnitEvent(57);//constant unitevent EVENT_UNIT_SELECTED                              = ConvertUnitEvent(57)
		private unitevent EVENT_UNIT_DESELECTED = ConvertUnitEvent(58);//constant unitevent EVENT_UNIT_DESELECTED                            = ConvertUnitEvent(58)
		private unitevent EVENT_UNIT_STATE_LIMIT = ConvertUnitEvent(59);//constant unitevent EVENT_UNIT_STATE_LIMIT                           = ConvertUnitEvent(59)
		//
		//
		private unitevent EVENT_UNIT_ACQUIRED_TARGET = ConvertUnitEvent(60);//constant unitevent EVENT_UNIT_ACQUIRED_TARGET                       = ConvertUnitEvent(60)
		private unitevent EVENT_UNIT_TARGET_IN_RANGE = ConvertUnitEvent(61);//constant unitevent EVENT_UNIT_TARGET_IN_RANGE                       = ConvertUnitEvent(61)
		private unitevent EVENT_UNIT_ATTACKED = ConvertUnitEvent(62);//constant unitevent EVENT_UNIT_ATTACKED                              = ConvertUnitEvent(62)
		private unitevent EVENT_UNIT_RESCUED = ConvertUnitEvent(63);//constant unitevent EVENT_UNIT_RESCUED                               = ConvertUnitEvent(63)
		private unitevent EVENT_UNIT_CONSTRUCT_CANCEL = ConvertUnitEvent(64);//constant unitevent EVENT_UNIT_CONSTRUCT_CANCEL                      = ConvertUnitEvent(64)
		private unitevent EVENT_UNIT_CONSTRUCT_FINISH = ConvertUnitEvent(65);//constant unitevent EVENT_UNIT_CONSTRUCT_FINISH                      = ConvertUnitEvent(65)
		private unitevent EVENT_UNIT_UPGRADE_START = ConvertUnitEvent(66);//constant unitevent EVENT_UNIT_UPGRADE_START                         = ConvertUnitEvent(66)
		private unitevent EVENT_UNIT_UPGRADE_CANCEL = ConvertUnitEvent(67);//constant unitevent EVENT_UNIT_UPGRADE_CANCEL                        = ConvertUnitEvent(67)
		private unitevent EVENT_UNIT_UPGRADE_FINISH = ConvertUnitEvent(68);//constant unitevent EVENT_UNIT_UPGRADE_FINISH                        = ConvertUnitEvent(68)
		//
		//
		//
		private unitevent EVENT_UNIT_TRAIN_START = ConvertUnitEvent(69);//constant unitevent EVENT_UNIT_TRAIN_START                           = ConvertUnitEvent(69)
		private unitevent EVENT_UNIT_TRAIN_CANCEL = ConvertUnitEvent(70);//constant unitevent EVENT_UNIT_TRAIN_CANCEL                          = ConvertUnitEvent(70)
		private unitevent EVENT_UNIT_TRAIN_FINISH = ConvertUnitEvent(71);//constant unitevent EVENT_UNIT_TRAIN_FINISH                          = ConvertUnitEvent(71)
		private unitevent EVENT_UNIT_RESEARCH_START = ConvertUnitEvent(72);//constant unitevent EVENT_UNIT_RESEARCH_START                        = ConvertUnitEvent(72)
		private unitevent EVENT_UNIT_RESEARCH_CANCEL = ConvertUnitEvent(73);//constant unitevent EVENT_UNIT_RESEARCH_CANCEL                       = ConvertUnitEvent(73)
		private unitevent EVENT_UNIT_RESEARCH_FINISH = ConvertUnitEvent(74);//constant unitevent EVENT_UNIT_RESEARCH_FINISH                       = ConvertUnitEvent(74)
		private unitevent EVENT_UNIT_ISSUED_ORDER = ConvertUnitEvent(75);//constant unitevent EVENT_UNIT_ISSUED_ORDER                          = ConvertUnitEvent(75)
		private unitevent EVENT_UNIT_ISSUED_POINT_ORDER = ConvertUnitEvent(76);//constant unitevent EVENT_UNIT_ISSUED_POINT_ORDER                    = ConvertUnitEvent(76)
		private unitevent EVENT_UNIT_ISSUED_TARGET_ORDER = ConvertUnitEvent(77);//constant unitevent EVENT_UNIT_ISSUED_TARGET_ORDER                   = ConvertUnitEvent(77)
		private unitevent EVENT_UNIT_HERO_LEVEL = ConvertUnitEvent(78);//constant unitevent EVENT_UNIT_HERO_LEVEL                            = ConvertUnitEvent(78)
		private unitevent EVENT_UNIT_HERO_SKILL = ConvertUnitEvent(79);//constant unitevent EVENT_UNIT_HERO_SKILL                            = ConvertUnitEvent(79)
		private unitevent EVENT_UNIT_HERO_REVIVABLE = ConvertUnitEvent(80);//constant unitevent EVENT_UNIT_HERO_REVIVABLE                        = ConvertUnitEvent(80)
		private unitevent EVENT_UNIT_HERO_REVIVE_START = ConvertUnitEvent(81);//constant unitevent EVENT_UNIT_HERO_REVIVE_START                     = ConvertUnitEvent(81)
		private unitevent EVENT_UNIT_HERO_REVIVE_CANCEL = ConvertUnitEvent(82);//constant unitevent EVENT_UNIT_HERO_REVIVE_CANCEL                    = ConvertUnitEvent(82)
		private unitevent EVENT_UNIT_HERO_REVIVE_FINISH = ConvertUnitEvent(83);//constant unitevent EVENT_UNIT_HERO_REVIVE_FINISH                    = ConvertUnitEvent(83)
		private unitevent EVENT_UNIT_SUMMON = ConvertUnitEvent(84);//constant unitevent EVENT_UNIT_SUMMON                                = ConvertUnitEvent(84)
		private unitevent EVENT_UNIT_DROP_ITEM = ConvertUnitEvent(85);//constant unitevent EVENT_UNIT_DROP_ITEM                             = ConvertUnitEvent(85)
		private unitevent EVENT_UNIT_PICKUP_ITEM = ConvertUnitEvent(86);//constant unitevent EVENT_UNIT_PICKUP_ITEM                           = ConvertUnitEvent(86)
		private unitevent EVENT_UNIT_USE_ITEM = ConvertUnitEvent(87);//constant unitevent EVENT_UNIT_USE_ITEM                              = ConvertUnitEvent(87)
		private unitevent EVENT_UNIT_LOADED = ConvertUnitEvent(88);//constant unitevent EVENT_UNIT_LOADED                                = ConvertUnitEvent(88)
		private widgetevent EVENT_WIDGET_DEATH = ConvertWidgetEvent(89);//constant widgetevent EVENT_WIDGET_DEATH                             = ConvertWidgetEvent(89)
		private dialogevent EVENT_DIALOG_BUTTON_CLICK = ConvertDialogEvent(90);//constant dialogevent EVENT_DIALOG_BUTTON_CLICK                      = ConvertDialogEvent(90)
		private dialogevent EVENT_DIALOG_CLICK = ConvertDialogEvent(91);//constant dialogevent EVENT_DIALOG_CLICK                             = ConvertDialogEvent(91)
		//
		//
		//
		//
		//
		//
		//
		private gameevent EVENT_GAME_LOADED = ConvertGameEvent(256);//constant gameevent          EVENT_GAME_LOADED                       = ConvertGameEvent(256)
		private gameevent EVENT_GAME_TOURNAMENT_FINISH_SOON = ConvertGameEvent(257);//constant gameevent          EVENT_GAME_TOURNAMENT_FINISH_SOON       = ConvertGameEvent(257)
		private gameevent EVENT_GAME_TOURNAMENT_FINISH_NOW = ConvertGameEvent(258);//constant gameevent          EVENT_GAME_TOURNAMENT_FINISH_NOW        = ConvertGameEvent(258)
		private gameevent EVENT_GAME_SAVE = ConvertGameEvent(259);//constant gameevent          EVENT_GAME_SAVE                         = ConvertGameEvent(259)
		//
		//
		//
		private playerevent EVENT_PLAYER_ARROW_LEFT_DOWN = ConvertPlayerEvent(261);//constant playerevent        EVENT_PLAYER_ARROW_LEFT_DOWN            = ConvertPlayerEvent(261)
		private playerevent EVENT_PLAYER_ARROW_LEFT_UP = ConvertPlayerEvent(262);//constant playerevent        EVENT_PLAYER_ARROW_LEFT_UP              = ConvertPlayerEvent(262)
		private playerevent EVENT_PLAYER_ARROW_RIGHT_DOWN = ConvertPlayerEvent(263);//constant playerevent        EVENT_PLAYER_ARROW_RIGHT_DOWN           = ConvertPlayerEvent(263)
		private playerevent EVENT_PLAYER_ARROW_RIGHT_UP = ConvertPlayerEvent(264);//constant playerevent        EVENT_PLAYER_ARROW_RIGHT_UP             = ConvertPlayerEvent(264)
		private playerevent EVENT_PLAYER_ARROW_DOWN_DOWN = ConvertPlayerEvent(265);//constant playerevent        EVENT_PLAYER_ARROW_DOWN_DOWN            = ConvertPlayerEvent(265)
		private playerevent EVENT_PLAYER_ARROW_DOWN_UP = ConvertPlayerEvent(266);//constant playerevent        EVENT_PLAYER_ARROW_DOWN_UP              = ConvertPlayerEvent(266)
		private playerevent EVENT_PLAYER_ARROW_UP_DOWN = ConvertPlayerEvent(267);//constant playerevent        EVENT_PLAYER_ARROW_UP_DOWN              = ConvertPlayerEvent(267)
		private playerevent EVENT_PLAYER_ARROW_UP_UP = ConvertPlayerEvent(268);//constant playerevent        EVENT_PLAYER_ARROW_UP_UP                = ConvertPlayerEvent(268)
		//
		//
		//
		private playerunitevent EVENT_PLAYER_UNIT_SELL = ConvertPlayerUnitEvent(269);//constant playerunitevent    EVENT_PLAYER_UNIT_SELL                  = ConvertPlayerUnitEvent(269)
		private playerunitevent EVENT_PLAYER_UNIT_CHANGE_OWNER = ConvertPlayerUnitEvent(270);//constant playerunitevent    EVENT_PLAYER_UNIT_CHANGE_OWNER          = ConvertPlayerUnitEvent(270)
		private playerunitevent EVENT_PLAYER_UNIT_SELL_ITEM = ConvertPlayerUnitEvent(271);//constant playerunitevent    EVENT_PLAYER_UNIT_SELL_ITEM             = ConvertPlayerUnitEvent(271)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_CHANNEL = ConvertPlayerUnitEvent(272);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_CHANNEL         = ConvertPlayerUnitEvent(272)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_CAST = ConvertPlayerUnitEvent(273);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_CAST            = ConvertPlayerUnitEvent(273)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_EFFECT = ConvertPlayerUnitEvent(274);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_EFFECT          = ConvertPlayerUnitEvent(274)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_FINISH = ConvertPlayerUnitEvent(275);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_FINISH          = ConvertPlayerUnitEvent(275)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_ENDCAST = ConvertPlayerUnitEvent(276);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_ENDCAST         = ConvertPlayerUnitEvent(276)
		private playerunitevent EVENT_PLAYER_UNIT_PAWN_ITEM = ConvertPlayerUnitEvent(277);//constant playerunitevent    EVENT_PLAYER_UNIT_PAWN_ITEM             = ConvertPlayerUnitEvent(277)
		//
		//
		//
		private unitevent EVENT_UNIT_SELL = ConvertUnitEvent(286);//constant unitevent          EVENT_UNIT_SELL                         = ConvertUnitEvent(286)
		private unitevent EVENT_UNIT_CHANGE_OWNER = ConvertUnitEvent(287);//constant unitevent          EVENT_UNIT_CHANGE_OWNER                 = ConvertUnitEvent(287)
		private unitevent EVENT_UNIT_SELL_ITEM = ConvertUnitEvent(288);//constant unitevent          EVENT_UNIT_SELL_ITEM                    = ConvertUnitEvent(288)
		private unitevent EVENT_UNIT_SPELL_CHANNEL = ConvertUnitEvent(289);//constant unitevent          EVENT_UNIT_SPELL_CHANNEL                = ConvertUnitEvent(289)
		private unitevent EVENT_UNIT_SPELL_CAST = ConvertUnitEvent(290);//constant unitevent          EVENT_UNIT_SPELL_CAST                   = ConvertUnitEvent(290)
		private unitevent EVENT_UNIT_SPELL_EFFECT = ConvertUnitEvent(291);//constant unitevent          EVENT_UNIT_SPELL_EFFECT                 = ConvertUnitEvent(291)
		private unitevent EVENT_UNIT_SPELL_FINISH = ConvertUnitEvent(292);//constant unitevent          EVENT_UNIT_SPELL_FINISH                 = ConvertUnitEvent(292)
		private unitevent EVENT_UNIT_SPELL_ENDCAST = ConvertUnitEvent(293);//constant unitevent          EVENT_UNIT_SPELL_ENDCAST                = ConvertUnitEvent(293)
		private unitevent EVENT_UNIT_PAWN_ITEM = ConvertUnitEvent(294);//constant unitevent          EVENT_UNIT_PAWN_ITEM                    = ConvertUnitEvent(294)
		//
		//
		//
		//
		//
		private limitop LESS_THAN = ConvertLimitOp(0);//constant limitop LESS_THAN                              = ConvertLimitOp(0)
		private limitop LESS_THAN_OR_EQUAL = ConvertLimitOp(1);//constant limitop LESS_THAN_OR_EQUAL                     = ConvertLimitOp(1)
		private limitop EQUAL = ConvertLimitOp(2);//constant limitop EQUAL                                  = ConvertLimitOp(2)
		private limitop GREATER_THAN_OR_EQUAL = ConvertLimitOp(3);//constant limitop GREATER_THAN_OR_EQUAL                  = ConvertLimitOp(3)
		private limitop GREATER_THAN = ConvertLimitOp(4);//constant limitop GREATER_THAN                           = ConvertLimitOp(4)
		private limitop NOT_EQUAL = ConvertLimitOp(5);//constant limitop NOT_EQUAL                              = ConvertLimitOp(5)
		//
		//
		//
		private unittype UNIT_TYPE_HERO = ConvertUnitType(0);//constant unittype UNIT_TYPE_HERO                        = ConvertUnitType(0)
		private unittype UNIT_TYPE_DEAD = ConvertUnitType(1);//constant unittype UNIT_TYPE_DEAD                        = ConvertUnitType(1)
		private unittype UNIT_TYPE_STRUCTURE = ConvertUnitType(2);//constant unittype UNIT_TYPE_STRUCTURE                   = ConvertUnitType(2)
		private unittype UNIT_TYPE_FLYING = ConvertUnitType(3);//constant unittype UNIT_TYPE_FLYING                      = ConvertUnitType(3)
		private unittype UNIT_TYPE_GROUND = ConvertUnitType(4);//constant unittype UNIT_TYPE_GROUND                      = ConvertUnitType(4)
		private unittype UNIT_TYPE_ATTACKS_FLYING = ConvertUnitType(5);//constant unittype UNIT_TYPE_ATTACKS_FLYING              = ConvertUnitType(5)
		private unittype UNIT_TYPE_ATTACKS_GROUND = ConvertUnitType(6);//constant unittype UNIT_TYPE_ATTACKS_GROUND              = ConvertUnitType(6)
		private unittype UNIT_TYPE_MELEE_ATTACKER = ConvertUnitType(7);//constant unittype UNIT_TYPE_MELEE_ATTACKER              = ConvertUnitType(7)
		private unittype UNIT_TYPE_RANGED_ATTACKER = ConvertUnitType(8);//constant unittype UNIT_TYPE_RANGED_ATTACKER             = ConvertUnitType(8)
		private unittype UNIT_TYPE_GIANT = ConvertUnitType(9);//constant unittype UNIT_TYPE_GIANT                       = ConvertUnitType(9)
		private unittype UNIT_TYPE_SUMMONED = ConvertUnitType(10);//constant unittype UNIT_TYPE_SUMMONED                    = ConvertUnitType(10)
		private unittype UNIT_TYPE_STUNNED = ConvertUnitType(11);//constant unittype UNIT_TYPE_STUNNED                     = ConvertUnitType(11)
		private unittype UNIT_TYPE_PLAGUED = ConvertUnitType(12);//constant unittype UNIT_TYPE_PLAGUED                     = ConvertUnitType(12)
		private unittype UNIT_TYPE_SNARED = ConvertUnitType(13);//constant unittype UNIT_TYPE_SNARED                      = ConvertUnitType(13)
		private unittype UNIT_TYPE_UNDEAD = ConvertUnitType(14);//constant unittype UNIT_TYPE_UNDEAD                      = ConvertUnitType(14)
		private unittype UNIT_TYPE_MECHANICAL = ConvertUnitType(15);//constant unittype UNIT_TYPE_MECHANICAL                  = ConvertUnitType(15)
		private unittype UNIT_TYPE_PEON = ConvertUnitType(16);//constant unittype UNIT_TYPE_PEON                        = ConvertUnitType(16)
		private unittype UNIT_TYPE_SAPPER = ConvertUnitType(17);//constant unittype UNIT_TYPE_SAPPER                      = ConvertUnitType(17)
		private unittype UNIT_TYPE_TOWNHALL = ConvertUnitType(18);//constant unittype UNIT_TYPE_TOWNHALL                    = ConvertUnitType(18)
		private unittype UNIT_TYPE_ANCIENT = ConvertUnitType(19);//constant unittype UNIT_TYPE_ANCIENT                     = ConvertUnitType(19)
		private unittype UNIT_TYPE_TAUREN = ConvertUnitType(20);//constant unittype UNIT_TYPE_TAUREN                      = ConvertUnitType(20)
		private unittype UNIT_TYPE_POISONED = ConvertUnitType(21);//constant unittype UNIT_TYPE_POISONED                    = ConvertUnitType(21)
		private unittype UNIT_TYPE_POLYMORPHED = ConvertUnitType(22);//constant unittype UNIT_TYPE_POLYMORPHED                 = ConvertUnitType(22)
		private unittype UNIT_TYPE_SLEEPING = ConvertUnitType(23);//constant unittype UNIT_TYPE_SLEEPING                    = ConvertUnitType(23)
		private unittype UNIT_TYPE_RESISTANT = ConvertUnitType(24);//constant unittype UNIT_TYPE_RESISTANT                   = ConvertUnitType(24)
		private unittype UNIT_TYPE_ETHEREAL = ConvertUnitType(25);//constant unittype UNIT_TYPE_ETHEREAL                    = ConvertUnitType(25)
		private unittype UNIT_TYPE_MAGIC_IMMUNE = ConvertUnitType(26);//constant unittype UNIT_TYPE_MAGIC_IMMUNE                = ConvertUnitType(26)
		//
		//
		//
		private itemtype ITEM_TYPE_PERMANENT = ConvertItemType(0);//constant itemtype ITEM_TYPE_PERMANENT                   = ConvertItemType(0)
		private itemtype ITEM_TYPE_CHARGED = ConvertItemType(1);//constant itemtype ITEM_TYPE_CHARGED                     = ConvertItemType(1)
		private itemtype ITEM_TYPE_POWERUP = ConvertItemType(2);//constant itemtype ITEM_TYPE_POWERUP                     = ConvertItemType(2)
		private itemtype ITEM_TYPE_ARTIFACT = ConvertItemType(3);//constant itemtype ITEM_TYPE_ARTIFACT                    = ConvertItemType(3)
		private itemtype ITEM_TYPE_PURCHASABLE = ConvertItemType(4);//constant itemtype ITEM_TYPE_PURCHASABLE                 = ConvertItemType(4)
		private itemtype ITEM_TYPE_CAMPAIGN = ConvertItemType(5);//constant itemtype ITEM_TYPE_CAMPAIGN                    = ConvertItemType(5)
		private itemtype ITEM_TYPE_MISCELLANEOUS = ConvertItemType(6);//constant itemtype ITEM_TYPE_MISCELLANEOUS               = ConvertItemType(6)
		private itemtype ITEM_TYPE_UNKNOWN = ConvertItemType(7);//constant itemtype ITEM_TYPE_UNKNOWN                     = ConvertItemType(7)
		private itemtype ITEM_TYPE_ANY = ConvertItemType(8);//constant itemtype ITEM_TYPE_ANY                         = ConvertItemType(8)
		//
		private itemtype ITEM_TYPE_TOME = ConvertItemType(2);//constant itemtype ITEM_TYPE_TOME                        = ConvertItemType(2)
		//
		//
		//
		private camerafield CAMERA_FIELD_TARGET_DISTANCE = ConvertCameraField(0);//constant camerafield CAMERA_FIELD_TARGET_DISTANCE       = ConvertCameraField(0)
		private camerafield CAMERA_FIELD_FARZ = ConvertCameraField(1);//constant camerafield CAMERA_FIELD_FARZ                  = ConvertCameraField(1)
		private camerafield CAMERA_FIELD_ANGLE_OF_ATTACK = ConvertCameraField(2);//constant camerafield CAMERA_FIELD_ANGLE_OF_ATTACK       = ConvertCameraField(2)
		private camerafield CAMERA_FIELD_FIELD_OF_VIEW = ConvertCameraField(3);//constant camerafield CAMERA_FIELD_FIELD_OF_VIEW         = ConvertCameraField(3)
		private camerafield CAMERA_FIELD_ROLL = ConvertCameraField(4);//constant camerafield CAMERA_FIELD_ROLL                  = ConvertCameraField(4)
		private camerafield CAMERA_FIELD_ROTATION = ConvertCameraField(5);//constant camerafield CAMERA_FIELD_ROTATION              = ConvertCameraField(5)
		private camerafield CAMERA_FIELD_ZOFFSET = ConvertCameraField(6);//constant camerafield CAMERA_FIELD_ZOFFSET               = ConvertCameraField(6)
		private blendmode BLEND_MODE_NONE = ConvertBlendMode(0);//constant blendmode   BLEND_MODE_NONE                    = ConvertBlendMode(0)
		private blendmode BLEND_MODE_DONT_CARE = ConvertBlendMode(0);//constant blendmode   BLEND_MODE_DONT_CARE               = ConvertBlendMode(0)
		private blendmode BLEND_MODE_KEYALPHA = ConvertBlendMode(1);//constant blendmode   BLEND_MODE_KEYALPHA                = ConvertBlendMode(1)
		private blendmode BLEND_MODE_BLEND = ConvertBlendMode(2);//constant blendmode   BLEND_MODE_BLEND                   = ConvertBlendMode(2)
		private blendmode BLEND_MODE_ADDITIVE = ConvertBlendMode(3);//constant blendmode   BLEND_MODE_ADDITIVE                = ConvertBlendMode(3)
		private blendmode BLEND_MODE_MODULATE = ConvertBlendMode(4);//constant blendmode   BLEND_MODE_MODULATE                = ConvertBlendMode(4)
		private blendmode BLEND_MODE_MODULATE_2X = ConvertBlendMode(5);//constant blendmode   BLEND_MODE_MODULATE_2X             = ConvertBlendMode(5)
		private raritycontrol RARITY_FREQUENT = ConvertRarityControl(0);//constant raritycontrol  RARITY_FREQUENT                 = ConvertRarityControl(0)
		private raritycontrol RARITY_RARE = ConvertRarityControl(1);//constant raritycontrol  RARITY_RARE                     = ConvertRarityControl(1)
		private texmapflags TEXMAP_FLAG_NONE = ConvertTexMapFlags(0);//constant texmapflags    TEXMAP_FLAG_NONE                = ConvertTexMapFlags(0)
		private texmapflags TEXMAP_FLAG_WRAP_U = ConvertTexMapFlags(1);//constant texmapflags    TEXMAP_FLAG_WRAP_U              = ConvertTexMapFlags(1)
		private texmapflags TEXMAP_FLAG_WRAP_V = ConvertTexMapFlags(2);//constant texmapflags    TEXMAP_FLAG_WRAP_V              = ConvertTexMapFlags(2)
		private texmapflags TEXMAP_FLAG_WRAP_UV = ConvertTexMapFlags(3);//constant texmapflags    TEXMAP_FLAG_WRAP_UV             = ConvertTexMapFlags(3)
		private fogstate FOG_OF_WAR_MASKED = ConvertFogState(1);//constant fogstate       FOG_OF_WAR_MASKED               = ConvertFogState(1)
		private fogstate FOG_OF_WAR_FOGGED = ConvertFogState(2);//constant fogstate       FOG_OF_WAR_FOGGED               = ConvertFogState(2)
		private fogstate FOG_OF_WAR_VISIBLE = ConvertFogState(4);//constant fogstate       FOG_OF_WAR_VISIBLE              = ConvertFogState(4)
		//
		//
		//
		private int CAMERA_MARGIN_LEFT = 0;//constant integer        CAMERA_MARGIN_LEFT              = 0
		private int CAMERA_MARGIN_RIGHT = 1;//constant integer        CAMERA_MARGIN_RIGHT             = 1
		private int CAMERA_MARGIN_TOP = 2;//constant integer        CAMERA_MARGIN_TOP               = 2
		private int CAMERA_MARGIN_BOTTOM = 3;//constant integer        CAMERA_MARGIN_BOTTOM            = 3
		//
		//
		//
		private effecttype EFFECT_TYPE_EFFECT = ConvertEffectType(0);//constant effecttype     EFFECT_TYPE_EFFECT              = ConvertEffectType(0)
		private effecttype EFFECT_TYPE_TARGET = ConvertEffectType(1);//constant effecttype     EFFECT_TYPE_TARGET              = ConvertEffectType(1)
		private effecttype EFFECT_TYPE_CASTER = ConvertEffectType(2);//constant effecttype     EFFECT_TYPE_CASTER              = ConvertEffectType(2)
		private effecttype EFFECT_TYPE_SPECIAL = ConvertEffectType(3);//constant effecttype     EFFECT_TYPE_SPECIAL             = ConvertEffectType(3)
		private effecttype EFFECT_TYPE_AREA_EFFECT = ConvertEffectType(4);//constant effecttype     EFFECT_TYPE_AREA_EFFECT         = ConvertEffectType(4)
		private effecttype EFFECT_TYPE_MISSILE = ConvertEffectType(5);//constant effecttype     EFFECT_TYPE_MISSILE             = ConvertEffectType(5)
		private effecttype EFFECT_TYPE_LIGHTNING = ConvertEffectType(6);//constant effecttype     EFFECT_TYPE_LIGHTNING           = ConvertEffectType(6)
		private soundtype SOUND_TYPE_EFFECT = ConvertSoundType(0);//constant soundtype      SOUND_TYPE_EFFECT               = ConvertSoundType(0)
		private soundtype SOUND_TYPE_EFFECT_LOOPED = ConvertSoundType(1);//constant soundtype      SOUND_TYPE_EFFECT_LOOPED        = ConvertSoundType(1)
		//
		//
		public static float Deg2Rad(float degrees);//native Deg2Rad  takes real degrees returns real
		public static float Rad2Deg(float radians);//native Rad2Deg  takes real radians returns real
		public static float Sin(float radians);//native Sin      takes real radians returns real
		public static float Cos(float radians);//native Cos      takes real radians returns real
		public static float Tan(float radians);//native Tan      takes real radians returns real
		//
		public static float Asin(float y);//native Asin     takes real y returns real
		public static float Acos(float x);//native Acos     takes real x returns real
		public static float Atan(float x);//native Atan     takes real x returns real
		//
		public static float Atan2(float y, float x);//native Atan2    takes real y, real x returns real
		//
		public static float SquareRoot(float x);//native SquareRoot takes real x returns real
		//
		//
		//
		//
		public static float Pow(float x, float power);//native Pow      takes real x, real power returns real
		//
		//
		public static float I2R(int i);//native I2R  takes integer i returns real
		public static int R2I(float r);//native R2I  takes real r returns integer
		public static string I2S(int i);//native I2S  takes integer i returns string
		public static string R2S(float r);//native R2S  takes real r returns string
		public static string R2SW(float r, int width, int precision);//native R2SW takes real r, integer width, integer precision returns string
		public static int S2I(string s);//native S2I  takes string s returns integer
		public static float S2R(string s);//native S2R  takes string s returns real
		public static int GetHandleId(handle h);//native GetHandleId takes handle h returns integer
		public static string SubString(string source, int start, int end);//native SubString takes string source, integer start, integer end returns string
		public static int StringLength(string s);//native StringLength takes string s returns integer
		public static string StringCase(string source, bool upper);//native StringCase takes string source, boolean upper returns string
		public static int StringHash(string s);//native StringHash takes string s returns integer
		public static string GetLocalizedString(string source);//native GetLocalizedString takes string source returns string
		public static int GetLocalizedHotkey(string source);//native GetLocalizedHotkey takes string source returns integer
		//
		//
		//
		//
		//
		//
		//
		//
		public static void SetMapName(string name);//native SetMapName           takes string name returns nothing
		public static void SetMapDescription(string description);//native SetMapDescription    takes string description returns nothing
		public static void SetTeams(int teamcount);//native SetTeams             takes integer teamcount returns nothing
		public static void SetPlayers(int playercount);//native SetPlayers           takes integer playercount returns nothing
		public static void DefineStartLocation(int whichStartLoc, float x, float y);//native DefineStartLocation      takes integer whichStartLoc, real x, real y returns nothing
		public static void DefineStartLocationLoc(int whichStartLoc, location whichLocation);//native DefineStartLocationLoc   takes integer whichStartLoc, location whichLocation returns nothing
		public static void SetStartLocPrioCount(int whichStartLoc, int prioSlotCount);//native SetStartLocPrioCount     takes integer whichStartLoc, integer prioSlotCount returns nothing
		public static void SetStartLocPrio(int whichStartLoc, int prioSlotIndex, int otherStartLocIndex, startlocprio priority);//native SetStartLocPrio          takes integer whichStartLoc, integer prioSlotIndex, integer otherStartLocIndex, startlocprio priority returns nothing
		public static int GetStartLocPrioSlot(int whichStartLoc, int prioSlotIndex);//native GetStartLocPrioSlot      takes integer whichStartLoc, integer prioSlotIndex returns integer
		public static startlocprio GetStartLocPrio(int whichStartLoc, int prioSlotIndex);//native GetStartLocPrio          takes integer whichStartLoc, integer prioSlotIndex returns startlocprio
		public static void SetGameTypeSupported(gametype whichGameType, bool value);//native SetGameTypeSupported takes gametype whichGameType, boolean value returns nothing
		public static void SetMapFlag(mapflag whichMapFlag, bool value);//native SetMapFlag           takes mapflag whichMapFlag, boolean value returns nothing
		public static void SetGamePlacement(placement whichPlacementType);//native SetGamePlacement     takes placement whichPlacementType returns nothing
		public static void SetGameSpeed(gamespeed whichspeed);//native SetGameSpeed         takes gamespeed whichspeed returns nothing
		public static void SetGameDifficulty(gamedifficulty whichdifficulty);//native SetGameDifficulty    takes gamedifficulty whichdifficulty returns nothing
		public static void SetResourceDensity(mapdensity whichdensity);//native SetResourceDensity   takes mapdensity whichdensity returns nothing
		public static void SetCreatureDensity(mapdensity whichdensity);//native SetCreatureDensity   takes mapdensity whichdensity returns nothing
		public static int GetTeams();//native GetTeams             takes nothing returns integer
		public static int GetPlayers();//native GetPlayers           takes nothing returns integer
		public static bool IsGameTypeSupported(gametype whichGameType);//native IsGameTypeSupported  takes gametype whichGameType returns boolean
		public static gametype GetGameTypeSelected();//native GetGameTypeSelected  takes nothing returns gametype
		public static bool IsMapFlagSet(mapflag whichMapFlag);//native IsMapFlagSet         takes mapflag whichMapFlag returns boolean
		public static placement GetGamePlacement();//constant native GetGamePlacement     takes nothing returns placement
		public static gamespeed GetGameSpeed();//constant native GetGameSpeed         takes nothing returns gamespeed
		public static gamedifficulty GetGameDifficulty();//constant native GetGameDifficulty    takes nothing returns gamedifficulty
		public static mapdensity GetResourceDensity();//constant native GetResourceDensity   takes nothing returns mapdensity
		public static mapdensity GetCreatureDensity();//constant native GetCreatureDensity   takes nothing returns mapdensity
		public static float GetStartLocationX(int whichStartLocation);//constant native GetStartLocationX    takes integer whichStartLocation returns real
		public static float GetStartLocationY(int whichStartLocation);//constant native GetStartLocationY    takes integer whichStartLocation returns real
		public static location GetStartLocationLoc(int whichStartLocation);//constant native GetStartLocationLoc  takes integer whichStartLocation returns location
		public static void SetPlayerTeam(player whichPlayer, int whichTeam);//native SetPlayerTeam            takes player whichPlayer, integer whichTeam returns nothing
		public static void SetPlayerStartLocation(player whichPlayer, int startLocIndex);//native SetPlayerStartLocation   takes player whichPlayer, integer startLocIndex returns nothing
		//
		//
		//
		//
		public static void ForcePlayerStartLocation(player whichPlayer, int startLocIndex);//native ForcePlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
		public static void SetPlayerColor(player whichPlayer, playercolor color);//native SetPlayerColor           takes player whichPlayer, playercolor color returns nothing
		public static void SetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, bool value);//native SetPlayerAlliance        takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, boolean value returns nothing
		public static void SetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource, int rate);//native SetPlayerTaxRate         takes player sourcePlayer, player otherPlayer, playerstate whichResource, integer rate returns nothing
		public static void SetPlayerRacePreference(player whichPlayer, racepreference whichRacePreference);//native SetPlayerRacePreference  takes player whichPlayer, racepreference whichRacePreference returns nothing
		public static void SetPlayerRaceSelectable(player whichPlayer, bool value);//native SetPlayerRaceSelectable  takes player whichPlayer, boolean value returns nothing
		public static void SetPlayerController(player whichPlayer, mapcontrol controlType);//native SetPlayerController      takes player whichPlayer, mapcontrol controlType returns nothing
		public static void SetPlayerName(player whichPlayer, string name);//native SetPlayerName            takes player whichPlayer, string name returns nothing
		public static void SetPlayerOnScoreScreen(player whichPlayer, bool flag);//native SetPlayerOnScoreScreen   takes player whichPlayer, boolean flag returns nothing
		public static int GetPlayerTeam(player whichPlayer);//native GetPlayerTeam            takes player whichPlayer returns integer
		public static int GetPlayerStartLocation(player whichPlayer);//native GetPlayerStartLocation   takes player whichPlayer returns integer
		public static playercolor GetPlayerColor(player whichPlayer);//native GetPlayerColor           takes player whichPlayer returns playercolor
		public static bool GetPlayerSelectable(player whichPlayer);//native GetPlayerSelectable      takes player whichPlayer returns boolean
		public static mapcontrol GetPlayerController(player whichPlayer);//native GetPlayerController      takes player whichPlayer returns mapcontrol
		public static playerslotstate GetPlayerSlotState(player whichPlayer);//native GetPlayerSlotState       takes player whichPlayer returns playerslotstate
		public static int GetPlayerTaxRate(player sourcePlayer, player otherPlayer, playerstate whichResource);//native GetPlayerTaxRate         takes player sourcePlayer, player otherPlayer, playerstate whichResource returns integer
		public static bool IsPlayerRacePrefSet(player whichPlayer, racepreference pref);//native IsPlayerRacePrefSet      takes player whichPlayer, racepreference pref returns boolean
		public static string GetPlayerName(player whichPlayer);//native GetPlayerName            takes player whichPlayer returns string
		//
		//
		//
		public static timer CreateTimer();//native CreateTimer          takes nothing returns timer
		public static void DestroyTimer(timer whichTimer);//native DestroyTimer         takes timer whichTimer returns nothing
		public static void TimerStart(timer whichTimer, float timeout, bool periodic, code handlerFunc);//native TimerStart           takes timer whichTimer, real timeout, boolean periodic, code handlerFunc returns nothing
		public static float TimerGetElapsed(timer whichTimer);//native TimerGetElapsed      takes timer whichTimer returns real
		public static float TimerGetRemaining(timer whichTimer);//native TimerGetRemaining    takes timer whichTimer returns real
		public static float TimerGetTimeout(timer whichTimer);//native TimerGetTimeout      takes timer whichTimer returns real
		public static void PauseTimer(timer whichTimer);//native PauseTimer           takes timer whichTimer returns nothing
		public static void ResumeTimer(timer whichTimer);//native ResumeTimer          takes timer whichTimer returns nothing
		public static timer GetExpiredTimer();//native GetExpiredTimer      takes nothing returns timer
		//
		//
		//
		public static group CreateGroup();//native CreateGroup                          takes nothing returns group
		public static void DestroyGroup(group whichGroup);//native DestroyGroup                         takes group whichGroup returns nothing
		public static void GroupAddUnit(group whichGroup, unit whichUnit);//native GroupAddUnit                         takes group whichGroup, unit whichUnit returns nothing
		public static void GroupRemoveUnit(group whichGroup, unit whichUnit);//native GroupRemoveUnit                      takes group whichGroup, unit whichUnit returns nothing
		public static void GroupClear(group whichGroup);//native GroupClear                           takes group whichGroup returns nothing
		public static void GroupEnumUnitsOfType(group whichGroup, string unitname, boolexpr filter);//native GroupEnumUnitsOfType                 takes group whichGroup, string unitname, boolexpr filter returns nothing
		public static void GroupEnumUnitsOfPlayer(group whichGroup, player whichPlayer, boolexpr filter);//native GroupEnumUnitsOfPlayer               takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
		public static void GroupEnumUnitsOfTypeCounted(group whichGroup, string unitname, boolexpr filter, int countLimit);//native GroupEnumUnitsOfTypeCounted          takes group whichGroup, string unitname, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsInRect(group whichGroup, rect r, boolexpr filter);//native GroupEnumUnitsInRect                 takes group whichGroup, rect r, boolexpr filter returns nothing
		public static void GroupEnumUnitsInRectCounted(group whichGroup, rect r, boolexpr filter, int countLimit);//native GroupEnumUnitsInRectCounted          takes group whichGroup, rect r, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsInRange(group whichGroup, float x, float y, float radius, boolexpr filter);//native GroupEnumUnitsInRange                takes group whichGroup, real x, real y, real radius, boolexpr filter returns nothing
		public static void GroupEnumUnitsInRangeOfLoc(group whichGroup, location whichLocation, float radius, boolexpr filter);//native GroupEnumUnitsInRangeOfLoc           takes group whichGroup, location whichLocation, real radius, boolexpr filter returns nothing
		public static void GroupEnumUnitsInRangeCounted(group whichGroup, float x, float y, float radius, boolexpr filter, int countLimit);//native GroupEnumUnitsInRangeCounted         takes group whichGroup, real x, real y, real radius, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsInRangeOfLocCounted(group whichGroup, location whichLocation, float radius, boolexpr filter, int countLimit);//native GroupEnumUnitsInRangeOfLocCounted    takes group whichGroup, location whichLocation, real radius, boolexpr filter, integer countLimit returns nothing
		public static void GroupEnumUnitsSelected(group whichGroup, player whichPlayer, boolexpr filter);//native GroupEnumUnitsSelected               takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
		public static bool GroupImmediateOrder(group whichGroup, string order);//native GroupImmediateOrder                  takes group whichGroup, string order returns boolean
		public static bool GroupImmediateOrderById(group whichGroup, int order);//native GroupImmediateOrderById              takes group whichGroup, integer order returns boolean
		public static bool GroupPointOrder(group whichGroup, string order, float x, float y);//native GroupPointOrder                      takes group whichGroup, string order, real x, real y returns boolean
		public static bool GroupPointOrderLoc(group whichGroup, string order, location whichLocation);//native GroupPointOrderLoc                   takes group whichGroup, string order, location whichLocation returns boolean
		public static bool GroupPointOrderById(group whichGroup, int order, float x, float y);//native GroupPointOrderById                  takes group whichGroup, integer order, real x, real y returns boolean
		public static bool GroupPointOrderByIdLoc(group whichGroup, int order, location whichLocation);//native GroupPointOrderByIdLoc               takes group whichGroup, integer order, location whichLocation returns boolean
		public static bool GroupTargetOrder(group whichGroup, string order, widget targetWidget);//native GroupTargetOrder                     takes group whichGroup, string order, widget targetWidget returns boolean
		public static bool GroupTargetOrderById(group whichGroup, int order, widget targetWidget);//native GroupTargetOrderById                 takes group whichGroup, integer order, widget targetWidget returns boolean
		//
		//
		//
		//
		public static void ForGroup(group whichGroup, code callback);//native ForGroup                 takes group whichGroup, code callback returns nothing
		public static unit FirstOfGroup(group whichGroup);//native FirstOfGroup             takes group whichGroup returns unit
		//
		//
		//
		public static force CreateForce();//native CreateForce              takes nothing returns force
		public static void DestroyForce(force whichForce);//native DestroyForce             takes force whichForce returns nothing
		public static void ForceAddPlayer(force whichForce, player whichPlayer);//native ForceAddPlayer           takes force whichForce, player whichPlayer returns nothing
		public static void ForceRemovePlayer(force whichForce, player whichPlayer);//native ForceRemovePlayer        takes force whichForce, player whichPlayer returns nothing
		public static void ForceClear(force whichForce);//native ForceClear               takes force whichForce returns nothing
		public static void ForceEnumPlayers(force whichForce, boolexpr filter);//native ForceEnumPlayers         takes force whichForce, boolexpr filter returns nothing
		public static void ForceEnumPlayersCounted(force whichForce, boolexpr filter, int countLimit);//native ForceEnumPlayersCounted  takes force whichForce, boolexpr filter, integer countLimit returns nothing
		public static void ForceEnumAllies(force whichForce, player whichPlayer, boolexpr filter);//native ForceEnumAllies          takes force whichForce, player whichPlayer, boolexpr filter returns nothing
		public static void ForceEnumEnemies(force whichForce, player whichPlayer, boolexpr filter);//native ForceEnumEnemies         takes force whichForce, player whichPlayer, boolexpr filter returns nothing
		public static void ForForce(force whichForce, code callback);//native ForForce                 takes force whichForce, code callback returns nothing
		//
		//
		//
		public static rect Rect(float minx, float miny, float maxx, float maxy);//native Rect                     takes real minx, real miny, real maxx, real maxy returns rect
		public static rect RectFromLoc(location min, location max);//native RectFromLoc              takes location min, location max returns rect
		public static void RemoveRect(rect whichRect);//native RemoveRect               takes rect whichRect returns nothing
		public static void SetRect(rect whichRect, float minx, float miny, float maxx, float maxy);//native SetRect                  takes rect whichRect, real minx, real miny, real maxx, real maxy returns nothing
		public static void SetRectFromLoc(rect whichRect, location min, location max);//native SetRectFromLoc           takes rect whichRect, location min, location max returns nothing
		public static void MoveRectTo(rect whichRect, float newCenterX, float newCenterY);//native MoveRectTo               takes rect whichRect, real newCenterX, real newCenterY returns nothing
		public static void MoveRectToLoc(rect whichRect, location newCenterLoc);//native MoveRectToLoc            takes rect whichRect, location newCenterLoc returns nothing
		public static float GetRectCenterX(rect whichRect);//native GetRectCenterX           takes rect whichRect returns real
		public static float GetRectCenterY(rect whichRect);//native GetRectCenterY           takes rect whichRect returns real
		public static float GetRectMinX(rect whichRect);//native GetRectMinX              takes rect whichRect returns real
		public static float GetRectMinY(rect whichRect);//native GetRectMinY              takes rect whichRect returns real
		public static float GetRectMaxX(rect whichRect);//native GetRectMaxX              takes rect whichRect returns real
		public static float GetRectMaxY(rect whichRect);//native GetRectMaxY              takes rect whichRect returns real
		public static region CreateRegion();//native CreateRegion             takes nothing returns region
		public static void RemoveRegion(region whichRegion);//native RemoveRegion             takes region whichRegion returns nothing
		public static void RegionAddRect(region whichRegion, rect r);//native RegionAddRect            takes region whichRegion, rect r returns nothing
		public static void RegionClearRect(region whichRegion, rect r);//native RegionClearRect          takes region whichRegion, rect r returns nothing
		public static void RegionAddCell(region whichRegion, float x, float y);//native RegionAddCell           takes region whichRegion, real x, real y returns nothing
		public static void RegionAddCellAtLoc(region whichRegion, location whichLocation);//native RegionAddCellAtLoc      takes region whichRegion, location whichLocation returns nothing
		public static void RegionClearCell(region whichRegion, float x, float y);//native RegionClearCell         takes region whichRegion, real x, real y returns nothing
		public static void RegionClearCellAtLoc(region whichRegion, location whichLocation);//native RegionClearCellAtLoc    takes region whichRegion, location whichLocation returns nothing
		public static location Location(float x, float y);//native Location                 takes real x, real y returns location
		public static void RemoveLocation(location whichLocation);//native RemoveLocation           takes location whichLocation returns nothing
		public static void MoveLocation(location whichLocation, float newX, float newY);//native MoveLocation             takes location whichLocation, real newX, real newY returns nothing
		public static float GetLocationX(location whichLocation);//native GetLocationX             takes location whichLocation returns real
		public static float GetLocationY(location whichLocation);//native GetLocationY             takes location whichLocation returns real
		//
		//
		public static float GetLocationZ(location whichLocation);//native GetLocationZ             takes location whichLocation returns real
		public static bool IsUnitInRegion(region whichRegion, unit whichUnit);//native IsUnitInRegion               takes region whichRegion, unit whichUnit returns boolean
		public static bool IsPointInRegion(region whichRegion, float x, float y);//native IsPointInRegion              takes region whichRegion, real x, real y returns boolean
		public static bool IsLocationInRegion(region whichRegion, location whichLocation);//native IsLocationInRegion           takes region whichRegion, location whichLocation returns boolean
		//
		public static rect GetWorldBounds();//native GetWorldBounds           takes nothing returns rect
		//
		//
		//
		public static trigger CreateTrigger();//native CreateTrigger    takes nothing returns trigger
		public static void DestroyTrigger(trigger whichTrigger);//native DestroyTrigger   takes trigger whichTrigger returns nothing
		public static void ResetTrigger(trigger whichTrigger);//native ResetTrigger     takes trigger whichTrigger returns nothing
		public static void EnableTrigger(trigger whichTrigger);//native EnableTrigger    takes trigger whichTrigger returns nothing
		public static void DisableTrigger(trigger whichTrigger);//native DisableTrigger   takes trigger whichTrigger returns nothing
		public static bool IsTriggerEnabled(trigger whichTrigger);//native IsTriggerEnabled takes trigger whichTrigger returns boolean
		public static void TriggerWaitOnSleeps(trigger whichTrigger, bool flag);//native TriggerWaitOnSleeps   takes trigger whichTrigger, boolean flag returns nothing
		public static bool IsTriggerWaitOnSleeps(trigger whichTrigger);//native IsTriggerWaitOnSleeps takes trigger whichTrigger returns boolean
		public static unit GetFilterUnit();//constant native GetFilterUnit       takes nothing returns unit
		public static unit GetEnumUnit();//constant native GetEnumUnit         takes nothing returns unit
		public static destructable GetFilterDestructable();//constant native GetFilterDestructable   takes nothing returns destructable
		public static destructable GetEnumDestructable();//constant native GetEnumDestructable     takes nothing returns destructable
		public static item GetFilterItem();//constant native GetFilterItem           takes nothing returns item
		public static item GetEnumItem();//constant native GetEnumItem             takes nothing returns item
		public static player GetFilterPlayer();//constant native GetFilterPlayer     takes nothing returns player
		public static player GetEnumPlayer();//constant native GetEnumPlayer       takes nothing returns player
		public static trigger GetTriggeringTrigger();//constant native GetTriggeringTrigger    takes nothing returns trigger
		public static eventid GetTriggerEventId();//constant native GetTriggerEventId       takes nothing returns eventid
		public static int GetTriggerEvalCount(trigger whichTrigger);//constant native GetTriggerEvalCount     takes trigger whichTrigger returns integer
		public static int GetTriggerExecCount(trigger whichTrigger);//constant native GetTriggerExecCount     takes trigger whichTrigger returns integer
		public static void ExecuteFunc(string funcName);//native ExecuteFunc          takes string funcName returns nothing
		//
		//
		//
		public static boolexpr And(boolexpr operandA, boolexpr operandB);//native And              takes boolexpr operandA, boolexpr operandB returns boolexpr
		public static boolexpr Or(boolexpr operandA, boolexpr operandB);//native Or               takes boolexpr operandA, boolexpr operandB returns boolexpr
		public static boolexpr Not(boolexpr operand);//native Not              takes boolexpr operand returns boolexpr
		public static conditionfunc Condition(code func);//native Condition        takes code func returns conditionfunc
		public static void DestroyCondition(conditionfunc c);//native DestroyCondition takes conditionfunc c returns nothing
		public static filterfunc Filter(code func);//native Filter           takes code func returns filterfunc
		public static void DestroyFilter(filterfunc f);//native DestroyFilter    takes filterfunc f returns nothing
		public static void DestroyBoolExpr(boolexpr e);//native DestroyBoolExpr  takes boolexpr e returns nothing
		//
		//
		//
		public static event TriggerRegisterVariableEvent(trigger whichTrigger, string varName, limitop opcode, float limitval);//native TriggerRegisterVariableEvent takes trigger whichTrigger, string varName, limitop opcode, real limitval returns event
		//
		//
		//
		public static event TriggerRegisterTimerEvent(trigger whichTrigger, float timeout, bool periodic);//native TriggerRegisterTimerEvent takes trigger whichTrigger, real timeout, boolean periodic returns event
		//
		public static event TriggerRegisterTimerExpireEvent(trigger whichTrigger, timer t);//native TriggerRegisterTimerExpireEvent takes trigger whichTrigger, timer t returns event
		public static event TriggerRegisterGameStateEvent(trigger whichTrigger, gamestate whichState, limitop opcode, float limitval);//native TriggerRegisterGameStateEvent takes trigger whichTrigger, gamestate whichState, limitop opcode, real limitval returns event
		public static event TriggerRegisterDialogEvent(trigger whichTrigger, dialog whichDialog);//native TriggerRegisterDialogEvent       takes trigger whichTrigger, dialog whichDialog returns event
		public static event TriggerRegisterDialogButtonEvent(trigger whichTrigger, button whichButton);//native TriggerRegisterDialogButtonEvent takes trigger whichTrigger, button whichButton returns event
		//
		public static gamestate GetEventGameState();//constant native GetEventGameState takes nothing returns gamestate
		public static event TriggerRegisterGameEvent(trigger whichTrigger, gameevent whichGameEvent);//native TriggerRegisterGameEvent takes trigger whichTrigger, gameevent whichGameEvent returns event
		//
		public static player GetWinningPlayer();//constant native GetWinningPlayer takes nothing returns player
		public static event TriggerRegisterEnterRegion(trigger whichTrigger, region whichRegion, boolexpr filter);//native TriggerRegisterEnterRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
		//
		public static region GetTriggeringRegion();//constant native GetTriggeringRegion takes nothing returns region
		public static unit GetEnteringUnit();//constant native GetEnteringUnit takes nothing returns unit
		//
		public static event TriggerRegisterLeaveRegion(trigger whichTrigger, region whichRegion, boolexpr filter);//native TriggerRegisterLeaveRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
		public static unit GetLeavingUnit();//constant native GetLeavingUnit takes nothing returns unit
		public static event TriggerRegisterTrackableHitEvent(trigger whichTrigger, trackable t);//native TriggerRegisterTrackableHitEvent takes trigger whichTrigger, trackable t returns event
		public static event TriggerRegisterTrackableTrackEvent(trigger whichTrigger, trackable t);//native TriggerRegisterTrackableTrackEvent takes trigger whichTrigger, trackable t returns event
		//
		//
		public static trackable GetTriggeringTrackable();//constant native GetTriggeringTrackable takes nothing returns trackable
		//
		public static button GetClickedButton();//constant native GetClickedButton takes nothing returns button
		public static dialog GetClickedDialog();//constant native GetClickedDialog    takes nothing returns dialog
		//
		public static float GetTournamentFinishSoonTimeRemaining();//constant native GetTournamentFinishSoonTimeRemaining takes nothing returns real
		public static int GetTournamentFinishNowRule();//constant native GetTournamentFinishNowRule takes nothing returns integer
		public static player GetTournamentFinishNowPlayer();//constant native GetTournamentFinishNowPlayer takes nothing returns player
		public static int GetTournamentScore(player whichPlayer);//constant native GetTournamentScore takes player whichPlayer returns integer
		//
		public static string GetSaveBasicFilename();//constant native GetSaveBasicFilename takes nothing returns string
		//
		//
		//
		public static event TriggerRegisterPlayerEvent(trigger whichTrigger, player whichPlayer, playerevent whichPlayerEvent);//native TriggerRegisterPlayerEvent takes trigger whichTrigger, player  whichPlayer, playerevent whichPlayerEvent returns event
		//
		//
		public static player GetTriggerPlayer();//constant native GetTriggerPlayer takes nothing returns player
		public static event TriggerRegisterPlayerUnitEvent(trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter);//native TriggerRegisterPlayerUnitEvent takes trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter returns event
		//
		//
		public static unit GetLevelingUnit();//constant native GetLevelingUnit takes nothing returns unit
		//
		//
		public static unit GetLearningUnit();//constant native GetLearningUnit      takes nothing returns unit
		public static int GetLearnedSkill();//constant native GetLearnedSkill      takes nothing returns integer
		public static int GetLearnedSkillLevel();//constant native GetLearnedSkillLevel takes nothing returns integer
		//
		public static unit GetRevivableUnit();//constant native GetRevivableUnit takes nothing returns unit
		//
		//
		//
		//
		//
		//
		public static unit GetRevivingUnit();//constant native GetRevivingUnit takes nothing returns unit
		//
		public static unit GetAttacker();//constant native GetAttacker takes nothing returns unit
		//
		public static unit GetRescuer();//constant native GetRescuer  takes nothing returns unit
		//
		public static unit GetDyingUnit();//constant native GetDyingUnit takes nothing returns unit
		public static unit GetKillingUnit();//constant native GetKillingUnit takes nothing returns unit
		//
		public static unit GetDecayingUnit();//constant native GetDecayingUnit takes nothing returns unit
		//
		//
		//
		public static unit GetConstructingStructure();//constant native GetConstructingStructure takes nothing returns unit
		//
		//
		public static unit GetCancelledStructure();//constant native GetCancelledStructure takes nothing returns unit
		public static unit GetConstructedStructure();//constant native GetConstructedStructure takes nothing returns unit
		//
		//
		//
		public static unit GetResearchingUnit();//constant native GetResearchingUnit takes nothing returns unit
		public static int GetResearched();//constant native GetResearched takes nothing returns integer
		//
		//
		public static int GetTrainedUnitType();//constant native GetTrainedUnitType takes nothing returns integer
		//
		public static unit GetTrainedUnit();//constant native GetTrainedUnit takes nothing returns unit
		//
		public static unit GetDetectedUnit();//constant native GetDetectedUnit takes nothing returns unit
		//
		public static unit GetSummoningUnit();//constant native GetSummoningUnit    takes nothing returns unit
		public static unit GetSummonedUnit();//constant native GetSummonedUnit     takes nothing returns unit
		//
		public static unit GetTransportUnit();//constant native GetTransportUnit    takes nothing returns unit
		public static unit GetLoadedUnit();//constant native GetLoadedUnit       takes nothing returns unit
		//
		public static unit GetSellingUnit();//constant native GetSellingUnit      takes nothing returns unit
		public static unit GetSoldUnit();//constant native GetSoldUnit         takes nothing returns unit
		public static unit GetBuyingUnit();//constant native GetBuyingUnit       takes nothing returns unit
		//
		public static item GetSoldItem();//constant native GetSoldItem         takes nothing returns item
		//
		public static unit GetChangingUnit();//constant native GetChangingUnit             takes nothing returns unit
		public static player GetChangingUnitPrevOwner();//constant native GetChangingUnitPrevOwner    takes nothing returns player
		//
		//
		//
		public static unit GetManipulatingUnit();//constant native GetManipulatingUnit takes nothing returns unit
		public static item GetManipulatedItem();//constant native GetManipulatedItem  takes nothing returns item
		//
		public static unit GetOrderedUnit();//constant native GetOrderedUnit takes nothing returns unit
		public static int GetIssuedOrderId();//constant native GetIssuedOrderId takes nothing returns integer
		//
		public static float GetOrderPointX();//constant native GetOrderPointX takes nothing returns real
		public static float GetOrderPointY();//constant native GetOrderPointY takes nothing returns real
		public static location GetOrderPointLoc();//constant native GetOrderPointLoc takes nothing returns location
		//
		public static widget GetOrderTarget();//constant native GetOrderTarget              takes nothing returns widget
		public static destructable GetOrderTargetDestructable();//constant native GetOrderTargetDestructable  takes nothing returns destructable
		public static item GetOrderTargetItem();//constant native GetOrderTargetItem          takes nothing returns item
		public static unit GetOrderTargetUnit();//constant native GetOrderTargetUnit          takes nothing returns unit
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		public static unit GetSpellAbilityUnit();//constant native GetSpellAbilityUnit         takes nothing returns unit
		public static int GetSpellAbilityId();//constant native GetSpellAbilityId           takes nothing returns integer
		public static ability GetSpellAbility();//constant native GetSpellAbility             takes nothing returns ability
		public static location GetSpellTargetLoc();//constant native GetSpellTargetLoc           takes nothing returns location
		public static float GetSpellTargetX();//constant native GetSpellTargetX				takes nothing returns real
		public static float GetSpellTargetY();//constant native GetSpellTargetY				takes nothing returns real
		public static destructable GetSpellTargetDestructable();//constant native GetSpellTargetDestructable  takes nothing returns destructable
		public static item GetSpellTargetItem();//constant native GetSpellTargetItem          takes nothing returns item
		public static unit GetSpellTargetUnit();//constant native GetSpellTargetUnit          takes nothing returns unit
		public static event TriggerRegisterPlayerAllianceChange(trigger whichTrigger, player whichPlayer, alliancetype whichAlliance);//native TriggerRegisterPlayerAllianceChange takes trigger whichTrigger, player whichPlayer, alliancetype whichAlliance returns event
		public static event TriggerRegisterPlayerStateEvent(trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, float limitval);//native TriggerRegisterPlayerStateEvent takes trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, real limitval returns event
		//
		public static playerstate GetEventPlayerState();//constant native GetEventPlayerState takes nothing returns playerstate
		public static event TriggerRegisterPlayerChatEvent(trigger whichTrigger, player whichPlayer, string chatMessageToDetect, bool exactMatchOnly);//native TriggerRegisterPlayerChatEvent takes trigger whichTrigger, player whichPlayer, string chatMessageToDetect, boolean exactMatchOnly returns event
		//
		//
		//
		public static string GetEventPlayerChatString();//constant native GetEventPlayerChatString takes nothing returns string
		//
		public static string GetEventPlayerChatStringMatched();//constant native GetEventPlayerChatStringMatched takes nothing returns string
		public static event TriggerRegisterDeathEvent(trigger whichTrigger, widget whichWidget);//native TriggerRegisterDeathEvent takes trigger whichTrigger, widget whichWidget returns event
		//
		//
		//
		//
		//
		public static unit GetTriggerUnit();//constant native GetTriggerUnit takes nothing returns unit
		public static event TriggerRegisterUnitStateEvent(trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, float limitval);//native TriggerRegisterUnitStateEvent takes trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, real limitval returns event
		//
		public static unitstate GetEventUnitState();//constant native GetEventUnitState takes nothing returns unitstate
		public static event TriggerRegisterUnitEvent(trigger whichTrigger, unit whichUnit, unitevent whichEvent);//native TriggerRegisterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent returns event
		//
		public static float GetEventDamage();//constant native GetEventDamage takes nothing returns real
		public static unit GetEventDamageSource();//constant native GetEventDamageSource takes nothing returns unit
		//
		//
		//
		//
		public static player GetEventDetectingPlayer();//constant native GetEventDetectingPlayer takes nothing returns player
		public static event TriggerRegisterFilterUnitEvent(trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter);//native TriggerRegisterFilterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter returns event
		//
		//
		public static unit GetEventTargetUnit();//constant native GetEventTargetUnit takes nothing returns unit
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		public static event TriggerRegisterUnitInRange(trigger whichTrigger, unit whichUnit, float range, boolexpr filter);//native TriggerRegisterUnitInRange takes trigger whichTrigger, unit whichUnit, real range, boolexpr filter returns event
		public static triggercondition TriggerAddCondition(trigger whichTrigger, boolexpr condition);//native TriggerAddCondition    takes trigger whichTrigger, boolexpr condition returns triggercondition
		public static void TriggerRemoveCondition(trigger whichTrigger, triggercondition whichCondition);//native TriggerRemoveCondition takes trigger whichTrigger, triggercondition whichCondition returns nothing
		public static void TriggerClearConditions(trigger whichTrigger);//native TriggerClearConditions takes trigger whichTrigger returns nothing
		public static triggeraction TriggerAddAction(trigger whichTrigger, code actionFunc);//native TriggerAddAction     takes trigger whichTrigger, code actionFunc returns triggeraction
		public static void TriggerRemoveAction(trigger whichTrigger, triggeraction whichAction);//native TriggerRemoveAction  takes trigger whichTrigger, triggeraction whichAction returns nothing
		public static void TriggerClearActions(trigger whichTrigger);//native TriggerClearActions  takes trigger whichTrigger returns nothing
		public static void TriggerSleepAction(float timeout);//native TriggerSleepAction   takes real timeout returns nothing
		public static void TriggerWaitForSound(sound s, float offset);//native TriggerWaitForSound  takes sound s, real offset returns nothing
		public static bool TriggerEvaluate(trigger whichTrigger);//native TriggerEvaluate      takes trigger whichTrigger returns boolean
		public static void TriggerExecute(trigger whichTrigger);//native TriggerExecute       takes trigger whichTrigger returns nothing
		public static void TriggerExecuteWait(trigger whichTrigger);//native TriggerExecuteWait   takes trigger whichTrigger returns nothing
		public static void TriggerSyncStart();//native TriggerSyncStart     takes nothing returns nothing
		public static void TriggerSyncReady();//native TriggerSyncReady     takes nothing returns nothing
		//
		//
		public static float GetWidgetLife(widget whichWidget);//native  GetWidgetLife   takes widget whichWidget returns real
		public static void SetWidgetLife(widget whichWidget, float newLife);//native  SetWidgetLife   takes widget whichWidget, real newLife returns nothing
		public static float GetWidgetX(widget whichWidget);//native  GetWidgetX      takes widget whichWidget returns real
		public static float GetWidgetY(widget whichWidget);//native  GetWidgetY      takes widget whichWidget returns real
		public static widget GetTriggerWidget();//constant native GetTriggerWidget takes nothing returns widget
		//
		//
		//
		public static destructable CreateDestructable(int objectid, float x, float y, float face, float scale, int variation);//native          CreateDestructable          takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
		public static destructable CreateDestructableZ(int objectid, float x, float y, float z, float face, float scale, int variation);//native          CreateDestructableZ         takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
		public static destructable CreateDeadDestructable(int objectid, float x, float y, float face, float scale, int variation);//native          CreateDeadDestructable      takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
		public static destructable CreateDeadDestructableZ(int objectid, float x, float y, float z, float face, float scale, int variation);//native          CreateDeadDestructableZ     takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
		public static void RemoveDestructable(destructable d);//native          RemoveDestructable          takes destructable d returns nothing
		public static void KillDestructable(destructable d);//native          KillDestructable            takes destructable d returns nothing
		public static void SetDestructableInvulnerable(destructable d, bool flag);//native          SetDestructableInvulnerable takes destructable d, boolean flag returns nothing
		public static bool IsDestructableInvulnerable(destructable d);//native          IsDestructableInvulnerable  takes destructable d returns boolean
		public static void EnumDestructablesInRect(rect r, boolexpr filter, code actionFunc);//native          EnumDestructablesInRect     takes rect r, boolexpr filter, code actionFunc returns nothing
		public static int GetDestructableTypeId(destructable d);//native          GetDestructableTypeId       takes destructable d returns integer
		public static float GetDestructableX(destructable d);//native          GetDestructableX            takes destructable d returns real
		public static float GetDestructableY(destructable d);//native          GetDestructableY            takes destructable d returns real
		public static void SetDestructableLife(destructable d, float life);//native          SetDestructableLife         takes destructable d, real life returns nothing
		public static float GetDestructableLife(destructable d);//native          GetDestructableLife         takes destructable d returns real
		public static void SetDestructableMaxLife(destructable d, float max);//native          SetDestructableMaxLife      takes destructable d, real max returns nothing
		public static float GetDestructableMaxLife(destructable d);//native          GetDestructableMaxLife      takes destructable d returns real
		public static void DestructableRestoreLife(destructable d, float life, bool birth);//native          DestructableRestoreLife     takes destructable d, real life, boolean birth returns nothing
		public static void QueueDestructableAnimation(destructable d, string whichAnimation);//native          QueueDestructableAnimation  takes destructable d, string whichAnimation returns nothing
		public static void SetDestructableAnimation(destructable d, string whichAnimation);//native          SetDestructableAnimation    takes destructable d, string whichAnimation returns nothing
		public static void SetDestructableAnimationSpeed(destructable d, float speedFactor);//native          SetDestructableAnimationSpeed takes destructable d, real speedFactor returns nothing
		public static void ShowDestructable(destructable d, bool flag);//native          ShowDestructable            takes destructable d, boolean flag returns nothing
		public static float GetDestructableOccluderHeight(destructable d);//native          GetDestructableOccluderHeight takes destructable d returns real
		public static void SetDestructableOccluderHeight(destructable d, float height);//native          SetDestructableOccluderHeight takes destructable d, real height returns nothing
		public static string GetDestructableName(destructable d);//native          GetDestructableName         takes destructable d returns string
		public static destructable GetTriggerDestructable();//constant native GetTriggerDestructable takes nothing returns destructable
		//
		//
		public static item CreateItem(int itemid, float x, float y);//native          CreateItem      takes integer itemid, real x, real y returns item
		public static void RemoveItem(item whichItem);//native          RemoveItem      takes item whichItem returns nothing
		public static player GetItemPlayer(item whichItem);//native          GetItemPlayer   takes item whichItem returns player
		public static int GetItemTypeId(item i);//native          GetItemTypeId   takes item i returns integer
		public static float GetItemX(item i);//native          GetItemX        takes item i returns real
		public static float GetItemY(item i);//native          GetItemY        takes item i returns real
		public static void SetItemPosition(item i, float x, float y);//native          SetItemPosition takes item i, real x, real y returns nothing
		public static void SetItemDropOnDeath(item whichItem, bool flag);//native          SetItemDropOnDeath  takes item whichItem, boolean flag returns nothing
		public static void SetItemDroppable(item i, bool flag);//native          SetItemDroppable takes item i, boolean flag returns nothing
		public static void SetItemPawnable(item i, bool flag);//native          SetItemPawnable takes item i, boolean flag returns nothing
		public static void SetItemPlayer(item whichItem, player whichPlayer, bool changeColor);//native          SetItemPlayer    takes item whichItem, player whichPlayer, boolean changeColor returns nothing
		public static void SetItemInvulnerable(item whichItem, bool flag);//native          SetItemInvulnerable takes item whichItem, boolean flag returns nothing
		public static bool IsItemInvulnerable(item whichItem);//native          IsItemInvulnerable  takes item whichItem returns boolean
		public static void SetItemVisible(item whichItem, bool show);//native          SetItemVisible  takes item whichItem, boolean show returns nothing
		public static bool IsItemVisible(item whichItem);//native          IsItemVisible   takes item whichItem returns boolean
		public static bool IsItemOwned(item whichItem);//native          IsItemOwned     takes item whichItem returns boolean
		public static bool IsItemPowerup(item whichItem);//native          IsItemPowerup   takes item whichItem returns boolean
		public static bool IsItemSellable(item whichItem);//native          IsItemSellable  takes item whichItem returns boolean
		public static bool IsItemPawnable(item whichItem);//native          IsItemPawnable  takes item whichItem returns boolean
		public static bool IsItemIdPowerup(int itemId);//native          IsItemIdPowerup takes integer itemId returns boolean
		public static bool IsItemIdSellable(int itemId);//native          IsItemIdSellable takes integer itemId returns boolean
		public static bool IsItemIdPawnable(int itemId);//native          IsItemIdPawnable takes integer itemId returns boolean
		public static void EnumItemsInRect(rect r, boolexpr filter, code actionFunc);//native          EnumItemsInRect     takes rect r, boolexpr filter, code actionFunc returns nothing
		public static int GetItemLevel(item whichItem);//native          GetItemLevel    takes item whichItem returns integer
		public static itemtype GetItemType(item whichItem);//native          GetItemType     takes item whichItem returns itemtype
		public static void SetItemDropID(item whichItem, int unitId);//native          SetItemDropID   takes item whichItem, integer unitId returns nothing
		public static string GetItemName(item whichItem);//constant native GetItemName     takes item whichItem returns string
		public static int GetItemCharges(item whichItem);//native          GetItemCharges  takes item whichItem returns integer
		public static void SetItemCharges(item whichItem, int charges);//native          SetItemCharges  takes item whichItem, integer charges returns nothing
		public static int GetItemUserData(item whichItem);//native          GetItemUserData takes item whichItem returns integer
		public static void SetItemUserData(item whichItem, int data);//native          SetItemUserData takes item whichItem, integer data returns nothing
		//
		//
		//
		public static unit CreateUnit(player id, int unitid, float x, float y, float face);//native          CreateUnit              takes player id, integer unitid, real x, real y, real face returns unit
		public static unit CreateUnitByName(player whichPlayer, string unitname, float x, float y, float face);//native          CreateUnitByName        takes player whichPlayer, string unitname, real x, real y, real face returns unit
		public static unit CreateUnitAtLoc(player id, int unitid, location whichLocation, float face);//native          CreateUnitAtLoc         takes player id, integer unitid, location whichLocation, real face returns unit
		public static unit CreateUnitAtLocByName(player id, string unitname, location whichLocation, float face);//native          CreateUnitAtLocByName   takes player id, string unitname, location whichLocation, real face returns unit
		public static unit CreateCorpse(player whichPlayer, int unitid, float x, float y, float face);//native          CreateCorpse            takes player whichPlayer, integer unitid, real x, real y, real face returns unit
		public static void KillUnit(unit whichUnit);//native          KillUnit            takes unit whichUnit returns nothing
		public static void RemoveUnit(unit whichUnit);//native          RemoveUnit          takes unit whichUnit returns nothing
		public static void ShowUnit(unit whichUnit, bool show);//native          ShowUnit            takes unit whichUnit, boolean show returns nothing
		public static void SetUnitState(unit whichUnit, unitstate whichUnitState, float newVal);//native          SetUnitState        takes unit whichUnit, unitstate whichUnitState, real newVal returns nothing
		public static void SetUnitX(unit whichUnit, float newX);//native          SetUnitX            takes unit whichUnit, real newX returns nothing
		public static void SetUnitY(unit whichUnit, float newY);//native          SetUnitY            takes unit whichUnit, real newY returns nothing
		public static void SetUnitPosition(unit whichUnit, float newX, float newY);//native          SetUnitPosition     takes unit whichUnit, real newX, real newY returns nothing
		public static void SetUnitPositionLoc(unit whichUnit, location whichLocation);//native          SetUnitPositionLoc  takes unit whichUnit, location whichLocation returns nothing
		public static void SetUnitFacing(unit whichUnit, float facingAngle);//native          SetUnitFacing       takes unit whichUnit, real facingAngle returns nothing
		public static void SetUnitFacingTimed(unit whichUnit, float facingAngle, float duration);//native          SetUnitFacingTimed  takes unit whichUnit, real facingAngle, real duration returns nothing
		public static void SetUnitMoveSpeed(unit whichUnit, float newSpeed);//native          SetUnitMoveSpeed    takes unit whichUnit, real newSpeed returns nothing
		public static void SetUnitFlyHeight(unit whichUnit, float newHeight, float rate);//native          SetUnitFlyHeight    takes unit whichUnit, real newHeight, real rate returns nothing
		public static void SetUnitTurnSpeed(unit whichUnit, float newTurnSpeed);//native          SetUnitTurnSpeed    takes unit whichUnit, real newTurnSpeed returns nothing
		public static void SetUnitPropWindow(unit whichUnit, float newPropWindowAngle);//native          SetUnitPropWindow   takes unit whichUnit, real newPropWindowAngle returns nothing
		public static void SetUnitAcquireRange(unit whichUnit, float newAcquireRange);//native          SetUnitAcquireRange takes unit whichUnit, real newAcquireRange returns nothing
		public static void SetUnitCreepGuard(unit whichUnit, bool creepGuard);//native          SetUnitCreepGuard   takes unit whichUnit, boolean creepGuard returns nothing
		public static float GetUnitAcquireRange(unit whichUnit);//native          GetUnitAcquireRange     takes unit whichUnit returns real
		public static float GetUnitTurnSpeed(unit whichUnit);//native          GetUnitTurnSpeed        takes unit whichUnit returns real
		public static float GetUnitPropWindow(unit whichUnit);//native          GetUnitPropWindow       takes unit whichUnit returns real
		public static float GetUnitFlyHeight(unit whichUnit);//native          GetUnitFlyHeight        takes unit whichUnit returns real
		public static float GetUnitDefaultAcquireRange(unit whichUnit);//native          GetUnitDefaultAcquireRange      takes unit whichUnit returns real
		public static float GetUnitDefaultTurnSpeed(unit whichUnit);//native          GetUnitDefaultTurnSpeed         takes unit whichUnit returns real
		public static float GetUnitDefaultPropWindow(unit whichUnit);//native          GetUnitDefaultPropWindow        takes unit whichUnit returns real
		public static float GetUnitDefaultFlyHeight(unit whichUnit);//native          GetUnitDefaultFlyHeight         takes unit whichUnit returns real
		public static void SetUnitOwner(unit whichUnit, player whichPlayer, bool changeColor);//native          SetUnitOwner        takes unit whichUnit, player whichPlayer, boolean changeColor returns nothing
		public static void SetUnitColor(unit whichUnit, playercolor whichColor);//native          SetUnitColor        takes unit whichUnit, playercolor whichColor returns nothing
		public static void SetUnitScale(unit whichUnit, float scaleX, float scaleY, float scaleZ);//native          SetUnitScale        takes unit whichUnit, real scaleX, real scaleY, real scaleZ returns nothing
		public static void SetUnitTimeScale(unit whichUnit, float timeScale);//native          SetUnitTimeScale    takes unit whichUnit, real timeScale returns nothing
		public static void SetUnitBlendTime(unit whichUnit, float blendTime);//native          SetUnitBlendTime    takes unit whichUnit, real blendTime returns nothing
		public static void SetUnitVertexColor(unit whichUnit, int red, int green, int blue, int alpha);//native          SetUnitVertexColor  takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
		public static void QueueUnitAnimation(unit whichUnit, string whichAnimation);//native          QueueUnitAnimation          takes unit whichUnit, string whichAnimation returns nothing
		public static void SetUnitAnimation(unit whichUnit, string whichAnimation);//native          SetUnitAnimation            takes unit whichUnit, string whichAnimation returns nothing
		public static void SetUnitAnimationByIndex(unit whichUnit, int whichAnimation);//native          SetUnitAnimationByIndex     takes unit whichUnit, integer whichAnimation returns nothing
		public static void SetUnitAnimationWithRarity(unit whichUnit, string whichAnimation, raritycontrol rarity);//native          SetUnitAnimationWithRarity  takes unit whichUnit, string whichAnimation, raritycontrol rarity returns nothing
		public static void AddUnitAnimationProperties(unit whichUnit, string animProperties, bool add);//native          AddUnitAnimationProperties  takes unit whichUnit, string animProperties, boolean add returns nothing
		public static void SetUnitLookAt(unit whichUnit, string whichBone, unit lookAtTarget, float offsetX, float offsetY, float offsetZ);//native          SetUnitLookAt       takes unit whichUnit, string whichBone, unit lookAtTarget, real offsetX, real offsetY, real offsetZ returns nothing
		public static void ResetUnitLookAt(unit whichUnit);//native          ResetUnitLookAt     takes unit whichUnit returns nothing
		public static void SetUnitRescuable(unit whichUnit, player byWhichPlayer, bool flag);//native          SetUnitRescuable    takes unit whichUnit, player byWhichPlayer, boolean flag returns nothing
		public static void SetUnitRescueRange(unit whichUnit, float range);//native          SetUnitRescueRange  takes unit whichUnit, real range returns nothing
		public static void SetHeroStr(unit whichHero, int newStr, bool permanent);//native          SetHeroStr          takes unit whichHero, integer newStr, boolean permanent returns nothing
		public static void SetHeroAgi(unit whichHero, int newAgi, bool permanent);//native          SetHeroAgi          takes unit whichHero, integer newAgi, boolean permanent returns nothing
		public static void SetHeroInt(unit whichHero, int newInt, bool permanent);//native          SetHeroInt          takes unit whichHero, integer newInt, boolean permanent returns nothing
		public static int GetHeroStr(unit whichHero, bool includeBonuses);//native          GetHeroStr          takes unit whichHero, boolean includeBonuses returns integer
		public static int GetHeroAgi(unit whichHero, bool includeBonuses);//native          GetHeroAgi          takes unit whichHero, boolean includeBonuses returns integer
		public static int GetHeroInt(unit whichHero, bool includeBonuses);//native          GetHeroInt          takes unit whichHero, boolean includeBonuses returns integer
		public static bool UnitStripHeroLevel(unit whichHero, int howManyLevels);//native          UnitStripHeroLevel  takes unit whichHero, integer howManyLevels returns boolean
		public static int GetHeroXP(unit whichHero);//native          GetHeroXP           takes unit whichHero returns integer
		public static void SetHeroXP(unit whichHero, int newXpVal, bool showEyeCandy);//native          SetHeroXP           takes unit whichHero, integer newXpVal,  boolean showEyeCandy returns nothing
		public static int GetHeroSkillPoints(unit whichHero);//native          GetHeroSkillPoints      takes unit whichHero returns integer
		public static bool UnitModifySkillPoints(unit whichHero, int skillPointDelta);//native          UnitModifySkillPoints   takes unit whichHero, integer skillPointDelta returns boolean
		public static void AddHeroXP(unit whichHero, int xpToAdd, bool showEyeCandy);//native          AddHeroXP           takes unit whichHero, integer xpToAdd,   boolean showEyeCandy returns nothing
		public static void SetHeroLevel(unit whichHero, int level, bool showEyeCandy);//native          SetHeroLevel        takes unit whichHero, integer level,  boolean showEyeCandy returns nothing
		public static int GetHeroLevel(unit whichHero);//constant native GetHeroLevel        takes unit whichHero returns integer
		public static int GetUnitLevel(unit whichUnit);//constant native GetUnitLevel        takes unit whichUnit returns integer
		public static string GetHeroProperName(unit whichHero);//native          GetHeroProperName   takes unit whichHero returns string
		public static void SuspendHeroXP(unit whichHero, bool flag);//native          SuspendHeroXP       takes unit whichHero, boolean flag returns nothing
		public static bool IsSuspendedXP(unit whichHero);//native          IsSuspendedXP       takes unit whichHero returns boolean
		public static void SelectHeroSkill(unit whichHero, int abilcode);//native          SelectHeroSkill     takes unit whichHero, integer abilcode returns nothing
		public static int GetUnitAbilityLevel(unit whichUnit, int abilcode);//native          GetUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
		public static int DecUnitAbilityLevel(unit whichUnit, int abilcode);//native          DecUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
		public static int IncUnitAbilityLevel(unit whichUnit, int abilcode);//native          IncUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
		public static int SetUnitAbilityLevel(unit whichUnit, int abilcode, int level);//native          SetUnitAbilityLevel takes unit whichUnit, integer abilcode, integer level returns integer
		public static bool ReviveHero(unit whichHero, float x, float y, bool doEyecandy);//native          ReviveHero          takes unit whichHero, real x, real y, boolean doEyecandy returns boolean
		public static bool ReviveHeroLoc(unit whichHero, location loc, bool doEyecandy);//native          ReviveHeroLoc       takes unit whichHero, location loc, boolean doEyecandy returns boolean
		public static void SetUnitExploded(unit whichUnit, bool exploded);//native          SetUnitExploded     takes unit whichUnit, boolean exploded returns nothing
		public static void SetUnitInvulnerable(unit whichUnit, bool flag);//native          SetUnitInvulnerable takes unit whichUnit, boolean flag returns nothing
		public static void PauseUnit(unit whichUnit, bool flag);//native          PauseUnit           takes unit whichUnit, boolean flag returns nothing
		public static bool IsUnitPaused(unit whichHero);//native          IsUnitPaused        takes unit whichHero returns boolean
		public static void SetUnitPathing(unit whichUnit, bool flag);//native          SetUnitPathing      takes unit whichUnit, boolean flag returns nothing
		public static void ClearSelection();//native          ClearSelection      takes nothing returns nothing
		public static void SelectUnit(unit whichUnit, bool flag);//native          SelectUnit          takes unit whichUnit, boolean flag returns nothing
		public static int GetUnitPointValue(unit whichUnit);//native          GetUnitPointValue       takes unit whichUnit returns integer
		public static int GetUnitPointValueByType(int unitType);//native          GetUnitPointValueByType takes integer unitType returns integer
		//
		public static bool UnitAddItem(unit whichUnit, item whichItem);//native          UnitAddItem             takes unit whichUnit, item whichItem returns boolean
		public static item UnitAddItemById(unit whichUnit, int itemId);//native          UnitAddItemById         takes unit whichUnit, integer itemId returns item
		public static bool UnitAddItemToSlotById(unit whichUnit, int itemId, int itemSlot);//native          UnitAddItemToSlotById   takes unit whichUnit, integer itemId, integer itemSlot returns boolean
		public static void UnitRemoveItem(unit whichUnit, item whichItem);//native          UnitRemoveItem          takes unit whichUnit, item whichItem returns nothing
		public static item UnitRemoveItemFromSlot(unit whichUnit, int itemSlot);//native          UnitRemoveItemFromSlot  takes unit whichUnit, integer itemSlot returns item
		public static bool UnitHasItem(unit whichUnit, item whichItem);//native          UnitHasItem             takes unit whichUnit, item whichItem returns boolean
		public static item UnitItemInSlot(unit whichUnit, int itemSlot);//native          UnitItemInSlot          takes unit whichUnit, integer itemSlot returns item
		public static int UnitInventorySize(unit whichUnit);//native          UnitInventorySize       takes unit whichUnit returns integer
		public static bool UnitDropItemPoint(unit whichUnit, item whichItem, float x, float y);//native          UnitDropItemPoint       takes unit whichUnit, item whichItem, real x, real y returns boolean
		public static bool UnitDropItemSlot(unit whichUnit, item whichItem, int slot);//native          UnitDropItemSlot        takes unit whichUnit, item whichItem, integer slot returns boolean
		public static bool UnitDropItemTarget(unit whichUnit, item whichItem, widget target);//native          UnitDropItemTarget      takes unit whichUnit, item whichItem, widget target returns boolean
		public static bool UnitUseItem(unit whichUnit, item whichItem);//native          UnitUseItem             takes unit whichUnit, item whichItem returns boolean
		public static bool UnitUseItemPoint(unit whichUnit, item whichItem, float x, float y);//native          UnitUseItemPoint        takes unit whichUnit, item whichItem, real x, real y returns boolean
		public static bool UnitUseItemTarget(unit whichUnit, item whichItem, widget target);//native          UnitUseItemTarget       takes unit whichUnit, item whichItem, widget target returns boolean
		public static float GetUnitX(unit whichUnit);//constant native GetUnitX            takes unit whichUnit returns real
		public static float GetUnitY(unit whichUnit);//constant native GetUnitY            takes unit whichUnit returns real
		public static location GetUnitLoc(unit whichUnit);//constant native GetUnitLoc          takes unit whichUnit returns location
		public static float GetUnitFacing(unit whichUnit);//constant native GetUnitFacing       takes unit whichUnit returns real
		public static float GetUnitMoveSpeed(unit whichUnit);//constant native GetUnitMoveSpeed    takes unit whichUnit returns real
		public static float GetUnitDefaultMoveSpeed(unit whichUnit);//constant native GetUnitDefaultMoveSpeed takes unit whichUnit returns real
		public static float GetUnitState(unit whichUnit, unitstate whichUnitState);//constant native GetUnitState        takes unit whichUnit, unitstate whichUnitState returns real
		public static player GetOwningPlayer(unit whichUnit);//constant native GetOwningPlayer     takes unit whichUnit returns player
		public static int GetUnitTypeId(unit whichUnit);//constant native GetUnitTypeId       takes unit whichUnit returns integer
		public static race GetUnitRace(unit whichUnit);//constant native GetUnitRace         takes unit whichUnit returns race
		public static string GetUnitName(unit whichUnit);//constant native GetUnitName         takes unit whichUnit returns string
		public static int GetUnitFoodUsed(unit whichUnit);//constant native GetUnitFoodUsed     takes unit whichUnit returns integer
		public static int GetUnitFoodMade(unit whichUnit);//constant native GetUnitFoodMade     takes unit whichUnit returns integer
		public static int GetFoodMade(int unitId);//constant native GetFoodMade         takes integer unitId returns integer
		public static int GetFoodUsed(int unitId);//constant native GetFoodUsed         takes integer unitId returns integer
		public static void SetUnitUseFood(unit whichUnit, bool useFood);//native          SetUnitUseFood      takes unit whichUnit, boolean useFood returns nothing
		public static location GetUnitRallyPoint(unit whichUnit);//constant native GetUnitRallyPoint           takes unit whichUnit returns location
		public static unit GetUnitRallyUnit(unit whichUnit);//constant native GetUnitRallyUnit            takes unit whichUnit returns unit
		public static destructable GetUnitRallyDestructable(unit whichUnit);//constant native GetUnitRallyDestructable    takes unit whichUnit returns destructable
		public static bool IsUnitInGroup(unit whichUnit, group whichGroup);//constant native IsUnitInGroup       takes unit whichUnit, group whichGroup returns boolean
		public static bool IsUnitInForce(unit whichUnit, force whichForce);//constant native IsUnitInForce       takes unit whichUnit, force whichForce returns boolean
		public static bool IsUnitOwnedByPlayer(unit whichUnit, player whichPlayer);//constant native IsUnitOwnedByPlayer takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitAlly(unit whichUnit, player whichPlayer);//constant native IsUnitAlly          takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitEnemy(unit whichUnit, player whichPlayer);//constant native IsUnitEnemy         takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitVisible(unit whichUnit, player whichPlayer);//constant native IsUnitVisible       takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitDetected(unit whichUnit, player whichPlayer);//constant native IsUnitDetected      takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitInvisible(unit whichUnit, player whichPlayer);//constant native IsUnitInvisible     takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitFogged(unit whichUnit, player whichPlayer);//constant native IsUnitFogged        takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitMasked(unit whichUnit, player whichPlayer);//constant native IsUnitMasked        takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitSelected(unit whichUnit, player whichPlayer);//constant native IsUnitSelected      takes unit whichUnit, player whichPlayer returns boolean
		public static bool IsUnitRace(unit whichUnit, race whichRace);//constant native IsUnitRace          takes unit whichUnit, race whichRace returns boolean
		public static bool IsUnitType(unit whichUnit, unittype whichUnitType);//constant native IsUnitType          takes unit whichUnit, unittype whichUnitType returns boolean
		public static bool IsUnit(unit whichUnit, unit whichSpecifiedUnit);//constant native IsUnit              takes unit whichUnit, unit whichSpecifiedUnit returns boolean
		public static bool IsUnitInRange(unit whichUnit, unit otherUnit, float distance);//constant native IsUnitInRange       takes unit whichUnit, unit otherUnit, real distance returns boolean
		public static bool IsUnitInRangeXY(unit whichUnit, float x, float y, float distance);//constant native IsUnitInRangeXY     takes unit whichUnit, real x, real y, real distance returns boolean
		public static bool IsUnitInRangeLoc(unit whichUnit, location whichLocation, float distance);//constant native IsUnitInRangeLoc    takes unit whichUnit, location whichLocation, real distance returns boolean
		public static bool IsUnitHidden(unit whichUnit);//constant native IsUnitHidden        takes unit whichUnit returns boolean
		public static bool IsUnitIllusion(unit whichUnit);//constant native IsUnitIllusion      takes unit whichUnit returns boolean
		public static bool IsUnitInTransport(unit whichUnit, unit whichTransport);//constant native IsUnitInTransport   takes unit whichUnit, unit whichTransport returns boolean
		public static bool IsUnitLoaded(unit whichUnit);//constant native IsUnitLoaded        takes unit whichUnit returns boolean
		public static bool IsHeroUnitId(int unitId);//constant native IsHeroUnitId        takes integer unitId returns boolean
		public static bool IsUnitIdType(int unitId, unittype whichUnitType);//constant native IsUnitIdType        takes integer unitId, unittype whichUnitType returns boolean
		public static void UnitShareVision(unit whichUnit, player whichPlayer, bool share);//native UnitShareVision              takes unit whichUnit, player whichPlayer, boolean share returns nothing
		public static void UnitSuspendDecay(unit whichUnit, bool suspend);//native UnitSuspendDecay             takes unit whichUnit, boolean suspend returns nothing
		public static bool UnitAddType(unit whichUnit, unittype whichUnitType);//native UnitAddType                  takes unit whichUnit, unittype whichUnitType returns boolean
		public static bool UnitRemoveType(unit whichUnit, unittype whichUnitType);//native UnitRemoveType               takes unit whichUnit, unittype whichUnitType returns boolean
		public static bool UnitAddAbility(unit whichUnit, int abilityId);//native UnitAddAbility               takes unit whichUnit, integer abilityId returns boolean
		public static bool UnitRemoveAbility(unit whichUnit, int abilityId);//native UnitRemoveAbility            takes unit whichUnit, integer abilityId returns boolean
		public static bool UnitMakeAbilityPermanent(unit whichUnit, bool permanent, int abilityId);//native UnitMakeAbilityPermanent     takes unit whichUnit, boolean permanent, integer abilityId returns boolean
		public static void UnitRemoveBuffs(unit whichUnit, bool removePositive, bool removeNegative);//native UnitRemoveBuffs              takes unit whichUnit, boolean removePositive, boolean removeNegative returns nothing
		public static void UnitRemoveBuffsEx(unit whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);//native UnitRemoveBuffsEx            takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns nothing
		public static bool UnitHasBuffsEx(unit whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);//native UnitHasBuffsEx               takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns boolean
		public static int UnitCountBuffsEx(unit whichUnit, bool removePositive, bool removeNegative, bool magic, bool physical, bool timedLife, bool aura, bool autoDispel);//native UnitCountBuffsEx             takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns integer
		public static void UnitAddSleep(unit whichUnit, bool add);//native UnitAddSleep                 takes unit whichUnit, boolean add returns nothing
		public static bool UnitCanSleep(unit whichUnit);//native UnitCanSleep                 takes unit whichUnit returns boolean
		public static void UnitAddSleepPerm(unit whichUnit, bool add);//native UnitAddSleepPerm             takes unit whichUnit, boolean add returns nothing
		public static bool UnitCanSleepPerm(unit whichUnit);//native UnitCanSleepPerm             takes unit whichUnit returns boolean
		public static bool UnitIsSleeping(unit whichUnit);//native UnitIsSleeping               takes unit whichUnit returns boolean
		public static void UnitWakeUp(unit whichUnit);//native UnitWakeUp                   takes unit whichUnit returns nothing
		public static void UnitApplyTimedLife(unit whichUnit, int buffId, float duration);//native UnitApplyTimedLife           takes unit whichUnit, integer buffId, real duration returns nothing
		public static bool UnitIgnoreAlarm(unit whichUnit, bool flag);//native UnitIgnoreAlarm              takes unit whichUnit, boolean flag returns boolean
		public static bool UnitIgnoreAlarmToggled(unit whichUnit);//native UnitIgnoreAlarmToggled       takes unit whichUnit returns boolean
		public static void UnitResetCooldown(unit whichUnit);//native UnitResetCooldown            takes unit whichUnit returns nothing
		public static void UnitSetConstructionProgress(unit whichUnit, int constructionPercentage);//native UnitSetConstructionProgress  takes unit whichUnit, integer constructionPercentage returns nothing
		public static void UnitSetUpgradeProgress(unit whichUnit, int upgradePercentage);//native UnitSetUpgradeProgress       takes unit whichUnit, integer upgradePercentage returns nothing
		public static void UnitPauseTimedLife(unit whichUnit, bool flag);//native UnitPauseTimedLife           takes unit whichUnit, boolean flag returns nothing
		public static void UnitSetUsesAltIcon(unit whichUnit, bool flag);//native UnitSetUsesAltIcon           takes unit whichUnit, boolean flag returns nothing
		public static bool UnitDamagePoint(unit whichUnit, float delay, float radius, float x, float y, float amount, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType);//native UnitDamagePoint              takes unit whichUnit, real delay, real radius, real x, real y, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
		public static bool UnitDamageTarget(unit whichUnit, widget target, float amount, bool attack, bool ranged, attacktype attackType, damagetype damageType, weapontype weaponType);//native UnitDamageTarget             takes unit whichUnit, widget target, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
		public static bool IssueImmediateOrder(unit whichUnit, string order);//native IssueImmediateOrder          takes unit whichUnit, string order returns boolean
		public static bool IssueImmediateOrderById(unit whichUnit, int order);//native IssueImmediateOrderById      takes unit whichUnit, integer order returns boolean
		public static bool IssuePointOrder(unit whichUnit, string order, float x, float y);//native IssuePointOrder              takes unit whichUnit, string order, real x, real y returns boolean
		public static bool IssuePointOrderLoc(unit whichUnit, string order, location whichLocation);//native IssuePointOrderLoc           takes unit whichUnit, string order, location whichLocation returns boolean
		public static bool IssuePointOrderById(unit whichUnit, int order, float x, float y);//native IssuePointOrderById          takes unit whichUnit, integer order, real x, real y returns boolean
		public static bool IssuePointOrderByIdLoc(unit whichUnit, int order, location whichLocation);//native IssuePointOrderByIdLoc       takes unit whichUnit, integer order, location whichLocation returns boolean
		public static bool IssueTargetOrder(unit whichUnit, string order, widget targetWidget);//native IssueTargetOrder             takes unit whichUnit, string order, widget targetWidget returns boolean
		public static bool IssueTargetOrderById(unit whichUnit, int order, widget targetWidget);//native IssueTargetOrderById         takes unit whichUnit, integer order, widget targetWidget returns boolean
		public static bool IssueInstantPointOrder(unit whichUnit, string order, float x, float y, widget instantTargetWidget);//native IssueInstantPointOrder       takes unit whichUnit, string order, real x, real y, widget instantTargetWidget returns boolean
		public static bool IssueInstantPointOrderById(unit whichUnit, int order, float x, float y, widget instantTargetWidget);//native IssueInstantPointOrderById   takes unit whichUnit, integer order, real x, real y, widget instantTargetWidget returns boolean
		public static bool IssueInstantTargetOrder(unit whichUnit, string order, widget targetWidget, widget instantTargetWidget);//native IssueInstantTargetOrder      takes unit whichUnit, string order, widget targetWidget, widget instantTargetWidget returns boolean
		public static bool IssueInstantTargetOrderById(unit whichUnit, int order, widget targetWidget, widget instantTargetWidget);//native IssueInstantTargetOrderById  takes unit whichUnit, integer order, widget targetWidget, widget instantTargetWidget returns boolean
		public static bool IssueBuildOrder(unit whichPeon, string unitToBuild, float x, float y);//native IssueBuildOrder              takes unit whichPeon, string unitToBuild, real x, real y returns boolean
		public static bool IssueBuildOrderById(unit whichPeon, int unitId, float x, float y);//native IssueBuildOrderById          takes unit whichPeon, integer unitId, real x, real y returns boolean
		public static bool IssueNeutralImmediateOrder(player forWhichPlayer, unit neutralStructure, string unitToBuild);//native IssueNeutralImmediateOrder       takes player forWhichPlayer, unit neutralStructure, string unitToBuild returns boolean
		public static bool IssueNeutralImmediateOrderById(player forWhichPlayer, unit neutralStructure, int unitId);//native IssueNeutralImmediateOrderById   takes player forWhichPlayer,unit neutralStructure, integer unitId returns boolean
		public static bool IssueNeutralPointOrder(player forWhichPlayer, unit neutralStructure, string unitToBuild, float x, float y);//native IssueNeutralPointOrder           takes player forWhichPlayer,unit neutralStructure, string unitToBuild, real x, real y returns boolean
		public static bool IssueNeutralPointOrderById(player forWhichPlayer, unit neutralStructure, int unitId, float x, float y);//native IssueNeutralPointOrderById       takes player forWhichPlayer,unit neutralStructure, integer unitId, real x, real y returns boolean
		public static bool IssueNeutralTargetOrder(player forWhichPlayer, unit neutralStructure, string unitToBuild, widget target);//native IssueNeutralTargetOrder          takes player forWhichPlayer,unit neutralStructure, string unitToBuild, widget target returns boolean
		public static bool IssueNeutralTargetOrderById(player forWhichPlayer, unit neutralStructure, int unitId, widget target);//native IssueNeutralTargetOrderById      takes player forWhichPlayer,unit neutralStructure, integer unitId, widget target returns boolean
		public static int GetUnitCurrentOrder(unit whichUnit);//native GetUnitCurrentOrder          takes unit whichUnit returns integer
		public static void SetResourceAmount(unit whichUnit, int amount);//native SetResourceAmount            takes unit whichUnit, integer amount returns nothing
		public static void AddResourceAmount(unit whichUnit, int amount);//native AddResourceAmount            takes unit whichUnit, integer amount returns nothing
		public static int GetResourceAmount(unit whichUnit);//native GetResourceAmount            takes unit whichUnit returns integer
		public static float WaygateGetDestinationX(unit waygate);//native WaygateGetDestinationX       takes unit waygate returns real
		public static float WaygateGetDestinationY(unit waygate);//native WaygateGetDestinationY       takes unit waygate returns real
		public static void WaygateSetDestination(unit waygate, float x, float y);//native WaygateSetDestination        takes unit waygate, real x, real y returns nothing
		public static void WaygateActivate(unit waygate, bool activate);//native WaygateActivate              takes unit waygate, boolean activate returns nothing
		public static bool WaygateIsActive(unit waygate);//native WaygateIsActive              takes unit waygate returns boolean
		public static void AddItemToAllStock(int itemId, int currentStock, int stockMax);//native AddItemToAllStock            takes integer itemId, integer currentStock, integer stockMax returns nothing
		public static void AddItemToStock(unit whichUnit, int itemId, int currentStock, int stockMax);//native AddItemToStock               takes unit whichUnit, integer itemId, integer currentStock, integer stockMax returns nothing
		public static void AddUnitToAllStock(int unitId, int currentStock, int stockMax);//native AddUnitToAllStock            takes integer unitId, integer currentStock, integer stockMax returns nothing
		public static void AddUnitToStock(unit whichUnit, int unitId, int currentStock, int stockMax);//native AddUnitToStock               takes unit whichUnit, integer unitId, integer currentStock, integer stockMax returns nothing
		public static void RemoveItemFromAllStock(int itemId);//native RemoveItemFromAllStock       takes integer itemId returns nothing
		public static void RemoveItemFromStock(unit whichUnit, int itemId);//native RemoveItemFromStock          takes unit whichUnit, integer itemId returns nothing
		public static void RemoveUnitFromAllStock(int unitId);//native RemoveUnitFromAllStock       takes integer unitId returns nothing
		public static void RemoveUnitFromStock(unit whichUnit, int unitId);//native RemoveUnitFromStock          takes unit whichUnit, integer unitId returns nothing
		public static void SetAllItemTypeSlots(int slots);//native SetAllItemTypeSlots          takes integer slots returns nothing
		public static void SetAllUnitTypeSlots(int slots);//native SetAllUnitTypeSlots          takes integer slots returns nothing
		public static void SetItemTypeSlots(unit whichUnit, int slots);//native SetItemTypeSlots             takes unit whichUnit, integer slots returns nothing
		public static void SetUnitTypeSlots(unit whichUnit, int slots);//native SetUnitTypeSlots             takes unit whichUnit, integer slots returns nothing
		public static int GetUnitUserData(unit whichUnit);//native GetUnitUserData              takes unit whichUnit returns integer
		public static void SetUnitUserData(unit whichUnit, int data);//native SetUnitUserData              takes unit whichUnit, integer data returns nothing
		//
		//
		public static player Player(int number);//constant native Player              takes integer number returns player
		public static player GetLocalPlayer();//constant native GetLocalPlayer      takes nothing returns player
		public static bool IsPlayerAlly(player whichPlayer, player otherPlayer);//constant native IsPlayerAlly        takes player whichPlayer, player otherPlayer returns boolean
		public static bool IsPlayerEnemy(player whichPlayer, player otherPlayer);//constant native IsPlayerEnemy       takes player whichPlayer, player otherPlayer returns boolean
		public static bool IsPlayerInForce(player whichPlayer, force whichForce);//constant native IsPlayerInForce     takes player whichPlayer, force whichForce returns boolean
		public static bool IsPlayerObserver(player whichPlayer);//constant native IsPlayerObserver    takes player whichPlayer returns boolean
		public static bool IsVisibleToPlayer(float x, float y, player whichPlayer);//constant native IsVisibleToPlayer           takes real x, real y, player whichPlayer returns boolean
		public static bool IsLocationVisibleToPlayer(location whichLocation, player whichPlayer);//constant native IsLocationVisibleToPlayer   takes location whichLocation, player whichPlayer returns boolean
		public static bool IsFoggedToPlayer(float x, float y, player whichPlayer);//constant native IsFoggedToPlayer            takes real x, real y, player whichPlayer returns boolean
		public static bool IsLocationFoggedToPlayer(location whichLocation, player whichPlayer);//constant native IsLocationFoggedToPlayer    takes location whichLocation, player whichPlayer returns boolean
		public static bool IsMaskedToPlayer(float x, float y, player whichPlayer);//constant native IsMaskedToPlayer            takes real x, real y, player whichPlayer returns boolean
		public static bool IsLocationMaskedToPlayer(location whichLocation, player whichPlayer);//constant native IsLocationMaskedToPlayer    takes location whichLocation, player whichPlayer returns boolean
		public static race GetPlayerRace(player whichPlayer);//constant native GetPlayerRace           takes player whichPlayer returns race
		public static int GetPlayerId(player whichPlayer);//constant native GetPlayerId             takes player whichPlayer returns integer
		public static int GetPlayerUnitCount(player whichPlayer, bool includeIncomplete);//constant native GetPlayerUnitCount      takes player whichPlayer, boolean includeIncomplete returns integer
		public static int GetPlayerTypedUnitCount(player whichPlayer, string unitName, bool includeIncomplete, bool includeUpgrades);//constant native GetPlayerTypedUnitCount takes player whichPlayer, string unitName, boolean includeIncomplete, boolean includeUpgrades returns integer
		public static int GetPlayerStructureCount(player whichPlayer, bool includeIncomplete);//constant native GetPlayerStructureCount takes player whichPlayer, boolean includeIncomplete returns integer
		public static int GetPlayerState(player whichPlayer, playerstate whichPlayerState);//constant native GetPlayerState          takes player whichPlayer, playerstate whichPlayerState returns integer
		public static int GetPlayerScore(player whichPlayer, playerscore whichPlayerScore);//constant native GetPlayerScore          takes player whichPlayer, playerscore whichPlayerScore returns integer
		public static bool GetPlayerAlliance(player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting);//constant native GetPlayerAlliance       takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting returns boolean
		public static float GetPlayerHandicap(player whichPlayer);//constant native GetPlayerHandicap       takes player whichPlayer returns real
		public static float GetPlayerHandicapXP(player whichPlayer);//constant native GetPlayerHandicapXP     takes player whichPlayer returns real
		public static void SetPlayerHandicap(player whichPlayer, float handicap);//constant native SetPlayerHandicap       takes player whichPlayer, real handicap returns nothing
		public static void SetPlayerHandicapXP(player whichPlayer, float handicap);//constant native SetPlayerHandicapXP     takes player whichPlayer, real handicap returns nothing
		public static void SetPlayerTechMaxAllowed(player whichPlayer, int techid, int maximum);//constant native SetPlayerTechMaxAllowed takes player whichPlayer, integer techid, integer maximum returns nothing
		public static int GetPlayerTechMaxAllowed(player whichPlayer, int techid);//constant native GetPlayerTechMaxAllowed takes player whichPlayer, integer techid returns integer
		public static void AddPlayerTechResearched(player whichPlayer, int techid, int levels);//constant native AddPlayerTechResearched takes player whichPlayer, integer techid, integer levels returns nothing
		public static void SetPlayerTechResearched(player whichPlayer, int techid, int setToLevel);//constant native SetPlayerTechResearched takes player whichPlayer, integer techid, integer setToLevel returns nothing
		public static bool GetPlayerTechResearched(player whichPlayer, int techid, bool specificonly);//constant native GetPlayerTechResearched takes player whichPlayer, integer techid, boolean specificonly returns boolean
		public static int GetPlayerTechCount(player whichPlayer, int techid, bool specificonly);//constant native GetPlayerTechCount      takes player whichPlayer, integer techid, boolean specificonly returns integer
		public static void SetPlayerUnitsOwner(player whichPlayer, int newOwner);//native SetPlayerUnitsOwner takes player whichPlayer, integer newOwner returns nothing
		public static void CripplePlayer(player whichPlayer, force toWhichPlayers, bool flag);//native CripplePlayer takes player whichPlayer, force toWhichPlayers, boolean flag returns nothing
		public static void SetPlayerAbilityAvailable(player whichPlayer, int abilid, bool avail);//native SetPlayerAbilityAvailable        takes player whichPlayer, integer abilid, boolean avail returns nothing
		public static void SetPlayerState(player whichPlayer, playerstate whichPlayerState, int value);//native SetPlayerState   takes player whichPlayer, playerstate whichPlayerState, integer value returns nothing
		public static void RemovePlayer(player whichPlayer, playergameresult gameResult);//native RemovePlayer     takes player whichPlayer, playergameresult gameResult returns nothing
		//
		//
		//
		public static void CachePlayerHeroData(player whichPlayer);//native CachePlayerHeroData takes player whichPlayer returns nothing
		//
		//
		public static void SetFogStateRect(player forWhichPlayer, fogstate whichState, rect where, bool useSharedVision);//native  SetFogStateRect      takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision returns nothing
		public static void SetFogStateRadius(player forWhichPlayer, fogstate whichState, float centerx, float centerY, float radius, bool useSharedVision);//native  SetFogStateRadius    takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision returns nothing
		public static void SetFogStateRadiusLoc(player forWhichPlayer, fogstate whichState, location center, float radius, bool useSharedVision);//native  SetFogStateRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision returns nothing
		public static void FogMaskEnable(bool enable);//native  FogMaskEnable        takes boolean enable returns nothing
		public static bool IsFogMaskEnabled();//native  IsFogMaskEnabled     takes nothing returns boolean
		public static void FogEnable(bool enable);//native  FogEnable            takes boolean enable returns nothing
		public static bool IsFogEnabled();//native  IsFogEnabled         takes nothing returns boolean
		public static fogmodifier CreateFogModifierRect(player forWhichPlayer, fogstate whichState, rect where, bool useSharedVision, bool afterUnits);//native CreateFogModifierRect        takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision, boolean afterUnits returns fogmodifier
		public static fogmodifier CreateFogModifierRadius(player forWhichPlayer, fogstate whichState, float centerx, float centerY, float radius, bool useSharedVision, bool afterUnits);//native CreateFogModifierRadius      takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
		public static fogmodifier CreateFogModifierRadiusLoc(player forWhichPlayer, fogstate whichState, location center, float radius, bool useSharedVision, bool afterUnits);//native CreateFogModifierRadiusLoc   takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
		public static void DestroyFogModifier(fogmodifier whichFogModifier);//native DestroyFogModifier           takes fogmodifier whichFogModifier returns nothing
		public static void FogModifierStart(fogmodifier whichFogModifier);//native FogModifierStart             takes fogmodifier whichFogModifier returns nothing
		public static void FogModifierStop(fogmodifier whichFogModifier);//native FogModifierStop              takes fogmodifier whichFogModifier returns nothing
		//
		//
		public static version VersionGet();//native VersionGet takes nothing returns version
		public static bool VersionCompatible(version whichVersion);//native VersionCompatible takes version whichVersion returns boolean
		public static bool VersionSupported(version whichVersion);//native VersionSupported takes version whichVersion returns boolean
		public static void EndGame(bool doScoreScreen);//native EndGame takes boolean doScoreScreen returns nothing
		//
		public static void ChangeLevel(string newLevel, bool doScoreScreen);//native          ChangeLevel         takes string newLevel, boolean doScoreScreen returns nothing
		public static void RestartGame(bool doScoreScreen);//native          RestartGame         takes boolean doScoreScreen returns nothing
		public static void ReloadGame();//native          ReloadGame          takes nothing returns nothing
		//
		//
		public static void SetCampaignMenuRace(race r);//native          SetCampaignMenuRace takes race r returns nothing
		public static void SetCampaignMenuRaceEx(int campaignIndex);//native          SetCampaignMenuRaceEx takes integer campaignIndex returns nothing
		public static void ForceCampaignSelectScreen();//native          ForceCampaignSelectScreen takes nothing returns nothing
		public static void LoadGame(string saveFileName, bool doScoreScreen);//native          LoadGame            takes string saveFileName, boolean doScoreScreen returns nothing
		public static void SaveGame(string saveFileName);//native          SaveGame            takes string saveFileName returns nothing
		public static bool RenameSaveDirectory(string sourceDirName, string destDirName);//native          RenameSaveDirectory takes string sourceDirName, string destDirName returns boolean
		public static bool RemoveSaveDirectory(string sourceDirName);//native          RemoveSaveDirectory takes string sourceDirName returns boolean
		public static bool CopySaveGame(string sourceSaveName, string destSaveName);//native          CopySaveGame        takes string sourceSaveName, string destSaveName returns boolean
		public static bool SaveGameExists(string saveName);//native          SaveGameExists      takes string saveName returns boolean
		public static void SyncSelections();//native          SyncSelections      takes nothing returns nothing
		public static void SetFloatGameState(fgamestate whichFloatGameState, float value);//native          SetFloatGameState   takes fgamestate whichFloatGameState, real value returns nothing
		public static float GetFloatGameState(fgamestate whichFloatGameState);//constant native GetFloatGameState   takes fgamestate whichFloatGameState returns real
		public static void SetIntegerGameState(igamestate whichIntegerGameState, int value);//native          SetIntegerGameState takes igamestate whichIntegerGameState, integer value returns nothing
		public static int GetIntegerGameState(igamestate whichIntegerGameState);//constant native GetIntegerGameState takes igamestate whichIntegerGameState returns integer
		//
		//
		public static void SetTutorialCleared(bool cleared);//native  SetTutorialCleared      takes boolean cleared returns nothing
		public static void SetMissionAvailable(int campaignNumber, int missionNumber, bool available);//native  SetMissionAvailable     takes integer campaignNumber, integer missionNumber, boolean available returns nothing
		public static void SetCampaignAvailable(int campaignNumber, bool available);//native  SetCampaignAvailable    takes integer campaignNumber, boolean available  returns nothing
		public static void SetOpCinematicAvailable(int campaignNumber, bool available);//native  SetOpCinematicAvailable takes integer campaignNumber, boolean available  returns nothing
		public static void SetEdCinematicAvailable(int campaignNumber, bool available);//native  SetEdCinematicAvailable takes integer campaignNumber, boolean available  returns nothing
		public static gamedifficulty GetDefaultDifficulty();//native  GetDefaultDifficulty    takes nothing returns gamedifficulty
		public static void SetDefaultDifficulty(gamedifficulty g);//native  SetDefaultDifficulty    takes gamedifficulty g returns nothing
		public static void SetCustomCampaignButtonVisible(int whichButton, bool visible);//native  SetCustomCampaignButtonVisible  takes integer whichButton, boolean visible returns nothing
		public static bool GetCustomCampaignButtonVisible(int whichButton);//native  GetCustomCampaignButtonVisible  takes integer whichButton returns boolean
		public static void DoNotSaveReplay();//native  DoNotSaveReplay         takes nothing returns nothing
		//
		//
		public static dialog DialogCreate();//native DialogCreate                 takes nothing returns dialog
		public static void DialogDestroy(dialog whichDialog);//native DialogDestroy                takes dialog whichDialog returns nothing
		public static void DialogClear(dialog whichDialog);//native DialogClear                  takes dialog whichDialog returns nothing
		public static void DialogSetMessage(dialog whichDialog, string messageText);//native DialogSetMessage             takes dialog whichDialog, string messageText returns nothing
		public static button DialogAddButton(dialog whichDialog, string buttonText, int hotkey);//native DialogAddButton              takes dialog whichDialog, string buttonText, integer hotkey returns button
		public static button DialogAddQuitButton(dialog whichDialog, bool doScoreScreen, string buttonText, int hotkey);//native DialogAddQuitButton          takes dialog whichDialog, boolean doScoreScreen, string buttonText, integer hotkey returns button
		public static void DialogDisplay(player whichPlayer, dialog whichDialog, bool flag);//native DialogDisplay                takes player whichPlayer, dialog whichDialog, boolean flag returns nothing
		//
		//
		//
		public static bool ReloadGameCachesFromDisk();//native  ReloadGameCachesFromDisk takes nothing returns boolean
		public static gamecache InitGameCache(string campaignFile);//native  InitGameCache    takes string campaignFile returns gamecache
		public static bool SaveGameCache(gamecache whichCache);//native  SaveGameCache    takes gamecache whichCache returns boolean
		public static void StoreInteger(gamecache cache, string missionKey, string key, int value);//native  StoreInteger					takes gamecache cache, string missionKey, string key, integer value returns nothing
		public static void StoreReal(gamecache cache, string missionKey, string key, float value);//native  StoreReal						takes gamecache cache, string missionKey, string key, real value returns nothing
		public static void StoreBoolean(gamecache cache, string missionKey, string key, bool value);//native  StoreBoolean					takes gamecache cache, string missionKey, string key, boolean value returns nothing
		public static bool StoreUnit(gamecache cache, string missionKey, string key, unit whichUnit);//native  StoreUnit						takes gamecache cache, string missionKey, string key, unit whichUnit returns boolean
		public static bool StoreString(gamecache cache, string missionKey, string key, string value);//native  StoreString						takes gamecache cache, string missionKey, string key, string value returns boolean
		public static void SyncStoredInteger(gamecache cache, string missionKey, string key);//native SyncStoredInteger        takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredReal(gamecache cache, string missionKey, string key);//native SyncStoredReal           takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredBoolean(gamecache cache, string missionKey, string key);//native SyncStoredBoolean        takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredUnit(gamecache cache, string missionKey, string key);//native SyncStoredUnit           takes gamecache cache, string missionKey, string key returns nothing
		public static void SyncStoredString(gamecache cache, string missionKey, string key);//native SyncStoredString         takes gamecache cache, string missionKey, string key returns nothing
		public static bool HaveStoredInteger(gamecache cache, string missionKey, string key);//native  HaveStoredInteger					takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredReal(gamecache cache, string missionKey, string key);//native  HaveStoredReal						takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredBoolean(gamecache cache, string missionKey, string key);//native  HaveStoredBoolean					takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredUnit(gamecache cache, string missionKey, string key);//native  HaveStoredUnit						takes gamecache cache, string missionKey, string key returns boolean
		public static bool HaveStoredString(gamecache cache, string missionKey, string key);//native  HaveStoredString					takes gamecache cache, string missionKey, string key returns boolean
		public static void FlushGameCache(gamecache cache);//native  FlushGameCache						takes gamecache cache returns nothing
		public static void FlushStoredMission(gamecache cache, string missionKey);//native  FlushStoredMission					takes gamecache cache, string missionKey returns nothing
		public static void FlushStoredInteger(gamecache cache, string missionKey, string key);//native  FlushStoredInteger					takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredReal(gamecache cache, string missionKey, string key);//native  FlushStoredReal						takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredBoolean(gamecache cache, string missionKey, string key);//native  FlushStoredBoolean					takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredUnit(gamecache cache, string missionKey, string key);//native  FlushStoredUnit						takes gamecache cache, string missionKey, string key returns nothing
		public static void FlushStoredString(gamecache cache, string missionKey, string key);//native  FlushStoredString					takes gamecache cache, string missionKey, string key returns nothing
		//
		public static int GetStoredInteger(gamecache cache, string missionKey, string key);//native  GetStoredInteger				takes gamecache cache, string missionKey, string key returns integer
		public static float GetStoredReal(gamecache cache, string missionKey, string key);//native  GetStoredReal					takes gamecache cache, string missionKey, string key returns real
		public static bool GetStoredBoolean(gamecache cache, string missionKey, string key);//native  GetStoredBoolean				takes gamecache cache, string missionKey, string key returns boolean
		public static string GetStoredString(gamecache cache, string missionKey, string key);//native  GetStoredString					takes gamecache cache, string missionKey, string key returns string
		public static unit RestoreUnit(gamecache cache, string missionKey, string key, player forWhichPlayer, float x, float y, float facing);//native  RestoreUnit						takes gamecache cache, string missionKey, string key, player forWhichPlayer, real x, real y, real facing returns unit
		public static hashtable InitHashtable();//native  InitHashtable    takes nothing returns hashtable
		public static void SaveInteger(hashtable table, int parentKey, int childKey, int value);//native  SaveInteger						takes hashtable table, integer parentKey, integer childKey, integer value returns nothing
		public static void SaveReal(hashtable table, int parentKey, int childKey, float value);//native  SaveReal						takes hashtable table, integer parentKey, integer childKey, real value returns nothing
		public static void SaveBoolean(hashtable table, int parentKey, int childKey, bool value);//native  SaveBoolean						takes hashtable table, integer parentKey, integer childKey, boolean value returns nothing
		public static bool SaveStr(hashtable table, int parentKey, int childKey, string value);//native  SaveStr							takes hashtable table, integer parentKey, integer childKey, string value returns boolean
		public static bool SavePlayerHandle(hashtable table, int parentKey, int childKey, player whichPlayer);//native  SavePlayerHandle				takes hashtable table, integer parentKey, integer childKey, player whichPlayer returns boolean
		public static bool SaveWidgetHandle(hashtable table, int parentKey, int childKey, widget whichWidget);//native  SaveWidgetHandle				takes hashtable table, integer parentKey, integer childKey, widget whichWidget returns boolean
		public static bool SaveDestructableHandle(hashtable table, int parentKey, int childKey, destructable whichDestructable);//native  SaveDestructableHandle			takes hashtable table, integer parentKey, integer childKey, destructable whichDestructable returns boolean
		public static bool SaveItemHandle(hashtable table, int parentKey, int childKey, item whichItem);//native  SaveItemHandle					takes hashtable table, integer parentKey, integer childKey, item whichItem returns boolean
		public static bool SaveUnitHandle(hashtable table, int parentKey, int childKey, unit whichUnit);//native  SaveUnitHandle					takes hashtable table, integer parentKey, integer childKey, unit whichUnit returns boolean
		public static bool SaveAbilityHandle(hashtable table, int parentKey, int childKey, ability whichAbility);//native  SaveAbilityHandle				takes hashtable table, integer parentKey, integer childKey, ability whichAbility returns boolean
		public static bool SaveTimerHandle(hashtable table, int parentKey, int childKey, timer whichTimer);//native  SaveTimerHandle					takes hashtable table, integer parentKey, integer childKey, timer whichTimer returns boolean
		public static bool SaveTriggerHandle(hashtable table, int parentKey, int childKey, trigger whichTrigger);//native  SaveTriggerHandle				takes hashtable table, integer parentKey, integer childKey, trigger whichTrigger returns boolean
		public static bool SaveTriggerConditionHandle(hashtable table, int parentKey, int childKey, triggercondition whichTriggercondition);//native  SaveTriggerConditionHandle		takes hashtable table, integer parentKey, integer childKey, triggercondition whichTriggercondition returns boolean
		public static bool SaveTriggerActionHandle(hashtable table, int parentKey, int childKey, triggeraction whichTriggeraction);//native  SaveTriggerActionHandle			takes hashtable table, integer parentKey, integer childKey, triggeraction whichTriggeraction returns boolean
		public static bool SaveTriggerEventHandle(hashtable table, int parentKey, int childKey, event whichEvent);//native  SaveTriggerEventHandle			takes hashtable table, integer parentKey, integer childKey, event whichEvent returns boolean
		public static bool SaveForceHandle(hashtable table, int parentKey, int childKey, force whichForce);//native  SaveForceHandle					takes hashtable table, integer parentKey, integer childKey, force whichForce returns boolean
		public static bool SaveGroupHandle(hashtable table, int parentKey, int childKey, group whichGroup);//native  SaveGroupHandle					takes hashtable table, integer parentKey, integer childKey, group whichGroup returns boolean
		public static bool SaveLocationHandle(hashtable table, int parentKey, int childKey, location whichLocation);//native  SaveLocationHandle				takes hashtable table, integer parentKey, integer childKey, location whichLocation returns boolean
		public static bool SaveRectHandle(hashtable table, int parentKey, int childKey, rect whichRect);//native  SaveRectHandle					takes hashtable table, integer parentKey, integer childKey, rect whichRect returns boolean
		public static bool SaveBooleanExprHandle(hashtable table, int parentKey, int childKey, boolexpr whichBoolexpr);//native  SaveBooleanExprHandle			takes hashtable table, integer parentKey, integer childKey, boolexpr whichBoolexpr returns boolean
		public static bool SaveSoundHandle(hashtable table, int parentKey, int childKey, sound whichSound);//native  SaveSoundHandle					takes hashtable table, integer parentKey, integer childKey, sound whichSound returns boolean
		public static bool SaveEffectHandle(hashtable table, int parentKey, int childKey, effect whichEffect);//native  SaveEffectHandle				takes hashtable table, integer parentKey, integer childKey, effect whichEffect returns boolean
		public static bool SaveUnitPoolHandle(hashtable table, int parentKey, int childKey, unitpool whichUnitpool);//native  SaveUnitPoolHandle				takes hashtable table, integer parentKey, integer childKey, unitpool whichUnitpool returns boolean
		public static bool SaveItemPoolHandle(hashtable table, int parentKey, int childKey, itempool whichItempool);//native  SaveItemPoolHandle				takes hashtable table, integer parentKey, integer childKey, itempool whichItempool returns boolean
		public static bool SaveQuestHandle(hashtable table, int parentKey, int childKey, quest whichQuest);//native  SaveQuestHandle					takes hashtable table, integer parentKey, integer childKey, quest whichQuest returns boolean
		public static bool SaveQuestItemHandle(hashtable table, int parentKey, int childKey, questitem whichQuestitem);//native  SaveQuestItemHandle				takes hashtable table, integer parentKey, integer childKey, questitem whichQuestitem returns boolean
		public static bool SaveDefeatConditionHandle(hashtable table, int parentKey, int childKey, defeatcondition whichDefeatcondition);//native  SaveDefeatConditionHandle		takes hashtable table, integer parentKey, integer childKey, defeatcondition whichDefeatcondition returns boolean
		public static bool SaveTimerDialogHandle(hashtable table, int parentKey, int childKey, timerdialog whichTimerdialog);//native  SaveTimerDialogHandle			takes hashtable table, integer parentKey, integer childKey, timerdialog whichTimerdialog returns boolean
		public static bool SaveLeaderboardHandle(hashtable table, int parentKey, int childKey, leaderboard whichLeaderboard);//native  SaveLeaderboardHandle			takes hashtable table, integer parentKey, integer childKey, leaderboard whichLeaderboard returns boolean
		public static bool SaveMultiboardHandle(hashtable table, int parentKey, int childKey, multiboard whichMultiboard);//native  SaveMultiboardHandle			takes hashtable table, integer parentKey, integer childKey, multiboard whichMultiboard returns boolean
		public static bool SaveMultiboardItemHandle(hashtable table, int parentKey, int childKey, multiboarditem whichMultiboarditem);//native  SaveMultiboardItemHandle		takes hashtable table, integer parentKey, integer childKey, multiboarditem whichMultiboarditem returns boolean
		public static bool SaveTrackableHandle(hashtable table, int parentKey, int childKey, trackable whichTrackable);//native  SaveTrackableHandle				takes hashtable table, integer parentKey, integer childKey, trackable whichTrackable returns boolean
		public static bool SaveDialogHandle(hashtable table, int parentKey, int childKey, dialog whichDialog);//native  SaveDialogHandle				takes hashtable table, integer parentKey, integer childKey, dialog whichDialog returns boolean
		public static bool SaveButtonHandle(hashtable table, int parentKey, int childKey, button whichButton);//native  SaveButtonHandle				takes hashtable table, integer parentKey, integer childKey, button whichButton returns boolean
		public static bool SaveTextTagHandle(hashtable table, int parentKey, int childKey, texttag whichTexttag);//native  SaveTextTagHandle				takes hashtable table, integer parentKey, integer childKey, texttag whichTexttag returns boolean
		public static bool SaveLightningHandle(hashtable table, int parentKey, int childKey, lightning whichLightning);//native  SaveLightningHandle				takes hashtable table, integer parentKey, integer childKey, lightning whichLightning returns boolean
		public static bool SaveImageHandle(hashtable table, int parentKey, int childKey, image whichImage);//native  SaveImageHandle					takes hashtable table, integer parentKey, integer childKey, image whichImage returns boolean
		public static bool SaveUbersplatHandle(hashtable table, int parentKey, int childKey, ubersplat whichUbersplat);//native  SaveUbersplatHandle				takes hashtable table, integer parentKey, integer childKey, ubersplat whichUbersplat returns boolean
		public static bool SaveRegionHandle(hashtable table, int parentKey, int childKey, region whichRegion);//native  SaveRegionHandle				takes hashtable table, integer parentKey, integer childKey, region whichRegion returns boolean
		public static bool SaveFogStateHandle(hashtable table, int parentKey, int childKey, fogstate whichFogState);//native  SaveFogStateHandle				takes hashtable table, integer parentKey, integer childKey, fogstate whichFogState returns boolean
		public static bool SaveFogModifierHandle(hashtable table, int parentKey, int childKey, fogmodifier whichFogModifier);//native  SaveFogModifierHandle			takes hashtable table, integer parentKey, integer childKey, fogmodifier whichFogModifier returns boolean
		public static bool SaveAgentHandle(hashtable table, int parentKey, int childKey, agent whichAgent);//native  SaveAgentHandle					takes hashtable table, integer parentKey, integer childKey, agent whichAgent returns boolean
		public static bool SaveHashtableHandle(hashtable table, int parentKey, int childKey, hashtable whichHashtable);//native  SaveHashtableHandle				takes hashtable table, integer parentKey, integer childKey, hashtable whichHashtable returns boolean
		public static int LoadInteger(hashtable table, int parentKey, int childKey);//native  LoadInteger					takes hashtable table, integer parentKey, integer childKey returns integer
		public static float LoadReal(hashtable table, int parentKey, int childKey);//native  LoadReal					takes hashtable table, integer parentKey, integer childKey returns real
		public static bool LoadBoolean(hashtable table, int parentKey, int childKey);//native  LoadBoolean				    takes hashtable table, integer parentKey, integer childKey returns boolean
		public static string LoadStr(hashtable table, int parentKey, int childKey);//native  LoadStr 					takes hashtable table, integer parentKey, integer childKey returns string
		public static player LoadPlayerHandle(hashtable table, int parentKey, int childKey);//native  LoadPlayerHandle			takes hashtable table, integer parentKey, integer childKey returns player
		public static widget LoadWidgetHandle(hashtable table, int parentKey, int childKey);//native  LoadWidgetHandle			takes hashtable table, integer parentKey, integer childKey returns widget
		public static destructable LoadDestructableHandle(hashtable table, int parentKey, int childKey);//native  LoadDestructableHandle		takes hashtable table, integer parentKey, integer childKey returns destructable
		public static item LoadItemHandle(hashtable table, int parentKey, int childKey);//native  LoadItemHandle				takes hashtable table, integer parentKey, integer childKey returns item
		public static unit LoadUnitHandle(hashtable table, int parentKey, int childKey);//native  LoadUnitHandle				takes hashtable table, integer parentKey, integer childKey returns unit
		public static ability LoadAbilityHandle(hashtable table, int parentKey, int childKey);//native  LoadAbilityHandle			takes hashtable table, integer parentKey, integer childKey returns ability
		public static timer LoadTimerHandle(hashtable table, int parentKey, int childKey);//native  LoadTimerHandle				takes hashtable table, integer parentKey, integer childKey returns timer
		public static trigger LoadTriggerHandle(hashtable table, int parentKey, int childKey);//native  LoadTriggerHandle			takes hashtable table, integer parentKey, integer childKey returns trigger
		public static triggercondition LoadTriggerConditionHandle(hashtable table, int parentKey, int childKey);//native  LoadTriggerConditionHandle	takes hashtable table, integer parentKey, integer childKey returns triggercondition
		public static triggeraction LoadTriggerActionHandle(hashtable table, int parentKey, int childKey);//native  LoadTriggerActionHandle		takes hashtable table, integer parentKey, integer childKey returns triggeraction
		public static event LoadTriggerEventHandle(hashtable table, int parentKey, int childKey);//native  LoadTriggerEventHandle		takes hashtable table, integer parentKey, integer childKey returns event
		public static force LoadForceHandle(hashtable table, int parentKey, int childKey);//native  LoadForceHandle				takes hashtable table, integer parentKey, integer childKey returns force
		public static group LoadGroupHandle(hashtable table, int parentKey, int childKey);//native  LoadGroupHandle				takes hashtable table, integer parentKey, integer childKey returns group
		public static location LoadLocationHandle(hashtable table, int parentKey, int childKey);//native  LoadLocationHandle			takes hashtable table, integer parentKey, integer childKey returns location
		public static rect LoadRectHandle(hashtable table, int parentKey, int childKey);//native  LoadRectHandle				takes hashtable table, integer parentKey, integer childKey returns rect
		public static boolexpr LoadBooleanExprHandle(hashtable table, int parentKey, int childKey);//native  LoadBooleanExprHandle		takes hashtable table, integer parentKey, integer childKey returns boolexpr
		public static sound LoadSoundHandle(hashtable table, int parentKey, int childKey);//native  LoadSoundHandle				takes hashtable table, integer parentKey, integer childKey returns sound
		public static effect LoadEffectHandle(hashtable table, int parentKey, int childKey);//native  LoadEffectHandle			takes hashtable table, integer parentKey, integer childKey returns effect
		public static unitpool LoadUnitPoolHandle(hashtable table, int parentKey, int childKey);//native  LoadUnitPoolHandle			takes hashtable table, integer parentKey, integer childKey returns unitpool
		public static itempool LoadItemPoolHandle(hashtable table, int parentKey, int childKey);//native  LoadItemPoolHandle			takes hashtable table, integer parentKey, integer childKey returns itempool
		public static quest LoadQuestHandle(hashtable table, int parentKey, int childKey);//native  LoadQuestHandle				takes hashtable table, integer parentKey, integer childKey returns quest
		public static questitem LoadQuestItemHandle(hashtable table, int parentKey, int childKey);//native  LoadQuestItemHandle			takes hashtable table, integer parentKey, integer childKey returns questitem
		public static defeatcondition LoadDefeatConditionHandle(hashtable table, int parentKey, int childKey);//native  LoadDefeatConditionHandle	takes hashtable table, integer parentKey, integer childKey returns defeatcondition
		public static timerdialog LoadTimerDialogHandle(hashtable table, int parentKey, int childKey);//native  LoadTimerDialogHandle		takes hashtable table, integer parentKey, integer childKey returns timerdialog
		public static leaderboard LoadLeaderboardHandle(hashtable table, int parentKey, int childKey);//native  LoadLeaderboardHandle		takes hashtable table, integer parentKey, integer childKey returns leaderboard
		public static multiboard LoadMultiboardHandle(hashtable table, int parentKey, int childKey);//native  LoadMultiboardHandle		takes hashtable table, integer parentKey, integer childKey returns multiboard
		public static multiboarditem LoadMultiboardItemHandle(hashtable table, int parentKey, int childKey);//native  LoadMultiboardItemHandle	takes hashtable table, integer parentKey, integer childKey returns multiboarditem
		public static trackable LoadTrackableHandle(hashtable table, int parentKey, int childKey);//native  LoadTrackableHandle			takes hashtable table, integer parentKey, integer childKey returns trackable
		public static dialog LoadDialogHandle(hashtable table, int parentKey, int childKey);//native  LoadDialogHandle			takes hashtable table, integer parentKey, integer childKey returns dialog
		public static button LoadButtonHandle(hashtable table, int parentKey, int childKey);//native  LoadButtonHandle			takes hashtable table, integer parentKey, integer childKey returns button
		public static texttag LoadTextTagHandle(hashtable table, int parentKey, int childKey);//native  LoadTextTagHandle			takes hashtable table, integer parentKey, integer childKey returns texttag
		public static lightning LoadLightningHandle(hashtable table, int parentKey, int childKey);//native  LoadLightningHandle			takes hashtable table, integer parentKey, integer childKey returns lightning
		public static image LoadImageHandle(hashtable table, int parentKey, int childKey);//native  LoadImageHandle				takes hashtable table, integer parentKey, integer childKey returns image
		public static ubersplat LoadUbersplatHandle(hashtable table, int parentKey, int childKey);//native  LoadUbersplatHandle			takes hashtable table, integer parentKey, integer childKey returns ubersplat
		public static region LoadRegionHandle(hashtable table, int parentKey, int childKey);//native  LoadRegionHandle			takes hashtable table, integer parentKey, integer childKey returns region
		public static fogstate LoadFogStateHandle(hashtable table, int parentKey, int childKey);//native  LoadFogStateHandle			takes hashtable table, integer parentKey, integer childKey returns fogstate
		public static fogmodifier LoadFogModifierHandle(hashtable table, int parentKey, int childKey);//native  LoadFogModifierHandle		takes hashtable table, integer parentKey, integer childKey returns fogmodifier
		public static hashtable LoadHashtableHandle(hashtable table, int parentKey, int childKey);//native  LoadHashtableHandle			takes hashtable table, integer parentKey, integer childKey returns hashtable
		public static bool HaveSavedInteger(hashtable table, int parentKey, int childKey);//native  HaveSavedInteger					takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedReal(hashtable table, int parentKey, int childKey);//native  HaveSavedReal						takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedBoolean(hashtable table, int parentKey, int childKey);//native  HaveSavedBoolean					takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedString(hashtable table, int parentKey, int childKey);//native  HaveSavedString					    takes hashtable table, integer parentKey, integer childKey returns boolean
		public static bool HaveSavedHandle(hashtable table, int parentKey, int childKey);//native  HaveSavedHandle     				takes hashtable table, integer parentKey, integer childKey returns boolean
		public static void RemoveSavedInteger(hashtable table, int parentKey, int childKey);//native  RemoveSavedInteger					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedReal(hashtable table, int parentKey, int childKey);//native  RemoveSavedReal						takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedBoolean(hashtable table, int parentKey, int childKey);//native  RemoveSavedBoolean					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedString(hashtable table, int parentKey, int childKey);//native  RemoveSavedString					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void RemoveSavedHandle(hashtable table, int parentKey, int childKey);//native  RemoveSavedHandle					takes hashtable table, integer parentKey, integer childKey returns nothing
		public static void FlushParentHashtable(hashtable table);//native  FlushParentHashtable						takes hashtable table returns nothing
		public static void FlushChildHashtable(hashtable table, int parentKey);//native  FlushChildHashtable					takes hashtable table, integer parentKey returns nothing
		//
		//
		public static int GetRandomInt(int lowBound, int highBound);//native GetRandomInt takes integer lowBound, integer highBound returns integer
		public static float GetRandomReal(float lowBound, float highBound);//native GetRandomReal takes real lowBound, real highBound returns real
		public static unitpool CreateUnitPool();//native CreateUnitPool           takes nothing returns unitpool
		public static void DestroyUnitPool(unitpool whichPool);//native DestroyUnitPool          takes unitpool whichPool returns nothing
		public static void UnitPoolAddUnitType(unitpool whichPool, int unitId, float weight);//native UnitPoolAddUnitType      takes unitpool whichPool, integer unitId, real weight returns nothing
		public static void UnitPoolRemoveUnitType(unitpool whichPool, int unitId);//native UnitPoolRemoveUnitType   takes unitpool whichPool, integer unitId returns nothing
		public static unit PlaceRandomUnit(unitpool whichPool, player forWhichPlayer, float x, float y, float facing);//native PlaceRandomUnit          takes unitpool whichPool, player forWhichPlayer, real x, real y, real facing returns unit
		public static itempool CreateItemPool();//native CreateItemPool           takes nothing returns itempool
		public static void DestroyItemPool(itempool whichItemPool);//native DestroyItemPool          takes itempool whichItemPool returns nothing
		public static void ItemPoolAddItemType(itempool whichItemPool, int itemId, float weight);//native ItemPoolAddItemType      takes itempool whichItemPool, integer itemId, real weight returns nothing
		public static void ItemPoolRemoveItemType(itempool whichItemPool, int itemId);//native ItemPoolRemoveItemType   takes itempool whichItemPool, integer itemId returns nothing
		public static item PlaceRandomItem(itempool whichItemPool, float x, float y);//native PlaceRandomItem          takes itempool whichItemPool, real x, real y returns item
		//
		public static int ChooseRandomCreep(int level);//native ChooseRandomCreep        takes integer level returns integer
		public static int ChooseRandomNPBuilding();//native ChooseRandomNPBuilding   takes nothing returns integer
		public static int ChooseRandomItem(int level);//native ChooseRandomItem         takes integer level returns integer
		public static int ChooseRandomItemEx(itemtype whichType, int level);//native ChooseRandomItemEx       takes itemtype whichType, integer level returns integer
		public static void SetRandomSeed(int seed);//native SetRandomSeed            takes integer seed returns nothing
		//
		//
		public static void SetTerrainFog(float a, float b, float c, float d, float e);//native SetTerrainFog                takes real a, real b, real c, real d, real e returns nothing
		public static void ResetTerrainFog();//native ResetTerrainFog              takes nothing returns nothing
		public static void SetUnitFog(float a, float b, float c, float d, float e);//native SetUnitFog                   takes real a, real b, real c, real d, real e returns nothing
		public static void SetTerrainFogEx(int style, float zstart, float zend, float density, float red, float green, float blue);//native SetTerrainFogEx              takes integer style, real zstart, real zend, real density, real red, real green, real blue returns nothing
		public static void DisplayTextToPlayer(player toPlayer, float x, float y, string message);//native DisplayTextToPlayer          takes player toPlayer, real x, real y, string message returns nothing
		public static void DisplayTimedTextToPlayer(player toPlayer, float x, float y, float duration, string message);//native DisplayTimedTextToPlayer     takes player toPlayer, real x, real y, real duration, string message returns nothing
		public static void DisplayTimedTextFromPlayer(player toPlayer, float x, float y, float duration, string message);//native DisplayTimedTextFromPlayer   takes player toPlayer, real x, real y, real duration, string message returns nothing
		public static void ClearTextMessages();//native ClearTextMessages            takes nothing returns nothing
		public static void SetDayNightModels(string terrainDNCFile, string unitDNCFile);//native SetDayNightModels            takes string terrainDNCFile, string unitDNCFile returns nothing
		public static void SetSkyModel(string skyModelFile);//native SetSkyModel                  takes string skyModelFile returns nothing
		public static void EnableUserControl(bool b);//native EnableUserControl            takes boolean b returns nothing
		public static void EnableUserUI(bool b);//native EnableUserUI                 takes boolean b returns nothing
		public static void SuspendTimeOfDay(bool b);//native SuspendTimeOfDay             takes boolean b returns nothing
		public static void SetTimeOfDayScale(float r);//native SetTimeOfDayScale            takes real r returns nothing
		public static float GetTimeOfDayScale();//native GetTimeOfDayScale            takes nothing returns real
		public static void ShowInterface(bool flag, float fadeDuration);//native ShowInterface                takes boolean flag, real fadeDuration returns nothing
		public static void PauseGame(bool flag);//native PauseGame                    takes boolean flag returns nothing
		public static void UnitAddIndicator(unit whichUnit, int red, int green, int blue, int alpha);//native UnitAddIndicator             takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
		public static void AddIndicator(widget whichWidget, int red, int green, int blue, int alpha);//native AddIndicator                 takes widget whichWidget, integer red, integer green, integer blue, integer alpha returns nothing
		public static void PingMinimap(float x, float y, float duration);//native PingMinimap                  takes real x, real y, real duration returns nothing
		public static void PingMinimapEx(float x, float y, float duration, int red, int green, int blue, bool extraEffects);//native PingMinimapEx                takes real x, real y, real duration, integer red, integer green, integer blue, boolean extraEffects returns nothing
		public static void EnableOcclusion(bool flag);//native EnableOcclusion              takes boolean flag returns nothing
		public static void SetIntroShotText(string introText);//native SetIntroShotText             takes string introText returns nothing
		public static void SetIntroShotModel(string introModelPath);//native SetIntroShotModel            takes string introModelPath returns nothing
		public static void EnableWorldFogBoundary(bool b);//native EnableWorldFogBoundary       takes boolean b returns nothing
		public static void PlayModelCinematic(string modelName);//native PlayModelCinematic           takes string modelName returns nothing
		public static void PlayCinematic(string movieName);//native PlayCinematic                takes string movieName returns nothing
		public static void ForceUIKey(string key);//native ForceUIKey                   takes string key returns nothing
		public static void ForceUICancel();//native ForceUICancel                takes nothing returns nothing
		public static void DisplayLoadDialog();//native DisplayLoadDialog            takes nothing returns nothing
		public static void SetAltMinimapIcon(string iconPath);//native SetAltMinimapIcon            takes string iconPath returns nothing
		public static void DisableRestartMission(bool flag);//native DisableRestartMission        takes boolean flag returns nothing
		public static texttag CreateTextTag();//native CreateTextTag                takes nothing returns texttag
		public static void DestroyTextTag(texttag t);//native DestroyTextTag               takes texttag t returns nothing
		public static void SetTextTagText(texttag t, string s, float height);//native SetTextTagText               takes texttag t, string s, real height returns nothing
		public static void SetTextTagPos(texttag t, float x, float y, float heightOffset);//native SetTextTagPos                takes texttag t, real x, real y, real heightOffset returns nothing
		public static void SetTextTagPosUnit(texttag t, unit whichUnit, float heightOffset);//native SetTextTagPosUnit            takes texttag t, unit whichUnit, real heightOffset returns nothing
		public static void SetTextTagColor(texttag t, int red, int green, int blue, int alpha);//native SetTextTagColor              takes texttag t, integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetTextTagVelocity(texttag t, float xvel, float yvel);//native SetTextTagVelocity           takes texttag t, real xvel, real yvel returns nothing
		public static void SetTextTagVisibility(texttag t, bool flag);//native SetTextTagVisibility         takes texttag t, boolean flag returns nothing
		public static void SetTextTagSuspended(texttag t, bool flag);//native SetTextTagSuspended          takes texttag t, boolean flag returns nothing
		public static void SetTextTagPermanent(texttag t, bool flag);//native SetTextTagPermanent          takes texttag t, boolean flag returns nothing
		public static void SetTextTagAge(texttag t, float age);//native SetTextTagAge                takes texttag t, real age returns nothing
		public static void SetTextTagLifespan(texttag t, float lifespan);//native SetTextTagLifespan           takes texttag t, real lifespan returns nothing
		public static void SetTextTagFadepoint(texttag t, float fadepoint);//native SetTextTagFadepoint          takes texttag t, real fadepoint returns nothing
		public static void SetReservedLocalHeroButtons(int reserved);//native SetReservedLocalHeroButtons  takes integer reserved returns nothing
		public static int GetAllyColorFilterState();//native GetAllyColorFilterState      takes nothing returns integer
		public static void SetAllyColorFilterState(int state);//native SetAllyColorFilterState      takes integer state returns nothing
		public static bool GetCreepCampFilterState();//native GetCreepCampFilterState      takes nothing returns boolean
		public static void SetCreepCampFilterState(bool state);//native SetCreepCampFilterState      takes boolean state returns nothing
		public static void EnableMinimapFilterButtons(bool enableAlly, bool enableCreep);//native EnableMinimapFilterButtons   takes boolean enableAlly, boolean enableCreep returns nothing
		public static void EnableDragSelect(bool state, bool ui);//native EnableDragSelect             takes boolean state, boolean ui returns nothing
		public static void EnablePreSelect(bool state, bool ui);//native EnablePreSelect              takes boolean state, boolean ui returns nothing
		public static void EnableSelect(bool state, bool ui);//native EnableSelect                 takes boolean state, boolean ui returns nothing
		//
		//
		public static trackable CreateTrackable(string trackableModelPath, float x, float y, float facing);//native CreateTrackable      takes string trackableModelPath, real x, real y, real facing returns trackable
		//
		//
		public static quest CreateQuest();//native CreateQuest          takes nothing returns quest
		public static void DestroyQuest(quest whichQuest);//native DestroyQuest         takes quest whichQuest returns nothing
		public static void QuestSetTitle(quest whichQuest, string title);//native QuestSetTitle        takes quest whichQuest, string title returns nothing
		public static void QuestSetDescription(quest whichQuest, string description);//native QuestSetDescription  takes quest whichQuest, string description returns nothing
		public static void QuestSetIconPath(quest whichQuest, string iconPath);//native QuestSetIconPath     takes quest whichQuest, string iconPath returns nothing
		public static void QuestSetRequired(quest whichQuest, bool required);//native QuestSetRequired     takes quest whichQuest, boolean required   returns nothing
		public static void QuestSetCompleted(quest whichQuest, bool completed);//native QuestSetCompleted    takes quest whichQuest, boolean completed  returns nothing
		public static void QuestSetDiscovered(quest whichQuest, bool discovered);//native QuestSetDiscovered   takes quest whichQuest, boolean discovered returns nothing
		public static void QuestSetFailed(quest whichQuest, bool failed);//native QuestSetFailed       takes quest whichQuest, boolean failed     returns nothing
		public static void QuestSetEnabled(quest whichQuest, bool enabled);//native QuestSetEnabled      takes quest whichQuest, boolean enabled    returns nothing
		public static bool IsQuestRequired(quest whichQuest);//native IsQuestRequired     takes quest whichQuest returns boolean
		public static bool IsQuestCompleted(quest whichQuest);//native IsQuestCompleted    takes quest whichQuest returns boolean
		public static bool IsQuestDiscovered(quest whichQuest);//native IsQuestDiscovered   takes quest whichQuest returns boolean
		public static bool IsQuestFailed(quest whichQuest);//native IsQuestFailed       takes quest whichQuest returns boolean
		public static bool IsQuestEnabled(quest whichQuest);//native IsQuestEnabled      takes quest whichQuest returns boolean
		public static questitem QuestCreateItem(quest whichQuest);//native QuestCreateItem          takes quest whichQuest returns questitem
		public static void QuestItemSetDescription(questitem whichQuestItem, string description);//native QuestItemSetDescription  takes questitem whichQuestItem, string description returns nothing
		public static void QuestItemSetCompleted(questitem whichQuestItem, bool completed);//native QuestItemSetCompleted    takes questitem whichQuestItem, boolean completed returns nothing
		public static bool IsQuestItemCompleted(questitem whichQuestItem);//native IsQuestItemCompleted     takes questitem whichQuestItem returns boolean
		public static defeatcondition CreateDefeatCondition();//native CreateDefeatCondition            takes nothing returns defeatcondition
		public static void DestroyDefeatCondition(defeatcondition whichCondition);//native DestroyDefeatCondition           takes defeatcondition whichCondition returns nothing
		public static void DefeatConditionSetDescription(defeatcondition whichCondition, string description);//native DefeatConditionSetDescription    takes defeatcondition whichCondition, string description returns nothing
		public static void FlashQuestDialogButton();//native FlashQuestDialogButton   takes nothing returns nothing
		public static void ForceQuestDialogUpdate();//native ForceQuestDialogUpdate   takes nothing returns nothing
		//
		//
		public static timerdialog CreateTimerDialog(timer t);//native CreateTimerDialog                takes timer t returns timerdialog
		public static void DestroyTimerDialog(timerdialog whichDialog);//native DestroyTimerDialog               takes timerdialog whichDialog returns nothing
		public static void TimerDialogSetTitle(timerdialog whichDialog, string title);//native TimerDialogSetTitle              takes timerdialog whichDialog, string title returns nothing
		public static void TimerDialogSetTitleColor(timerdialog whichDialog, int red, int green, int blue, int alpha);//native TimerDialogSetTitleColor         takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
		public static void TimerDialogSetTimeColor(timerdialog whichDialog, int red, int green, int blue, int alpha);//native TimerDialogSetTimeColor          takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
		public static void TimerDialogSetSpeed(timerdialog whichDialog, float speedMultFactor);//native TimerDialogSetSpeed              takes timerdialog whichDialog, real speedMultFactor returns nothing
		public static void TimerDialogDisplay(timerdialog whichDialog, bool display);//native TimerDialogDisplay               takes timerdialog whichDialog, boolean display returns nothing
		public static bool IsTimerDialogDisplayed(timerdialog whichDialog);//native IsTimerDialogDisplayed           takes timerdialog whichDialog returns boolean
		public static void TimerDialogSetRealTimeRemaining(timerdialog whichDialog, float timeRemaining);//native TimerDialogSetRealTimeRemaining  takes timerdialog whichDialog, real timeRemaining returns nothing
		//
		//
		//
		public static leaderboard CreateLeaderboard();//native CreateLeaderboard                takes nothing returns leaderboard
		public static void DestroyLeaderboard(leaderboard lb);//native DestroyLeaderboard               takes leaderboard lb returns nothing
		public static void LeaderboardDisplay(leaderboard lb, bool show);//native LeaderboardDisplay               takes leaderboard lb, boolean show returns nothing
		public static bool IsLeaderboardDisplayed(leaderboard lb);//native IsLeaderboardDisplayed           takes leaderboard lb returns boolean
		public static int LeaderboardGetItemCount(leaderboard lb);//native LeaderboardGetItemCount          takes leaderboard lb returns integer
		public static void LeaderboardSetSizeByItemCount(leaderboard lb, int count);//native LeaderboardSetSizeByItemCount    takes leaderboard lb, integer count returns nothing
		public static void LeaderboardAddItem(leaderboard lb, string label, int value, player p);//native LeaderboardAddItem               takes leaderboard lb, string label, integer value, player p returns nothing
		public static void LeaderboardRemoveItem(leaderboard lb, int index);//native LeaderboardRemoveItem            takes leaderboard lb, integer index returns nothing
		public static void LeaderboardRemovePlayerItem(leaderboard lb, player p);//native LeaderboardRemovePlayerItem      takes leaderboard lb, player p returns nothing
		public static void LeaderboardClear(leaderboard lb);//native LeaderboardClear                 takes leaderboard lb returns nothing
		public static void LeaderboardSortItemsByValue(leaderboard lb, bool ascending);//native LeaderboardSortItemsByValue      takes leaderboard lb, boolean ascending returns nothing
		public static void LeaderboardSortItemsByPlayer(leaderboard lb, bool ascending);//native LeaderboardSortItemsByPlayer     takes leaderboard lb, boolean ascending returns nothing
		public static void LeaderboardSortItemsByLabel(leaderboard lb, bool ascending);//native LeaderboardSortItemsByLabel      takes leaderboard lb, boolean ascending returns nothing
		public static bool LeaderboardHasPlayerItem(leaderboard lb, player p);//native LeaderboardHasPlayerItem         takes leaderboard lb, player p returns boolean
		public static int LeaderboardGetPlayerIndex(leaderboard lb, player p);//native LeaderboardGetPlayerIndex        takes leaderboard lb, player p returns integer
		public static void LeaderboardSetLabel(leaderboard lb, string label);//native LeaderboardSetLabel              takes leaderboard lb, string label returns nothing
		public static string LeaderboardGetLabelText(leaderboard lb);//native LeaderboardGetLabelText          takes leaderboard lb returns string
		public static void PlayerSetLeaderboard(player toPlayer, leaderboard lb);//native PlayerSetLeaderboard             takes player toPlayer, leaderboard lb returns nothing
		public static leaderboard PlayerGetLeaderboard(player toPlayer);//native PlayerGetLeaderboard             takes player toPlayer returns leaderboard
		public static void LeaderboardSetLabelColor(leaderboard lb, int red, int green, int blue, int alpha);//native LeaderboardSetLabelColor         takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static void LeaderboardSetValueColor(leaderboard lb, int red, int green, int blue, int alpha);//native LeaderboardSetValueColor         takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static void LeaderboardSetStyle(leaderboard lb, bool showLabel, bool showNames, bool showValues, bool showIcons);//native LeaderboardSetStyle              takes leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons returns nothing
		public static void LeaderboardSetItemValue(leaderboard lb, int whichItem, int val);//native LeaderboardSetItemValue          takes leaderboard lb, integer whichItem, integer val returns nothing
		public static void LeaderboardSetItemLabel(leaderboard lb, int whichItem, string val);//native LeaderboardSetItemLabel          takes leaderboard lb, integer whichItem, string val returns nothing
		public static void LeaderboardSetItemStyle(leaderboard lb, int whichItem, bool showLabel, bool showValue, bool showIcon);//native LeaderboardSetItemStyle          takes leaderboard lb, integer whichItem, boolean showLabel, boolean showValue, boolean showIcon returns nothing
		public static void LeaderboardSetItemLabelColor(leaderboard lb, int whichItem, int red, int green, int blue, int alpha);//native LeaderboardSetItemLabelColor     takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
		public static void LeaderboardSetItemValueColor(leaderboard lb, int whichItem, int red, int green, int blue, int alpha);//native LeaderboardSetItemValueColor     takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
		//
		//
		//
		//
		public static multiboard CreateMultiboard();//native CreateMultiboard                 takes nothing returns multiboard
		public static void DestroyMultiboard(multiboard lb);//native DestroyMultiboard                takes multiboard lb returns nothing
		public static void MultiboardDisplay(multiboard lb, bool show);//native MultiboardDisplay                takes multiboard lb, boolean show returns nothing
		public static bool IsMultiboardDisplayed(multiboard lb);//native IsMultiboardDisplayed            takes multiboard lb returns boolean
		public static void MultiboardMinimize(multiboard lb, bool minimize);//native MultiboardMinimize               takes multiboard lb, boolean minimize returns nothing
		public static bool IsMultiboardMinimized(multiboard lb);//native IsMultiboardMinimized            takes multiboard lb returns boolean
		public static void MultiboardClear(multiboard lb);//native MultiboardClear                  takes multiboard lb returns nothing
		public static void MultiboardSetTitleText(multiboard lb, string label);//native MultiboardSetTitleText           takes multiboard lb, string label returns nothing
		public static string MultiboardGetTitleText(multiboard lb);//native MultiboardGetTitleText           takes multiboard lb returns string
		public static void MultiboardSetTitleTextColor(multiboard lb, int red, int green, int blue, int alpha);//native MultiboardSetTitleTextColor      takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static int MultiboardGetRowCount(multiboard lb);//native MultiboardGetRowCount            takes multiboard lb returns integer
		public static int MultiboardGetColumnCount(multiboard lb);//native MultiboardGetColumnCount         takes multiboard lb returns integer
		public static void MultiboardSetColumnCount(multiboard lb, int count);//native MultiboardSetColumnCount         takes multiboard lb, integer count returns nothing
		public static void MultiboardSetRowCount(multiboard lb, int count);//native MultiboardSetRowCount            takes multiboard lb, integer count returns nothing
		//
		public static void MultiboardSetItemsStyle(multiboard lb, bool showValues, bool showIcons);//native MultiboardSetItemsStyle          takes multiboard lb, boolean showValues, boolean showIcons returns nothing
		public static void MultiboardSetItemsValue(multiboard lb, string value);//native MultiboardSetItemsValue          takes multiboard lb, string value returns nothing
		public static void MultiboardSetItemsValueColor(multiboard lb, int red, int green, int blue, int alpha);//native MultiboardSetItemsValueColor     takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
		public static void MultiboardSetItemsWidth(multiboard lb, float width);//native MultiboardSetItemsWidth          takes multiboard lb, real width returns nothing
		public static void MultiboardSetItemsIcon(multiboard lb, string iconPath);//native MultiboardSetItemsIcon           takes multiboard lb, string iconPath returns nothing
		//
		public static multiboarditem MultiboardGetItem(multiboard lb, int row, int column);//native MultiboardGetItem                takes multiboard lb, integer row, integer column returns multiboarditem
		public static void MultiboardReleaseItem(multiboarditem mbi);//native MultiboardReleaseItem            takes multiboarditem mbi returns nothing
		public static void MultiboardSetItemStyle(multiboarditem mbi, bool showValue, bool showIcon);//native MultiboardSetItemStyle           takes multiboarditem mbi, boolean showValue, boolean showIcon returns nothing
		public static void MultiboardSetItemValue(multiboarditem mbi, string val);//native MultiboardSetItemValue           takes multiboarditem mbi, string val returns nothing
		public static void MultiboardSetItemValueColor(multiboarditem mbi, int red, int green, int blue, int alpha);//native MultiboardSetItemValueColor      takes multiboarditem mbi, integer red, integer green, integer blue, integer alpha returns nothing
		public static void MultiboardSetItemWidth(multiboarditem mbi, float width);//native MultiboardSetItemWidth           takes multiboarditem mbi, real width returns nothing
		public static void MultiboardSetItemIcon(multiboarditem mbi, string iconFileName);//native MultiboardSetItemIcon            takes multiboarditem mbi, string iconFileName returns nothing
		//
		//
		//
		public static void MultiboardSuppressDisplay(bool flag);//native MultiboardSuppressDisplay        takes boolean flag returns nothing
		//
		//
		public static void SetCameraPosition(float x, float y);//native SetCameraPosition            takes real x, real y returns nothing
		public static void SetCameraQuickPosition(float x, float y);//native SetCameraQuickPosition       takes real x, real y returns nothing
		public static void SetCameraBounds(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);//native SetCameraBounds              takes real x1, real y1, real x2, real y2, real x3, real y3, real x4, real y4 returns nothing
		public static void StopCamera();//native StopCamera                   takes nothing returns nothing
		public static void ResetToGameCamera(float duration);//native ResetToGameCamera            takes real duration returns nothing
		public static void PanCameraTo(float x, float y);//native PanCameraTo                  takes real x, real y returns nothing
		public static void PanCameraToTimed(float x, float y, float duration);//native PanCameraToTimed             takes real x, real y, real duration returns nothing
		public static void PanCameraToWithZ(float x, float y, float zOffsetDest);//native PanCameraToWithZ             takes real x, real y, real zOffsetDest returns nothing
		public static void PanCameraToTimedWithZ(float x, float y, float zOffsetDest, float duration);//native PanCameraToTimedWithZ        takes real x, real y, real zOffsetDest, real duration returns nothing
		public static void SetCinematicCamera(string cameraModelFile);//native SetCinematicCamera           takes string cameraModelFile returns nothing
		public static void SetCameraRotateMode(float x, float y, float radiansToSweep, float duration);//native SetCameraRotateMode          takes real x, real y, real radiansToSweep, real duration returns nothing
		public static void SetCameraField(camerafield whichField, float value, float duration);//native SetCameraField               takes camerafield whichField, real value, real duration returns nothing
		public static void AdjustCameraField(camerafield whichField, float offset, float duration);//native AdjustCameraField            takes camerafield whichField, real offset, real duration returns nothing
		public static void SetCameraTargetController(unit whichUnit, float xoffset, float yoffset, bool inheritOrientation);//native SetCameraTargetController    takes unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation returns nothing
		public static void SetCameraOrientController(unit whichUnit, float xoffset, float yoffset);//native SetCameraOrientController    takes unit whichUnit, real xoffset, real yoffset returns nothing
		public static camerasetup CreateCameraSetup();//native CreateCameraSetup                    takes nothing returns camerasetup
		public static void CameraSetupSetField(camerasetup whichSetup, camerafield whichField, float value, float duration);//native CameraSetupSetField                  takes camerasetup whichSetup, camerafield whichField, real value, real duration returns nothing
		public static float CameraSetupGetField(camerasetup whichSetup, camerafield whichField);//native CameraSetupGetField                  takes camerasetup whichSetup, camerafield whichField returns real
		public static void CameraSetupSetDestPosition(camerasetup whichSetup, float x, float y, float duration);//native CameraSetupSetDestPosition           takes camerasetup whichSetup, real x, real y, real duration returns nothing
		public static location CameraSetupGetDestPositionLoc(camerasetup whichSetup);//native CameraSetupGetDestPositionLoc        takes camerasetup whichSetup returns location
		public static float CameraSetupGetDestPositionX(camerasetup whichSetup);//native CameraSetupGetDestPositionX          takes camerasetup whichSetup returns real
		public static float CameraSetupGetDestPositionY(camerasetup whichSetup);//native CameraSetupGetDestPositionY          takes camerasetup whichSetup returns real
		public static void CameraSetupApply(camerasetup whichSetup, bool doPan, bool panTimed);//native CameraSetupApply                     takes camerasetup whichSetup, boolean doPan, boolean panTimed returns nothing
		public static void CameraSetupApplyWithZ(camerasetup whichSetup, float zDestOffset);//native CameraSetupApplyWithZ                takes camerasetup whichSetup, real zDestOffset returns nothing
		public static void CameraSetupApplyForceDuration(camerasetup whichSetup, bool doPan, float forceDuration);//native CameraSetupApplyForceDuration        takes camerasetup whichSetup, boolean doPan, real forceDuration returns nothing
		public static void CameraSetupApplyForceDurationWithZ(camerasetup whichSetup, float zDestOffset, float forceDuration);//native CameraSetupApplyForceDurationWithZ   takes camerasetup whichSetup, real zDestOffset, real forceDuration returns nothing
		public static void CameraSetTargetNoise(float mag, float velocity);//native CameraSetTargetNoise             takes real mag, real velocity returns nothing
		public static void CameraSetSourceNoise(float mag, float velocity);//native CameraSetSourceNoise             takes real mag, real velocity returns nothing
		public static void CameraSetTargetNoiseEx(float mag, float velocity, bool vertOnly);//native CameraSetTargetNoiseEx           takes real mag, real velocity, boolean vertOnly returns nothing
		public static void CameraSetSourceNoiseEx(float mag, float velocity, bool vertOnly);//native CameraSetSourceNoiseEx           takes real mag, real velocity, boolean vertOnly returns nothing
		public static void CameraSetSmoothingFactor(float factor);//native CameraSetSmoothingFactor         takes real factor returns nothing
		public static void SetCineFilterTexture(string filename);//native SetCineFilterTexture             takes string filename returns nothing
		public static void SetCineFilterBlendMode(blendmode whichMode);//native SetCineFilterBlendMode           takes blendmode whichMode returns nothing
		public static void SetCineFilterTexMapFlags(texmapflags whichFlags);//native SetCineFilterTexMapFlags         takes texmapflags whichFlags returns nothing
		public static void SetCineFilterStartUV(float minu, float minv, float maxu, float maxv);//native SetCineFilterStartUV             takes real minu, real minv, real maxu, real maxv returns nothing
		public static void SetCineFilterEndUV(float minu, float minv, float maxu, float maxv);//native SetCineFilterEndUV               takes real minu, real minv, real maxu, real maxv returns nothing
		public static void SetCineFilterStartColor(int red, int green, int blue, int alpha);//native SetCineFilterStartColor          takes integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetCineFilterEndColor(int red, int green, int blue, int alpha);//native SetCineFilterEndColor            takes integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetCineFilterDuration(float duration);//native SetCineFilterDuration            takes real duration returns nothing
		public static void DisplayCineFilter(bool flag);//native DisplayCineFilter                takes boolean flag returns nothing
		public static bool IsCineFilterDisplayed();//native IsCineFilterDisplayed            takes nothing returns boolean
		public static void SetCinematicScene(int portraitUnitId, playercolor color, string speakerTitle, string text, float sceneDuration, float voiceoverDuration);//native SetCinematicScene                takes integer portraitUnitId, playercolor color, string speakerTitle, string text, real sceneDuration, real voiceoverDuration returns nothing
		public static void EndCinematicScene();//native EndCinematicScene                takes nothing returns nothing
		public static void ForceCinematicSubtitles(bool flag);//native ForceCinematicSubtitles          takes boolean flag returns nothing
		public static float GetCameraMargin(int whichMargin);//native GetCameraMargin                  takes integer whichMargin returns real
		//
		public static float GetCameraBoundMinX();//constant native GetCameraBoundMinX          takes nothing returns real
		public static float GetCameraBoundMinY();//constant native GetCameraBoundMinY          takes nothing returns real
		public static float GetCameraBoundMaxX();//constant native GetCameraBoundMaxX          takes nothing returns real
		public static float GetCameraBoundMaxY();//constant native GetCameraBoundMaxY          takes nothing returns real
		public static float GetCameraField(camerafield whichField);//constant native GetCameraField              takes camerafield whichField returns real
		public static float GetCameraTargetPositionX();//constant native GetCameraTargetPositionX    takes nothing returns real
		public static float GetCameraTargetPositionY();//constant native GetCameraTargetPositionY    takes nothing returns real
		public static float GetCameraTargetPositionZ();//constant native GetCameraTargetPositionZ    takes nothing returns real
		public static location GetCameraTargetPositionLoc();//constant native GetCameraTargetPositionLoc  takes nothing returns location
		public static float GetCameraEyePositionX();//constant native GetCameraEyePositionX       takes nothing returns real
		public static float GetCameraEyePositionY();//constant native GetCameraEyePositionY       takes nothing returns real
		public static float GetCameraEyePositionZ();//constant native GetCameraEyePositionZ       takes nothing returns real
		public static location GetCameraEyePositionLoc();//constant native GetCameraEyePositionLoc     takes nothing returns location
		//
		//
		//
		public static void NewSoundEnvironment(string environmentName);//native NewSoundEnvironment          takes string environmentName returns nothing
		public static sound CreateSound(string fileName, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate, string eaxSetting);//native CreateSound                  takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string eaxSetting returns sound
		public static sound CreateSoundFilenameWithLabel(string fileName, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate, string SLKEntryName);//native CreateSoundFilenameWithLabel takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string SLKEntryName returns sound
		public static sound CreateSoundFromLabel(string soundLabel, bool looping, bool is3D, bool stopwhenoutofrange, int fadeInRate, int fadeOutRate);//native CreateSoundFromLabel         takes string soundLabel, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate returns sound
		public static sound CreateMIDISound(string soundLabel, int fadeInRate, int fadeOutRate);//native CreateMIDISound              takes string soundLabel, integer fadeInRate, integer fadeOutRate returns sound
		public static void SetSoundParamsFromLabel(sound soundHandle, string soundLabel);//native SetSoundParamsFromLabel      takes sound soundHandle, string soundLabel returns nothing
		public static void SetSoundDistanceCutoff(sound soundHandle, float cutoff);//native SetSoundDistanceCutoff       takes sound soundHandle, real cutoff returns nothing
		public static void SetSoundChannel(sound soundHandle, int channel);//native SetSoundChannel              takes sound soundHandle, integer channel returns nothing
		public static void SetSoundVolume(sound soundHandle, int volume);//native SetSoundVolume               takes sound soundHandle, integer volume returns nothing
		public static void SetSoundPitch(sound soundHandle, float pitch);//native SetSoundPitch                takes sound soundHandle, real pitch returns nothing
		//
		public static void SetSoundPlayPosition(sound soundHandle, int millisecs);//native SetSoundPlayPosition         takes sound soundHandle, integer millisecs returns nothing
		//
		public static void SetSoundDistances(sound soundHandle, float minDist, float maxDist);//native SetSoundDistances            takes sound soundHandle, real minDist, real maxDist returns nothing
		public static void SetSoundConeAngles(sound soundHandle, float inside, float outside, int outsideVolume);//native SetSoundConeAngles           takes sound soundHandle, real inside, real outside, integer outsideVolume returns nothing
		public static void SetSoundConeOrientation(sound soundHandle, float x, float y, float z);//native SetSoundConeOrientation      takes sound soundHandle, real x, real y, real z returns nothing
		public static void SetSoundPosition(sound soundHandle, float x, float y, float z);//native SetSoundPosition             takes sound soundHandle, real x, real y, real z returns nothing
		public static void SetSoundVelocity(sound soundHandle, float x, float y, float z);//native SetSoundVelocity             takes sound soundHandle, real x, real y, real z returns nothing
		public static void AttachSoundToUnit(sound soundHandle, unit whichUnit);//native AttachSoundToUnit            takes sound soundHandle, unit whichUnit returns nothing
		public static void StartSound(sound soundHandle);//native StartSound                   takes sound soundHandle returns nothing
		public static void StopSound(sound soundHandle, bool killWhenDone, bool fadeOut);//native StopSound                    takes sound soundHandle, boolean killWhenDone, boolean fadeOut returns nothing
		public static void KillSoundWhenDone(sound soundHandle);//native KillSoundWhenDone            takes sound soundHandle returns nothing
		//
		public static void SetMapMusic(string musicName, bool random, int index);//native SetMapMusic                  takes string musicName, boolean random, integer index returns nothing
		public static void ClearMapMusic();//native ClearMapMusic                takes nothing returns nothing
		public static void PlayMusic(string musicName);//native PlayMusic                    takes string musicName returns nothing
		public static void PlayMusicEx(string musicName, int frommsecs, int fadeinmsecs);//native PlayMusicEx                  takes string musicName, integer frommsecs, integer fadeinmsecs returns nothing
		public static void StopMusic(bool fadeOut);//native StopMusic                    takes boolean fadeOut returns nothing
		public static void ResumeMusic();//native ResumeMusic                  takes nothing returns nothing
		public static void PlayThematicMusic(string musicFileName);//native PlayThematicMusic            takes string musicFileName returns nothing
		public static void PlayThematicMusicEx(string musicFileName, int frommsecs);//native PlayThematicMusicEx          takes string musicFileName, integer frommsecs returns nothing
		public static void EndThematicMusic();//native EndThematicMusic             takes nothing returns nothing
		public static void SetMusicVolume(int volume);//native SetMusicVolume               takes integer volume returns nothing
		public static void SetMusicPlayPosition(int millisecs);//native SetMusicPlayPosition         takes integer millisecs returns nothing
		public static void SetThematicMusicPlayPosition(int millisecs);//native SetThematicMusicPlayPosition takes integer millisecs returns nothing
		//
		public static void SetSoundDuration(sound soundHandle, int duration);//native SetSoundDuration             takes sound soundHandle, integer duration returns nothing
		public static int GetSoundDuration(sound soundHandle);//native GetSoundDuration             takes sound soundHandle returns integer
		public static int GetSoundFileDuration(string musicFileName);//native GetSoundFileDuration         takes string musicFileName returns integer
		public static void VolumeGroupSetVolume(volumegroup vgroup, float scale);//native VolumeGroupSetVolume         takes volumegroup vgroup, real scale returns nothing
		public static void VolumeGroupReset();//native VolumeGroupReset             takes nothing returns nothing
		public static bool GetSoundIsPlaying(sound soundHandle);//native GetSoundIsPlaying            takes sound soundHandle returns boolean
		public static bool GetSoundIsLoading(sound soundHandle);//native GetSoundIsLoading            takes sound soundHandle returns boolean
		public static void RegisterStackedSound(sound soundHandle, bool byPosition, float rectwidth, float rectheight);//native RegisterStackedSound         takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
		public static void UnregisterStackedSound(sound soundHandle, bool byPosition, float rectwidth, float rectheight);//native UnregisterStackedSound       takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
		//
		//
		//
		public static weathereffect AddWeatherEffect(rect where, int effectID);//native AddWeatherEffect             takes rect where, integer effectID returns weathereffect
		public static void RemoveWeatherEffect(weathereffect whichEffect);//native RemoveWeatherEffect          takes weathereffect whichEffect returns nothing
		public static void EnableWeatherEffect(weathereffect whichEffect, bool enable);//native EnableWeatherEffect          takes weathereffect whichEffect, boolean enable returns nothing
		public static terraindeformation TerrainDeformCrater(float x, float y, float radius, float depth, int duration, bool permanent);//native TerrainDeformCrater          takes real x, real y, real radius, real depth, integer duration, boolean permanent returns terraindeformation
		public static terraindeformation TerrainDeformRipple(float x, float y, float radius, float depth, int duration, int count, float spaceWaves, float timeWaves, float radiusStartPct, bool limitNeg);//native TerrainDeformRipple          takes real x, real y, real radius, real depth, integer duration, integer count, real spaceWaves, real timeWaves, real radiusStartPct, boolean limitNeg returns terraindeformation
		public static terraindeformation TerrainDeformWave(float x, float y, float dirX, float dirY, float distance, float speed, float radius, float depth, int trailTime, int count);//native TerrainDeformWave            takes real x, real y, real dirX, real dirY, real distance, real speed, real radius, real depth, integer trailTime, integer count returns terraindeformation
		public static terraindeformation TerrainDeformRandom(float x, float y, float radius, float minDelta, float maxDelta, int duration, int updateInterval);//native TerrainDeformRandom          takes real x, real y, real radius, real minDelta, real maxDelta, integer duration, integer updateInterval returns terraindeformation
		public static void TerrainDeformStop(terraindeformation deformation, int duration);//native TerrainDeformStop            takes terraindeformation deformation, integer duration returns nothing
		public static void TerrainDeformStopAll();//native TerrainDeformStopAll         takes nothing returns nothing
		public static effect AddSpecialEffect(string modelName, float x, float y);//native AddSpecialEffect             takes string modelName, real x, real y returns effect
		public static effect AddSpecialEffectLoc(string modelName, location where);//native AddSpecialEffectLoc          takes string modelName, location where returns effect
		public static effect AddSpecialEffectTarget(string modelName, widget targetWidget, string attachPointName);//native AddSpecialEffectTarget       takes string modelName, widget targetWidget, string attachPointName returns effect
		public static void DestroyEffect(effect whichEffect);//native DestroyEffect                takes effect whichEffect returns nothing
		public static effect AddSpellEffect(string abilityString, effecttype t, float x, float y);//native AddSpellEffect               takes string abilityString, effecttype t, real x, real y returns effect
		public static effect AddSpellEffectLoc(string abilityString, effecttype t, location where);//native AddSpellEffectLoc            takes string abilityString, effecttype t,location where returns effect
		public static effect AddSpellEffectById(int abilityId, effecttype t, float x, float y);//native AddSpellEffectById           takes integer abilityId, effecttype t,real x, real y returns effect
		public static effect AddSpellEffectByIdLoc(int abilityId, effecttype t, location where);//native AddSpellEffectByIdLoc        takes integer abilityId, effecttype t,location where returns effect
		public static effect AddSpellEffectTarget(string modelName, effecttype t, widget targetWidget, string attachPoint);//native AddSpellEffectTarget         takes string modelName, effecttype t, widget targetWidget, string attachPoint returns effect
		public static effect AddSpellEffectTargetById(int abilityId, effecttype t, widget targetWidget, string attachPoint);//native AddSpellEffectTargetById     takes integer abilityId, effecttype t, widget targetWidget, string attachPoint returns effect
		public static lightning AddLightning(string codeName, bool checkVisibility, float x1, float y1, float x2, float y2);//native AddLightning                 takes string codeName, boolean checkVisibility, real x1, real y1, real x2, real y2 returns lightning
		public static lightning AddLightningEx(string codeName, bool checkVisibility, float x1, float y1, float z1, float x2, float y2, float z2);//native AddLightningEx               takes string codeName, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns lightning
		public static bool DestroyLightning(lightning whichBolt);//native DestroyLightning             takes lightning whichBolt returns boolean
		public static bool MoveLightning(lightning whichBolt, bool checkVisibility, float x1, float y1, float x2, float y2);//native MoveLightning                takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real x2, real y2 returns boolean
		public static bool MoveLightningEx(lightning whichBolt, bool checkVisibility, float x1, float y1, float z1, float x2, float y2, float z2);//native MoveLightningEx              takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns boolean
		public static float GetLightningColorA(lightning whichBolt);//native GetLightningColorA           takes lightning whichBolt returns real
		public static float GetLightningColorR(lightning whichBolt);//native GetLightningColorR           takes lightning whichBolt returns real
		public static float GetLightningColorG(lightning whichBolt);//native GetLightningColorG           takes lightning whichBolt returns real
		public static float GetLightningColorB(lightning whichBolt);//native GetLightningColorB           takes lightning whichBolt returns real
		public static bool SetLightningColor(lightning whichBolt, float r, float g, float b, float a);//native SetLightningColor            takes lightning whichBolt, real r, real g, real b, real a returns boolean
		public static string GetAbilityEffect(string abilityString, effecttype t, int index);//native GetAbilityEffect             takes string abilityString, effecttype t, integer index returns string
		public static string GetAbilityEffectById(int abilityId, effecttype t, int index);//native GetAbilityEffectById         takes integer abilityId, effecttype t, integer index returns string
		public static string GetAbilitySound(string abilityString, soundtype t);//native GetAbilitySound              takes string abilityString, soundtype t returns string
		public static string GetAbilitySoundById(int abilityId, soundtype t);//native GetAbilitySoundById          takes integer abilityId, soundtype t returns string
		//
		//
		//
		public static int GetTerrainCliffLevel(float x, float y);//native GetTerrainCliffLevel         takes real x, real y returns integer
		public static void SetWaterBaseColor(int red, int green, int blue, int alpha);//native SetWaterBaseColor            takes integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetWaterDeforms(bool val);//native SetWaterDeforms              takes boolean val returns nothing
		public static int GetTerrainType(float x, float y);//native GetTerrainType               takes real x, real y returns integer
		public static int GetTerrainVariance(float x, float y);//native GetTerrainVariance           takes real x, real y returns integer
		public static void SetTerrainType(float x, float y, int terrainType, int variation, int area, int shape);//native SetTerrainType               takes real x, real y, integer terrainType, integer variation, integer area, integer shape returns nothing
		public static bool IsTerrainPathable(float x, float y, pathingtype t);//native IsTerrainPathable            takes real x, real y, pathingtype t returns boolean
		public static void SetTerrainPathable(float x, float y, pathingtype t, bool flag);//native SetTerrainPathable           takes real x, real y, pathingtype t, boolean flag returns nothing
		//
		//
		//
		public static image CreateImage(string file, float sizeX, float sizeY, float sizeZ, float posX, float posY, float posZ, float originX, float originY, float originZ, int imageType);//native CreateImage                  takes string file, real sizeX, real sizeY, real sizeZ, real posX, real posY, real posZ, real originX, real originY, real originZ, integer imageType returns image
		public static void DestroyImage(image whichImage);//native DestroyImage                 takes image whichImage returns nothing
		public static void ShowImage(image whichImage, bool flag);//native ShowImage                    takes image whichImage, boolean flag returns nothing
		public static void SetImageConstantHeight(image whichImage, bool flag, float height);//native SetImageConstantHeight       takes image whichImage, boolean flag, real height returns nothing
		public static void SetImagePosition(image whichImage, float x, float y, float z);//native SetImagePosition             takes image whichImage, real x, real y, real z returns nothing
		public static void SetImageColor(image whichImage, int red, int green, int blue, int alpha);//native SetImageColor                takes image whichImage, integer red, integer green, integer blue, integer alpha returns nothing
		public static void SetImageRender(image whichImage, bool flag);//native SetImageRender               takes image whichImage, boolean flag returns nothing
		public static void SetImageRenderAlways(image whichImage, bool flag);//native SetImageRenderAlways         takes image whichImage, boolean flag returns nothing
		public static void SetImageAboveWater(image whichImage, bool flag, bool useWaterAlpha);//native SetImageAboveWater           takes image whichImage, boolean flag, boolean useWaterAlpha returns nothing
		public static void SetImageType(image whichImage, int imageType);//native SetImageType                 takes image whichImage, integer imageType returns nothing
		//
		//
		//
		public static ubersplat CreateUbersplat(float x, float y, string name, int red, int green, int blue, int alpha, bool forcePaused, bool noBirthTime);//native CreateUbersplat              takes real x, real y, string name, integer red, integer green, integer blue, integer alpha, boolean forcePaused, boolean noBirthTime returns ubersplat
		public static void DestroyUbersplat(ubersplat whichSplat);//native DestroyUbersplat             takes ubersplat whichSplat returns nothing
		public static void ResetUbersplat(ubersplat whichSplat);//native ResetUbersplat               takes ubersplat whichSplat returns nothing
		public static void FinishUbersplat(ubersplat whichSplat);//native FinishUbersplat              takes ubersplat whichSplat returns nothing
		public static void ShowUbersplat(ubersplat whichSplat, bool flag);//native ShowUbersplat                takes ubersplat whichSplat, boolean flag returns nothing
		public static void SetUbersplatRender(ubersplat whichSplat, bool flag);//native SetUbersplatRender           takes ubersplat whichSplat, boolean flag returns nothing
		public static void SetUbersplatRenderAlways(ubersplat whichSplat, bool flag);//native SetUbersplatRenderAlways     takes ubersplat whichSplat, boolean flag returns nothing
		//
		//
		//
		public static void SetBlight(player whichPlayer, float x, float y, float radius, bool addBlight);//native SetBlight                takes player whichPlayer, real x, real y, real radius, boolean addBlight returns nothing
		public static void SetBlightRect(player whichPlayer, rect r, bool addBlight);//native SetBlightRect            takes player whichPlayer, rect r, boolean addBlight returns nothing
		public static void SetBlightPoint(player whichPlayer, float x, float y, bool addBlight);//native SetBlightPoint           takes player whichPlayer, real x, real y, boolean addBlight returns nothing
		public static void SetBlightLoc(player whichPlayer, location whichLocation, float radius, bool addBlight);//native SetBlightLoc             takes player whichPlayer, location whichLocation, real radius, boolean addBlight returns nothing
		public static unit CreateBlightedGoldmine(player id, float x, float y, float face);//native CreateBlightedGoldmine   takes player id, real x, real y, real face returns unit
		public static bool IsPointBlighted(float x, float y);//native IsPointBlighted          takes real x, real y returns boolean
		//
		//
		//
		public static void SetDoodadAnimation(float x, float y, float radius, int doodadID, bool nearestOnly, string animName, bool animRandom);//native SetDoodadAnimation       takes real x, real y, real radius, integer doodadID, boolean nearestOnly, string animName, boolean animRandom returns nothing
		public static void SetDoodadAnimationRect(rect r, int doodadID, string animName, bool animRandom);//native SetDoodadAnimationRect   takes rect r, integer doodadID, string animName, boolean animRandom returns nothing
		//
		//
		//
		public static void StartMeleeAI(player num, string script);//native StartMeleeAI         takes player num, string script                 returns nothing
		public static void StartCampaignAI(player num, string script);//native StartCampaignAI      takes player num, string script                 returns nothing
		public static void CommandAI(player num, int command, int data);//native CommandAI            takes player num, integer command, integer data returns nothing
		public static void PauseCompAI(player p, bool pause);//native PauseCompAI          takes player p,   boolean pause                 returns nothing
		public static aidifficulty GetAIDifficulty(player num);//native GetAIDifficulty      takes player num                                returns aidifficulty
		public static void RemoveGuardPosition(unit hUnit);//native RemoveGuardPosition  takes unit hUnit                                returns nothing
		public static void RecycleGuardPosition(unit hUnit);//native RecycleGuardPosition takes unit hUnit                                returns nothing
		public static void RemoveAllGuardPositions(player num);//native RemoveAllGuardPositions takes player num                             returns nothing
		//
		public static void Cheat(string cheatStr);//native Cheat            takes string cheatStr returns nothing
		public static bool IsNoVictoryCheat();//native IsNoVictoryCheat takes nothing returns boolean
		public static bool IsNoDefeatCheat();//native IsNoDefeatCheat  takes nothing returns boolean
		public static void Preload(string filename);//native Preload          takes string filename returns nothing
		public static void PreloadEnd(float timeout);//native PreloadEnd       takes real timeout returns nothing
		public static void PreloadStart();//native PreloadStart     takes nothing returns nothing
		public static void PreloadRefresh();//native PreloadRefresh   takes nothing returns nothing
		public static void PreloadEndEx();//native PreloadEndEx     takes nothing returns nothing
		public static void PreloadGenClear();//native PreloadGenClear  takes nothing returns nothing
		public static void PreloadGenStart();//native PreloadGenStart  takes nothing returns nothing
		public static void PreloadGenEnd(string filename);//native PreloadGenEnd    takes string filename returns nothing
		public static void Preloader(string filename);//native Preloader        takes string filename returns nothing

	
	}
}

