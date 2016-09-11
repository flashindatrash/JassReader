using System;
using System.Collections.Generic;

namespace Jass {

	public class BlizzardJ {

		//
		//
		//
		//
		//
		//
		//
		public const float bj_PI = 3.14159;//constant real      bj_PI                            = 3.14159
		public const float bj_E = 2.71828;//constant real      bj_E                             = 2.71828
		public const float bj_CELLWIDTH = 128.0;//constant real      bj_CELLWIDTH                     = 128.0
		public const float bj_CLIFFHEIGHT = 128.0;//constant real      bj_CLIFFHEIGHT                   = 128.0
		public const float bj_UNIT_FACING = 270.0;//constant real      bj_UNIT_FACING                   = 270.0
		public const float bj_RADTODEG = 180.0/bj_PI;//constant real      bj_RADTODEG                      = 180.0/bj_PI
		public const float bj_DEGTORAD = bj_PI/180.0;//constant real      bj_DEGTORAD                      = bj_PI/180.0
		public const float bj_TEXT_DELAY_QUEST = 20.00;//constant real      bj_TEXT_DELAY_QUEST              = 20.00
		public const float bj_TEXT_DELAY_QUESTUPDATE = 20.00;//constant real      bj_TEXT_DELAY_QUESTUPDATE        = 20.00
		public const float bj_TEXT_DELAY_QUESTDONE = 20.00;//constant real      bj_TEXT_DELAY_QUESTDONE          = 20.00
		public const float bj_TEXT_DELAY_QUESTFAILED = 20.00;//constant real      bj_TEXT_DELAY_QUESTFAILED        = 20.00
		public const float bj_TEXT_DELAY_QUESTREQUIREMENT = 20.00;//constant real      bj_TEXT_DELAY_QUESTREQUIREMENT   = 20.00
		public const float bj_TEXT_DELAY_MISSIONFAILED = 20.00;//constant real      bj_TEXT_DELAY_MISSIONFAILED      = 20.00
		public const float bj_TEXT_DELAY_ALWAYSHINT = 12.00;//constant real      bj_TEXT_DELAY_ALWAYSHINT         = 12.00
		public const float bj_TEXT_DELAY_HINT = 12.00;//constant real      bj_TEXT_DELAY_HINT               = 12.00
		public const float bj_TEXT_DELAY_SECRET = 10.00;//constant real      bj_TEXT_DELAY_SECRET             = 10.00
		public const float bj_TEXT_DELAY_UNITACQUIRED = 15.00;//constant real      bj_TEXT_DELAY_UNITACQUIRED       = 15.00
		public const float bj_TEXT_DELAY_UNITAVAILABLE = 10.00;//constant real      bj_TEXT_DELAY_UNITAVAILABLE      = 10.00
		public const float bj_TEXT_DELAY_ITEMACQUIRED = 10.00;//constant real      bj_TEXT_DELAY_ITEMACQUIRED       = 10.00
		public const float bj_TEXT_DELAY_WARNING = 12.00;//constant real      bj_TEXT_DELAY_WARNING            = 12.00
		public const float bj_QUEUE_DELAY_QUEST = 5.00;//constant real      bj_QUEUE_DELAY_QUEST             =  5.00
		public const float bj_QUEUE_DELAY_HINT = 5.00;//constant real      bj_QUEUE_DELAY_HINT              =  5.00
		public const float bj_QUEUE_DELAY_SECRET = 3.00;//constant real      bj_QUEUE_DELAY_SECRET            =  3.00
		public const float bj_HANDICAP_EASY = 60.00;//constant real      bj_HANDICAP_EASY                 = 60.00
		public const float bj_GAME_STARTED_THRESHOLD = 0.01;//constant real      bj_GAME_STARTED_THRESHOLD        =  0.01
		public const float bj_WAIT_FOR_COND_MIN_INTERVAL = 0.10;//constant real      bj_WAIT_FOR_COND_MIN_INTERVAL    =  0.10
		public const float bj_POLLED_WAIT_INTERVAL = 0.10;//constant real      bj_POLLED_WAIT_INTERVAL          =  0.10
		public const float bj_POLLED_WAIT_SKIP_THRESHOLD = 2.00;//constant real      bj_POLLED_WAIT_SKIP_THRESHOLD    =  2.00
		//
		public const int bj_MAX_INVENTORY = 6;//constant integer   bj_MAX_INVENTORY                 =   6
		public const int bj_MAX_PLAYERS = 12;//constant integer   bj_MAX_PLAYERS                   =  12
		public const int bj_PLAYER_NEUTRAL_VICTIM = 13;//constant integer   bj_PLAYER_NEUTRAL_VICTIM         =  13
		public const int bj_PLAYER_NEUTRAL_EXTRA = 14;//constant integer   bj_PLAYER_NEUTRAL_EXTRA          =  14
		public const int bj_MAX_PLAYER_SLOTS = 16;//constant integer   bj_MAX_PLAYER_SLOTS              =  16
		public const int bj_MAX_SKELETONS = 25;//constant integer   bj_MAX_SKELETONS                 =  25
		public const int bj_MAX_STOCK_ITEM_SLOTS = 11;//constant integer   bj_MAX_STOCK_ITEM_SLOTS          =  11
		public const int bj_MAX_STOCK_UNIT_SLOTS = 11;//constant integer   bj_MAX_STOCK_UNIT_SLOTS          =  11
		public const int bj_MAX_ITEM_LEVEL = 10;//constant integer   bj_MAX_ITEM_LEVEL                =  10
		//
		//
		public const float bj_TOD_DAWN = 6.00;//constant real      bj_TOD_DAWN                      = 6.00
		public const float bj_TOD_DUSK = 18.00;//constant real      bj_TOD_DUSK                      = 18.00
		//
		//
		//
		//
		//
		//
		//
		//
		//
		public const float bj_MELEE_STARTING_TOD = 8.00;//constant real      bj_MELEE_STARTING_TOD            = 8.00
		public const int bj_MELEE_STARTING_GOLD_V0 = 750;//constant integer   bj_MELEE_STARTING_GOLD_V0        = 750
		public const int bj_MELEE_STARTING_GOLD_V1 = 500;//constant integer   bj_MELEE_STARTING_GOLD_V1        = 500
		public const int bj_MELEE_STARTING_LUMBER_V0 = 200;//constant integer   bj_MELEE_STARTING_LUMBER_V0      = 200
		public const int bj_MELEE_STARTING_LUMBER_V1 = 150;//constant integer   bj_MELEE_STARTING_LUMBER_V1      = 150
		public const int bj_MELEE_STARTING_HERO_TOKENS = 1;//constant integer   bj_MELEE_STARTING_HERO_TOKENS    = 1
		public const int bj_MELEE_HERO_LIMIT = 3;//constant integer   bj_MELEE_HERO_LIMIT              = 3
		public const int bj_MELEE_HERO_TYPE_LIMIT = 1;//constant integer   bj_MELEE_HERO_TYPE_LIMIT         = 1
		public const float bj_MELEE_MINE_SEARCH_RADIUS = 2000;//constant real      bj_MELEE_MINE_SEARCH_RADIUS      = 2000
		public const float bj_MELEE_CLEAR_UNITS_RADIUS = 1500;//constant real      bj_MELEE_CLEAR_UNITS_RADIUS      = 1500
		public const float bj_MELEE_CRIPPLE_TIMEOUT = 120.00;//constant real      bj_MELEE_CRIPPLE_TIMEOUT         = 120.00
		public const float bj_MELEE_CRIPPLE_MSG_DURATION = 20.00;//constant real      bj_MELEE_CRIPPLE_MSG_DURATION    = 20.00
		public const int bj_MELEE_MAX_TWINKED_HEROES_V0 = 3;//constant integer   bj_MELEE_MAX_TWINKED_HEROES_V0   = 3
		public const int bj_MELEE_MAX_TWINKED_HEROES_V1 = 1;//constant integer   bj_MELEE_MAX_TWINKED_HEROES_V1   = 1
		//
		public const float bj_CREEP_ITEM_DELAY = 0.50;//constant real      bj_CREEP_ITEM_DELAY              = 0.50
		//
		public const float bj_STOCK_RESTOCK_INITIAL_DELAY = 120;//constant real      bj_STOCK_RESTOCK_INITIAL_DELAY   = 120
		public const float bj_STOCK_RESTOCK_INTERVAL = 30;//constant real      bj_STOCK_RESTOCK_INTERVAL        = 30
		public const int bj_STOCK_MAX_ITERATIONS = 20;//constant integer   bj_STOCK_MAX_ITERATIONS          = 20
		//
		public const int bj_MAX_DEST_IN_REGION_EVENTS = 64;//constant integer   bj_MAX_DEST_IN_REGION_EVENTS     = 64
		//
		public const int bj_CAMERA_MIN_FARZ = 100;//constant integer   bj_CAMERA_MIN_FARZ               = 100
		public const int bj_CAMERA_DEFAULT_DISTANCE = 1650;//constant integer   bj_CAMERA_DEFAULT_DISTANCE       = 1650
		public const int bj_CAMERA_DEFAULT_FARZ = 5000;//constant integer   bj_CAMERA_DEFAULT_FARZ           = 5000
		public const int bj_CAMERA_DEFAULT_AOA = 304;//constant integer   bj_CAMERA_DEFAULT_AOA            = 304
		public const int bj_CAMERA_DEFAULT_FOV = 70;//constant integer   bj_CAMERA_DEFAULT_FOV            = 70
		public const int bj_CAMERA_DEFAULT_ROLL = 0;//constant integer   bj_CAMERA_DEFAULT_ROLL           = 0
		public const int bj_CAMERA_DEFAULT_ROTATION = 90;//constant integer   bj_CAMERA_DEFAULT_ROTATION       = 90
		//
		public const float bj_RESCUE_PING_TIME = 2.00;//constant real      bj_RESCUE_PING_TIME              = 2.00
		//
		public const float bj_NOTHING_SOUND_DURATION = 5.00;//constant real      bj_NOTHING_SOUND_DURATION        = 5.00
		public const float bj_TRANSMISSION_PING_TIME = 1.00;//constant real      bj_TRANSMISSION_PING_TIME        = 1.00
		public const int bj_TRANSMISSION_IND_RED = 255;//constant integer   bj_TRANSMISSION_IND_RED          = 255
		public const int bj_TRANSMISSION_IND_BLUE = 255;//constant integer   bj_TRANSMISSION_IND_BLUE         = 255
		public const int bj_TRANSMISSION_IND_GREEN = 255;//constant integer   bj_TRANSMISSION_IND_GREEN        = 255
		public const int bj_TRANSMISSION_IND_ALPHA = 255;//constant integer   bj_TRANSMISSION_IND_ALPHA        = 255
		public const float bj_TRANSMISSION_PORT_HANGTIME = 1.50;//constant real      bj_TRANSMISSION_PORT_HANGTIME    = 1.50
		//
		public const float bj_CINEMODE_INTERFACEFADE = 0.50;//constant real      bj_CINEMODE_INTERFACEFADE        = 0.50
		public const gamespeed bj_CINEMODE_GAMESPEED = MAP_SPEED_NORMAL;//constant gamespeed bj_CINEMODE_GAMESPEED            = MAP_SPEED_NORMAL
		//
		public const float bj_CINEMODE_VOLUME_UNITMOVEMENT = 0.40;//constant real      bj_CINEMODE_VOLUME_UNITMOVEMENT  = 0.40
		public const float bj_CINEMODE_VOLUME_UNITSOUNDS = 0.00;//constant real      bj_CINEMODE_VOLUME_UNITSOUNDS    = 0.00
		public const float bj_CINEMODE_VOLUME_COMBAT = 0.40;//constant real      bj_CINEMODE_VOLUME_COMBAT        = 0.40
		public const float bj_CINEMODE_VOLUME_SPELLS = 0.40;//constant real      bj_CINEMODE_VOLUME_SPELLS        = 0.40
		public const float bj_CINEMODE_VOLUME_UI = 0.00;//constant real      bj_CINEMODE_VOLUME_UI            = 0.00
		public const float bj_CINEMODE_VOLUME_MUSIC = 0.55;//constant real      bj_CINEMODE_VOLUME_MUSIC         = 0.55
		public const float bj_CINEMODE_VOLUME_AMBIENTSOUNDS = 1.00;//constant real      bj_CINEMODE_VOLUME_AMBIENTSOUNDS = 1.00
		public const float bj_CINEMODE_VOLUME_FIRE = 0.60;//constant real      bj_CINEMODE_VOLUME_FIRE          = 0.60
		//
		public const float bj_SPEECH_VOLUME_UNITMOVEMENT = 0.25;//constant real      bj_SPEECH_VOLUME_UNITMOVEMENT    = 0.25
		public const float bj_SPEECH_VOLUME_UNITSOUNDS = 0.00;//constant real      bj_SPEECH_VOLUME_UNITSOUNDS      = 0.00
		public const float bj_SPEECH_VOLUME_COMBAT = 0.25;//constant real      bj_SPEECH_VOLUME_COMBAT          = 0.25
		public const float bj_SPEECH_VOLUME_SPELLS = 0.25;//constant real      bj_SPEECH_VOLUME_SPELLS          = 0.25
		public const float bj_SPEECH_VOLUME_UI = 0.00;//constant real      bj_SPEECH_VOLUME_UI              = 0.00
		public const float bj_SPEECH_VOLUME_MUSIC = 0.55;//constant real      bj_SPEECH_VOLUME_MUSIC           = 0.55
		public const float bj_SPEECH_VOLUME_AMBIENTSOUNDS = 1.00;//constant real      bj_SPEECH_VOLUME_AMBIENTSOUNDS   = 1.00
		public const float bj_SPEECH_VOLUME_FIRE = 0.60;//constant real      bj_SPEECH_VOLUME_FIRE            = 0.60
		//
		public const float bj_SMARTPAN_TRESHOLD_PAN = 500;//constant real      bj_SMARTPAN_TRESHOLD_PAN         = 500
		public const float bj_SMARTPAN_TRESHOLD_SNAP = 3500;//constant real      bj_SMARTPAN_TRESHOLD_SNAP        = 3500
		//
		public const int bj_MAX_QUEUED_TRIGGERS = 100;//constant integer   bj_MAX_QUEUED_TRIGGERS           = 100
		public const float bj_QUEUED_TRIGGER_TIMEOUT = 180.00;//constant real      bj_QUEUED_TRIGGER_TIMEOUT        = 180.00
		//
		public const int bj_CAMPAIGN_INDEX_T = 0;//constant integer   bj_CAMPAIGN_INDEX_T        = 0
		public const int bj_CAMPAIGN_INDEX_H = 1;//constant integer   bj_CAMPAIGN_INDEX_H        = 1
		public const int bj_CAMPAIGN_INDEX_U = 2;//constant integer   bj_CAMPAIGN_INDEX_U        = 2
		public const int bj_CAMPAIGN_INDEX_O = 3;//constant integer   bj_CAMPAIGN_INDEX_O        = 3
		public const int bj_CAMPAIGN_INDEX_N = 4;//constant integer   bj_CAMPAIGN_INDEX_N        = 4
		public const int bj_CAMPAIGN_INDEX_XN = 5;//constant integer   bj_CAMPAIGN_INDEX_XN       = 5
		public const int bj_CAMPAIGN_INDEX_XH = 6;//constant integer   bj_CAMPAIGN_INDEX_XH       = 6
		public const int bj_CAMPAIGN_INDEX_XU = 7;//constant integer   bj_CAMPAIGN_INDEX_XU       = 7
		public const int bj_CAMPAIGN_INDEX_XO = 8;//constant integer   bj_CAMPAIGN_INDEX_XO       = 8
		//
		public const int bj_CAMPAIGN_OFFSET_T = 0;//constant integer   bj_CAMPAIGN_OFFSET_T       = 0
		public const int bj_CAMPAIGN_OFFSET_H = 1;//constant integer   bj_CAMPAIGN_OFFSET_H       = 1
		public const int bj_CAMPAIGN_OFFSET_U = 2;//constant integer   bj_CAMPAIGN_OFFSET_U       = 2
		public const int bj_CAMPAIGN_OFFSET_O = 3;//constant integer   bj_CAMPAIGN_OFFSET_O       = 3
		public const int bj_CAMPAIGN_OFFSET_N = 4;//constant integer   bj_CAMPAIGN_OFFSET_N       = 4
		public const int bj_CAMPAIGN_OFFSET_XN = 0;//constant integer   bj_CAMPAIGN_OFFSET_XN      = 0
		public const int bj_CAMPAIGN_OFFSET_XH = 1;//constant integer   bj_CAMPAIGN_OFFSET_XH      = 1
		public const int bj_CAMPAIGN_OFFSET_XU = 2;//constant integer   bj_CAMPAIGN_OFFSET_XU      = 2
		public const int bj_CAMPAIGN_OFFSET_XO = 3;//constant integer   bj_CAMPAIGN_OFFSET_XO      = 3
		//
		//
		public const int bj_MISSION_INDEX_T00 = bj_CAMPAIGN_OFFSET_T * 1000 + 0;//constant integer   bj_MISSION_INDEX_T00       = bj_CAMPAIGN_OFFSET_T * 1000 + 0
		public const int bj_MISSION_INDEX_T01 = bj_CAMPAIGN_OFFSET_T * 1000 + 1;//constant integer   bj_MISSION_INDEX_T01       = bj_CAMPAIGN_OFFSET_T * 1000 + 1
		//
		public const int bj_MISSION_INDEX_H00 = bj_CAMPAIGN_OFFSET_H * 1000 + 0;//constant integer   bj_MISSION_INDEX_H00       = bj_CAMPAIGN_OFFSET_H * 1000 + 0
		public const int bj_MISSION_INDEX_H01 = bj_CAMPAIGN_OFFSET_H * 1000 + 1;//constant integer   bj_MISSION_INDEX_H01       = bj_CAMPAIGN_OFFSET_H * 1000 + 1
		public const int bj_MISSION_INDEX_H02 = bj_CAMPAIGN_OFFSET_H * 1000 + 2;//constant integer   bj_MISSION_INDEX_H02       = bj_CAMPAIGN_OFFSET_H * 1000 + 2
		public const int bj_MISSION_INDEX_H03 = bj_CAMPAIGN_OFFSET_H * 1000 + 3;//constant integer   bj_MISSION_INDEX_H03       = bj_CAMPAIGN_OFFSET_H * 1000 + 3
		public const int bj_MISSION_INDEX_H04 = bj_CAMPAIGN_OFFSET_H * 1000 + 4;//constant integer   bj_MISSION_INDEX_H04       = bj_CAMPAIGN_OFFSET_H * 1000 + 4
		public const int bj_MISSION_INDEX_H05 = bj_CAMPAIGN_OFFSET_H * 1000 + 5;//constant integer   bj_MISSION_INDEX_H05       = bj_CAMPAIGN_OFFSET_H * 1000 + 5
		public const int bj_MISSION_INDEX_H06 = bj_CAMPAIGN_OFFSET_H * 1000 + 6;//constant integer   bj_MISSION_INDEX_H06       = bj_CAMPAIGN_OFFSET_H * 1000 + 6
		public const int bj_MISSION_INDEX_H07 = bj_CAMPAIGN_OFFSET_H * 1000 + 7;//constant integer   bj_MISSION_INDEX_H07       = bj_CAMPAIGN_OFFSET_H * 1000 + 7
		public const int bj_MISSION_INDEX_H08 = bj_CAMPAIGN_OFFSET_H * 1000 + 8;//constant integer   bj_MISSION_INDEX_H08       = bj_CAMPAIGN_OFFSET_H * 1000 + 8
		public const int bj_MISSION_INDEX_H09 = bj_CAMPAIGN_OFFSET_H * 1000 + 9;//constant integer   bj_MISSION_INDEX_H09       = bj_CAMPAIGN_OFFSET_H * 1000 + 9
		public const int bj_MISSION_INDEX_H10 = bj_CAMPAIGN_OFFSET_H * 1000 + 10;//constant integer   bj_MISSION_INDEX_H10       = bj_CAMPAIGN_OFFSET_H * 1000 + 10
		public const int bj_MISSION_INDEX_H11 = bj_CAMPAIGN_OFFSET_H * 1000 + 11;//constant integer   bj_MISSION_INDEX_H11       = bj_CAMPAIGN_OFFSET_H * 1000 + 11
		//
		public const int bj_MISSION_INDEX_U00 = bj_CAMPAIGN_OFFSET_U * 1000 + 0;//constant integer   bj_MISSION_INDEX_U00       = bj_CAMPAIGN_OFFSET_U * 1000 + 0
		public const int bj_MISSION_INDEX_U01 = bj_CAMPAIGN_OFFSET_U * 1000 + 1;//constant integer   bj_MISSION_INDEX_U01       = bj_CAMPAIGN_OFFSET_U * 1000 + 1
		public const int bj_MISSION_INDEX_U02 = bj_CAMPAIGN_OFFSET_U * 1000 + 2;//constant integer   bj_MISSION_INDEX_U02       = bj_CAMPAIGN_OFFSET_U * 1000 + 2
		public const int bj_MISSION_INDEX_U03 = bj_CAMPAIGN_OFFSET_U * 1000 + 3;//constant integer   bj_MISSION_INDEX_U03       = bj_CAMPAIGN_OFFSET_U * 1000 + 3
		public const int bj_MISSION_INDEX_U05 = bj_CAMPAIGN_OFFSET_U * 1000 + 4;//constant integer   bj_MISSION_INDEX_U05       = bj_CAMPAIGN_OFFSET_U * 1000 + 4
		public const int bj_MISSION_INDEX_U07 = bj_CAMPAIGN_OFFSET_U * 1000 + 5;//constant integer   bj_MISSION_INDEX_U07       = bj_CAMPAIGN_OFFSET_U * 1000 + 5
		public const int bj_MISSION_INDEX_U08 = bj_CAMPAIGN_OFFSET_U * 1000 + 6;//constant integer   bj_MISSION_INDEX_U08       = bj_CAMPAIGN_OFFSET_U * 1000 + 6
		public const int bj_MISSION_INDEX_U09 = bj_CAMPAIGN_OFFSET_U * 1000 + 7;//constant integer   bj_MISSION_INDEX_U09       = bj_CAMPAIGN_OFFSET_U * 1000 + 7
		public const int bj_MISSION_INDEX_U10 = bj_CAMPAIGN_OFFSET_U * 1000 + 8;//constant integer   bj_MISSION_INDEX_U10       = bj_CAMPAIGN_OFFSET_U * 1000 + 8
		public const int bj_MISSION_INDEX_U11 = bj_CAMPAIGN_OFFSET_U * 1000 + 9;//constant integer   bj_MISSION_INDEX_U11       = bj_CAMPAIGN_OFFSET_U * 1000 + 9
		//
		public const int bj_MISSION_INDEX_O00 = bj_CAMPAIGN_OFFSET_O * 1000 + 0;//constant integer   bj_MISSION_INDEX_O00       = bj_CAMPAIGN_OFFSET_O * 1000 + 0
		public const int bj_MISSION_INDEX_O01 = bj_CAMPAIGN_OFFSET_O * 1000 + 1;//constant integer   bj_MISSION_INDEX_O01       = bj_CAMPAIGN_OFFSET_O * 1000 + 1
		public const int bj_MISSION_INDEX_O02 = bj_CAMPAIGN_OFFSET_O * 1000 + 2;//constant integer   bj_MISSION_INDEX_O02       = bj_CAMPAIGN_OFFSET_O * 1000 + 2
		public const int bj_MISSION_INDEX_O03 = bj_CAMPAIGN_OFFSET_O * 1000 + 3;//constant integer   bj_MISSION_INDEX_O03       = bj_CAMPAIGN_OFFSET_O * 1000 + 3
		public const int bj_MISSION_INDEX_O04 = bj_CAMPAIGN_OFFSET_O * 1000 + 4;//constant integer   bj_MISSION_INDEX_O04       = bj_CAMPAIGN_OFFSET_O * 1000 + 4
		public const int bj_MISSION_INDEX_O05 = bj_CAMPAIGN_OFFSET_O * 1000 + 5;//constant integer   bj_MISSION_INDEX_O05       = bj_CAMPAIGN_OFFSET_O * 1000 + 5
		public const int bj_MISSION_INDEX_O06 = bj_CAMPAIGN_OFFSET_O * 1000 + 6;//constant integer   bj_MISSION_INDEX_O06       = bj_CAMPAIGN_OFFSET_O * 1000 + 6
		public const int bj_MISSION_INDEX_O07 = bj_CAMPAIGN_OFFSET_O * 1000 + 7;//constant integer   bj_MISSION_INDEX_O07       = bj_CAMPAIGN_OFFSET_O * 1000 + 7
		public const int bj_MISSION_INDEX_O08 = bj_CAMPAIGN_OFFSET_O * 1000 + 8;//constant integer   bj_MISSION_INDEX_O08       = bj_CAMPAIGN_OFFSET_O * 1000 + 8
		public const int bj_MISSION_INDEX_O09 = bj_CAMPAIGN_OFFSET_O * 1000 + 9;//constant integer   bj_MISSION_INDEX_O09       = bj_CAMPAIGN_OFFSET_O * 1000 + 9
		public const int bj_MISSION_INDEX_O10 = bj_CAMPAIGN_OFFSET_O * 1000 + 10;//constant integer   bj_MISSION_INDEX_O10       = bj_CAMPAIGN_OFFSET_O * 1000 + 10
		//
		public const int bj_MISSION_INDEX_N00 = bj_CAMPAIGN_OFFSET_N * 1000 + 0;//constant integer   bj_MISSION_INDEX_N00       = bj_CAMPAIGN_OFFSET_N * 1000 + 0
		public const int bj_MISSION_INDEX_N01 = bj_CAMPAIGN_OFFSET_N * 1000 + 1;//constant integer   bj_MISSION_INDEX_N01       = bj_CAMPAIGN_OFFSET_N * 1000 + 1
		public const int bj_MISSION_INDEX_N02 = bj_CAMPAIGN_OFFSET_N * 1000 + 2;//constant integer   bj_MISSION_INDEX_N02       = bj_CAMPAIGN_OFFSET_N * 1000 + 2
		public const int bj_MISSION_INDEX_N03 = bj_CAMPAIGN_OFFSET_N * 1000 + 3;//constant integer   bj_MISSION_INDEX_N03       = bj_CAMPAIGN_OFFSET_N * 1000 + 3
		public const int bj_MISSION_INDEX_N04 = bj_CAMPAIGN_OFFSET_N * 1000 + 4;//constant integer   bj_MISSION_INDEX_N04       = bj_CAMPAIGN_OFFSET_N * 1000 + 4
		public const int bj_MISSION_INDEX_N05 = bj_CAMPAIGN_OFFSET_N * 1000 + 5;//constant integer   bj_MISSION_INDEX_N05       = bj_CAMPAIGN_OFFSET_N * 1000 + 5
		public const int bj_MISSION_INDEX_N06 = bj_CAMPAIGN_OFFSET_N * 1000 + 6;//constant integer   bj_MISSION_INDEX_N06       = bj_CAMPAIGN_OFFSET_N * 1000 + 6
		public const int bj_MISSION_INDEX_N07 = bj_CAMPAIGN_OFFSET_N * 1000 + 7;//constant integer   bj_MISSION_INDEX_N07       = bj_CAMPAIGN_OFFSET_N * 1000 + 7
		public const int bj_MISSION_INDEX_N08 = bj_CAMPAIGN_OFFSET_N * 1000 + 8;//constant integer   bj_MISSION_INDEX_N08       = bj_CAMPAIGN_OFFSET_N * 1000 + 8
		public const int bj_MISSION_INDEX_N09 = bj_CAMPAIGN_OFFSET_N * 1000 + 9;//constant integer   bj_MISSION_INDEX_N09       = bj_CAMPAIGN_OFFSET_N * 1000 + 9
		//
		public const int bj_MISSION_INDEX_XN00 = bj_CAMPAIGN_OFFSET_XN * 1000 + 0;//constant integer   bj_MISSION_INDEX_XN00       = bj_CAMPAIGN_OFFSET_XN * 1000 + 0
		public const int bj_MISSION_INDEX_XN01 = bj_CAMPAIGN_OFFSET_XN * 1000 + 1;//constant integer   bj_MISSION_INDEX_XN01       = bj_CAMPAIGN_OFFSET_XN * 1000 + 1
		public const int bj_MISSION_INDEX_XN02 = bj_CAMPAIGN_OFFSET_XN * 1000 + 2;//constant integer   bj_MISSION_INDEX_XN02       = bj_CAMPAIGN_OFFSET_XN * 1000 + 2
		public const int bj_MISSION_INDEX_XN03 = bj_CAMPAIGN_OFFSET_XN * 1000 + 3;//constant integer   bj_MISSION_INDEX_XN03       = bj_CAMPAIGN_OFFSET_XN * 1000 + 3
		public const int bj_MISSION_INDEX_XN04 = bj_CAMPAIGN_OFFSET_XN * 1000 + 4;//constant integer   bj_MISSION_INDEX_XN04       = bj_CAMPAIGN_OFFSET_XN * 1000 + 4
		public const int bj_MISSION_INDEX_XN05 = bj_CAMPAIGN_OFFSET_XN * 1000 + 5;//constant integer   bj_MISSION_INDEX_XN05       = bj_CAMPAIGN_OFFSET_XN * 1000 + 5
		public const int bj_MISSION_INDEX_XN06 = bj_CAMPAIGN_OFFSET_XN * 1000 + 6;//constant integer   bj_MISSION_INDEX_XN06       = bj_CAMPAIGN_OFFSET_XN * 1000 + 6
		public const int bj_MISSION_INDEX_XN07 = bj_CAMPAIGN_OFFSET_XN * 1000 + 7;//constant integer   bj_MISSION_INDEX_XN07       = bj_CAMPAIGN_OFFSET_XN * 1000 + 7
		public const int bj_MISSION_INDEX_XN08 = bj_CAMPAIGN_OFFSET_XN * 1000 + 8;//constant integer   bj_MISSION_INDEX_XN08       = bj_CAMPAIGN_OFFSET_XN * 1000 + 8
		public const int bj_MISSION_INDEX_XN09 = bj_CAMPAIGN_OFFSET_XN * 1000 + 9;//constant integer   bj_MISSION_INDEX_XN09       = bj_CAMPAIGN_OFFSET_XN * 1000 + 9
		public const int bj_MISSION_INDEX_XN10 = bj_CAMPAIGN_OFFSET_XN * 1000 + 10;//constant integer   bj_MISSION_INDEX_XN10       = bj_CAMPAIGN_OFFSET_XN * 1000 + 10
		//
		public const int bj_MISSION_INDEX_XH00 = bj_CAMPAIGN_OFFSET_XH * 1000 + 0;//constant integer   bj_MISSION_INDEX_XH00       = bj_CAMPAIGN_OFFSET_XH * 1000 + 0
		public const int bj_MISSION_INDEX_XH01 = bj_CAMPAIGN_OFFSET_XH * 1000 + 1;//constant integer   bj_MISSION_INDEX_XH01       = bj_CAMPAIGN_OFFSET_XH * 1000 + 1
		public const int bj_MISSION_INDEX_XH02 = bj_CAMPAIGN_OFFSET_XH * 1000 + 2;//constant integer   bj_MISSION_INDEX_XH02       = bj_CAMPAIGN_OFFSET_XH * 1000 + 2
		public const int bj_MISSION_INDEX_XH03 = bj_CAMPAIGN_OFFSET_XH * 1000 + 3;//constant integer   bj_MISSION_INDEX_XH03       = bj_CAMPAIGN_OFFSET_XH * 1000 + 3
		public const int bj_MISSION_INDEX_XH04 = bj_CAMPAIGN_OFFSET_XH * 1000 + 4;//constant integer   bj_MISSION_INDEX_XH04       = bj_CAMPAIGN_OFFSET_XH * 1000 + 4
		public const int bj_MISSION_INDEX_XH05 = bj_CAMPAIGN_OFFSET_XH * 1000 + 5;//constant integer   bj_MISSION_INDEX_XH05       = bj_CAMPAIGN_OFFSET_XH * 1000 + 5
		public const int bj_MISSION_INDEX_XH06 = bj_CAMPAIGN_OFFSET_XH * 1000 + 6;//constant integer   bj_MISSION_INDEX_XH06       = bj_CAMPAIGN_OFFSET_XH * 1000 + 6
		public const int bj_MISSION_INDEX_XH07 = bj_CAMPAIGN_OFFSET_XH * 1000 + 7;//constant integer   bj_MISSION_INDEX_XH07       = bj_CAMPAIGN_OFFSET_XH * 1000 + 7
		public const int bj_MISSION_INDEX_XH08 = bj_CAMPAIGN_OFFSET_XH * 1000 + 8;//constant integer   bj_MISSION_INDEX_XH08       = bj_CAMPAIGN_OFFSET_XH * 1000 + 8
		public const int bj_MISSION_INDEX_XH09 = bj_CAMPAIGN_OFFSET_XH * 1000 + 9;//constant integer   bj_MISSION_INDEX_XH09       = bj_CAMPAIGN_OFFSET_XH * 1000 + 9
		//
		public const int bj_MISSION_INDEX_XU00 = bj_CAMPAIGN_OFFSET_XU * 1000 + 0;//constant integer   bj_MISSION_INDEX_XU00       = bj_CAMPAIGN_OFFSET_XU * 1000 + 0
		public const int bj_MISSION_INDEX_XU01 = bj_CAMPAIGN_OFFSET_XU * 1000 + 1;//constant integer   bj_MISSION_INDEX_XU01       = bj_CAMPAIGN_OFFSET_XU * 1000 + 1
		public const int bj_MISSION_INDEX_XU02 = bj_CAMPAIGN_OFFSET_XU * 1000 + 2;//constant integer   bj_MISSION_INDEX_XU02       = bj_CAMPAIGN_OFFSET_XU * 1000 + 2
		public const int bj_MISSION_INDEX_XU03 = bj_CAMPAIGN_OFFSET_XU * 1000 + 3;//constant integer   bj_MISSION_INDEX_XU03       = bj_CAMPAIGN_OFFSET_XU * 1000 + 3
		public const int bj_MISSION_INDEX_XU04 = bj_CAMPAIGN_OFFSET_XU * 1000 + 4;//constant integer   bj_MISSION_INDEX_XU04       = bj_CAMPAIGN_OFFSET_XU * 1000 + 4
		public const int bj_MISSION_INDEX_XU05 = bj_CAMPAIGN_OFFSET_XU * 1000 + 5;//constant integer   bj_MISSION_INDEX_XU05       = bj_CAMPAIGN_OFFSET_XU * 1000 + 5
		public const int bj_MISSION_INDEX_XU06 = bj_CAMPAIGN_OFFSET_XU * 1000 + 6;//constant integer   bj_MISSION_INDEX_XU06       = bj_CAMPAIGN_OFFSET_XU * 1000 + 6
		public const int bj_MISSION_INDEX_XU07 = bj_CAMPAIGN_OFFSET_XU * 1000 + 7;//constant integer   bj_MISSION_INDEX_XU07       = bj_CAMPAIGN_OFFSET_XU * 1000 + 7
		public const int bj_MISSION_INDEX_XU08 = bj_CAMPAIGN_OFFSET_XU * 1000 + 8;//constant integer   bj_MISSION_INDEX_XU08       = bj_CAMPAIGN_OFFSET_XU * 1000 + 8
		public const int bj_MISSION_INDEX_XU09 = bj_CAMPAIGN_OFFSET_XU * 1000 + 9;//constant integer   bj_MISSION_INDEX_XU09       = bj_CAMPAIGN_OFFSET_XU * 1000 + 9
		public const int bj_MISSION_INDEX_XU10 = bj_CAMPAIGN_OFFSET_XU * 1000 + 10;//constant integer   bj_MISSION_INDEX_XU10       = bj_CAMPAIGN_OFFSET_XU * 1000 + 10
		public const int bj_MISSION_INDEX_XU11 = bj_CAMPAIGN_OFFSET_XU * 1000 + 11;//constant integer   bj_MISSION_INDEX_XU11       = bj_CAMPAIGN_OFFSET_XU * 1000 + 11
		public const int bj_MISSION_INDEX_XU12 = bj_CAMPAIGN_OFFSET_XU * 1000 + 12;//constant integer   bj_MISSION_INDEX_XU12       = bj_CAMPAIGN_OFFSET_XU * 1000 + 12
		public const int bj_MISSION_INDEX_XU13 = bj_CAMPAIGN_OFFSET_XU * 1000 + 13;//constant integer   bj_MISSION_INDEX_XU13       = bj_CAMPAIGN_OFFSET_XU * 1000 + 13
		//
		public const int bj_MISSION_INDEX_XO00 = bj_CAMPAIGN_OFFSET_XO * 1000 + 0;//constant integer   bj_MISSION_INDEX_XO00       = bj_CAMPAIGN_OFFSET_XO * 1000 + 0
		//
		public const int bj_CINEMATICINDEX_TOP = 0;//constant integer   bj_CINEMATICINDEX_TOP      = 0
		public const int bj_CINEMATICINDEX_HOP = 1;//constant integer   bj_CINEMATICINDEX_HOP      = 1
		public const int bj_CINEMATICINDEX_HED = 2;//constant integer   bj_CINEMATICINDEX_HED      = 2
		public const int bj_CINEMATICINDEX_OOP = 3;//constant integer   bj_CINEMATICINDEX_OOP      = 3
		public const int bj_CINEMATICINDEX_OED = 4;//constant integer   bj_CINEMATICINDEX_OED      = 4
		public const int bj_CINEMATICINDEX_UOP = 5;//constant integer   bj_CINEMATICINDEX_UOP      = 5
		public const int bj_CINEMATICINDEX_UED = 6;//constant integer   bj_CINEMATICINDEX_UED      = 6
		public const int bj_CINEMATICINDEX_NOP = 7;//constant integer   bj_CINEMATICINDEX_NOP      = 7
		public const int bj_CINEMATICINDEX_NED = 8;//constant integer   bj_CINEMATICINDEX_NED      = 8
		public const int bj_CINEMATICINDEX_XOP = 9;//constant integer   bj_CINEMATICINDEX_XOP      = 9
		public const int bj_CINEMATICINDEX_XED = 10;//constant integer   bj_CINEMATICINDEX_XED      = 10
		//
		public const int bj_ALLIANCE_UNALLIED = 0;//constant integer   bj_ALLIANCE_UNALLIED        = 0
		public const int bj_ALLIANCE_UNALLIED_VISION = 1;//constant integer   bj_ALLIANCE_UNALLIED_VISION = 1
		public const int bj_ALLIANCE_ALLIED = 2;//constant integer   bj_ALLIANCE_ALLIED          = 2
		public const int bj_ALLIANCE_ALLIED_VISION = 3;//constant integer   bj_ALLIANCE_ALLIED_VISION   = 3
		public const int bj_ALLIANCE_ALLIED_UNITS = 4;//constant integer   bj_ALLIANCE_ALLIED_UNITS    = 4
		public const int bj_ALLIANCE_ALLIED_ADVUNITS = 5;//constant integer   bj_ALLIANCE_ALLIED_ADVUNITS = 5
		public const int bj_ALLIANCE_NEUTRAL = 6;//constant integer   bj_ALLIANCE_NEUTRAL         = 6
		public const int bj_ALLIANCE_NEUTRAL_VISION = 7;//constant integer   bj_ALLIANCE_NEUTRAL_VISION  = 7
		//
		public const int bj_KEYEVENTTYPE_DEPRESS = 0;//constant integer   bj_KEYEVENTTYPE_DEPRESS     = 0
		public const int bj_KEYEVENTTYPE_RELEASE = 1;//constant integer   bj_KEYEVENTTYPE_RELEASE     = 1
		//
		public const int bj_KEYEVENTKEY_LEFT = 0;//constant integer   bj_KEYEVENTKEY_LEFT         = 0
		public const int bj_KEYEVENTKEY_RIGHT = 1;//constant integer   bj_KEYEVENTKEY_RIGHT        = 1
		public const int bj_KEYEVENTKEY_DOWN = 2;//constant integer   bj_KEYEVENTKEY_DOWN         = 2
		public const int bj_KEYEVENTKEY_UP = 3;//constant integer   bj_KEYEVENTKEY_UP           = 3
		//
		public const int bj_TIMETYPE_ADD = 0;//constant integer   bj_TIMETYPE_ADD             = 0
		public const int bj_TIMETYPE_SET = 1;//constant integer   bj_TIMETYPE_SET             = 1
		public const int bj_TIMETYPE_SUB = 2;//constant integer   bj_TIMETYPE_SUB             = 2
		//
		public const int bj_CAMERABOUNDS_ADJUST_ADD = 0;//constant integer   bj_CAMERABOUNDS_ADJUST_ADD  = 0
		public const int bj_CAMERABOUNDS_ADJUST_SUB = 1;//constant integer   bj_CAMERABOUNDS_ADJUST_SUB  = 1
		//
		public const int bj_QUESTTYPE_REQ_DISCOVERED = 0;//constant integer   bj_QUESTTYPE_REQ_DISCOVERED   = 0
		public const int bj_QUESTTYPE_REQ_UNDISCOVERED = 1;//constant integer   bj_QUESTTYPE_REQ_UNDISCOVERED = 1
		public const int bj_QUESTTYPE_OPT_DISCOVERED = 2;//constant integer   bj_QUESTTYPE_OPT_DISCOVERED   = 2
		public const int bj_QUESTTYPE_OPT_UNDISCOVERED = 3;//constant integer   bj_QUESTTYPE_OPT_UNDISCOVERED = 3
		//
		public const int bj_QUESTMESSAGE_DISCOVERED = 0;//constant integer   bj_QUESTMESSAGE_DISCOVERED    = 0
		public const int bj_QUESTMESSAGE_UPDATED = 1;//constant integer   bj_QUESTMESSAGE_UPDATED       = 1
		public const int bj_QUESTMESSAGE_COMPLETED = 2;//constant integer   bj_QUESTMESSAGE_COMPLETED     = 2
		public const int bj_QUESTMESSAGE_FAILED = 3;//constant integer   bj_QUESTMESSAGE_FAILED        = 3
		public const int bj_QUESTMESSAGE_REQUIREMENT = 4;//constant integer   bj_QUESTMESSAGE_REQUIREMENT   = 4
		public const int bj_QUESTMESSAGE_MISSIONFAILED = 5;//constant integer   bj_QUESTMESSAGE_MISSIONFAILED = 5
		public const int bj_QUESTMESSAGE_ALWAYSHINT = 6;//constant integer   bj_QUESTMESSAGE_ALWAYSHINT    = 6
		public const int bj_QUESTMESSAGE_HINT = 7;//constant integer   bj_QUESTMESSAGE_HINT          = 7
		public const int bj_QUESTMESSAGE_SECRET = 8;//constant integer   bj_QUESTMESSAGE_SECRET        = 8
		public const int bj_QUESTMESSAGE_UNITACQUIRED = 9;//constant integer   bj_QUESTMESSAGE_UNITACQUIRED  = 9
		public const int bj_QUESTMESSAGE_UNITAVAILABLE = 10;//constant integer   bj_QUESTMESSAGE_UNITAVAILABLE = 10
		public const int bj_QUESTMESSAGE_ITEMACQUIRED = 11;//constant integer   bj_QUESTMESSAGE_ITEMACQUIRED  = 11
		public const int bj_QUESTMESSAGE_WARNING = 12;//constant integer   bj_QUESTMESSAGE_WARNING       = 12
		//
		public const int bj_SORTTYPE_SORTBYVALUE = 0;//constant integer   bj_SORTTYPE_SORTBYVALUE     = 0
		public const int bj_SORTTYPE_SORTBYPLAYER = 1;//constant integer   bj_SORTTYPE_SORTBYPLAYER    = 1
		public const int bj_SORTTYPE_SORTBYLABEL = 2;//constant integer   bj_SORTTYPE_SORTBYLABEL     = 2
		//
		public const int bj_CINEFADETYPE_FADEIN = 0;//constant integer   bj_CINEFADETYPE_FADEIN      = 0
		public const int bj_CINEFADETYPE_FADEOUT = 1;//constant integer   bj_CINEFADETYPE_FADEOUT     = 1
		public const int bj_CINEFADETYPE_FADEOUTIN = 2;//constant integer   bj_CINEFADETYPE_FADEOUTIN   = 2
		//
		public const int bj_REMOVEBUFFS_POSITIVE = 0;//constant integer   bj_REMOVEBUFFS_POSITIVE     = 0
		public const int bj_REMOVEBUFFS_NEGATIVE = 1;//constant integer   bj_REMOVEBUFFS_NEGATIVE     = 1
		public const int bj_REMOVEBUFFS_ALL = 2;//constant integer   bj_REMOVEBUFFS_ALL          = 2
		public const int bj_REMOVEBUFFS_NONTLIFE = 3;//constant integer   bj_REMOVEBUFFS_NONTLIFE     = 3
		//
		public const int bj_BUFF_POLARITY_POSITIVE = 0;//constant integer   bj_BUFF_POLARITY_POSITIVE   = 0
		public const int bj_BUFF_POLARITY_NEGATIVE = 1;//constant integer   bj_BUFF_POLARITY_NEGATIVE   = 1
		public const int bj_BUFF_POLARITY_EITHER = 2;//constant integer   bj_BUFF_POLARITY_EITHER     = 2
		//
		public const int bj_BUFF_RESIST_MAGIC = 0;//constant integer   bj_BUFF_RESIST_MAGIC        = 0
		public const int bj_BUFF_RESIST_PHYSICAL = 1;//constant integer   bj_BUFF_RESIST_PHYSICAL     = 1
		public const int bj_BUFF_RESIST_EITHER = 2;//constant integer   bj_BUFF_RESIST_EITHER       = 2
		public const int bj_BUFF_RESIST_BOTH = 3;//constant integer   bj_BUFF_RESIST_BOTH         = 3
		//
		public const int bj_HEROSTAT_STR = 0;//constant integer   bj_HEROSTAT_STR             = 0
		public const int bj_HEROSTAT_AGI = 1;//constant integer   bj_HEROSTAT_AGI             = 1
		public const int bj_HEROSTAT_INT = 2;//constant integer   bj_HEROSTAT_INT             = 2
		//
		public const int bj_MODIFYMETHOD_ADD = 0;//constant integer   bj_MODIFYMETHOD_ADD    = 0
		public const int bj_MODIFYMETHOD_SUB = 1;//constant integer   bj_MODIFYMETHOD_SUB    = 1
		public const int bj_MODIFYMETHOD_SET = 2;//constant integer   bj_MODIFYMETHOD_SET    = 2
		//
		public const int bj_UNIT_STATE_METHOD_ABSOLUTE = 0;//constant integer   bj_UNIT_STATE_METHOD_ABSOLUTE = 0
		public const int bj_UNIT_STATE_METHOD_RELATIVE = 1;//constant integer   bj_UNIT_STATE_METHOD_RELATIVE = 1
		public const int bj_UNIT_STATE_METHOD_DEFAULTS = 2;//constant integer   bj_UNIT_STATE_METHOD_DEFAULTS = 2
		public const int bj_UNIT_STATE_METHOD_MAXIMUM = 3;//constant integer   bj_UNIT_STATE_METHOD_MAXIMUM  = 3
		//
		public const int bj_GATEOPERATION_CLOSE = 0;//constant integer   bj_GATEOPERATION_CLOSE      = 0
		public const int bj_GATEOPERATION_OPEN = 1;//constant integer   bj_GATEOPERATION_OPEN       = 1
		public const int bj_GATEOPERATION_DESTROY = 2;//constant integer   bj_GATEOPERATION_DESTROY    = 2
		//
		public const int bj_GAMECACHE_BOOLEAN = 0;//constant integer   bj_GAMECACHE_BOOLEAN                 = 0
		public const int bj_GAMECACHE_INTEGER = 1;//constant integer   bj_GAMECACHE_INTEGER                 = 1
		public const int bj_GAMECACHE_REAL = 2;//constant integer   bj_GAMECACHE_REAL                    = 2
		public const int bj_GAMECACHE_UNIT = 3;//constant integer   bj_GAMECACHE_UNIT                    = 3
		public const int bj_GAMECACHE_STRING = 4;//constant integer   bj_GAMECACHE_STRING                  = 4
		//
		public const int bj_HASHTABLE_BOOLEAN = 0;//constant integer   bj_HASHTABLE_BOOLEAN                 = 0
		public const int bj_HASHTABLE_INTEGER = 1;//constant integer   bj_HASHTABLE_INTEGER                 = 1
		public const int bj_HASHTABLE_REAL = 2;//constant integer   bj_HASHTABLE_REAL                    = 2
		public const int bj_HASHTABLE_STRING = 3;//constant integer   bj_HASHTABLE_STRING                  = 3
		public const int bj_HASHTABLE_HANDLE = 4;//constant integer   bj_HASHTABLE_HANDLE                  = 4
		//
		public const int bj_ITEM_STATUS_HIDDEN = 0;//constant integer   bj_ITEM_STATUS_HIDDEN       = 0
		public const int bj_ITEM_STATUS_OWNED = 1;//constant integer   bj_ITEM_STATUS_OWNED        = 1
		public const int bj_ITEM_STATUS_INVULNERABLE = 2;//constant integer   bj_ITEM_STATUS_INVULNERABLE = 2
		public const int bj_ITEM_STATUS_POWERUP = 3;//constant integer   bj_ITEM_STATUS_POWERUP      = 3
		public const int bj_ITEM_STATUS_SELLABLE = 4;//constant integer   bj_ITEM_STATUS_SELLABLE     = 4
		public const int bj_ITEM_STATUS_PAWNABLE = 5;//constant integer   bj_ITEM_STATUS_PAWNABLE     = 5
		//
		public const int bj_ITEMCODE_STATUS_POWERUP = 0;//constant integer   bj_ITEMCODE_STATUS_POWERUP  = 0
		public const int bj_ITEMCODE_STATUS_SELLABLE = 1;//constant integer   bj_ITEMCODE_STATUS_SELLABLE = 1
		public const int bj_ITEMCODE_STATUS_PAWNABLE = 2;//constant integer   bj_ITEMCODE_STATUS_PAWNABLE = 2
		//
		public const int bj_MINIMAPPINGSTYLE_SIMPLE = 0;//constant integer   bj_MINIMAPPINGSTYLE_SIMPLE  = 0
		public const int bj_MINIMAPPINGSTYLE_FLASHY = 1;//constant integer   bj_MINIMAPPINGSTYLE_FLASHY  = 1
		public const int bj_MINIMAPPINGSTYLE_ATTACK = 2;//constant integer   bj_MINIMAPPINGSTYLE_ATTACK  = 2
		//
		public const float bj_CORPSE_MAX_DEATH_TIME = 8.00;//constant real      bj_CORPSE_MAX_DEATH_TIME    = 8.00
		//
		public const int bj_CORPSETYPE_FLESH = 0;//constant integer   bj_CORPSETYPE_FLESH         = 0
		public const int bj_CORPSETYPE_BONE = 1;//constant integer   bj_CORPSETYPE_BONE          = 1
		//
		public const int bj_ELEVATOR_BLOCKER_CODE = 'DTep';//constant integer   bj_ELEVATOR_BLOCKER_CODE    = 'DTep'
		public const int bj_ELEVATOR_CODE01 = 'DTrf';//constant integer   bj_ELEVATOR_CODE01          = 'DTrf'
		public const int bj_ELEVATOR_CODE02 = 'DTrx';//constant integer   bj_ELEVATOR_CODE02          = 'DTrx'
		//
		public const int bj_ELEVATOR_WALL_TYPE_ALL = 0;//constant integer   bj_ELEVATOR_WALL_TYPE_ALL        = 0
		public const int bj_ELEVATOR_WALL_TYPE_EAST = 1;//constant integer   bj_ELEVATOR_WALL_TYPE_EAST       = 1
		public const int bj_ELEVATOR_WALL_TYPE_NORTH = 2;//constant integer   bj_ELEVATOR_WALL_TYPE_NORTH      = 2
		public const int bj_ELEVATOR_WALL_TYPE_SOUTH = 3;//constant integer   bj_ELEVATOR_WALL_TYPE_SOUTH      = 3
		public const int bj_ELEVATOR_WALL_TYPE_WEST = 4;//constant integer   bj_ELEVATOR_WALL_TYPE_WEST       = 4
		//
		//
		//
		//
		public static force bj_FORCE_ALL_PLAYERS = null;//force              bj_FORCE_ALL_PLAYERS        = null
		public static force[] bj_FORCE_PLAYER;//force array        bj_FORCE_PLAYER
		public static int bj_MELEE_MAX_TWINKED_HEROES = 0;//integer            bj_MELEE_MAX_TWINKED_HEROES = 0
		//
		public static rect bj_mapInitialPlayableArea = null;//rect               bj_mapInitialPlayableArea   = null
		public static rect bj_mapInitialCameraBounds = null;//rect               bj_mapInitialCameraBounds   = null
		//
		public static int bj_forLoopAIndex = 0;//integer            bj_forLoopAIndex            = 0
		public static int bj_forLoopBIndex = 0;//integer            bj_forLoopBIndex            = 0
		public static int bj_forLoopAIndexEnd = 0;//integer            bj_forLoopAIndexEnd         = 0
		public static int bj_forLoopBIndexEnd = 0;//integer            bj_forLoopBIndexEnd         = 0
		public static bool bj_slotControlReady = false;//boolean            bj_slotControlReady         = false
		public static bool[] bj_slotControlUsed;//boolean array      bj_slotControlUsed
		public static mapcontrol[] bj_slotControl;//mapcontrol array   bj_slotControl
		//
		public static timer bj_gameStartedTimer = null;//timer              bj_gameStartedTimer         = null
		public static bool bj_gameStarted = false;//boolean            bj_gameStarted              = false
		public static timer bj_volumeGroupsTimer = CreateTimer();//timer              bj_volumeGroupsTimer        = CreateTimer()
		//
		public static bool bj_isSinglePlayer = false;//boolean            bj_isSinglePlayer           = false
		//
		public static trigger bj_dncSoundsDay = null;//trigger            bj_dncSoundsDay             = null
		public static trigger bj_dncSoundsNight = null;//trigger            bj_dncSoundsNight           = null
		public static sound bj_dayAmbientSound = null;//sound              bj_dayAmbientSound          = null
		public static sound bj_nightAmbientSound = null;//sound              bj_nightAmbientSound        = null
		public static trigger bj_dncSoundsDawn = null;//trigger            bj_dncSoundsDawn            = null
		public static trigger bj_dncSoundsDusk = null;//trigger            bj_dncSoundsDusk            = null
		public static sound bj_dawnSound = null;//sound              bj_dawnSound                = null
		public static sound bj_duskSound = null;//sound              bj_duskSound                = null
		public static bool bj_useDawnDuskSounds = true;//boolean            bj_useDawnDuskSounds        = true
		public static bool bj_dncIsDaytime = false;//boolean            bj_dncIsDaytime             = false
		//
		//
		public static sound bj_rescueSound = null;//sound              bj_rescueSound              = null
		public static sound bj_questDiscoveredSound = null;//sound              bj_questDiscoveredSound     = null
		public static sound bj_questUpdatedSound = null;//sound              bj_questUpdatedSound        = null
		public static sound bj_questCompletedSound = null;//sound              bj_questCompletedSound      = null
		public static sound bj_questFailedSound = null;//sound              bj_questFailedSound         = null
		public static sound bj_questHintSound = null;//sound              bj_questHintSound           = null
		public static sound bj_questSecretSound = null;//sound              bj_questSecretSound         = null
		public static sound bj_questItemAcquiredSound = null;//sound              bj_questItemAcquiredSound   = null
		public static sound bj_questWarningSound = null;//sound              bj_questWarningSound        = null
		public static sound bj_victoryDialogSound = null;//sound              bj_victoryDialogSound       = null
		public static sound bj_defeatDialogSound = null;//sound              bj_defeatDialogSound        = null
		//
		public static trigger bj_stockItemPurchased = null;//trigger            bj_stockItemPurchased       = null
		public static timer bj_stockUpdateTimer = null;//timer              bj_stockUpdateTimer         = null
		public static bool[] bj_stockAllowedPermanent;//boolean array      bj_stockAllowedPermanent
		public static bool[] bj_stockAllowedCharged;//boolean array      bj_stockAllowedCharged
		public static bool[] bj_stockAllowedArtifact;//boolean array      bj_stockAllowedArtifact
		public static int bj_stockPickedItemLevel = 0;//integer            bj_stockPickedItemLevel     = 0
		public static itemtype bj_stockPickedItemType;//itemtype           bj_stockPickedItemType
		//
		public static trigger bj_meleeVisibilityTrained = null;//trigger            bj_meleeVisibilityTrained   = null
		public static bool bj_meleeVisibilityIsDay = true;//boolean            bj_meleeVisibilityIsDay     = true
		public static bool bj_meleeGrantHeroItems = false;//boolean            bj_meleeGrantHeroItems      = false
		public static location bj_meleeNearestMineToLoc = null;//location           bj_meleeNearestMineToLoc    = null
		public static unit bj_meleeNearestMine = null;//unit               bj_meleeNearestMine         = null
		public static float bj_meleeNearestMineDist = 0.00;//real               bj_meleeNearestMineDist     = 0.00
		public static bool bj_meleeGameOver = false;//boolean            bj_meleeGameOver            = false
		public static bool[] bj_meleeDefeated;//boolean array      bj_meleeDefeated
		public static bool[] bj_meleeVictoried;//boolean array      bj_meleeVictoried
		public static unit[] bj_ghoul;//unit array         bj_ghoul
		public static timer[] bj_crippledTimer;//timer array        bj_crippledTimer
		public static timerdialog[] bj_crippledTimerWindows;//timerdialog array  bj_crippledTimerWindows
		public static bool[] bj_playerIsCrippled;//boolean array      bj_playerIsCrippled
		public static bool[] bj_playerIsExposed;//boolean array      bj_playerIsExposed
		public static bool bj_finishSoonAllExposed = false;//boolean            bj_finishSoonAllExposed     = false
		public static timerdialog bj_finishSoonTimerDialog = null;//timerdialog        bj_finishSoonTimerDialog    = null
		public static int[] bj_meleeTwinkedHeroes;//integer array      bj_meleeTwinkedHeroes
		//
		public static trigger bj_rescueUnitBehavior = null;//trigger            bj_rescueUnitBehavior       = null
		public static bool bj_rescueChangeColorUnit = true;//boolean            bj_rescueChangeColorUnit    = true
		public static bool bj_rescueChangeColorBldg = true;//boolean            bj_rescueChangeColorBldg    = true
		//
		public static timer bj_cineSceneEndingTimer = null;//timer              bj_cineSceneEndingTimer     = null
		public static sound bj_cineSceneLastSound = null;//sound              bj_cineSceneLastSound       = null
		public static trigger bj_cineSceneBeingSkipped = null;//trigger            bj_cineSceneBeingSkipped    = null
		//
		public static gamespeed bj_cineModePriorSpeed = MAP_SPEED_NORMAL;//gamespeed          bj_cineModePriorSpeed       = MAP_SPEED_NORMAL
		public static bool bj_cineModePriorFogSetting = false;//boolean            bj_cineModePriorFogSetting  = false
		public static bool bj_cineModePriorMaskSetting = false;//boolean            bj_cineModePriorMaskSetting = false
		public static bool bj_cineModeAlreadyIn = false;//boolean            bj_cineModeAlreadyIn        = false
		public static bool bj_cineModePriorDawnDusk = false;//boolean            bj_cineModePriorDawnDusk    = false
		public static int bj_cineModeSavedSeed = 0;//integer            bj_cineModeSavedSeed        = 0
		//
		public static timer bj_cineFadeFinishTimer = null;//timer              bj_cineFadeFinishTimer      = null
		public static timer bj_cineFadeContinueTimer = null;//timer              bj_cineFadeContinueTimer    = null
		public static float bj_cineFadeContinueRed = 0;//real               bj_cineFadeContinueRed      = 0
		public static float bj_cineFadeContinueGreen = 0;//real               bj_cineFadeContinueGreen    = 0
		public static float bj_cineFadeContinueBlue = 0;//real               bj_cineFadeContinueBlue     = 0
		public static float bj_cineFadeContinueTrans = 0;//real               bj_cineFadeContinueTrans    = 0
		public static float bj_cineFadeContinueDuration = 0;//real               bj_cineFadeContinueDuration = 0
		public static string bj_cineFadeContinueTex = "";//string             bj_cineFadeContinueTex      = ""
		//
		public static int bj_queuedExecTotal = 0;//integer            bj_queuedExecTotal          = 0
		public static trigger[] bj_queuedExecTriggers;//trigger array      bj_queuedExecTriggers
		public static bool[] bj_queuedExecUseConds;//boolean array      bj_queuedExecUseConds
		public static timer bj_queuedExecTimeoutTimer = CreateTimer();//timer              bj_queuedExecTimeoutTimer   = CreateTimer()
		public static trigger bj_queuedExecTimeout = null;//trigger            bj_queuedExecTimeout        = null
		//
		public static int bj_destInRegionDiesCount = 0;//integer            bj_destInRegionDiesCount    = 0
		public static trigger bj_destInRegionDiesTrig = null;//trigger            bj_destInRegionDiesTrig     = null
		public static int bj_groupCountUnits = 0;//integer            bj_groupCountUnits          = 0
		public static int bj_forceCountPlayers = 0;//integer            bj_forceCountPlayers        = 0
		public static int bj_groupEnumTypeId = 0;//integer            bj_groupEnumTypeId          = 0
		public static player bj_groupEnumOwningPlayer = null;//player             bj_groupEnumOwningPlayer    = null
		public static group bj_groupAddGroupDest = null;//group              bj_groupAddGroupDest        = null
		public static group bj_groupRemoveGroupDest = null;//group              bj_groupRemoveGroupDest     = null
		public static int bj_groupRandomConsidered = 0;//integer            bj_groupRandomConsidered    = 0
		public static unit bj_groupRandomCurrentPick = null;//unit               bj_groupRandomCurrentPick   = null
		public static group bj_groupLastCreatedDest = null;//group              bj_groupLastCreatedDest     = null
		public static group bj_randomSubGroupGroup = null;//group              bj_randomSubGroupGroup      = null
		public static int bj_randomSubGroupWant = 0;//integer            bj_randomSubGroupWant       = 0
		public static int bj_randomSubGroupTotal = 0;//integer            bj_randomSubGroupTotal      = 0
		public static float bj_randomSubGroupChance = 0;//real               bj_randomSubGroupChance     = 0
		public static int bj_destRandomConsidered = 0;//integer            bj_destRandomConsidered     = 0
		public static destructable bj_destRandomCurrentPick = null;//destructable       bj_destRandomCurrentPick    = null
		public static destructable bj_elevatorWallBlocker = null;//destructable       bj_elevatorWallBlocker      = null
		public static destructable bj_elevatorNeighbor = null;//destructable       bj_elevatorNeighbor         = null
		public static int bj_itemRandomConsidered = 0;//integer            bj_itemRandomConsidered     = 0
		public static item bj_itemRandomCurrentPick = null;//item               bj_itemRandomCurrentPick    = null
		public static int bj_forceRandomConsidered = 0;//integer            bj_forceRandomConsidered    = 0
		public static player bj_forceRandomCurrentPick = null;//player             bj_forceRandomCurrentPick   = null
		public static unit bj_makeUnitRescuableUnit = null;//unit               bj_makeUnitRescuableUnit    = null
		public static bool bj_makeUnitRescuableFlag = true;//boolean            bj_makeUnitRescuableFlag    = true
		public static bool bj_pauseAllUnitsFlag = true;//boolean            bj_pauseAllUnitsFlag        = true
		public static location bj_enumDestructableCenter = null;//location           bj_enumDestructableCenter   = null
		public static float bj_enumDestructableRadius = 0;//real               bj_enumDestructableRadius   = 0
		public static playercolor bj_setPlayerTargetColor = null;//playercolor        bj_setPlayerTargetColor     = null
		public static bool bj_isUnitGroupDeadResult = true;//boolean            bj_isUnitGroupDeadResult    = true
		public static bool bj_isUnitGroupEmptyResult = true;//boolean            bj_isUnitGroupEmptyResult   = true
		public static bool bj_isUnitGroupInRectResult = true;//boolean            bj_isUnitGroupInRectResult  = true
		public static rect bj_isUnitGroupInRectRect = null;//rect               bj_isUnitGroupInRectRect    = null
		public static bool bj_changeLevelShowScores = false;//boolean            bj_changeLevelShowScores    = false
		public static string bj_changeLevelMapName = null;//string             bj_changeLevelMapName       = null
		public static group bj_suspendDecayFleshGroup = CreateGroup();//group              bj_suspendDecayFleshGroup   = CreateGroup()
		public static group bj_suspendDecayBoneGroup = CreateGroup();//group              bj_suspendDecayBoneGroup    = CreateGroup()
		public static timer bj_delayedSuspendDecayTimer = CreateTimer();//timer              bj_delayedSuspendDecayTimer = CreateTimer()
		public static trigger bj_delayedSuspendDecayTrig = null;//trigger            bj_delayedSuspendDecayTrig  = null
		public static int bj_livingPlayerUnitsTypeId = 0;//integer            bj_livingPlayerUnitsTypeId  = 0
		public static widget bj_lastDyingWidget = null;//widget             bj_lastDyingWidget          = null
		//
		public static int bj_randDistCount = 0;//integer            bj_randDistCount            = 0
		public static int[] bj_randDistID;//integer array      bj_randDistID
		public static int[] bj_randDistChance;//integer array      bj_randDistChance
		//
		public static unit bj_lastCreatedUnit = null;//unit               bj_lastCreatedUnit          = null
		public static item bj_lastCreatedItem = null;//item               bj_lastCreatedItem          = null
		public static item bj_lastRemovedItem = null;//item               bj_lastRemovedItem          = null
		public static unit bj_lastHauntedGoldMine = null;//unit               bj_lastHauntedGoldMine      = null
		public static destructable bj_lastCreatedDestructable = null;//destructable       bj_lastCreatedDestructable  = null
		public static group bj_lastCreatedGroup = CreateGroup();//group              bj_lastCreatedGroup         = CreateGroup()
		public static fogmodifier bj_lastCreatedFogModifier = null;//fogmodifier        bj_lastCreatedFogModifier   = null
		public static effect bj_lastCreatedEffect = null;//effect             bj_lastCreatedEffect        = null
		public static weathereffect bj_lastCreatedWeatherEffect = null;//weathereffect      bj_lastCreatedWeatherEffect = null
		public static terraindeformation bj_lastCreatedTerrainDeformation = null;//terraindeformation bj_lastCreatedTerrainDeformation = null
		public static quest bj_lastCreatedQuest = null;//quest              bj_lastCreatedQuest         = null
		public static questitem bj_lastCreatedQuestItem = null;//questitem          bj_lastCreatedQuestItem     = null
		public static defeatcondition bj_lastCreatedDefeatCondition = null;//defeatcondition    bj_lastCreatedDefeatCondition = null
		public static timer bj_lastStartedTimer = CreateTimer();//timer              bj_lastStartedTimer         = CreateTimer()
		public static timerdialog bj_lastCreatedTimerDialog = null;//timerdialog        bj_lastCreatedTimerDialog   = null
		public static leaderboard bj_lastCreatedLeaderboard = null;//leaderboard        bj_lastCreatedLeaderboard   = null
		public static multiboard bj_lastCreatedMultiboard = null;//multiboard         bj_lastCreatedMultiboard    = null
		public static sound bj_lastPlayedSound = null;//sound              bj_lastPlayedSound          = null
		public static string bj_lastPlayedMusic = "";//string             bj_lastPlayedMusic          = ""
		public static float bj_lastTransmissionDuration = 0;//real               bj_lastTransmissionDuration = 0
		public static gamecache bj_lastCreatedGameCache = null;//gamecache          bj_lastCreatedGameCache     = null
		public static hashtable bj_lastCreatedHashtable = null;//hashtable          bj_lastCreatedHashtable     = null
		public static unit bj_lastLoadedUnit = null;//unit               bj_lastLoadedUnit           = null
		public static button bj_lastCreatedButton = null;//button             bj_lastCreatedButton        = null
		public static unit bj_lastReplacedUnit = null;//unit               bj_lastReplacedUnit         = null
		public static texttag bj_lastCreatedTextTag = null;//texttag            bj_lastCreatedTextTag       = null
		public static lightning bj_lastCreatedLightning = null;//lightning          bj_lastCreatedLightning     = null
		public static image bj_lastCreatedImage = null;//image              bj_lastCreatedImage         = null
		public static ubersplat bj_lastCreatedUbersplat = null;//ubersplat          bj_lastCreatedUbersplat     = null
		//
		public static boolexpr filterIssueHauntOrderAtLocBJ = null;//boolexpr           filterIssueHauntOrderAtLocBJ      = null
		public static boolexpr filterEnumDestructablesInCircleBJ = null;//boolexpr           filterEnumDestructablesInCircleBJ = null
		public static boolexpr filterGetUnitsInRectOfPlayer = null;//boolexpr           filterGetUnitsInRectOfPlayer      = null
		public static boolexpr filterGetUnitsOfTypeIdAll = null;//boolexpr           filterGetUnitsOfTypeIdAll         = null
		public static boolexpr filterGetUnitsOfPlayerAndTypeId = null;//boolexpr           filterGetUnitsOfPlayerAndTypeId   = null
		public static boolexpr filterMeleeTrainedUnitIsHeroBJ = null;//boolexpr           filterMeleeTrainedUnitIsHeroBJ    = null
		public static boolexpr filterLivingPlayerUnitsOfTypeId = null;//boolexpr           filterLivingPlayerUnitsOfTypeId   = null
		//
		public static bool bj_wantDestroyGroup = false;//boolean            bj_wantDestroyGroup         = false
		//
		//
		//
		//
		//
		//
		private void BJDebugMsg(string msg) {//function BJDebugMsg takes string msg returns nothing
			int i = 0;//local integer i = 0
			while (true) {//loop
				DisplayTimedTextToPlayer(Player(i),0,0,60,msg);//call DisplayTimedTextToPlayer(Player(i),0,0,60,msg)
				i = i + 1;//set i = i + 1
				if (i == bj_MAX_PLAYERS) { break; }//exitwhen i == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		//
		//
		//
		private float RMinBJ(float a, float b) {//function RMinBJ takes real a, real b returns real
			if ((a < b)) {//if (a < b) then
				return a;//return a
			} else {//else
				return b;//return b
			}//endif
		}//endfunction
		//
		private float RMaxBJ(float a, float b) {//function RMaxBJ takes real a, real b returns real
			if ((a < b)) {//if (a < b) then
				return b;//return b
			} else {//else
				return a;//return a
			}//endif
		}//endfunction
		//
		private float RAbsBJ(float a) {//function RAbsBJ takes real a returns real
			if ((a >= 0)) {//if (a >= 0) then
				return a;//return a
			} else {//else
				return -a;//return -a
			}//endif
		}//endfunction
		//
		private float RSignBJ(float a) {//function RSignBJ takes real a returns real
			if ((a >= 0.0)) {//if (a >= 0.0) then
				return 1.0;//return 1.0
			} else {//else
				return -1.0;//return -1.0
			}//endif
		}//endfunction
		//
		private int IMinBJ(int a, int b) {//function IMinBJ takes integer a, integer b returns integer
			if ((a < b)) {//if (a < b) then
				return a;//return a
			} else {//else
				return b;//return b
			}//endif
		}//endfunction
		//
		private int IMaxBJ(int a, int b) {//function IMaxBJ takes integer a, integer b returns integer
			if ((a < b)) {//if (a < b) then
				return b;//return b
			} else {//else
				return a;//return a
			}//endif
		}//endfunction
		//
		private int IAbsBJ(int a) {//function IAbsBJ takes integer a returns integer
			if ((a >= 0)) {//if (a >= 0) then
				return a;//return a
			} else {//else
				return -a;//return -a
			}//endif
		}//endfunction
		//
		private int ISignBJ(int a) {//function ISignBJ takes integer a returns integer
			if ((a >= 0)) {//if (a >= 0) then
				return 1;//return 1
			} else {//else
				return -1;//return -1
			}//endif
		}//endfunction
		//
		private float SinBJ(float degrees) {//function SinBJ takes real degrees returns real
			return Sin(degrees * bj_DEGTORAD);//return Sin(degrees * bj_DEGTORAD)
		}//endfunction
		//
		private float CosBJ(float degrees) {//function CosBJ takes real degrees returns real
			return Cos(degrees * bj_DEGTORAD);//return Cos(degrees * bj_DEGTORAD)
		}//endfunction
		//
		private float TanBJ(float degrees) {//function TanBJ takes real degrees returns real
			return Tan(degrees * bj_DEGTORAD);//return Tan(degrees * bj_DEGTORAD)
		}//endfunction
		//
		private float AsinBJ(float degrees) {//function AsinBJ takes real degrees returns real
			return Asin(degrees) * bj_RADTODEG;//return Asin(degrees) * bj_RADTODEG
		}//endfunction
		//
		private float AcosBJ(float degrees) {//function AcosBJ takes real degrees returns real
			return Acos(degrees) * bj_RADTODEG;//return Acos(degrees) * bj_RADTODEG
		}//endfunction
		//
		private float AtanBJ(float degrees) {//function AtanBJ takes real degrees returns real
			return Atan(degrees) * bj_RADTODEG;//return Atan(degrees) * bj_RADTODEG
		}//endfunction
		//
		private float Atan2BJ(float y, float x) {//function Atan2BJ takes real y, real x returns real
			return Atan2(y, x) * bj_RADTODEG;//return Atan2(y, x) * bj_RADTODEG
		}//endfunction
		//
		private float AngleBetweenPoints(location locA, location locB) {//function AngleBetweenPoints takes location locA, location locB returns real
			return bj_RADTODEG * Atan2(GetLocationY(locB) - GetLocationY(locA), GetLocationX(locB) - GetLocationX(locA));//return bj_RADTODEG * Atan2(GetLocationY(locB) - GetLocationY(locA), GetLocationX(locB) - GetLocationX(locA))
		}//endfunction
		//
		private float DistanceBetweenPoints(location locA, location locB) {//function DistanceBetweenPoints takes location locA, location locB returns real
			float dx = GetLocationX(locB) - GetLocationX(locA);//local real dx = GetLocationX(locB) - GetLocationX(locA)
			float dy = GetLocationY(locB) - GetLocationY(locA);//local real dy = GetLocationY(locB) - GetLocationY(locA)
			return SquareRoot(dx * dx + dy * dy);//return SquareRoot(dx * dx + dy * dy)
		}//endfunction
		//
		private location PolarProjectionBJ(location source, float dist, float angle) {//function PolarProjectionBJ takes location source, real dist, real angle returns location
			float x = GetLocationX(source) + dist * Cos(angle * bj_DEGTORAD);//local real x = GetLocationX(source) + dist * Cos(angle * bj_DEGTORAD)
			float y = GetLocationY(source) + dist * Sin(angle * bj_DEGTORAD);//local real y = GetLocationY(source) + dist * Sin(angle * bj_DEGTORAD)
			return Location(x, y);//return Location(x, y)
		}//endfunction
		//
		private float GetRandomDirectionDeg() {//function GetRandomDirectionDeg takes nothing returns real
			return GetRandomReal(0, 360);//return GetRandomReal(0, 360)
		}//endfunction
		//
		private float GetRandomPercentageBJ() {//function GetRandomPercentageBJ takes nothing returns real
			return GetRandomReal(0, 100);//return GetRandomReal(0, 100)
		}//endfunction
		//
		private location GetRandomLocInRect(rect whichRect) {//function GetRandomLocInRect takes rect whichRect returns location
			return Location(GetRandomReal(GetRectMinX(whichRect), GetRectMaxX(whichRect)), GetRandomReal(GetRectMinY(whichRect), GetRectMaxY(whichRect)));//return Location(GetRandomReal(GetRectMinX(whichRect), GetRectMaxX(whichRect)), GetRandomReal(GetRectMinY(whichRect), GetRectMaxY(whichRect)))
		}//endfunction
		//
		//
		//
		//
		private int ModuloInteger(int dividend, int divisor) {//function ModuloInteger takes integer dividend, integer divisor returns integer
			int modulus = dividend - (dividend / divisor) * divisor;//local integer modulus = dividend - (dividend / divisor) * divisor
			//
			//
			//
			if ((modulus < 0)) {//if (modulus < 0) then
				modulus = modulus + divisor;//set modulus = modulus + divisor
			}//endif
			return modulus;//return modulus
		}//endfunction
		//
		//
		//
		//
		private float ModuloReal(float dividend, float divisor) {//function ModuloReal takes real dividend, real divisor returns real
			float modulus = dividend - I2R(R2I(dividend / divisor)) * divisor;//local real modulus = dividend - I2R(R2I(dividend / divisor)) * divisor
			//
			//
			//
			if ((modulus < 0)) {//if (modulus < 0) then
				modulus = modulus + divisor;//set modulus = modulus + divisor
			}//endif
			return modulus;//return modulus
		}//endfunction
		//
		private location OffsetLocation(location loc, float dx, float dy) {//function OffsetLocation takes location loc, real dx, real dy returns location
			return Location(GetLocationX(loc) + dx, GetLocationY(loc) + dy);//return Location(GetLocationX(loc) + dx, GetLocationY(loc) + dy)
		}//endfunction
		//
		private rect OffsetRectBJ(rect r, float dx, float dy) {//function OffsetRectBJ takes rect r, real dx, real dy returns rect
			return Rect( GetRectMinX(r) + dx, GetRectMinY(r) + dy, GetRectMaxX(r) + dx, GetRectMaxY(r) + dy );//return Rect( GetRectMinX(r) + dx, GetRectMinY(r) + dy, GetRectMaxX(r) + dx, GetRectMaxY(r) + dy )
		}//endfunction
		//
		private rect RectFromCenterSizeBJ(location center, float width, float height) {//function RectFromCenterSizeBJ takes location center, real width, real height returns rect
			float x = GetLocationX( center );//local real x = GetLocationX( center )
			float y = GetLocationY( center );//local real y = GetLocationY( center )
			return Rect( x - width*0.5, y - height*0.5, x + width*0.5, y + height*0.5 );//return Rect( x - width*0.5, y - height*0.5, x + width*0.5, y + height*0.5 )
		}//endfunction
		//
		private bool RectContainsCoords(rect r, float x, float y) {//function RectContainsCoords takes rect r, real x, real y returns boolean
			return (GetRectMinX(r) <= x) && (x <= GetRectMaxX(r)) && (GetRectMinY(r) <= y) && (y <= GetRectMaxY(r));//return (GetRectMinX(r) <= x) and (x <= GetRectMaxX(r)) and (GetRectMinY(r) <= y) and (y <= GetRectMaxY(r))
		}//endfunction
		//
		private bool RectContainsLoc(rect r, location loc) {//function RectContainsLoc takes rect r, location loc returns boolean
			return RectContainsCoords(r, GetLocationX(loc), GetLocationY(loc));//return RectContainsCoords(r, GetLocationX(loc), GetLocationY(loc))
		}//endfunction
		//
		private bool RectContainsUnit(rect r, unit whichUnit) {//function RectContainsUnit takes rect r, unit whichUnit returns boolean
			return RectContainsCoords(r, GetUnitX(whichUnit), GetUnitY(whichUnit));//return RectContainsCoords(r, GetUnitX(whichUnit), GetUnitY(whichUnit))
		}//endfunction
		//
		private bool RectContainsItem(item whichItem, rect r) {//function RectContainsItem takes item whichItem, rect r returns boolean
			if ((whichItem == null)) {//if (whichItem == null) then
				return false;//return false
			}//endif
			if ((IsItemOwned(whichItem))) {//if (IsItemOwned(whichItem)) then
				return false;//return false
			}//endif
			return RectContainsCoords(r, GetItemX(whichItem), GetItemY(whichItem));//return RectContainsCoords(r, GetItemX(whichItem), GetItemY(whichItem))
		}//endfunction
		//
		//
		//
		//
		//
		//
		//
		//
		private void ConditionalTriggerExecute(trigger trig) {//function ConditionalTriggerExecute takes trigger trig returns nothing
			if (TriggerEvaluate(trig)) {//if TriggerEvaluate(trig) then
				TriggerExecute(trig);//call TriggerExecute(trig)
			}//endif
		}//endfunction
		//
		//
		//
		private bool TriggerExecuteBJ(trigger trig, bool checkConditions) {//function TriggerExecuteBJ takes trigger trig, boolean checkConditions returns boolean
			if (checkConditions) {//if checkConditions then
				if (!(TriggerEvaluate(trig))) {//if not (TriggerEvaluate(trig)) then
					return false;//return false
				}//endif
			}//endif
			TriggerExecute(trig);//call TriggerExecute(trig)
			return true;//return true
		}//endfunction
		//
		//
		//
		//
		//
		private bool PostTriggerExecuteBJ(trigger trig, bool checkConditions) {//function PostTriggerExecuteBJ takes trigger trig, boolean checkConditions returns boolean
			if (checkConditions) {//if checkConditions then
				if (!(TriggerEvaluate(trig))) {//if not (TriggerEvaluate(trig)) then
					return false;//return false
				}//endif
			}//endif
			TriggerRegisterTimerEvent(trig, 0, false);//call TriggerRegisterTimerEvent(trig, 0, false)
			return true;//return true
		}//endfunction
		//
		//
		//
		private void QueuedTriggerCheck() {//function QueuedTriggerCheck takes nothing returns nothing
			string s = "TrigQueue Check ";//local string s = "TrigQueue Check "
			int i;//local integer i
			i = 0;//set i = 0
			while (true) {//loop
				if (i >= bj_queuedExecTotal) { break; }//exitwhen i >= bj_queuedExecTotal
				s = s + "q[" + I2S(i) + "]=";//set s = s + "q[" + I2S(i) + "]="
				if ((bj_queuedExecTriggers[i] == null)) {//if (bj_queuedExecTriggers[i] == null) then
					s = s + "null ";//set s = s + "null "
				} else {//else
					s = s + "x ";//set s = s + "x "
				}//endif
				i = i + 1;//set i = i + 1
			}//endloop
			s = s + "(" + I2S(bj_queuedExecTotal) + " total)";//set s = s + "(" + I2S(bj_queuedExecTotal) + " total)"
			DisplayTimedTextToPlayer(GetLocalPlayer(),0,0,600,s);//call DisplayTimedTextToPlayer(GetLocalPlayer(),0,0,600,s)
		}//endfunction
		//
		//
		//
		//
		private int QueuedTriggerGetIndex(trigger trig) {//function QueuedTriggerGetIndex takes trigger trig returns integer
			//
			int index = 0;//local integer index     = 0
			while (true) {//loop
				if (index >= bj_queuedExecTotal) { break; }//exitwhen index >= bj_queuedExecTotal
				if ((bj_queuedExecTriggers[index] == trig)) {//if (bj_queuedExecTriggers[index] == trig) then
					return index;//return index
				}//endif
				index = index + 1;//set index = index + 1
			}//endloop
			return -1;//return -1
		}//endfunction
		//
		//
		//
		//
		//
		private bool QueuedTriggerRemoveByIndex(int trigIndex) {//function QueuedTriggerRemoveByIndex takes integer trigIndex returns boolean
			int index;//local integer index
			//
			if ((trigIndex >= bj_queuedExecTotal)) {//if (trigIndex >= bj_queuedExecTotal) then
				return false;//return false
			}//endif
			//
			bj_queuedExecTotal = bj_queuedExecTotal - 1;//set bj_queuedExecTotal = bj_queuedExecTotal - 1
			index = trigIndex;//set index = trigIndex
			while (true) {//loop
				if (index >= bj_queuedExecTotal) { break; }//exitwhen index >= bj_queuedExecTotal
				bj_queuedExecTriggers[index] = bj_queuedExecTriggers[index + 1];//set bj_queuedExecTriggers[index] = bj_queuedExecTriggers[index + 1]
				bj_queuedExecUseConds[index] = bj_queuedExecUseConds[index + 1];//set bj_queuedExecUseConds[index] = bj_queuedExecUseConds[index + 1]
				index = index + 1;//set index = index + 1
			}//endloop
			return true;//return true
		}//endfunction
		//
		//
		//
		//
		//
		private bool QueuedTriggerAttemptExec() {//function QueuedTriggerAttemptExec takes nothing returns boolean
			while (true) {//loop
				if (bj_queuedExecTotal == 0) { break; }//exitwhen bj_queuedExecTotal == 0
				if (TriggerExecuteBJ(bj_queuedExecTriggers[0], bj_queuedExecUseConds[0])) {//if TriggerExecuteBJ(bj_queuedExecTriggers[0], bj_queuedExecUseConds[0]) then
					//
					TimerStart(bj_queuedExecTimeoutTimer, bj_QUEUED_TRIGGER_TIMEOUT, false, null);//call TimerStart(bj_queuedExecTimeoutTimer, bj_QUEUED_TRIGGER_TIMEOUT, false, null)
					return true;//return true
				}//endif
				QueuedTriggerRemoveByIndex(0);//call QueuedTriggerRemoveByIndex(0)
			}//endloop
			return false;//return false
		}//endfunction
		//
		//
		//
		//
		private bool QueuedTriggerAddBJ(trigger trig, bool checkConditions) {//function QueuedTriggerAddBJ takes trigger trig, boolean checkConditions returns boolean
			//
			if ((bj_queuedExecTotal >= bj_MAX_QUEUED_TRIGGERS)) {//if (bj_queuedExecTotal >= bj_MAX_QUEUED_TRIGGERS) then
				return false;//return false
			}//endif
			//
			bj_queuedExecTriggers[bj_queuedExecTotal] = trig;//set bj_queuedExecTriggers[bj_queuedExecTotal] = trig
			bj_queuedExecUseConds[bj_queuedExecTotal] = checkConditions;//set bj_queuedExecUseConds[bj_queuedExecTotal] = checkConditions
			bj_queuedExecTotal = bj_queuedExecTotal + 1;//set bj_queuedExecTotal = bj_queuedExecTotal + 1
			//
			if ((bj_queuedExecTotal == 1)) {//if (bj_queuedExecTotal == 1) then
				QueuedTriggerAttemptExec();//call QueuedTriggerAttemptExec()
			}//endif
			return true;//return true
		}//endfunction
		//
		//
		//
		//
		private void QueuedTriggerRemoveBJ(trigger trig) {//function QueuedTriggerRemoveBJ takes trigger trig returns nothing
			int index;//local integer index
			int trigIndex;//local integer trigIndex
			bool trigExecuted;//local boolean trigExecuted
			//
			trigIndex = QueuedTriggerGetIndex(trig);//set trigIndex = QueuedTriggerGetIndex(trig)
			if ((trigIndex == -1)) {//if (trigIndex == -1) then
				return;//return
			}//endif
			//
			QueuedTriggerRemoveByIndex(trigIndex);//call QueuedTriggerRemoveByIndex(trigIndex)
			//
			if ((trigIndex == 0)) {//if (trigIndex == 0) then
				PauseTimer(bj_queuedExecTimeoutTimer);//call PauseTimer(bj_queuedExecTimeoutTimer)
				QueuedTriggerAttemptExec();//call QueuedTriggerAttemptExec()
			}//endif
		}//endfunction
		//
		//
		//
		//
		private void QueuedTriggerDoneBJ() {//function QueuedTriggerDoneBJ takes nothing returns nothing
			int index;//local integer index
			//
			if ((bj_queuedExecTotal <= 0)) {//if (bj_queuedExecTotal <= 0) then
				return;//return
			}//endif
			//
			QueuedTriggerRemoveByIndex(0);//call QueuedTriggerRemoveByIndex(0)
			//
			PauseTimer(bj_queuedExecTimeoutTimer);//call PauseTimer(bj_queuedExecTimeoutTimer)
			QueuedTriggerAttemptExec();//call QueuedTriggerAttemptExec()
		}//endfunction
		//
		//
		//
		private void QueuedTriggerClearBJ() {//function QueuedTriggerClearBJ takes nothing returns nothing
			PauseTimer(bj_queuedExecTimeoutTimer);//call PauseTimer(bj_queuedExecTimeoutTimer)
			bj_queuedExecTotal = 0;//set bj_queuedExecTotal = 0
		}//endfunction
		//
		//
		//
		private void QueuedTriggerClearInactiveBJ() {//function QueuedTriggerClearInactiveBJ takes nothing returns nothing
			bj_queuedExecTotal = IMinBJ(bj_queuedExecTotal, 1);//set bj_queuedExecTotal = IMinBJ(bj_queuedExecTotal, 1)
		}//endfunction
		//
		private int QueuedTriggerCountBJ() {//function QueuedTriggerCountBJ takes nothing returns integer
			return bj_queuedExecTotal;//return bj_queuedExecTotal
		}//endfunction
		//
		private bool IsTriggerQueueEmptyBJ() {//function IsTriggerQueueEmptyBJ takes nothing returns boolean
			return bj_queuedExecTotal <= 0;//return bj_queuedExecTotal <= 0
		}//endfunction
		//
		private bool IsTriggerQueuedBJ(trigger trig) {//function IsTriggerQueuedBJ takes trigger trig returns boolean
			return QueuedTriggerGetIndex(trig) != -1;//return QueuedTriggerGetIndex(trig) != -1
		}//endfunction
		//
		private int GetForLoopIndexA() {//function GetForLoopIndexA takes nothing returns integer
			return bj_forLoopAIndex;//return bj_forLoopAIndex
		}//endfunction
		//
		private void SetForLoopIndexA(int newIndex) {//function SetForLoopIndexA takes integer newIndex returns nothing
			bj_forLoopAIndex = newIndex;//set bj_forLoopAIndex = newIndex
		}//endfunction
		//
		private int GetForLoopIndexB() {//function GetForLoopIndexB takes nothing returns integer
			return bj_forLoopBIndex;//return bj_forLoopBIndex
		}//endfunction
		//
		private void SetForLoopIndexB(int newIndex) {//function SetForLoopIndexB takes integer newIndex returns nothing
			bj_forLoopBIndex = newIndex;//set bj_forLoopBIndex = newIndex
		}//endfunction
		//
		//
		//
		private void PolledWait(float duration) {//function PolledWait takes real duration returns nothing
			timer t;//local timer t
			float timeRemaining;//local real  timeRemaining
			if ((duration > 0)) {//if (duration > 0) then
				t = CreateTimer();//set t = CreateTimer()
				TimerStart(t, duration, false, null);//call TimerStart(t, duration, false, null)
				while (true) {//loop
					timeRemaining = TimerGetRemaining(t);//set timeRemaining = TimerGetRemaining(t)
					if (timeRemaining <= 0) { break; }//exitwhen timeRemaining <= 0
					//
					//
					//
					if ((timeRemaining > bj_POLLED_WAIT_SKIP_THRESHOLD)) {//if (timeRemaining > bj_POLLED_WAIT_SKIP_THRESHOLD) then
						TriggerSleepAction(0.1 * timeRemaining);//call TriggerSleepAction(0.1 * timeRemaining)
					} else {//else
						TriggerSleepAction(bj_POLLED_WAIT_INTERVAL);//call TriggerSleepAction(bj_POLLED_WAIT_INTERVAL)
					}//endif
				}//endloop
				DestroyTimer(t);//call DestroyTimer(t)
			}//endif
		}//endfunction
		//
		private int IntegerTertiaryOp(bool flag, int valueA, int valueB) {//function IntegerTertiaryOp takes boolean flag, integer valueA, integer valueB returns integer
			if (flag) {//if flag then
				return valueA;//return valueA
			} else {//else
				return valueB;//return valueB
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		//
		//
		private void DoNothing() {//function DoNothing takes nothing returns nothing
		}//endfunction
		//
		//
		//
		//
		//
		private void CommentString(string commentString) {//function CommentString takes string commentString returns nothing
		}//endfunction
		//
		//
		//
		private string StringIdentity(string theString) {//function StringIdentity takes string theString returns string
			return GetLocalizedString(theString);//return GetLocalizedString(theString)
		}//endfunction
		//
		private bool GetBooleanAnd(bool valueA, bool valueB) {//function GetBooleanAnd takes boolean valueA, boolean valueB returns boolean
			return valueA && valueB;//return valueA and valueB
		}//endfunction
		//
		private bool GetBooleanOr(bool valueA, bool valueB) {//function GetBooleanOr takes boolean valueA, boolean valueB returns boolean
			return valueA || valueB;//return valueA or valueB
		}//endfunction
		//
		//
		//
		//
		private int PercentToInt(float percentage, int max) {//function PercentToInt takes real percentage, integer max returns integer
			int result = R2I(percentage * I2R(max) * 0.01);//local integer result = R2I(percentage * I2R(max) * 0.01)
			if ((result < 0)) {//if (result < 0) then
				result = 0;//set result = 0
			} else if ((result > max)) {//elseif (result > max) then
				result = max;//set result = max
			}//endif
			return result;//return result
		}//endfunction
		//
		private int PercentTo255(float percentage) {//function PercentTo255 takes real percentage returns integer
			return PercentToInt(percentage, 255);//return PercentToInt(percentage, 255)
		}//endfunction
		//
		private float GetTimeOfDay() {//function GetTimeOfDay takes nothing returns real
			return GetFloatGameState(GAME_STATE_TIME_OF_DAY);//return GetFloatGameState(GAME_STATE_TIME_OF_DAY)
		}//endfunction
		//
		private void SetTimeOfDay(float whatTime) {//function SetTimeOfDay takes real whatTime returns nothing
			SetFloatGameState(GAME_STATE_TIME_OF_DAY, whatTime);//call SetFloatGameState(GAME_STATE_TIME_OF_DAY, whatTime)
		}//endfunction
		//
		private void SetTimeOfDayScalePercentBJ(float scalePercent) {//function SetTimeOfDayScalePercentBJ takes real scalePercent returns nothing
			SetTimeOfDayScale(scalePercent * 0.01);//call SetTimeOfDayScale(scalePercent * 0.01)
		}//endfunction
		//
		private float GetTimeOfDayScalePercentBJ() {//function GetTimeOfDayScalePercentBJ takes nothing returns real
			return GetTimeOfDayScale() * 100;//return GetTimeOfDayScale() * 100
		}//endfunction
		//
		private void PlaySound(string soundName) {//function PlaySound takes string soundName returns nothing
			sound soundHandle = CreateSound(soundName, false, false, true, 12700, 12700, "");//local sound soundHandle = CreateSound(soundName, false, false, true, 12700, 12700, "")
			StartSound(soundHandle);//call StartSound(soundHandle)
			KillSoundWhenDone(soundHandle);//call KillSoundWhenDone(soundHandle)
		}//endfunction
		//
		private bool CompareLocationsBJ(location A, location B) {//function CompareLocationsBJ takes location A, location B returns boolean
			return GetLocationX(A) == GetLocationX(B) && GetLocationY(A) == GetLocationY(B);//return GetLocationX(A) == GetLocationX(B) and GetLocationY(A) == GetLocationY(B)
		}//endfunction
		//
		private bool CompareRectsBJ(rect A, rect B) {//function CompareRectsBJ takes rect A, rect B returns boolean
			return GetRectMinX(A) == GetRectMinX(B) && GetRectMinY(A) == GetRectMinY(B) && GetRectMaxX(A) == GetRectMaxX(B) && GetRectMaxY(A) == GetRectMaxY(B);//return GetRectMinX(A) == GetRectMinX(B) and GetRectMinY(A) == GetRectMinY(B) and GetRectMaxX(A) == GetRectMaxX(B) and GetRectMaxY(A) == GetRectMaxY(B)
		}//endfunction
		//
		//
		//
		private rect GetRectFromCircleBJ(location center, float radius) {//function GetRectFromCircleBJ takes location center, real radius returns rect
			float centerX = GetLocationX(center);//local real centerX = GetLocationX(center)
			float centerY = GetLocationY(center);//local real centerY = GetLocationY(center)
			return Rect(centerX - radius, centerY - radius, centerX + radius, centerY + radius);//return Rect(centerX - radius, centerY - radius, centerX + radius, centerY + radius)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private camerasetup GetCurrentCameraSetup() {//function GetCurrentCameraSetup takes nothing returns camerasetup
			camerasetup theCam = CreateCameraSetup();//local camerasetup theCam = CreateCameraSetup()
			float duration = 0;//local real duration = 0
			CameraSetupSetField(theCam, CAMERA_FIELD_TARGET_DISTANCE, GetCameraField(CAMERA_FIELD_TARGET_DISTANCE), duration);//call CameraSetupSetField(theCam, CAMERA_FIELD_TARGET_DISTANCE, GetCameraField(CAMERA_FIELD_TARGET_DISTANCE), duration)
			CameraSetupSetField(theCam, CAMERA_FIELD_FARZ,            GetCameraField(CAMERA_FIELD_FARZ),            duration);//call CameraSetupSetField(theCam, CAMERA_FIELD_FARZ,            GetCameraField(CAMERA_FIELD_FARZ),            duration)
			CameraSetupSetField(theCam, CAMERA_FIELD_ZOFFSET,         GetCameraField(CAMERA_FIELD_ZOFFSET),         duration);//call CameraSetupSetField(theCam, CAMERA_FIELD_ZOFFSET,         GetCameraField(CAMERA_FIELD_ZOFFSET),         duration)
			CameraSetupSetField(theCam, CAMERA_FIELD_ANGLE_OF_ATTACK, bj_RADTODEG * GetCameraField(CAMERA_FIELD_ANGLE_OF_ATTACK), duration);//call CameraSetupSetField(theCam, CAMERA_FIELD_ANGLE_OF_ATTACK, bj_RADTODEG * GetCameraField(CAMERA_FIELD_ANGLE_OF_ATTACK), duration)
			CameraSetupSetField(theCam, CAMERA_FIELD_FIELD_OF_VIEW,   bj_RADTODEG * GetCameraField(CAMERA_FIELD_FIELD_OF_VIEW),   duration);//call CameraSetupSetField(theCam, CAMERA_FIELD_FIELD_OF_VIEW,   bj_RADTODEG * GetCameraField(CAMERA_FIELD_FIELD_OF_VIEW),   duration)
			CameraSetupSetField(theCam, CAMERA_FIELD_ROLL,            bj_RADTODEG * GetCameraField(CAMERA_FIELD_ROLL),            duration);//call CameraSetupSetField(theCam, CAMERA_FIELD_ROLL,            bj_RADTODEG * GetCameraField(CAMERA_FIELD_ROLL),            duration)
			CameraSetupSetField(theCam, CAMERA_FIELD_ROTATION,        bj_RADTODEG * GetCameraField(CAMERA_FIELD_ROTATION),        duration);//call CameraSetupSetField(theCam, CAMERA_FIELD_ROTATION,        bj_RADTODEG * GetCameraField(CAMERA_FIELD_ROTATION),        duration)
			CameraSetupSetDestPosition(theCam, GetCameraTargetPositionX(), GetCameraTargetPositionY(), duration);//call CameraSetupSetDestPosition(theCam, GetCameraTargetPositionX(), GetCameraTargetPositionY(), duration)
			return theCam;//return theCam
		}//endfunction
		//
		private void CameraSetupApplyForPlayer(bool doPan, camerasetup whichSetup, player whichPlayer, float duration) {//function CameraSetupApplyForPlayer takes boolean doPan, camerasetup whichSetup, player whichPlayer, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				CameraSetupApplyForceDuration(whichSetup, doPan, duration);//call CameraSetupApplyForceDuration(whichSetup, doPan, duration)
			}//endif
		}//endfunction
		//
		private float CameraSetupGetFieldSwap(camerafield whichField, camerasetup whichSetup) {//function CameraSetupGetFieldSwap takes camerafield whichField, camerasetup whichSetup returns real
			return CameraSetupGetField(whichSetup, whichField);//return CameraSetupGetField(whichSetup, whichField)
		}//endfunction
		//
		private void SetCameraFieldForPlayer(player whichPlayer, camerafield whichField, float value, float duration) {//function SetCameraFieldForPlayer takes player whichPlayer, camerafield whichField, real value, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraField(whichField, value, duration);//call SetCameraField(whichField, value, duration)
			}//endif
		}//endfunction
		//
		private void SetCameraTargetControllerNoZForPlayer(player whichPlayer, unit whichUnit, float xoffset, float yoffset, bool inheritOrientation) {//function SetCameraTargetControllerNoZForPlayer takes player whichPlayer, unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);//call SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation)
			}//endif
		}//endfunction
		//
		private void SetCameraPositionForPlayer(player whichPlayer, float x, float y) {//function SetCameraPositionForPlayer takes player whichPlayer, real x, real y returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraPosition(x, y);//call SetCameraPosition(x, y)
			}//endif
		}//endfunction
		//
		private void SetCameraPositionLocForPlayer(player whichPlayer, location loc) {//function SetCameraPositionLocForPlayer takes player whichPlayer, location loc returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraPosition(GetLocationX(loc), GetLocationY(loc));//call SetCameraPosition(GetLocationX(loc), GetLocationY(loc))
			}//endif
		}//endfunction
		//
		private void RotateCameraAroundLocBJ(float degrees, location loc, player whichPlayer, float duration) {//function RotateCameraAroundLocBJ takes real degrees, location loc, player whichPlayer, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraRotateMode(GetLocationX(loc), GetLocationY(loc), bj_DEGTORAD * degrees, duration);//call SetCameraRotateMode(GetLocationX(loc), GetLocationY(loc), bj_DEGTORAD * degrees, duration)
			}//endif
		}//endfunction
		//
		private void PanCameraToForPlayer(player whichPlayer, float x, float y) {//function PanCameraToForPlayer takes player whichPlayer, real x, real y returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				PanCameraTo(x, y);//call PanCameraTo(x, y)
			}//endif
		}//endfunction
		//
		private void PanCameraToLocForPlayer(player whichPlayer, location loc) {//function PanCameraToLocForPlayer takes player whichPlayer, location loc returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				PanCameraTo(GetLocationX(loc), GetLocationY(loc));//call PanCameraTo(GetLocationX(loc), GetLocationY(loc))
			}//endif
		}//endfunction
		//
		private void PanCameraToTimedForPlayer(player whichPlayer, float x, float y, float duration) {//function PanCameraToTimedForPlayer takes player whichPlayer, real x, real y, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				PanCameraToTimed(x, y, duration);//call PanCameraToTimed(x, y, duration)
			}//endif
		}//endfunction
		//
		private void PanCameraToTimedLocForPlayer(player whichPlayer, location loc, float duration) {//function PanCameraToTimedLocForPlayer takes player whichPlayer, location loc, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), duration);//call PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), duration)
			}//endif
		}//endfunction
		//
		private void PanCameraToTimedLocWithZForPlayer(player whichPlayer, location loc, float zOffset, float duration) {//function PanCameraToTimedLocWithZForPlayer takes player whichPlayer, location loc, real zOffset, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				PanCameraToTimedWithZ(GetLocationX(loc), GetLocationY(loc), zOffset, duration);//call PanCameraToTimedWithZ(GetLocationX(loc), GetLocationY(loc), zOffset, duration)
			}//endif
		}//endfunction
		//
		private void SmartCameraPanBJ(player whichPlayer, location loc, float duration) {//function SmartCameraPanBJ takes player whichPlayer, location loc, real duration returns nothing
			float dist;//local real dist
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				dist = DistanceBetweenPoints(loc, GetCameraTargetPositionLoc());//set dist = DistanceBetweenPoints(loc, GetCameraTargetPositionLoc())
				if ((dist >= bj_SMARTPAN_TRESHOLD_SNAP)) {//if (dist >= bj_SMARTPAN_TRESHOLD_SNAP) then
					//
					PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), 0);//call PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), 0)
				} else if ((dist >= bj_SMARTPAN_TRESHOLD_PAN)) {//elseif (dist >= bj_SMARTPAN_TRESHOLD_PAN) then
					//
					PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), duration);//call PanCameraToTimed(GetLocationX(loc), GetLocationY(loc), duration)
				} else {//else
					//
				}//endif
			}//endif
		}//endfunction
		//
		private void SetCinematicCameraForPlayer(player whichPlayer, string cameraModelFile) {//function SetCinematicCameraForPlayer takes player whichPlayer, string cameraModelFile returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCinematicCamera(cameraModelFile);//call SetCinematicCamera(cameraModelFile)
			}//endif
		}//endfunction
		//
		private void ResetToGameCameraForPlayer(player whichPlayer, float duration) {//function ResetToGameCameraForPlayer takes player whichPlayer, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				ResetToGameCamera(duration);//call ResetToGameCamera(duration)
			}//endif
		}//endfunction
		//
		private void CameraSetSourceNoiseForPlayer(player whichPlayer, float magnitude, float velocity) {//function CameraSetSourceNoiseForPlayer takes player whichPlayer, real magnitude, real velocity returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				CameraSetSourceNoise(magnitude, velocity);//call CameraSetSourceNoise(magnitude, velocity)
			}//endif
		}//endfunction
		//
		private void CameraSetTargetNoiseForPlayer(player whichPlayer, float magnitude, float velocity) {//function CameraSetTargetNoiseForPlayer takes player whichPlayer, real magnitude, real velocity returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				CameraSetTargetNoise(magnitude, velocity);//call CameraSetTargetNoise(magnitude, velocity)
			}//endif
		}//endfunction
		//
		private void CameraSetEQNoiseForPlayer(player whichPlayer, float magnitude) {//function CameraSetEQNoiseForPlayer takes player whichPlayer, real magnitude returns nothing
			float richter = magnitude;//local real richter = magnitude
			if ((richter > 5.0)) {//if (richter > 5.0) then
				richter = 5.0;//set richter = 5.0
			}//endif
			if ((richter < 2.0)) {//if (richter < 2.0) then
				richter = 2.0;//set richter = 2.0
			}//endif
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				CameraSetTargetNoiseEx(magnitude*2.0, magnitude*Pow(10,richter),true);//call CameraSetTargetNoiseEx(magnitude*2.0, magnitude*Pow(10,richter),true)
				CameraSetSourceNoiseEx(magnitude*2.0, magnitude*Pow(10,richter),true);//call CameraSetSourceNoiseEx(magnitude*2.0, magnitude*Pow(10,richter),true)
			}//endif
		}//endfunction
		//
		private void CameraClearNoiseForPlayer(player whichPlayer) {//function CameraClearNoiseForPlayer takes player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				CameraSetSourceNoise(0, 0);//call CameraSetSourceNoise(0, 0)
				CameraSetTargetNoise(0, 0);//call CameraSetTargetNoise(0, 0)
			}//endif
		}//endfunction
		//
		//
		//
		private rect GetCurrentCameraBoundsMapRectBJ() {//function GetCurrentCameraBoundsMapRectBJ takes nothing returns rect
			return Rect(GetCameraBoundMinX(), GetCameraBoundMinY(), GetCameraBoundMaxX(), GetCameraBoundMaxY());//return Rect(GetCameraBoundMinX(), GetCameraBoundMinY(), GetCameraBoundMaxX(), GetCameraBoundMaxY())
		}//endfunction
		//
		//
		//
		private rect GetCameraBoundsMapRect() {//function GetCameraBoundsMapRect takes nothing returns rect
			return bj_mapInitialCameraBounds;//return bj_mapInitialCameraBounds
		}//endfunction
		//
		//
		//
		private rect GetPlayableMapRect() {//function GetPlayableMapRect takes nothing returns rect
			return bj_mapInitialPlayableArea;//return bj_mapInitialPlayableArea
		}//endfunction
		//
		//
		//
		private rect GetEntireMapRect() {//function GetEntireMapRect takes nothing returns rect
			return GetWorldBounds();//return GetWorldBounds()
		}//endfunction
		//
		private void SetCameraBoundsToRect(rect r) {//function SetCameraBoundsToRect takes rect r returns nothing
			float minX = GetRectMinX(r);//local real minX = GetRectMinX(r)
			float minY = GetRectMinY(r);//local real minY = GetRectMinY(r)
			float maxX = GetRectMaxX(r);//local real maxX = GetRectMaxX(r)
			float maxY = GetRectMaxY(r);//local real maxY = GetRectMaxY(r)
			SetCameraBounds(minX, minY, minX, maxY, maxX, maxY, maxX, minY);//call SetCameraBounds(minX, minY, minX, maxY, maxX, maxY, maxX, minY)
		}//endfunction
		//
		private void SetCameraBoundsToRectForPlayerBJ(player whichPlayer, rect r) {//function SetCameraBoundsToRectForPlayerBJ takes player whichPlayer, rect r returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraBoundsToRect(r);//call SetCameraBoundsToRect(r)
			}//endif
		}//endfunction
		//
		private void AdjustCameraBoundsBJ(int adjustMethod, float dxWest, float dxEast, float dyNorth, float dySouth) {//function AdjustCameraBoundsBJ takes integer adjustMethod, real dxWest, real dxEast, real dyNorth, real dySouth returns nothing
			float minX = 0;//local real minX = 0
			float minY = 0;//local real minY = 0
			float maxX = 0;//local real maxX = 0
			float maxY = 0;//local real maxY = 0
			float scale = 0;//local real scale = 0
			if ((adjustMethod == bj_CAMERABOUNDS_ADJUST_ADD)) {//if (adjustMethod == bj_CAMERABOUNDS_ADJUST_ADD) then
				scale = 1;//set scale = 1
			} else if ((adjustMethod == bj_CAMERABOUNDS_ADJUST_SUB)) {//elseif (adjustMethod == bj_CAMERABOUNDS_ADJUST_SUB) then
				scale = -1;//set scale = -1
			} else {//else
				//
				return;//return
			}//endif
			//
			minX = GetCameraBoundMinX() - scale * dxWest;//set minX = GetCameraBoundMinX() - scale * dxWest
			maxX = GetCameraBoundMaxX() + scale * dxEast;//set maxX = GetCameraBoundMaxX() + scale * dxEast
			minY = GetCameraBoundMinY() - scale * dySouth;//set minY = GetCameraBoundMinY() - scale * dySouth
			maxY = GetCameraBoundMaxY() + scale * dyNorth;//set maxY = GetCameraBoundMaxY() + scale * dyNorth
			//
			if ((maxX < minX)) {//if (maxX < minX) then
				minX = (minX + maxX) * 0.5;//set minX = (minX + maxX) * 0.5
				maxX = minX;//set maxX = minX
			}//endif
			if ((maxY < minY)) {//if (maxY < minY) then
				minY = (minY + maxY) * 0.5;//set minY = (minY + maxY) * 0.5
				maxY = minY;//set maxY = minY
			}//endif
			//
			SetCameraBounds(minX, minY, minX, maxY, maxX, maxY, maxX, minY);//call SetCameraBounds(minX, minY, minX, maxY, maxX, maxY, maxX, minY)
		}//endfunction
		//
		private void AdjustCameraBoundsForPlayerBJ(int adjustMethod, player whichPlayer, float dxWest, float dxEast, float dyNorth, float dySouth) {//function AdjustCameraBoundsForPlayerBJ takes integer adjustMethod, player whichPlayer, real dxWest, real dxEast, real dyNorth, real dySouth returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				AdjustCameraBoundsBJ(adjustMethod, dxWest, dxEast, dyNorth, dySouth);//call AdjustCameraBoundsBJ(adjustMethod, dxWest, dxEast, dyNorth, dySouth)
			}//endif
		}//endfunction
		//
		private void SetCameraQuickPositionForPlayer(player whichPlayer, float x, float y) {//function SetCameraQuickPositionForPlayer takes player whichPlayer, real x, real y returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraQuickPosition(x, y);//call SetCameraQuickPosition(x, y)
			}//endif
		}//endfunction
		//
		private void SetCameraQuickPositionLocForPlayer(player whichPlayer, location loc) {//function SetCameraQuickPositionLocForPlayer takes player whichPlayer, location loc returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraQuickPosition(GetLocationX(loc), GetLocationY(loc));//call SetCameraQuickPosition(GetLocationX(loc), GetLocationY(loc))
			}//endif
		}//endfunction
		//
		private void SetCameraQuickPositionLoc(location loc) {//function SetCameraQuickPositionLoc takes location loc returns nothing
			SetCameraQuickPosition(GetLocationX(loc), GetLocationY(loc));//call SetCameraQuickPosition(GetLocationX(loc), GetLocationY(loc))
		}//endfunction
		//
		private void StopCameraForPlayerBJ(player whichPlayer) {//function StopCameraForPlayerBJ takes player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				StopCamera();//call StopCamera()
			}//endif
		}//endfunction
		//
		private void SetCameraOrientControllerForPlayerBJ(player whichPlayer, unit whichUnit, float xoffset, float yoffset) {//function SetCameraOrientControllerForPlayerBJ takes player whichPlayer, unit whichUnit, real xoffset, real yoffset returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SetCameraOrientController(whichUnit, xoffset, yoffset);//call SetCameraOrientController(whichUnit, xoffset, yoffset)
			}//endif
		}//endfunction
		//
		private void CameraSetSmoothingFactorBJ(float factor) {//function CameraSetSmoothingFactorBJ takes real factor returns nothing
			CameraSetSmoothingFactor(factor);//call CameraSetSmoothingFactor(factor)
		}//endfunction
		//
		private void CameraResetSmoothingFactorBJ() {//function CameraResetSmoothingFactorBJ takes nothing returns nothing
			CameraSetSmoothingFactor(0);//call CameraSetSmoothingFactor(0)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void DisplayTextToForce(force toForce, string message) {//function DisplayTextToForce takes force toForce, string message returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), toForce))) {//if (IsPlayerInForce(GetLocalPlayer(), toForce)) then
				//
				DisplayTextToPlayer(GetLocalPlayer(), 0, 0, message);//call DisplayTextToPlayer(GetLocalPlayer(), 0, 0, message)
			}//endif
		}//endfunction
		//
		private void DisplayTimedTextToForce(force toForce, float duration, string message) {//function DisplayTimedTextToForce takes force toForce, real duration, string message returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), toForce))) {//if (IsPlayerInForce(GetLocalPlayer(), toForce)) then
				//
				DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, duration, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, duration, message)
			}//endif
		}//endfunction
		//
		private void ClearTextMessagesBJ(force toForce) {//function ClearTextMessagesBJ takes force toForce returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), toForce))) {//if (IsPlayerInForce(GetLocalPlayer(), toForce)) then
				//
				ClearTextMessages();//call ClearTextMessages()
			}//endif
		}//endfunction
		//
		//
		//
		//
		private string SubStringBJ(string source, int start, int end) {//function SubStringBJ takes string source, integer start, integer end returns string
			return SubString(source, start-1, end);//return SubString(source, start-1, end)
		}//endfunction
		private int GetHandleIdBJ(handle h) {//function GetHandleIdBJ takes handle h returns integer
			return GetHandleId(h);//return GetHandleId(h)
		}//endfunction
		private int StringHashBJ(string s) {//function StringHashBJ takes string s returns integer
			return StringHash(s);//return StringHash(s)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private event TriggerRegisterTimerEventPeriodic(trigger trig, float timeout) {//function TriggerRegisterTimerEventPeriodic takes trigger trig, real timeout returns event
			return TriggerRegisterTimerEvent(trig, timeout, true);//return TriggerRegisterTimerEvent(trig, timeout, true)
		}//endfunction
		//
		private event TriggerRegisterTimerEventSingle(trigger trig, float timeout) {//function TriggerRegisterTimerEventSingle takes trigger trig, real timeout returns event
			return TriggerRegisterTimerEvent(trig, timeout, false);//return TriggerRegisterTimerEvent(trig, timeout, false)
		}//endfunction
		//
		private event TriggerRegisterTimerExpireEventBJ(trigger trig, timer t) {//function TriggerRegisterTimerExpireEventBJ takes trigger trig, timer t returns event
			return TriggerRegisterTimerExpireEvent(trig, t);//return TriggerRegisterTimerExpireEvent(trig, t)
		}//endfunction
		//
		private event TriggerRegisterPlayerUnitEventSimple(trigger trig, player whichPlayer, playerunitevent whichEvent) {//function TriggerRegisterPlayerUnitEventSimple takes trigger trig, player whichPlayer, playerunitevent whichEvent returns event
			return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, whichEvent, null);//return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, whichEvent, null)
		}//endfunction
		//
		private void TriggerRegisterAnyUnitEventBJ(trigger trig, playerunitevent whichEvent) {//function TriggerRegisterAnyUnitEventBJ takes trigger trig, playerunitevent whichEvent returns nothing
			int index;//local integer index
			index = 0;//set index = 0
			while (true) {//loop
				TriggerRegisterPlayerUnitEvent(trig, Player(index), whichEvent, null);//call TriggerRegisterPlayerUnitEvent(trig, Player(index), whichEvent, null)
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen index == bj_MAX_PLAYER_SLOTS
			}//endloop
		}//endfunction
		//
		private event TriggerRegisterPlayerSelectionEventBJ(trigger trig, player whichPlayer, bool selected) {//function TriggerRegisterPlayerSelectionEventBJ takes trigger trig, player whichPlayer, boolean selected returns event
			if (selected) {//if selected then
				return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, EVENT_PLAYER_UNIT_SELECTED, null);//return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, EVENT_PLAYER_UNIT_SELECTED, null)
			} else {//else
				return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, EVENT_PLAYER_UNIT_DESELECTED, null);//return TriggerRegisterPlayerUnitEvent(trig, whichPlayer, EVENT_PLAYER_UNIT_DESELECTED, null)
			}//endif
		}//endfunction
		//
		private event TriggerRegisterPlayerKeyEventBJ(trigger trig, player whichPlayer, int keType, int keKey) {//function TriggerRegisterPlayerKeyEventBJ takes trigger trig, player whichPlayer, integer keType, integer keKey returns event
			if ((keType == bj_KEYEVENTTYPE_DEPRESS)) {//if (keType == bj_KEYEVENTTYPE_DEPRESS) then
				//
				if ((keKey == bj_KEYEVENTKEY_LEFT)) {//if (keKey == bj_KEYEVENTKEY_LEFT) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_LEFT_DOWN);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_LEFT_DOWN)
				} else if ((keKey == bj_KEYEVENTKEY_RIGHT)) {//elseif (keKey == bj_KEYEVENTKEY_RIGHT) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_RIGHT_DOWN);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_RIGHT_DOWN)
				} else if ((keKey == bj_KEYEVENTKEY_DOWN)) {//elseif (keKey == bj_KEYEVENTKEY_DOWN) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_DOWN_DOWN);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_DOWN_DOWN)
				} else if ((keKey == bj_KEYEVENTKEY_UP)) {//elseif (keKey == bj_KEYEVENTKEY_UP) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_UP_DOWN);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_UP_DOWN)
				} else {//else
					//
					return null;//return null
				}//endif
			} else if ((keType == bj_KEYEVENTTYPE_RELEASE)) {//elseif (keType == bj_KEYEVENTTYPE_RELEASE) then
				//
				if ((keKey == bj_KEYEVENTKEY_LEFT)) {//if (keKey == bj_KEYEVENTKEY_LEFT) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_LEFT_UP);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_LEFT_UP)
				} else if ((keKey == bj_KEYEVENTKEY_RIGHT)) {//elseif (keKey == bj_KEYEVENTKEY_RIGHT) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_RIGHT_UP);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_RIGHT_UP)
				} else if ((keKey == bj_KEYEVENTKEY_DOWN)) {//elseif (keKey == bj_KEYEVENTKEY_DOWN) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_DOWN_UP);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_DOWN_UP)
				} else if ((keKey == bj_KEYEVENTKEY_UP)) {//elseif (keKey == bj_KEYEVENTKEY_UP) then
					return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_UP_UP);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ARROW_UP_UP)
				} else {//else
					//
					return null;//return null
				}//endif
			} else {//else
				//
				return null;//return null
			}//endif
		}//endfunction
		//
		private event TriggerRegisterPlayerEventVictory(trigger trig, player whichPlayer) {//function TriggerRegisterPlayerEventVictory takes trigger trig, player whichPlayer returns event
			return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_VICTORY);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_VICTORY)
		}//endfunction
		//
		private event TriggerRegisterPlayerEventDefeat(trigger trig, player whichPlayer) {//function TriggerRegisterPlayerEventDefeat takes trigger trig, player whichPlayer returns event
			return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_DEFEAT);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_DEFEAT)
		}//endfunction
		//
		private event TriggerRegisterPlayerEventLeave(trigger trig, player whichPlayer) {//function TriggerRegisterPlayerEventLeave takes trigger trig, player whichPlayer returns event
			return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_LEAVE);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_LEAVE)
		}//endfunction
		//
		private event TriggerRegisterPlayerEventAllianceChanged(trigger trig, player whichPlayer) {//function TriggerRegisterPlayerEventAllianceChanged takes trigger trig, player whichPlayer returns event
			return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ALLIANCE_CHANGED);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_ALLIANCE_CHANGED)
		}//endfunction
		//
		private event TriggerRegisterPlayerEventEndCinematic(trigger trig, player whichPlayer) {//function TriggerRegisterPlayerEventEndCinematic takes trigger trig, player whichPlayer returns event
			return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_END_CINEMATIC);//return TriggerRegisterPlayerEvent(trig, whichPlayer, EVENT_PLAYER_END_CINEMATIC)
		}//endfunction
		//
		private event TriggerRegisterGameStateEventTimeOfDay(trigger trig, limitop opcode, float limitval) {//function TriggerRegisterGameStateEventTimeOfDay takes trigger trig, limitop opcode, real limitval returns event
			return TriggerRegisterGameStateEvent(trig, GAME_STATE_TIME_OF_DAY, opcode, limitval);//return TriggerRegisterGameStateEvent(trig, GAME_STATE_TIME_OF_DAY, opcode, limitval)
		}//endfunction
		//
		private event TriggerRegisterEnterRegionSimple(trigger trig, region whichRegion) {//function TriggerRegisterEnterRegionSimple takes trigger trig, region whichRegion returns event
			return TriggerRegisterEnterRegion(trig, whichRegion, null);//return TriggerRegisterEnterRegion(trig, whichRegion, null)
		}//endfunction
		//
		private event TriggerRegisterLeaveRegionSimple(trigger trig, region whichRegion) {//function TriggerRegisterLeaveRegionSimple takes trigger trig, region whichRegion returns event
			return TriggerRegisterLeaveRegion(trig, whichRegion, null);//return TriggerRegisterLeaveRegion(trig, whichRegion, null)
		}//endfunction
		//
		private event TriggerRegisterEnterRectSimple(trigger trig, rect r) {//function TriggerRegisterEnterRectSimple takes trigger trig, rect r returns event
			region rectRegion = CreateRegion();//local region rectRegion = CreateRegion()
			RegionAddRect(rectRegion, r);//call RegionAddRect(rectRegion, r)
			return TriggerRegisterEnterRegion(trig, rectRegion, null);//return TriggerRegisterEnterRegion(trig, rectRegion, null)
		}//endfunction
		//
		private event TriggerRegisterLeaveRectSimple(trigger trig, rect r) {//function TriggerRegisterLeaveRectSimple takes trigger trig, rect r returns event
			region rectRegion = CreateRegion();//local region rectRegion = CreateRegion()
			RegionAddRect(rectRegion, r);//call RegionAddRect(rectRegion, r)
			return TriggerRegisterLeaveRegion(trig, rectRegion, null);//return TriggerRegisterLeaveRegion(trig, rectRegion, null)
		}//endfunction
		//
		private event TriggerRegisterDistanceBetweenUnits(trigger trig, unit whichUnit, boolexpr condition, float range) {//function TriggerRegisterDistanceBetweenUnits takes trigger trig, unit whichUnit, boolexpr condition, real range returns event
			return TriggerRegisterUnitInRange(trig, whichUnit, range, condition);//return TriggerRegisterUnitInRange(trig, whichUnit, range, condition)
		}//endfunction
		//
		private event TriggerRegisterUnitInRangeSimple(trigger trig, float range, unit whichUnit) {//function TriggerRegisterUnitInRangeSimple takes trigger trig, real range, unit whichUnit returns event
			return TriggerRegisterUnitInRange(trig, whichUnit, range, null);//return TriggerRegisterUnitInRange(trig, whichUnit, range, null)
		}//endfunction
		//
		private event TriggerRegisterUnitLifeEvent(trigger trig, unit whichUnit, limitop opcode, float limitval) {//function TriggerRegisterUnitLifeEvent takes trigger trig, unit whichUnit, limitop opcode, real limitval returns event
			return TriggerRegisterUnitStateEvent(trig, whichUnit, UNIT_STATE_LIFE, opcode, limitval);//return TriggerRegisterUnitStateEvent(trig, whichUnit, UNIT_STATE_LIFE, opcode, limitval)
		}//endfunction
		//
		private event TriggerRegisterUnitManaEvent(trigger trig, unit whichUnit, limitop opcode, float limitval) {//function TriggerRegisterUnitManaEvent takes trigger trig, unit whichUnit, limitop opcode, real limitval returns event
			return TriggerRegisterUnitStateEvent(trig, whichUnit, UNIT_STATE_MANA, opcode, limitval);//return TriggerRegisterUnitStateEvent(trig, whichUnit, UNIT_STATE_MANA, opcode, limitval)
		}//endfunction
		//
		private event TriggerRegisterDialogEventBJ(trigger trig, dialog whichDialog) {//function TriggerRegisterDialogEventBJ takes trigger trig, dialog whichDialog returns event
			return TriggerRegisterDialogEvent(trig, whichDialog);//return TriggerRegisterDialogEvent(trig, whichDialog)
		}//endfunction
		//
		private event TriggerRegisterShowSkillEventBJ(trigger trig) {//function TriggerRegisterShowSkillEventBJ takes trigger trig returns event
			return TriggerRegisterGameEvent(trig, EVENT_GAME_SHOW_SKILL);//return TriggerRegisterGameEvent(trig, EVENT_GAME_SHOW_SKILL)
		}//endfunction
		//
		private event TriggerRegisterBuildSubmenuEventBJ(trigger trig) {//function TriggerRegisterBuildSubmenuEventBJ takes trigger trig returns event
			return TriggerRegisterGameEvent(trig, EVENT_GAME_BUILD_SUBMENU);//return TriggerRegisterGameEvent(trig, EVENT_GAME_BUILD_SUBMENU)
		}//endfunction
		//
		private event TriggerRegisterGameLoadedEventBJ(trigger trig) {//function TriggerRegisterGameLoadedEventBJ takes trigger trig returns event
			return TriggerRegisterGameEvent(trig, EVENT_GAME_LOADED);//return TriggerRegisterGameEvent(trig, EVENT_GAME_LOADED)
		}//endfunction
		//
		private event TriggerRegisterGameSavedEventBJ(trigger trig) {//function TriggerRegisterGameSavedEventBJ takes trigger trig returns event
			return TriggerRegisterGameEvent(trig, EVENT_GAME_SAVE);//return TriggerRegisterGameEvent(trig, EVENT_GAME_SAVE)
		}//endfunction
		//
		private void RegisterDestDeathInRegionEnum() {//function RegisterDestDeathInRegionEnum takes nothing returns nothing
			bj_destInRegionDiesCount = bj_destInRegionDiesCount + 1;//set bj_destInRegionDiesCount = bj_destInRegionDiesCount + 1
			if ((bj_destInRegionDiesCount <= bj_MAX_DEST_IN_REGION_EVENTS)) {//if (bj_destInRegionDiesCount <= bj_MAX_DEST_IN_REGION_EVENTS) then
				TriggerRegisterDeathEvent(bj_destInRegionDiesTrig, GetEnumDestructable());//call TriggerRegisterDeathEvent(bj_destInRegionDiesTrig, GetEnumDestructable())
			}//endif
		}//endfunction
		//
		private void TriggerRegisterDestDeathInRegionEvent(trigger trig, rect r) {//function TriggerRegisterDestDeathInRegionEvent takes trigger trig, rect r returns nothing
			bj_destInRegionDiesTrig = trig;//set bj_destInRegionDiesTrig = trig
			bj_destInRegionDiesCount = 0;//set bj_destInRegionDiesCount = 0
			EnumDestructablesInRect(r, null, function RegisterDestDeathInRegionEnum);//call EnumDestructablesInRect(r, null, function RegisterDestDeathInRegionEnum)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private weathereffect AddWeatherEffectSaveLast(rect where, int effectID) {//function AddWeatherEffectSaveLast takes rect where, integer effectID returns weathereffect
			bj_lastCreatedWeatherEffect = AddWeatherEffect(where, effectID);//set bj_lastCreatedWeatherEffect = AddWeatherEffect(where, effectID)
			return bj_lastCreatedWeatherEffect;//return bj_lastCreatedWeatherEffect
		}//endfunction
		//
		private weathereffect GetLastCreatedWeatherEffect() {//function GetLastCreatedWeatherEffect takes nothing returns weathereffect
			return bj_lastCreatedWeatherEffect;//return bj_lastCreatedWeatherEffect
		}//endfunction
		//
		private void RemoveWeatherEffectBJ(weathereffect whichWeatherEffect) {//function RemoveWeatherEffectBJ takes weathereffect whichWeatherEffect returns nothing
			RemoveWeatherEffect(whichWeatherEffect);//call RemoveWeatherEffect(whichWeatherEffect)
		}//endfunction
		//
		private terraindeformation TerrainDeformationCraterBJ(float duration, bool permanent, location where, float radius, float depth) {//function TerrainDeformationCraterBJ takes real duration, boolean permanent, location where, real radius, real depth returns terraindeformation
			bj_lastCreatedTerrainDeformation = TerrainDeformCrater(GetLocationX(where), GetLocationY(where), radius, depth, R2I(duration * 1000), permanent);//set bj_lastCreatedTerrainDeformation = TerrainDeformCrater(GetLocationX(where), GetLocationY(where), radius, depth, R2I(duration * 1000), permanent)
			return bj_lastCreatedTerrainDeformation;//return bj_lastCreatedTerrainDeformation
		}//endfunction
		//
		private terraindeformation TerrainDeformationRippleBJ(float duration, bool limitNeg, location where, float startRadius, float endRadius, float depth, float wavePeriod, float waveWidth) {//function TerrainDeformationRippleBJ takes real duration, boolean limitNeg, location where, real startRadius, real endRadius, real depth, real wavePeriod, real waveWidth returns terraindeformation
			float spaceWave;//local real spaceWave
			float timeWave;//local real timeWave
			float radiusRatio;//local real radiusRatio
			if ((endRadius <= 0 || waveWidth <= 0 || wavePeriod <= 0)) {//if (endRadius <= 0 or waveWidth <= 0 or wavePeriod <= 0) then
				return null;//return null
			}//endif
			timeWave = 2.0 * duration / wavePeriod;//set timeWave = 2.0 * duration / wavePeriod
			spaceWave = 2.0 * endRadius / waveWidth;//set spaceWave = 2.0 * endRadius / waveWidth
			radiusRatio = startRadius / endRadius;//set radiusRatio = startRadius / endRadius
			bj_lastCreatedTerrainDeformation = TerrainDeformRipple(GetLocationX(where), GetLocationY(where), endRadius, depth, R2I(duration * 1000), 1, spaceWave, timeWave, radiusRatio, limitNeg);//set bj_lastCreatedTerrainDeformation = TerrainDeformRipple(GetLocationX(where), GetLocationY(where), endRadius, depth, R2I(duration * 1000), 1, spaceWave, timeWave, radiusRatio, limitNeg)
			return bj_lastCreatedTerrainDeformation;//return bj_lastCreatedTerrainDeformation
		}//endfunction
		//
		private terraindeformation TerrainDeformationWaveBJ(float duration, location source, location target, float radius, float depth, float trailDelay) {//function TerrainDeformationWaveBJ takes real duration, location source, location target, real radius, real depth, real trailDelay returns terraindeformation
			float distance;//local real distance
			float dirX;//local real dirX
			float dirY;//local real dirY
			float speed;//local real speed
			distance = DistanceBetweenPoints(source, target);//set distance = DistanceBetweenPoints(source, target)
			if ((distance == 0 || duration <= 0)) {//if (distance == 0 or duration <= 0) then
				return null;//return null
			}//endif
			dirX = (GetLocationX(target) - GetLocationX(source)) / distance;//set dirX = (GetLocationX(target) - GetLocationX(source)) / distance
			dirY = (GetLocationY(target) - GetLocationY(source)) / distance;//set dirY = (GetLocationY(target) - GetLocationY(source)) / distance
			speed = distance / duration;//set speed = distance / duration
			bj_lastCreatedTerrainDeformation = TerrainDeformWave(GetLocationX(source), GetLocationY(source), dirX, dirY, distance, speed, radius, depth, R2I(trailDelay * 1000), 1);//set bj_lastCreatedTerrainDeformation = TerrainDeformWave(GetLocationX(source), GetLocationY(source), dirX, dirY, distance, speed, radius, depth, R2I(trailDelay * 1000), 1)
			return bj_lastCreatedTerrainDeformation;//return bj_lastCreatedTerrainDeformation
		}//endfunction
		//
		private terraindeformation TerrainDeformationRandomBJ(float duration, location where, float radius, float minDelta, float maxDelta, float updateInterval) {//function TerrainDeformationRandomBJ takes real duration, location where, real radius, real minDelta, real maxDelta, real updateInterval returns terraindeformation
			bj_lastCreatedTerrainDeformation = TerrainDeformRandom(GetLocationX(where), GetLocationY(where), radius, minDelta, maxDelta, R2I(duration * 1000), R2I(updateInterval * 1000));//set bj_lastCreatedTerrainDeformation = TerrainDeformRandom(GetLocationX(where), GetLocationY(where), radius, minDelta, maxDelta, R2I(duration * 1000), R2I(updateInterval * 1000))
			return bj_lastCreatedTerrainDeformation;//return bj_lastCreatedTerrainDeformation
		}//endfunction
		//
		private void TerrainDeformationStopBJ(terraindeformation deformation, float duration) {//function TerrainDeformationStopBJ takes terraindeformation deformation, real duration returns nothing
			TerrainDeformStop(deformation, R2I(duration * 1000));//call TerrainDeformStop(deformation, R2I(duration * 1000))
		}//endfunction
		//
		private terraindeformation GetLastCreatedTerrainDeformation() {//function GetLastCreatedTerrainDeformation takes nothing returns terraindeformation
			return bj_lastCreatedTerrainDeformation;//return bj_lastCreatedTerrainDeformation
		}//endfunction
		//
		private lightning AddLightningLoc(string codeName, location where1, location where2) {//function AddLightningLoc takes string codeName, location where1, location where2 returns lightning
			bj_lastCreatedLightning = AddLightningEx(codeName, true, GetLocationX(where1), GetLocationY(where1), GetLocationZ(where1), GetLocationX(where2), GetLocationY(where2), GetLocationZ(where2));//set bj_lastCreatedLightning = AddLightningEx(codeName, true, GetLocationX(where1), GetLocationY(where1), GetLocationZ(where1), GetLocationX(where2), GetLocationY(where2), GetLocationZ(where2))
			return bj_lastCreatedLightning;//return bj_lastCreatedLightning
		}//endfunction
		//
		private bool DestroyLightningBJ(lightning whichBolt) {//function DestroyLightningBJ takes lightning whichBolt returns boolean
			return DestroyLightning(whichBolt);//return DestroyLightning(whichBolt)
		}//endfunction
		//
		private bool MoveLightningLoc(lightning whichBolt, location where1, location where2) {//function MoveLightningLoc takes lightning whichBolt, location where1, location where2 returns boolean
			return MoveLightningEx(whichBolt, true, GetLocationX(where1), GetLocationY(where1), GetLocationZ(where1), GetLocationX(where2), GetLocationY(where2), GetLocationZ(where2));//return MoveLightningEx(whichBolt, true, GetLocationX(where1), GetLocationY(where1), GetLocationZ(where1), GetLocationX(where2), GetLocationY(where2), GetLocationZ(where2))
		}//endfunction
		//
		private float GetLightningColorABJ(lightning whichBolt) {//function GetLightningColorABJ takes lightning whichBolt returns real
			return GetLightningColorA(whichBolt);//return GetLightningColorA(whichBolt)
		}//endfunction
		//
		private float GetLightningColorRBJ(lightning whichBolt) {//function GetLightningColorRBJ takes lightning whichBolt returns real
			return GetLightningColorR(whichBolt);//return GetLightningColorR(whichBolt)
		}//endfunction
		//
		private float GetLightningColorGBJ(lightning whichBolt) {//function GetLightningColorGBJ takes lightning whichBolt returns real
			return GetLightningColorG(whichBolt);//return GetLightningColorG(whichBolt)
		}//endfunction
		//
		private float GetLightningColorBBJ(lightning whichBolt) {//function GetLightningColorBBJ takes lightning whichBolt returns real
			return GetLightningColorB(whichBolt);//return GetLightningColorB(whichBolt)
		}//endfunction
		//
		private bool SetLightningColorBJ(lightning whichBolt, float r, float g, float b, float a) {//function SetLightningColorBJ takes lightning whichBolt, real r, real g, real b, real a returns boolean
			return SetLightningColor(whichBolt, r, g, b, a);//return SetLightningColor(whichBolt, r, g, b, a)
		}//endfunction
		//
		private lightning GetLastCreatedLightningBJ() {//function GetLastCreatedLightningBJ takes nothing returns lightning
			return bj_lastCreatedLightning;//return bj_lastCreatedLightning
		}//endfunction
		//
		private string GetAbilityEffectBJ(int abilcode, effecttype t, int index) {//function GetAbilityEffectBJ takes integer abilcode, effecttype t, integer index returns string
			return GetAbilityEffectById(abilcode, t, index);//return GetAbilityEffectById(abilcode, t, index)
		}//endfunction
		//
		private string GetAbilitySoundBJ(int abilcode, soundtype t) {//function GetAbilitySoundBJ takes integer abilcode, soundtype t returns string
			return GetAbilitySoundById(abilcode, t);//return GetAbilitySoundById(abilcode, t)
		}//endfunction
		//
		private int GetTerrainCliffLevelBJ(location where) {//function GetTerrainCliffLevelBJ takes location where returns integer
			return GetTerrainCliffLevel(GetLocationX(where), GetLocationY(where));//return GetTerrainCliffLevel(GetLocationX(where), GetLocationY(where))
		}//endfunction
		//
		private int GetTerrainTypeBJ(location where) {//function GetTerrainTypeBJ takes location where returns integer
			return GetTerrainType(GetLocationX(where), GetLocationY(where));//return GetTerrainType(GetLocationX(where), GetLocationY(where))
		}//endfunction
		//
		private int GetTerrainVarianceBJ(location where) {//function GetTerrainVarianceBJ takes location where returns integer
			return GetTerrainVariance(GetLocationX(where), GetLocationY(where));//return GetTerrainVariance(GetLocationX(where), GetLocationY(where))
		}//endfunction
		//
		private void SetTerrainTypeBJ(location where, int terrainType, int variation, int area, int shape) {//function SetTerrainTypeBJ takes location where, integer terrainType, integer variation, integer area, integer shape returns nothing
			SetTerrainType(GetLocationX(where), GetLocationY(where), terrainType, variation, area, shape);//call SetTerrainType(GetLocationX(where), GetLocationY(where), terrainType, variation, area, shape)
		}//endfunction
		//
		private bool IsTerrainPathableBJ(location where, pathingtype t) {//function IsTerrainPathableBJ takes location where, pathingtype t returns boolean
			return IsTerrainPathable(GetLocationX(where), GetLocationY(where), t);//return IsTerrainPathable(GetLocationX(where), GetLocationY(where), t)
		}//endfunction
		//
		private void SetTerrainPathableBJ(location where, pathingtype t, bool flag) {//function SetTerrainPathableBJ takes location where, pathingtype t, boolean flag returns nothing
			SetTerrainPathable(GetLocationX(where), GetLocationY(where), t, flag);//call SetTerrainPathable(GetLocationX(where), GetLocationY(where), t, flag)
		}//endfunction
		//
		private void SetWaterBaseColorBJ(float red, float green, float blue, float transparency) {//function SetWaterBaseColorBJ takes real red, real green, real blue, real transparency returns nothing
			SetWaterBaseColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call SetWaterBaseColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private fogmodifier CreateFogModifierRectSimple(player whichPlayer, fogstate whichFogState, rect r, bool afterUnits) {//function CreateFogModifierRectSimple takes player whichPlayer, fogstate whichFogState, rect r, boolean afterUnits returns fogmodifier
			bj_lastCreatedFogModifier = CreateFogModifierRect(whichPlayer, whichFogState, r, true, afterUnits);//set bj_lastCreatedFogModifier = CreateFogModifierRect(whichPlayer, whichFogState, r, true, afterUnits)
			return bj_lastCreatedFogModifier;//return bj_lastCreatedFogModifier
		}//endfunction
		//
		private fogmodifier CreateFogModifierRadiusLocSimple(player whichPlayer, fogstate whichFogState, location center, float radius, bool afterUnits) {//function CreateFogModifierRadiusLocSimple takes player whichPlayer, fogstate whichFogState, location center, real radius, boolean afterUnits returns fogmodifier
			bj_lastCreatedFogModifier = CreateFogModifierRadiusLoc(whichPlayer, whichFogState, center, radius, true, afterUnits);//set bj_lastCreatedFogModifier = CreateFogModifierRadiusLoc(whichPlayer, whichFogState, center, radius, true, afterUnits)
			return bj_lastCreatedFogModifier;//return bj_lastCreatedFogModifier
		}//endfunction
		//
		//
		//
		//
		//
		private fogmodifier CreateFogModifierRectBJ(bool enabled, player whichPlayer, fogstate whichFogState, rect r) {//function CreateFogModifierRectBJ takes boolean enabled, player whichPlayer, fogstate whichFogState, rect r returns fogmodifier
			bj_lastCreatedFogModifier = CreateFogModifierRect(whichPlayer, whichFogState, r, true, false);//set bj_lastCreatedFogModifier = CreateFogModifierRect(whichPlayer, whichFogState, r, true, false)
			if (enabled) {//if enabled then
				FogModifierStart(bj_lastCreatedFogModifier);//call FogModifierStart(bj_lastCreatedFogModifier)
			}//endif
			return bj_lastCreatedFogModifier;//return bj_lastCreatedFogModifier
		}//endfunction
		//
		//
		//
		//
		//
		private fogmodifier CreateFogModifierRadiusLocBJ(bool enabled, player whichPlayer, fogstate whichFogState, location center, float radius) {//function CreateFogModifierRadiusLocBJ takes boolean enabled, player whichPlayer, fogstate whichFogState, location center, real radius returns fogmodifier
			bj_lastCreatedFogModifier = CreateFogModifierRadiusLoc(whichPlayer, whichFogState, center, radius, true, false);//set bj_lastCreatedFogModifier = CreateFogModifierRadiusLoc(whichPlayer, whichFogState, center, radius, true, false)
			if (enabled) {//if enabled then
				FogModifierStart(bj_lastCreatedFogModifier);//call FogModifierStart(bj_lastCreatedFogModifier)
			}//endif
			return bj_lastCreatedFogModifier;//return bj_lastCreatedFogModifier
		}//endfunction
		//
		private fogmodifier GetLastCreatedFogModifier() {//function GetLastCreatedFogModifier takes nothing returns fogmodifier
			return bj_lastCreatedFogModifier;//return bj_lastCreatedFogModifier
		}//endfunction
		//
		private void FogEnableOn() {//function FogEnableOn takes nothing returns nothing
			FogEnable(true);//call FogEnable(true)
		}//endfunction
		//
		private void FogEnableOff() {//function FogEnableOff takes nothing returns nothing
			FogEnable(false);//call FogEnable(false)
		}//endfunction
		//
		private void FogMaskEnableOn() {//function FogMaskEnableOn takes nothing returns nothing
			FogMaskEnable(true);//call FogMaskEnable(true)
		}//endfunction
		//
		private void FogMaskEnableOff() {//function FogMaskEnableOff takes nothing returns nothing
			FogMaskEnable(false);//call FogMaskEnable(false)
		}//endfunction
		//
		private void UseTimeOfDayBJ(bool flag) {//function UseTimeOfDayBJ takes boolean flag returns nothing
			SuspendTimeOfDay(not flag);//call SuspendTimeOfDay(not flag)
		}//endfunction
		//
		private void SetTerrainFogExBJ(int style, float zstart, float zend, float density, float red, float green, float blue) {//function SetTerrainFogExBJ takes integer style, real zstart, real zend, real density, real red, real green, real blue returns nothing
			SetTerrainFogEx(style, zstart, zend, density, red * 0.01, green * 0.01, blue * 0.01);//call SetTerrainFogEx(style, zstart, zend, density, red * 0.01, green * 0.01, blue * 0.01)
		}//endfunction
		//
		private void ResetTerrainFogBJ() {//function ResetTerrainFogBJ takes nothing returns nothing
			ResetTerrainFog();//call ResetTerrainFog()
		}//endfunction
		//
		private void SetDoodadAnimationBJ(string animName, int doodadID, float radius, location center) {//function SetDoodadAnimationBJ takes string animName, integer doodadID, real radius, location center returns nothing
			SetDoodadAnimation(GetLocationX(center), GetLocationY(center), radius, doodadID, false, animName, false);//call SetDoodadAnimation(GetLocationX(center), GetLocationY(center), radius, doodadID, false, animName, false)
		}//endfunction
		//
		private void SetDoodadAnimationRectBJ(string animName, int doodadID, rect r) {//function SetDoodadAnimationRectBJ takes string animName, integer doodadID, rect r returns nothing
			SetDoodadAnimationRect(r, doodadID, animName, false);//call SetDoodadAnimationRect(r, doodadID, animName, false)
		}//endfunction
		//
		private void AddUnitAnimationPropertiesBJ(bool add, string animProperties, unit whichUnit) {//function AddUnitAnimationPropertiesBJ takes boolean add, string animProperties, unit whichUnit returns nothing
			AddUnitAnimationProperties(whichUnit, animProperties, add);//call AddUnitAnimationProperties(whichUnit, animProperties, add)
		}//endfunction
		//
		private image CreateImageBJ(string file, float size, location where, float zOffset, int imageType) {//function CreateImageBJ takes string file, real size, location where, real zOffset, integer imageType returns image
			bj_lastCreatedImage = CreateImage(file, size, size, size, GetLocationX(where), GetLocationY(where), zOffset, 0, 0, 0, imageType);//set bj_lastCreatedImage = CreateImage(file, size, size, size, GetLocationX(where), GetLocationY(where), zOffset, 0, 0, 0, imageType)
			return bj_lastCreatedImage;//return bj_lastCreatedImage
		}//endfunction
		//
		private void ShowImageBJ(bool flag, image whichImage) {//function ShowImageBJ takes boolean flag, image whichImage returns nothing
			ShowImage(whichImage, flag);//call ShowImage(whichImage, flag)
		}//endfunction
		//
		private void SetImagePositionBJ(image whichImage, location where, float zOffset) {//function SetImagePositionBJ takes image whichImage, location where, real zOffset returns nothing
			SetImagePosition(whichImage, GetLocationX(where), GetLocationY(where), zOffset);//call SetImagePosition(whichImage, GetLocationX(where), GetLocationY(where), zOffset)
		}//endfunction
		//
		private void SetImageColorBJ(image whichImage, float red, float green, float blue, float alpha) {//function SetImageColorBJ takes image whichImage, real red, real green, real blue, real alpha returns nothing
			SetImageColor(whichImage, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-alpha));//call SetImageColor(whichImage, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-alpha))
		}//endfunction
		//
		private image GetLastCreatedImage() {//function GetLastCreatedImage takes nothing returns image
			return bj_lastCreatedImage;//return bj_lastCreatedImage
		}//endfunction
		//
		private ubersplat CreateUbersplatBJ(location where, string name, float red, float green, float blue, float alpha, bool forcePaused, bool noBirthTime) {//function CreateUbersplatBJ takes location where, string name, real red, real green, real blue, real alpha, boolean forcePaused, boolean noBirthTime returns ubersplat
			bj_lastCreatedUbersplat = CreateUbersplat(GetLocationX(where), GetLocationY(where), name, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-alpha), forcePaused, noBirthTime);//set bj_lastCreatedUbersplat = CreateUbersplat(GetLocationX(where), GetLocationY(where), name, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-alpha), forcePaused, noBirthTime)
			return bj_lastCreatedUbersplat;//return bj_lastCreatedUbersplat
		}//endfunction
		//
		private void ShowUbersplatBJ(bool flag, ubersplat whichSplat) {//function ShowUbersplatBJ takes boolean flag, ubersplat whichSplat returns nothing
			ShowUbersplat(whichSplat, flag);//call ShowUbersplat(whichSplat, flag)
		}//endfunction
		//
		private ubersplat GetLastCreatedUbersplat() {//function GetLastCreatedUbersplat takes nothing returns ubersplat
			return bj_lastCreatedUbersplat;//return bj_lastCreatedUbersplat
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void PlaySoundBJ(sound soundHandle) {//function PlaySoundBJ takes sound soundHandle returns nothing
			bj_lastPlayedSound = soundHandle;//set bj_lastPlayedSound = soundHandle
			if ((soundHandle != null)) {//if (soundHandle != null) then
				StartSound(soundHandle);//call StartSound(soundHandle)
			}//endif
		}//endfunction
		//
		private void StopSoundBJ(sound soundHandle, bool fadeOut) {//function StopSoundBJ takes sound soundHandle, boolean fadeOut returns nothing
			StopSound(soundHandle, false, fadeOut);//call StopSound(soundHandle, false, fadeOut)
		}//endfunction
		//
		private void SetSoundVolumeBJ(sound soundHandle, float volumePercent) {//function SetSoundVolumeBJ takes sound soundHandle, real volumePercent returns nothing
			SetSoundVolume(soundHandle, PercentToInt(volumePercent, 127));//call SetSoundVolume(soundHandle, PercentToInt(volumePercent, 127))
		}//endfunction
		//
		private void SetSoundOffsetBJ(float newOffset, sound soundHandle) {//function SetSoundOffsetBJ takes real newOffset, sound soundHandle returns nothing
			SetSoundPlayPosition(soundHandle, R2I(newOffset * 1000));//call SetSoundPlayPosition(soundHandle, R2I(newOffset * 1000))
		}//endfunction
		//
		private void SetSoundDistanceCutoffBJ(sound soundHandle, float cutoff) {//function SetSoundDistanceCutoffBJ takes sound soundHandle, real cutoff returns nothing
			SetSoundDistanceCutoff(soundHandle, cutoff);//call SetSoundDistanceCutoff(soundHandle, cutoff)
		}//endfunction
		//
		private void SetSoundPitchBJ(sound soundHandle, float pitch) {//function SetSoundPitchBJ takes sound soundHandle, real pitch returns nothing
			SetSoundPitch(soundHandle, pitch);//call SetSoundPitch(soundHandle, pitch)
		}//endfunction
		//
		private void SetSoundPositionLocBJ(sound soundHandle, location loc, float z) {//function SetSoundPositionLocBJ takes sound soundHandle, location loc, real z returns nothing
			SetSoundPosition(soundHandle, GetLocationX(loc), GetLocationY(loc), z);//call SetSoundPosition(soundHandle, GetLocationX(loc), GetLocationY(loc), z)
		}//endfunction
		//
		private void AttachSoundToUnitBJ(sound soundHandle, unit whichUnit) {//function AttachSoundToUnitBJ takes sound soundHandle, unit whichUnit returns nothing
			AttachSoundToUnit(soundHandle, whichUnit);//call AttachSoundToUnit(soundHandle, whichUnit)
		}//endfunction
		//
		private void SetSoundConeAnglesBJ(sound soundHandle, float inside, float outside, float outsideVolumePercent) {//function SetSoundConeAnglesBJ takes sound soundHandle, real inside, real outside, real outsideVolumePercent returns nothing
			SetSoundConeAngles(soundHandle, inside, outside, PercentToInt(outsideVolumePercent, 127));//call SetSoundConeAngles(soundHandle, inside, outside, PercentToInt(outsideVolumePercent, 127))
		}//endfunction
		//
		private void KillSoundWhenDoneBJ(sound soundHandle) {//function KillSoundWhenDoneBJ takes sound soundHandle returns nothing
			KillSoundWhenDone(soundHandle);//call KillSoundWhenDone(soundHandle)
		}//endfunction
		//
		private void PlaySoundAtPointBJ(sound soundHandle, float volumePercent, location loc, float z) {//function PlaySoundAtPointBJ takes sound soundHandle, real volumePercent, location loc, real z returns nothing
			SetSoundPositionLocBJ(soundHandle, loc, z);//call SetSoundPositionLocBJ(soundHandle, loc, z)
			SetSoundVolumeBJ(soundHandle, volumePercent);//call SetSoundVolumeBJ(soundHandle, volumePercent)
			PlaySoundBJ(soundHandle);//call PlaySoundBJ(soundHandle)
		}//endfunction
		//
		private void PlaySoundOnUnitBJ(sound soundHandle, float volumePercent, unit whichUnit) {//function PlaySoundOnUnitBJ takes sound soundHandle, real volumePercent, unit whichUnit returns nothing
			AttachSoundToUnitBJ(soundHandle, whichUnit);//call AttachSoundToUnitBJ(soundHandle, whichUnit)
			SetSoundVolumeBJ(soundHandle, volumePercent);//call SetSoundVolumeBJ(soundHandle, volumePercent)
			PlaySoundBJ(soundHandle);//call PlaySoundBJ(soundHandle)
		}//endfunction
		//
		private void PlaySoundFromOffsetBJ(sound soundHandle, float volumePercent, float startingOffset) {//function PlaySoundFromOffsetBJ takes sound soundHandle, real volumePercent, real startingOffset returns nothing
			SetSoundVolumeBJ(soundHandle, volumePercent);//call SetSoundVolumeBJ(soundHandle, volumePercent)
			PlaySoundBJ(soundHandle);//call PlaySoundBJ(soundHandle)
			SetSoundOffsetBJ(startingOffset, soundHandle);//call SetSoundOffsetBJ(startingOffset, soundHandle)
		}//endfunction
		//
		private void PlayMusicBJ(string musicFileName) {//function PlayMusicBJ takes string musicFileName returns nothing
			bj_lastPlayedMusic = musicFileName;//set bj_lastPlayedMusic = musicFileName
			PlayMusic(musicFileName);//call PlayMusic(musicFileName)
		}//endfunction
		//
		private void PlayMusicExBJ(string musicFileName, float startingOffset, float fadeInTime) {//function PlayMusicExBJ takes string musicFileName, real startingOffset, real fadeInTime returns nothing
			bj_lastPlayedMusic = musicFileName;//set bj_lastPlayedMusic = musicFileName
			PlayMusicEx(musicFileName, R2I(startingOffset * 1000), R2I(fadeInTime * 1000));//call PlayMusicEx(musicFileName, R2I(startingOffset * 1000), R2I(fadeInTime * 1000))
		}//endfunction
		//
		private void SetMusicOffsetBJ(float newOffset) {//function SetMusicOffsetBJ takes real newOffset returns nothing
			SetMusicPlayPosition(R2I(newOffset * 1000));//call SetMusicPlayPosition(R2I(newOffset * 1000))
		}//endfunction
		//
		private void PlayThematicMusicBJ(string musicName) {//function PlayThematicMusicBJ takes string musicName returns nothing
			PlayThematicMusic(musicName);//call PlayThematicMusic(musicName)
		}//endfunction
		//
		private void PlayThematicMusicExBJ(string musicName, float startingOffset) {//function PlayThematicMusicExBJ takes string musicName, real startingOffset returns nothing
			PlayThematicMusicEx(musicName, R2I(startingOffset * 1000));//call PlayThematicMusicEx(musicName, R2I(startingOffset * 1000))
		}//endfunction
		//
		private void SetThematicMusicOffsetBJ(float newOffset) {//function SetThematicMusicOffsetBJ takes real newOffset returns nothing
			SetThematicMusicPlayPosition(R2I(newOffset * 1000));//call SetThematicMusicPlayPosition(R2I(newOffset * 1000))
		}//endfunction
		//
		private void EndThematicMusicBJ() {//function EndThematicMusicBJ takes nothing returns nothing
			EndThematicMusic();//call EndThematicMusic()
		}//endfunction
		//
		private void StopMusicBJ(bool fadeOut) {//function StopMusicBJ takes boolean fadeOut returns nothing
			StopMusic(fadeOut);//call StopMusic(fadeOut)
		}//endfunction
		//
		private void ResumeMusicBJ() {//function ResumeMusicBJ takes nothing returns nothing
			ResumeMusic();//call ResumeMusic()
		}//endfunction
		//
		private void SetMusicVolumeBJ(float volumePercent) {//function SetMusicVolumeBJ takes real volumePercent returns nothing
			SetMusicVolume(PercentToInt(volumePercent, 127));//call SetMusicVolume(PercentToInt(volumePercent, 127))
		}//endfunction
		//
		private float GetSoundDurationBJ(sound soundHandle) {//function GetSoundDurationBJ takes sound soundHandle returns real
			if ((soundHandle == null)) {//if (soundHandle == null) then
				return bj_NOTHING_SOUND_DURATION;//return bj_NOTHING_SOUND_DURATION
			} else {//else
				return I2R(GetSoundDuration(soundHandle)) * 0.001;//return I2R(GetSoundDuration(soundHandle)) * 0.001
			}//endif
		}//endfunction
		//
		private float GetSoundFileDurationBJ(string musicFileName) {//function GetSoundFileDurationBJ takes string musicFileName returns real
			return I2R(GetSoundFileDuration(musicFileName)) * 0.001;//return I2R(GetSoundFileDuration(musicFileName)) * 0.001
		}//endfunction
		//
		private sound GetLastPlayedSound() {//function GetLastPlayedSound takes nothing returns sound
			return bj_lastPlayedSound;//return bj_lastPlayedSound
		}//endfunction
		//
		private string GetLastPlayedMusic() {//function GetLastPlayedMusic takes nothing returns string
			return bj_lastPlayedMusic;//return bj_lastPlayedMusic
		}//endfunction
		//
		private void VolumeGroupSetVolumeBJ(volumegroup vgroup, float percent) {//function VolumeGroupSetVolumeBJ takes volumegroup vgroup, real percent returns nothing
			VolumeGroupSetVolume(vgroup, percent * 0.01);//call VolumeGroupSetVolume(vgroup, percent * 0.01)
		}//endfunction
		//
		private void SetCineModeVolumeGroupsImmediateBJ() {//function SetCineModeVolumeGroupsImmediateBJ takes nothing returns nothing
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITMOVEMENT,  bj_CINEMODE_VOLUME_UNITMOVEMENT);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITMOVEMENT,  bj_CINEMODE_VOLUME_UNITMOVEMENT)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITSOUNDS,    bj_CINEMODE_VOLUME_UNITSOUNDS);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITSOUNDS,    bj_CINEMODE_VOLUME_UNITSOUNDS)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_COMBAT,        bj_CINEMODE_VOLUME_COMBAT);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_COMBAT,        bj_CINEMODE_VOLUME_COMBAT)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_SPELLS,        bj_CINEMODE_VOLUME_SPELLS);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_SPELLS,        bj_CINEMODE_VOLUME_SPELLS)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UI,            bj_CINEMODE_VOLUME_UI);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UI,            bj_CINEMODE_VOLUME_UI)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_MUSIC,         bj_CINEMODE_VOLUME_MUSIC);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_MUSIC,         bj_CINEMODE_VOLUME_MUSIC)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_AMBIENTSOUNDS, bj_CINEMODE_VOLUME_AMBIENTSOUNDS);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_AMBIENTSOUNDS, bj_CINEMODE_VOLUME_AMBIENTSOUNDS)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_FIRE,          bj_CINEMODE_VOLUME_FIRE);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_FIRE,          bj_CINEMODE_VOLUME_FIRE)
		}//endfunction
		//
		private void SetCineModeVolumeGroupsBJ() {//function SetCineModeVolumeGroupsBJ takes nothing returns nothing
			//
			if (bj_gameStarted) {//if bj_gameStarted then
				SetCineModeVolumeGroupsImmediateBJ();//call SetCineModeVolumeGroupsImmediateBJ()
			} else {//else
				TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, function SetCineModeVolumeGroupsImmediateBJ);//call TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, function SetCineModeVolumeGroupsImmediateBJ)
			}//endif
		}//endfunction
		//
		private void SetSpeechVolumeGroupsImmediateBJ() {//function SetSpeechVolumeGroupsImmediateBJ takes nothing returns nothing
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITMOVEMENT,  bj_SPEECH_VOLUME_UNITMOVEMENT);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITMOVEMENT,  bj_SPEECH_VOLUME_UNITMOVEMENT)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITSOUNDS,    bj_SPEECH_VOLUME_UNITSOUNDS);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UNITSOUNDS,    bj_SPEECH_VOLUME_UNITSOUNDS)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_COMBAT,        bj_SPEECH_VOLUME_COMBAT);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_COMBAT,        bj_SPEECH_VOLUME_COMBAT)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_SPELLS,        bj_SPEECH_VOLUME_SPELLS);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_SPELLS,        bj_SPEECH_VOLUME_SPELLS)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UI,            bj_SPEECH_VOLUME_UI);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_UI,            bj_SPEECH_VOLUME_UI)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_MUSIC,         bj_SPEECH_VOLUME_MUSIC);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_MUSIC,         bj_SPEECH_VOLUME_MUSIC)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_AMBIENTSOUNDS, bj_SPEECH_VOLUME_AMBIENTSOUNDS);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_AMBIENTSOUNDS, bj_SPEECH_VOLUME_AMBIENTSOUNDS)
			VolumeGroupSetVolume(SOUND_VOLUMEGROUP_FIRE,          bj_SPEECH_VOLUME_FIRE);//call VolumeGroupSetVolume(SOUND_VOLUMEGROUP_FIRE,          bj_SPEECH_VOLUME_FIRE)
		}//endfunction
		//
		private void SetSpeechVolumeGroupsBJ() {//function SetSpeechVolumeGroupsBJ takes nothing returns nothing
			//
			if (bj_gameStarted) {//if bj_gameStarted then
				SetSpeechVolumeGroupsImmediateBJ();//call SetSpeechVolumeGroupsImmediateBJ()
			} else {//else
				TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, function SetSpeechVolumeGroupsImmediateBJ);//call TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, function SetSpeechVolumeGroupsImmediateBJ)
			}//endif
		}//endfunction
		//
		private void VolumeGroupResetImmediateBJ() {//function VolumeGroupResetImmediateBJ takes nothing returns nothing
			VolumeGroupReset();//call VolumeGroupReset()
		}//endfunction
		//
		private void VolumeGroupResetBJ() {//function VolumeGroupResetBJ takes nothing returns nothing
			//
			if (bj_gameStarted) {//if bj_gameStarted then
				VolumeGroupResetImmediateBJ();//call VolumeGroupResetImmediateBJ()
			} else {//else
				TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, function VolumeGroupResetImmediateBJ);//call TimerStart(bj_volumeGroupsTimer, bj_GAME_STARTED_THRESHOLD, false, function VolumeGroupResetImmediateBJ)
			}//endif
		}//endfunction
		//
		private bool GetSoundIsPlayingBJ(sound soundHandle) {//function GetSoundIsPlayingBJ takes sound soundHandle returns boolean
			return GetSoundIsLoading(soundHandle) || GetSoundIsPlaying(soundHandle);//return GetSoundIsLoading(soundHandle) or GetSoundIsPlaying(soundHandle)
		}//endfunction
		//
		private void WaitForSoundBJ(sound soundHandle, float offset) {//function WaitForSoundBJ takes sound soundHandle, real offset returns nothing
			TriggerWaitForSound(soundHandle, offset);//call TriggerWaitForSound( soundHandle, offset )
		}//endfunction
		//
		private void SetMapMusicIndexedBJ(string musicName, int index) {//function SetMapMusicIndexedBJ takes string musicName, integer index returns nothing
			SetMapMusic(musicName, false, index);//call SetMapMusic(musicName, false, index)
		}//endfunction
		//
		private void SetMapMusicRandomBJ(string musicName) {//function SetMapMusicRandomBJ takes string musicName returns nothing
			SetMapMusic(musicName, true, 0);//call SetMapMusic(musicName, true, 0)
		}//endfunction
		//
		private void ClearMapMusicBJ() {//function ClearMapMusicBJ takes nothing returns nothing
			ClearMapMusic();//call ClearMapMusic()
		}//endfunction
		//
		private void SetStackedSoundBJ(bool add, sound soundHandle, rect r) {//function SetStackedSoundBJ takes boolean add, sound soundHandle, rect r returns nothing
			float width = GetRectMaxX(r) - GetRectMinX(r);//local real width = GetRectMaxX(r) - GetRectMinX(r)
			float height = GetRectMaxY(r) - GetRectMinY(r);//local real height = GetRectMaxY(r) - GetRectMinY(r)
			SetSoundPosition(soundHandle, GetRectCenterX(r), GetRectCenterY(r), 0);//call SetSoundPosition(soundHandle, GetRectCenterX(r), GetRectCenterY(r), 0)
			if (add) {//if add then
				RegisterStackedSound(soundHandle, true, width, height);//call RegisterStackedSound(soundHandle, true, width, height)
			} else {//else
				UnregisterStackedSound(soundHandle, true, width, height);//call UnregisterStackedSound(soundHandle, true, width, height)
			}//endif
		}//endfunction
		//
		private void StartSoundForPlayerBJ(player whichPlayer, sound soundHandle) {//function StartSoundForPlayerBJ takes player whichPlayer, sound soundHandle returns nothing
			if ((whichPlayer == GetLocalPlayer())) {//if (whichPlayer == GetLocalPlayer()) then
				StartSound(soundHandle);//call StartSound(soundHandle)
			}//endif
		}//endfunction
		//
		private void VolumeGroupSetVolumeForPlayerBJ(player whichPlayer, volumegroup vgroup, float scale) {//function VolumeGroupSetVolumeForPlayerBJ takes player whichPlayer, volumegroup vgroup, real scale returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				VolumeGroupSetVolume(vgroup, scale);//call VolumeGroupSetVolume(vgroup, scale)
			}//endif
		}//endfunction
		//
		private void EnableDawnDusk(bool flag) {//function EnableDawnDusk takes boolean flag returns nothing
			bj_useDawnDuskSounds = flag;//set bj_useDawnDuskSounds = flag
		}//endfunction
		//
		private bool IsDawnDuskEnabled() {//function IsDawnDuskEnabled takes nothing returns boolean
			return bj_useDawnDuskSounds;//return bj_useDawnDuskSounds
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void SetAmbientDaySound(string inLabel) {//function SetAmbientDaySound takes string inLabel returns nothing
			float ToD;//local real ToD
			//
			if ((bj_dayAmbientSound != null)) {//if (bj_dayAmbientSound != null) then
				StopSound(bj_dayAmbientSound, true, true);//call StopSound(bj_dayAmbientSound, true, true)
			}//endif
			//
			bj_dayAmbientSound = CreateMIDISound(inLabel, 20, 20);//set bj_dayAmbientSound = CreateMIDISound(inLabel, 20, 20)
			//
			ToD = GetTimeOfDay();//set ToD = GetTimeOfDay()
			if ((ToD >= bj_TOD_DAWN && ToD < bj_TOD_DUSK)) {//if (ToD >= bj_TOD_DAWN and ToD < bj_TOD_DUSK) then
				StartSound(bj_dayAmbientSound);//call StartSound(bj_dayAmbientSound)
			}//endif
		}//endfunction
		//
		private void SetAmbientNightSound(string inLabel) {//function SetAmbientNightSound takes string inLabel returns nothing
			float ToD;//local real ToD
			//
			if ((bj_nightAmbientSound != null)) {//if (bj_nightAmbientSound != null) then
				StopSound(bj_nightAmbientSound, true, true);//call StopSound(bj_nightAmbientSound, true, true)
			}//endif
			//
			bj_nightAmbientSound = CreateMIDISound(inLabel, 20, 20);//set bj_nightAmbientSound = CreateMIDISound(inLabel, 20, 20)
			//
			ToD = GetTimeOfDay();//set ToD = GetTimeOfDay()
			if ((ToD < bj_TOD_DAWN || ToD >= bj_TOD_DUSK)) {//if (ToD < bj_TOD_DAWN or ToD >= bj_TOD_DUSK) then
				StartSound(bj_nightAmbientSound);//call StartSound(bj_nightAmbientSound)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private effect AddSpecialEffectLocBJ(location where, string modelName) {//function AddSpecialEffectLocBJ takes location where, string modelName returns effect
			bj_lastCreatedEffect = AddSpecialEffectLoc(modelName, where);//set bj_lastCreatedEffect = AddSpecialEffectLoc(modelName, where)
			return bj_lastCreatedEffect;//return bj_lastCreatedEffect
		}//endfunction
		//
		private effect AddSpecialEffectTargetUnitBJ(string attachPointName, widget targetWidget, string modelName) {//function AddSpecialEffectTargetUnitBJ takes string attachPointName, widget targetWidget, string modelName returns effect
			bj_lastCreatedEffect = AddSpecialEffectTarget(modelName, targetWidget, attachPointName);//set bj_lastCreatedEffect = AddSpecialEffectTarget(modelName, targetWidget, attachPointName)
			return bj_lastCreatedEffect;//return bj_lastCreatedEffect
		}//endfunction
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
		private void DestroyEffectBJ(effect whichEffect) {//function DestroyEffectBJ takes effect whichEffect returns nothing
			DestroyEffect(whichEffect);//call DestroyEffect(whichEffect)
		}//endfunction
		//
		private effect GetLastCreatedEffectBJ() {//function GetLastCreatedEffectBJ takes nothing returns effect
			return bj_lastCreatedEffect;//return bj_lastCreatedEffect
		}//endfunction
		//
		//
		//
		//
		//
		//
		private location GetItemLoc(item whichItem) {//function GetItemLoc takes item whichItem returns location
			return Location(GetItemX(whichItem), GetItemY(whichItem));//return Location(GetItemX(whichItem), GetItemY(whichItem))
		}//endfunction
		//
		private float GetItemLifeBJ(widget whichWidget) {//function GetItemLifeBJ takes widget whichWidget returns real
			return GetWidgetLife(whichWidget);//return GetWidgetLife(whichWidget)
		}//endfunction
		//
		private void SetItemLifeBJ(widget whichWidget, float life) {//function SetItemLifeBJ takes widget whichWidget, real life returns nothing
			SetWidgetLife(whichWidget, life);//call SetWidgetLife(whichWidget, life)
		}//endfunction
		//
		private void AddHeroXPSwapped(int xpToAdd, unit whichHero, bool showEyeCandy) {//function AddHeroXPSwapped takes integer xpToAdd, unit whichHero, boolean showEyeCandy returns nothing
			AddHeroXP(whichHero, xpToAdd, showEyeCandy);//call AddHeroXP(whichHero, xpToAdd, showEyeCandy)
		}//endfunction
		//
		private void SetHeroLevelBJ(unit whichHero, int newLevel, bool showEyeCandy) {//function SetHeroLevelBJ takes unit whichHero, integer newLevel, boolean showEyeCandy returns nothing
			int oldLevel = GetHeroLevel(whichHero);//local integer oldLevel = GetHeroLevel(whichHero)
			if ((newLevel > oldLevel)) {//if (newLevel > oldLevel) then
				SetHeroLevel(whichHero, newLevel, showEyeCandy);//call SetHeroLevel(whichHero, newLevel, showEyeCandy)
			} else if ((newLevel < oldLevel)) {//elseif (newLevel < oldLevel) then
				UnitStripHeroLevel(whichHero, oldLevel - newLevel);//call UnitStripHeroLevel(whichHero, oldLevel - newLevel)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private int DecUnitAbilityLevelSwapped(int abilcode, unit whichUnit) {//function DecUnitAbilityLevelSwapped takes integer abilcode, unit whichUnit returns integer
			return DecUnitAbilityLevel(whichUnit, abilcode);//return DecUnitAbilityLevel(whichUnit, abilcode)
		}//endfunction
		//
		private int IncUnitAbilityLevelSwapped(int abilcode, unit whichUnit) {//function IncUnitAbilityLevelSwapped takes integer abilcode, unit whichUnit returns integer
			return IncUnitAbilityLevel(whichUnit, abilcode);//return IncUnitAbilityLevel(whichUnit, abilcode)
		}//endfunction
		//
		private int SetUnitAbilityLevelSwapped(int abilcode, unit whichUnit, int level) {//function SetUnitAbilityLevelSwapped takes integer abilcode, unit whichUnit, integer level returns integer
			return SetUnitAbilityLevel(whichUnit, abilcode, level);//return SetUnitAbilityLevel(whichUnit, abilcode, level)
		}//endfunction
		//
		private int GetUnitAbilityLevelSwapped(int abilcode, unit whichUnit) {//function GetUnitAbilityLevelSwapped takes integer abilcode, unit whichUnit returns integer
			return GetUnitAbilityLevel(whichUnit, abilcode);//return GetUnitAbilityLevel(whichUnit, abilcode)
		}//endfunction
		//
		private bool UnitHasBuffBJ(unit whichUnit, int buffcode) {//function UnitHasBuffBJ takes unit whichUnit, integer buffcode returns boolean
			return (GetUnitAbilityLevel(whichUnit, buffcode) > 0);//return (GetUnitAbilityLevel(whichUnit, buffcode) > 0)
		}//endfunction
		//
		private bool UnitRemoveBuffBJ(int buffcode, unit whichUnit) {//function UnitRemoveBuffBJ takes integer buffcode, unit whichUnit returns boolean
			return UnitRemoveAbility(whichUnit, buffcode);//return UnitRemoveAbility(whichUnit, buffcode)
		}//endfunction
		//
		private bool UnitAddItemSwapped(item whichItem, unit whichHero) {//function UnitAddItemSwapped takes item whichItem, unit whichHero returns boolean
			return UnitAddItem(whichHero, whichItem);//return UnitAddItem(whichHero, whichItem)
		}//endfunction
		//
		private item UnitAddItemByIdSwapped(int itemId, unit whichHero) {//function UnitAddItemByIdSwapped takes integer itemId, unit whichHero returns item
			//
			//
			//
			bj_lastCreatedItem = CreateItem(itemId, GetUnitX(whichHero), GetUnitY(whichHero));//set bj_lastCreatedItem = CreateItem(itemId, GetUnitX(whichHero), GetUnitY(whichHero))
			UnitAddItem(whichHero, bj_lastCreatedItem);//call UnitAddItem(whichHero, bj_lastCreatedItem)
			return bj_lastCreatedItem;//return bj_lastCreatedItem
		}//endfunction
		//
		private void UnitRemoveItemSwapped(item whichItem, unit whichHero) {//function UnitRemoveItemSwapped takes item whichItem, unit whichHero returns nothing
			bj_lastRemovedItem = whichItem;//set bj_lastRemovedItem = whichItem
			UnitRemoveItem(whichHero, whichItem);//call UnitRemoveItem(whichHero, whichItem)
		}//endfunction
		//
		//
		//
		private item UnitRemoveItemFromSlotSwapped(int itemSlot, unit whichHero) {//function UnitRemoveItemFromSlotSwapped takes integer itemSlot, unit whichHero returns item
			bj_lastRemovedItem = UnitRemoveItemFromSlot(whichHero, itemSlot-1);//set bj_lastRemovedItem = UnitRemoveItemFromSlot(whichHero, itemSlot-1)
			return bj_lastRemovedItem;//return bj_lastRemovedItem
		}//endfunction
		//
		private item CreateItemLoc(int itemId, location loc) {//function CreateItemLoc takes integer itemId, location loc returns item
			bj_lastCreatedItem = CreateItem(itemId, GetLocationX(loc), GetLocationY(loc));//set bj_lastCreatedItem = CreateItem(itemId, GetLocationX(loc), GetLocationY(loc))
			return bj_lastCreatedItem;//return bj_lastCreatedItem
		}//endfunction
		//
		private item GetLastCreatedItem() {//function GetLastCreatedItem takes nothing returns item
			return bj_lastCreatedItem;//return bj_lastCreatedItem
		}//endfunction
		//
		private item GetLastRemovedItem() {//function GetLastRemovedItem takes nothing returns item
			return bj_lastRemovedItem;//return bj_lastRemovedItem
		}//endfunction
		//
		private void SetItemPositionLoc(item whichItem, location loc) {//function SetItemPositionLoc takes item whichItem, location loc returns nothing
			SetItemPosition(whichItem, GetLocationX(loc), GetLocationY(loc));//call SetItemPosition(whichItem, GetLocationX(loc), GetLocationY(loc))
		}//endfunction
		//
		private int GetLearnedSkillBJ() {//function GetLearnedSkillBJ takes nothing returns integer
			return GetLearnedSkill();//return GetLearnedSkill()
		}//endfunction
		//
		private void SuspendHeroXPBJ(bool flag, unit whichHero) {//function SuspendHeroXPBJ takes boolean flag, unit whichHero returns nothing
			SuspendHeroXP(whichHero, not flag);//call SuspendHeroXP(whichHero, not flag)
		}//endfunction
		//
		private void SetPlayerHandicapXPBJ(player whichPlayer, float handicapPercent) {//function SetPlayerHandicapXPBJ takes player whichPlayer, real handicapPercent returns nothing
			SetPlayerHandicapXP(whichPlayer, handicapPercent * 0.01);//call SetPlayerHandicapXP(whichPlayer, handicapPercent * 0.01)
		}//endfunction
		//
		private float GetPlayerHandicapXPBJ(player whichPlayer) {//function GetPlayerHandicapXPBJ takes player whichPlayer returns real
			return GetPlayerHandicapXP(whichPlayer) * 100;//return GetPlayerHandicapXP(whichPlayer) * 100
		}//endfunction
		//
		private void SetPlayerHandicapBJ(player whichPlayer, float handicapPercent) {//function SetPlayerHandicapBJ takes player whichPlayer, real handicapPercent returns nothing
			SetPlayerHandicap(whichPlayer, handicapPercent * 0.01);//call SetPlayerHandicap(whichPlayer, handicapPercent * 0.01)
		}//endfunction
		//
		private float GetPlayerHandicapBJ(player whichPlayer) {//function GetPlayerHandicapBJ takes player whichPlayer returns real
			return GetPlayerHandicap(whichPlayer) * 100;//return GetPlayerHandicap(whichPlayer) * 100
		}//endfunction
		//
		private int GetHeroStatBJ(int whichStat, unit whichHero, bool includeBonuses) {//function GetHeroStatBJ takes integer whichStat, unit whichHero, boolean includeBonuses returns integer
			if ((whichStat == bj_HEROSTAT_STR)) {//if (whichStat == bj_HEROSTAT_STR) then
				return GetHeroStr(whichHero, includeBonuses);//return GetHeroStr(whichHero, includeBonuses)
			} else if ((whichStat == bj_HEROSTAT_AGI)) {//elseif (whichStat == bj_HEROSTAT_AGI) then
				return GetHeroAgi(whichHero, includeBonuses);//return GetHeroAgi(whichHero, includeBonuses)
			} else if ((whichStat == bj_HEROSTAT_INT)) {//elseif (whichStat == bj_HEROSTAT_INT) then
				return GetHeroInt(whichHero, includeBonuses);//return GetHeroInt(whichHero, includeBonuses)
			} else {//else
				//
				return 0;//return 0
			}//endif
		}//endfunction
		//
		private void SetHeroStat(unit whichHero, int whichStat, int value) {//function SetHeroStat takes unit whichHero, integer whichStat, integer value returns nothing
			//
			if ((value <= 0)) {//if (value <= 0) then
				return;//return
			}//endif
			if ((whichStat == bj_HEROSTAT_STR)) {//if (whichStat == bj_HEROSTAT_STR) then
				SetHeroStr(whichHero, value, true);//call SetHeroStr(whichHero, value, true)
			} else if ((whichStat == bj_HEROSTAT_AGI)) {//elseif (whichStat == bj_HEROSTAT_AGI) then
				SetHeroAgi(whichHero, value, true);//call SetHeroAgi(whichHero, value, true)
			} else if ((whichStat == bj_HEROSTAT_INT)) {//elseif (whichStat == bj_HEROSTAT_INT) then
				SetHeroInt(whichHero, value, true);//call SetHeroInt(whichHero, value, true)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private void ModifyHeroStat(int whichStat, unit whichHero, int modifyMethod, int value) {//function ModifyHeroStat takes integer whichStat, unit whichHero, integer modifyMethod, integer value returns nothing
			if ((modifyMethod == bj_MODIFYMETHOD_ADD)) {//if (modifyMethod == bj_MODIFYMETHOD_ADD) then
				SetHeroStat(whichHero, whichStat, GetHeroStatBJ(whichStat, whichHero, false) + value);//call SetHeroStat(whichHero, whichStat, GetHeroStatBJ(whichStat, whichHero, false) + value)
			} else if ((modifyMethod == bj_MODIFYMETHOD_SUB)) {//elseif (modifyMethod == bj_MODIFYMETHOD_SUB) then
				SetHeroStat(whichHero, whichStat, GetHeroStatBJ(whichStat, whichHero, false) - value);//call SetHeroStat(whichHero, whichStat, GetHeroStatBJ(whichStat, whichHero, false) - value)
			} else if ((modifyMethod == bj_MODIFYMETHOD_SET)) {//elseif (modifyMethod == bj_MODIFYMETHOD_SET) then
				SetHeroStat(whichHero, whichStat, value);//call SetHeroStat(whichHero, whichStat, value)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private bool ModifyHeroSkillPoints(unit whichHero, int modifyMethod, int value) {//function ModifyHeroSkillPoints takes unit whichHero, integer modifyMethod, integer value returns boolean
			if ((modifyMethod == bj_MODIFYMETHOD_ADD)) {//if (modifyMethod == bj_MODIFYMETHOD_ADD) then
				return UnitModifySkillPoints(whichHero, value);//return UnitModifySkillPoints(whichHero, value)
			} else if ((modifyMethod == bj_MODIFYMETHOD_SUB)) {//elseif (modifyMethod == bj_MODIFYMETHOD_SUB) then
				return UnitModifySkillPoints(whichHero, -value);//return UnitModifySkillPoints(whichHero, -value)
			} else if ((modifyMethod == bj_MODIFYMETHOD_SET)) {//elseif (modifyMethod == bj_MODIFYMETHOD_SET) then
				return UnitModifySkillPoints(whichHero, value - GetHeroSkillPoints(whichHero));//return UnitModifySkillPoints(whichHero, value - GetHeroSkillPoints(whichHero))
			} else {//else
				//
				return false;//return false
			}//endif
		}//endfunction
		//
		private bool UnitDropItemPointBJ(unit whichUnit, item whichItem, float x, float y) {//function UnitDropItemPointBJ takes unit whichUnit, item whichItem, real x, real y returns boolean
			return UnitDropItemPoint(whichUnit, whichItem, x, y);//return UnitDropItemPoint(whichUnit, whichItem, x, y)
		}//endfunction
		//
		private bool UnitDropItemPointLoc(unit whichUnit, item whichItem, location loc) {//function UnitDropItemPointLoc takes unit whichUnit, item whichItem, location loc returns boolean
			return UnitDropItemPoint(whichUnit, whichItem, GetLocationX(loc), GetLocationY(loc));//return UnitDropItemPoint(whichUnit, whichItem, GetLocationX(loc), GetLocationY(loc))
		}//endfunction
		//
		private bool UnitDropItemSlotBJ(unit whichUnit, item whichItem, int slot) {//function UnitDropItemSlotBJ takes unit whichUnit, item whichItem, integer slot returns boolean
			return UnitDropItemSlot(whichUnit, whichItem, slot-1);//return UnitDropItemSlot(whichUnit, whichItem, slot-1)
		}//endfunction
		//
		private bool UnitDropItemTargetBJ(unit whichUnit, item whichItem, widget target) {//function UnitDropItemTargetBJ takes unit whichUnit, item whichItem, widget target returns boolean
			return UnitDropItemTarget(whichUnit, whichItem, target);//return UnitDropItemTarget(whichUnit, whichItem, target)
		}//endfunction
		//
		//
		//
		//
		private bool UnitUseItemDestructable(unit whichUnit, item whichItem, widget target) {//function UnitUseItemDestructable takes unit whichUnit, item whichItem, widget target returns boolean
			return UnitUseItemTarget(whichUnit, whichItem, target);//return UnitUseItemTarget(whichUnit, whichItem, target)
		}//endfunction
		//
		private bool UnitUseItemPointLoc(unit whichUnit, item whichItem, location loc) {//function UnitUseItemPointLoc takes unit whichUnit, item whichItem, location loc returns boolean
			return UnitUseItemPoint(whichUnit, whichItem, GetLocationX(loc), GetLocationY(loc));//return UnitUseItemPoint(whichUnit, whichItem, GetLocationX(loc), GetLocationY(loc))
		}//endfunction
		//
		//
		//
		private item UnitItemInSlotBJ(unit whichUnit, int itemSlot) {//function UnitItemInSlotBJ takes unit whichUnit, integer itemSlot returns item
			return UnitItemInSlot(whichUnit, itemSlot-1);//return UnitItemInSlot(whichUnit, itemSlot-1)
		}//endfunction
		//
		//
		//
		private int GetInventoryIndexOfItemTypeBJ(unit whichUnit, int itemId) {//function GetInventoryIndexOfItemTypeBJ takes unit whichUnit, integer itemId returns integer
			int index;//local integer index
			item indexItem;//local item    indexItem
			index = 0;//set index = 0
			while (true) {//loop
				indexItem = UnitItemInSlot(whichUnit, index);//set indexItem = UnitItemInSlot(whichUnit, index)
				if ((indexItem != null) && (GetItemTypeId(indexItem) == itemId)) {//if (indexItem != null) and (GetItemTypeId(indexItem) == itemId) then
					return index + 1;//return index + 1
				}//endif
				index = index + 1;//set index = index + 1
				if (index >= bj_MAX_INVENTORY) { break; }//exitwhen index >= bj_MAX_INVENTORY
			}//endloop
			return 0;//return 0
		}//endfunction
		//
		private item GetItemOfTypeFromUnitBJ(unit whichUnit, int itemId) {//function GetItemOfTypeFromUnitBJ takes unit whichUnit, integer itemId returns item
			int index = GetInventoryIndexOfItemTypeBJ(whichUnit, itemId);//local integer index = GetInventoryIndexOfItemTypeBJ(whichUnit, itemId)
			if ((index == 0)) {//if (index == 0) then
				return null;//return null
			} else {//else
				return UnitItemInSlot(whichUnit, index - 1);//return UnitItemInSlot(whichUnit, index - 1)
			}//endif
		}//endfunction
		//
		private bool UnitHasItemOfTypeBJ(unit whichUnit, int itemId) {//function UnitHasItemOfTypeBJ takes unit whichUnit, integer itemId returns boolean
			return GetInventoryIndexOfItemTypeBJ(whichUnit, itemId) > 0;//return GetInventoryIndexOfItemTypeBJ(whichUnit, itemId) > 0
		}//endfunction
		//
		private int UnitInventoryCount(unit whichUnit) {//function UnitInventoryCount takes unit whichUnit returns integer
			int index = 0;//local integer index = 0
			int count = 0;//local integer count = 0
			while (true) {//loop
				if ((UnitItemInSlot(whichUnit, index) != null)) {//if (UnitItemInSlot(whichUnit, index) != null) then
					count = count + 1;//set count = count + 1
				}//endif
				index = index + 1;//set index = index + 1
				if (index >= bj_MAX_INVENTORY) { break; }//exitwhen index >= bj_MAX_INVENTORY
			}//endloop
			return count;//return count
		}//endfunction
		//
		private int UnitInventorySizeBJ(unit whichUnit) {//function UnitInventorySizeBJ takes unit whichUnit returns integer
			return UnitInventorySize(whichUnit);//return UnitInventorySize(whichUnit)
		}//endfunction
		//
		private void SetItemInvulnerableBJ(item whichItem, bool flag) {//function SetItemInvulnerableBJ takes item whichItem, boolean flag returns nothing
			SetItemInvulnerable(whichItem, flag);//call SetItemInvulnerable(whichItem, flag)
		}//endfunction
		//
		private void SetItemDropOnDeathBJ(item whichItem, bool flag) {//function SetItemDropOnDeathBJ takes item whichItem, boolean flag returns nothing
			SetItemDropOnDeath(whichItem, flag);//call SetItemDropOnDeath(whichItem, flag)
		}//endfunction
		//
		private void SetItemDroppableBJ(item whichItem, bool flag) {//function SetItemDroppableBJ takes item whichItem, boolean flag returns nothing
			SetItemDroppable(whichItem, flag);//call SetItemDroppable(whichItem, flag)
		}//endfunction
		//
		private void SetItemPlayerBJ(item whichItem, player whichPlayer, bool changeColor) {//function SetItemPlayerBJ takes item whichItem, player whichPlayer, boolean changeColor returns nothing
			SetItemPlayer(whichItem, whichPlayer, changeColor);//call SetItemPlayer(whichItem, whichPlayer, changeColor)
		}//endfunction
		//
		private void SetItemVisibleBJ(bool show, item whichItem) {//function SetItemVisibleBJ takes boolean show, item whichItem returns nothing
			SetItemVisible(whichItem, show);//call SetItemVisible(whichItem, show)
		}//endfunction
		//
		private bool IsItemHiddenBJ(item whichItem) {//function IsItemHiddenBJ takes item whichItem returns boolean
			return !IsItemVisible(whichItem);//return not IsItemVisible(whichItem)
		}//endfunction
		//
		private int ChooseRandomItemBJ(int level) {//function ChooseRandomItemBJ takes integer level returns integer
			return ChooseRandomItem(level);//return ChooseRandomItem(level)
		}//endfunction
		//
		private int ChooseRandomItemExBJ(int level, itemtype whichType) {//function ChooseRandomItemExBJ takes integer level, itemtype whichType returns integer
			return ChooseRandomItemEx(whichType, level);//return ChooseRandomItemEx(whichType, level)
		}//endfunction
		//
		private int ChooseRandomNPBuildingBJ() {//function ChooseRandomNPBuildingBJ takes nothing returns integer
			return ChooseRandomNPBuilding();//return ChooseRandomNPBuilding()
		}//endfunction
		//
		private int ChooseRandomCreepBJ(int level) {//function ChooseRandomCreepBJ takes integer level returns integer
			return ChooseRandomCreep(level);//return ChooseRandomCreep(level)
		}//endfunction
		//
		private void EnumItemsInRectBJ(rect r, code actionFunc) {//function EnumItemsInRectBJ takes rect r, code actionFunc returns nothing
			EnumItemsInRect(r, null, actionFunc);//call EnumItemsInRect(r, null, actionFunc)
		}//endfunction
		//
		//
		//
		private void RandomItemInRectBJEnum() {//function RandomItemInRectBJEnum takes nothing returns nothing
			bj_itemRandomConsidered = bj_itemRandomConsidered + 1;//set bj_itemRandomConsidered = bj_itemRandomConsidered + 1
			if ((GetRandomInt(1, bj_itemRandomConsidered) == 1)) {//if (GetRandomInt(1, bj_itemRandomConsidered) == 1) then
				bj_itemRandomCurrentPick = GetEnumItem();//set bj_itemRandomCurrentPick = GetEnumItem()
			}//endif
		}//endfunction
		//
		//
		//
		private item RandomItemInRectBJ(rect r, boolexpr filter) {//function RandomItemInRectBJ takes rect r, boolexpr filter returns item
			bj_itemRandomConsidered = 0;//set bj_itemRandomConsidered = 0
			bj_itemRandomCurrentPick = null;//set bj_itemRandomCurrentPick = null
			EnumItemsInRect(r, filter, function RandomItemInRectBJEnum);//call EnumItemsInRect(r, filter, function RandomItemInRectBJEnum)
			DestroyBoolExpr(filter);//call DestroyBoolExpr(filter)
			return bj_itemRandomCurrentPick;//return bj_itemRandomCurrentPick
		}//endfunction
		//
		//
		//
		private item RandomItemInRectSimpleBJ(rect r) {//function RandomItemInRectSimpleBJ takes rect r returns item
			return RandomItemInRectBJ(r, null);//return RandomItemInRectBJ(r, null)
		}//endfunction
		//
		private bool CheckItemStatus(item whichItem, int status) {//function CheckItemStatus takes item whichItem, integer status returns boolean
			if ((status == bj_ITEM_STATUS_HIDDEN)) {//if (status == bj_ITEM_STATUS_HIDDEN) then
				return !IsItemVisible(whichItem);//return not IsItemVisible(whichItem)
			} else if ((status == bj_ITEM_STATUS_OWNED)) {//elseif (status == bj_ITEM_STATUS_OWNED) then
				return IsItemOwned(whichItem);//return IsItemOwned(whichItem)
			} else if ((status == bj_ITEM_STATUS_INVULNERABLE)) {//elseif (status == bj_ITEM_STATUS_INVULNERABLE) then
				return IsItemInvulnerable(whichItem);//return IsItemInvulnerable(whichItem)
			} else if ((status == bj_ITEM_STATUS_POWERUP)) {//elseif (status == bj_ITEM_STATUS_POWERUP) then
				return IsItemPowerup(whichItem);//return IsItemPowerup(whichItem)
			} else if ((status == bj_ITEM_STATUS_SELLABLE)) {//elseif (status == bj_ITEM_STATUS_SELLABLE) then
				return IsItemSellable(whichItem);//return IsItemSellable(whichItem)
			} else if ((status == bj_ITEM_STATUS_PAWNABLE)) {//elseif (status == bj_ITEM_STATUS_PAWNABLE) then
				return IsItemPawnable(whichItem);//return IsItemPawnable(whichItem)
			} else {//else
				//
				return false;//return false
			}//endif
		}//endfunction
		//
		private bool CheckItemcodeStatus(int itemId, int status) {//function CheckItemcodeStatus takes integer itemId, integer status returns boolean
			if ((status == bj_ITEMCODE_STATUS_POWERUP)) {//if (status == bj_ITEMCODE_STATUS_POWERUP) then
				return IsItemIdPowerup(itemId);//return IsItemIdPowerup(itemId)
			} else if ((status == bj_ITEMCODE_STATUS_SELLABLE)) {//elseif (status == bj_ITEMCODE_STATUS_SELLABLE) then
				return IsItemIdSellable(itemId);//return IsItemIdSellable(itemId)
			} else if ((status == bj_ITEMCODE_STATUS_PAWNABLE)) {//elseif (status == bj_ITEMCODE_STATUS_PAWNABLE) then
				return IsItemIdPawnable(itemId);//return IsItemIdPawnable(itemId)
			} else {//else
				//
				return false;//return false
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private int UnitId2OrderIdBJ(int unitId) {//function UnitId2OrderIdBJ takes integer unitId returns integer
			return unitId;//return unitId
		}//endfunction
		//
		private int String2UnitIdBJ(string unitIdString) {//function String2UnitIdBJ takes string unitIdString returns integer
			return UnitId(unitIdString);//return UnitId(unitIdString)
		}//endfunction
		//
		private string UnitId2StringBJ(int unitId) {//function UnitId2StringBJ takes integer unitId returns string
			string unitString = UnitId2String(unitId);//local string unitString = UnitId2String(unitId)
			if ((unitString != null)) {//if (unitString != null) then
				return unitString;//return unitString
			}//endif
			//
			return "";//return ""
		}//endfunction
		//
		private int String2OrderIdBJ(string orderIdString) {//function String2OrderIdBJ takes string orderIdString returns integer
			int orderId;//local integer orderId
			//
			orderId = OrderId(orderIdString);//set orderId = OrderId(orderIdString)
			if ((orderId != 0)) {//if (orderId != 0) then
				return orderId;//return orderId
			}//endif
			//
			orderId = UnitId(orderIdString);//set orderId = UnitId(orderIdString)
			if ((orderId != 0)) {//if (orderId != 0) then
				return orderId;//return orderId
			}//endif
			//
			return 0;//return 0
		}//endfunction
		//
		private string OrderId2StringBJ(int orderId) {//function OrderId2StringBJ takes integer orderId returns string
			string orderString;//local string orderString
			//
			orderString = OrderId2String(orderId);//set orderString = OrderId2String(orderId)
			if ((orderString != null)) {//if (orderString != null) then
				return orderString;//return orderString
			}//endif
			//
			orderString = UnitId2String(orderId);//set orderString = UnitId2String(orderId)
			if ((orderString != null)) {//if (orderString != null) then
				return orderString;//return orderString
			}//endif
			//
			return "";//return ""
		}//endfunction
		//
		private int GetIssuedOrderIdBJ() {//function GetIssuedOrderIdBJ takes nothing returns integer
			return GetIssuedOrderId();//return GetIssuedOrderId()
		}//endfunction
		//
		private unit GetKillingUnitBJ() {//function GetKillingUnitBJ takes nothing returns unit
			return GetKillingUnit();//return GetKillingUnit()
		}//endfunction
		//
		private unit CreateUnitAtLocSaveLast(player id, int unitid, location loc, float face) {//function CreateUnitAtLocSaveLast takes player id, integer unitid, location loc, real face returns unit
			if ((unitid == 'ugol')) {//if (unitid == 'ugol') then
				bj_lastCreatedUnit = CreateBlightedGoldmine(id, GetLocationX(loc), GetLocationY(loc), face);//set bj_lastCreatedUnit = CreateBlightedGoldmine(id, GetLocationX(loc), GetLocationY(loc), face)
			} else {//else
				bj_lastCreatedUnit = CreateUnitAtLoc(id, unitid, loc, face);//set bj_lastCreatedUnit = CreateUnitAtLoc(id, unitid, loc, face)
			}//endif
			return bj_lastCreatedUnit;//return bj_lastCreatedUnit
		}//endfunction
		//
		private unit GetLastCreatedUnit() {//function GetLastCreatedUnit takes nothing returns unit
			return bj_lastCreatedUnit;//return bj_lastCreatedUnit
		}//endfunction
		//
		private group CreateNUnitsAtLoc(int count, int unitId, player whichPlayer, location loc, float face) {//function CreateNUnitsAtLoc takes integer count, integer unitId, player whichPlayer, location loc, real face returns group
			GroupClear(bj_lastCreatedGroup);//call GroupClear(bj_lastCreatedGroup)
			while (true) {//loop
				count = count - 1;//set count = count - 1
				if (count < 0) { break; }//exitwhen count < 0
				CreateUnitAtLocSaveLast(whichPlayer, unitId, loc, face);//call CreateUnitAtLocSaveLast(whichPlayer, unitId, loc, face)
				GroupAddUnit(bj_lastCreatedGroup, bj_lastCreatedUnit);//call GroupAddUnit(bj_lastCreatedGroup, bj_lastCreatedUnit)
			}//endloop
			return bj_lastCreatedGroup;//return bj_lastCreatedGroup
		}//endfunction
		//
		private group CreateNUnitsAtLocFacingLocBJ(int count, int unitId, player whichPlayer, location loc, location lookAt) {//function CreateNUnitsAtLocFacingLocBJ takes integer count, integer unitId, player whichPlayer, location loc, location lookAt returns group
			return CreateNUnitsAtLoc(count, unitId, whichPlayer, loc, AngleBetweenPoints(loc, lookAt));//return CreateNUnitsAtLoc(count, unitId, whichPlayer, loc, AngleBetweenPoints(loc, lookAt))
		}//endfunction
		//
		private void GetLastCreatedGroupEnum() {//function GetLastCreatedGroupEnum takes nothing returns nothing
			GroupAddUnit(bj_groupLastCreatedDest, GetEnumUnit());//call GroupAddUnit(bj_groupLastCreatedDest, GetEnumUnit())
		}//endfunction
		//
		private group GetLastCreatedGroup() {//function GetLastCreatedGroup takes nothing returns group
			bj_groupLastCreatedDest = CreateGroup();//set bj_groupLastCreatedDest = CreateGroup()
			ForGroup(bj_lastCreatedGroup, function GetLastCreatedGroupEnum);//call ForGroup(bj_lastCreatedGroup, function GetLastCreatedGroupEnum)
			return bj_groupLastCreatedDest;//return bj_groupLastCreatedDest
		}//endfunction
		//
		private unit CreateCorpseLocBJ(int unitid, player whichPlayer, location loc) {//function CreateCorpseLocBJ takes integer unitid, player whichPlayer, location loc returns unit
			bj_lastCreatedUnit = CreateCorpse(whichPlayer, unitid, GetLocationX(loc), GetLocationY(loc), GetRandomReal(0, 360));//set bj_lastCreatedUnit = CreateCorpse(whichPlayer, unitid, GetLocationX(loc), GetLocationY(loc), GetRandomReal(0, 360))
			return bj_lastCreatedUnit;//return bj_lastCreatedUnit
		}//endfunction
		//
		private void UnitSuspendDecayBJ(bool suspend, unit whichUnit) {//function UnitSuspendDecayBJ takes boolean suspend, unit whichUnit returns nothing
			UnitSuspendDecay(whichUnit, suspend);//call UnitSuspendDecay(whichUnit, suspend)
		}//endfunction
		//
		private void DelayedSuspendDecayStopAnimEnum() {//function DelayedSuspendDecayStopAnimEnum takes nothing returns nothing
			unit enumUnit = GetEnumUnit();//local unit enumUnit = GetEnumUnit()
			if ((GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0)) {//if (GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0) then
				SetUnitTimeScale(enumUnit, 0.0001);//call SetUnitTimeScale(enumUnit, 0.0001)
			}//endif
		}//endfunction
		//
		private void DelayedSuspendDecayBoneEnum() {//function DelayedSuspendDecayBoneEnum takes nothing returns nothing
			unit enumUnit = GetEnumUnit();//local unit enumUnit = GetEnumUnit()
			if ((GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0)) {//if (GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0) then
				UnitSuspendDecay(enumUnit, true);//call UnitSuspendDecay(enumUnit, true)
				SetUnitTimeScale(enumUnit, 0.0001);//call SetUnitTimeScale(enumUnit, 0.0001)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		private void DelayedSuspendDecayFleshEnum() {//function DelayedSuspendDecayFleshEnum takes nothing returns nothing
			unit enumUnit = GetEnumUnit();//local unit enumUnit = GetEnumUnit()
			if ((GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0)) {//if (GetUnitState(enumUnit, UNIT_STATE_LIFE) <= 0) then
				UnitSuspendDecay(enumUnit, true);//call UnitSuspendDecay(enumUnit, true)
				SetUnitTimeScale(enumUnit, 10.0);//call SetUnitTimeScale(enumUnit, 10.0)
				SetUnitAnimation(enumUnit, "decay flesh");//call SetUnitAnimation(enumUnit, "decay flesh")
			}//endif
		}//endfunction
		//
		//
		//
		//
		private void DelayedSuspendDecay() {//function DelayedSuspendDecay takes nothing returns nothing
			group boneGroup;//local group boneGroup
			group fleshGroup;//local group fleshGroup
			//
			//
			//
			boneGroup = bj_suspendDecayBoneGroup;//set boneGroup = bj_suspendDecayBoneGroup
			fleshGroup = bj_suspendDecayFleshGroup;//set fleshGroup = bj_suspendDecayFleshGroup
			bj_suspendDecayBoneGroup = CreateGroup();//set bj_suspendDecayBoneGroup = CreateGroup()
			bj_suspendDecayFleshGroup = CreateGroup();//set bj_suspendDecayFleshGroup = CreateGroup()
			ForGroup(fleshGroup, function DelayedSuspendDecayStopAnimEnum);//call ForGroup(fleshGroup, function DelayedSuspendDecayStopAnimEnum)
			ForGroup(boneGroup, function DelayedSuspendDecayStopAnimEnum);//call ForGroup(boneGroup, function DelayedSuspendDecayStopAnimEnum)
			TriggerSleepAction(bj_CORPSE_MAX_DEATH_TIME);//call TriggerSleepAction(bj_CORPSE_MAX_DEATH_TIME)
			ForGroup(fleshGroup, function DelayedSuspendDecayFleshEnum);//call ForGroup(fleshGroup, function DelayedSuspendDecayFleshEnum)
			ForGroup(boneGroup, function DelayedSuspendDecayBoneEnum);//call ForGroup(boneGroup, function DelayedSuspendDecayBoneEnum)
			TriggerSleepAction(0.05);//call TriggerSleepAction(0.05)
			ForGroup(fleshGroup, function DelayedSuspendDecayStopAnimEnum);//call ForGroup(fleshGroup, function DelayedSuspendDecayStopAnimEnum)
			DestroyGroup(boneGroup);//call DestroyGroup(boneGroup)
			DestroyGroup(fleshGroup);//call DestroyGroup(fleshGroup)
		}//endfunction
		//
		private void DelayedSuspendDecayCreate() {//function DelayedSuspendDecayCreate takes nothing returns nothing
			bj_delayedSuspendDecayTrig = CreateTrigger();//set bj_delayedSuspendDecayTrig = CreateTrigger()
			TriggerRegisterTimerExpireEvent(bj_delayedSuspendDecayTrig, bj_delayedSuspendDecayTimer);//call TriggerRegisterTimerExpireEvent(bj_delayedSuspendDecayTrig, bj_delayedSuspendDecayTimer)
			TriggerAddAction(bj_delayedSuspendDecayTrig, function DelayedSuspendDecay);//call TriggerAddAction(bj_delayedSuspendDecayTrig, function DelayedSuspendDecay)
		}//endfunction
		//
		private unit CreatePermanentCorpseLocBJ(int style, int unitid, player whichPlayer, location loc, float facing) {//function CreatePermanentCorpseLocBJ takes integer style, integer unitid, player whichPlayer, location loc, real facing returns unit
			bj_lastCreatedUnit = CreateCorpse(whichPlayer, unitid, GetLocationX(loc), GetLocationY(loc), facing);//set bj_lastCreatedUnit = CreateCorpse(whichPlayer, unitid, GetLocationX(loc), GetLocationY(loc), facing)
			SetUnitBlendTime(bj_lastCreatedUnit, 0);//call SetUnitBlendTime(bj_lastCreatedUnit, 0)
			if ((style == bj_CORPSETYPE_FLESH)) {//if (style == bj_CORPSETYPE_FLESH) then
				SetUnitAnimation(bj_lastCreatedUnit, "decay flesh");//call SetUnitAnimation(bj_lastCreatedUnit, "decay flesh")
				GroupAddUnit(bj_suspendDecayFleshGroup, bj_lastCreatedUnit);//call GroupAddUnit(bj_suspendDecayFleshGroup, bj_lastCreatedUnit)
			} else if ((style == bj_CORPSETYPE_BONE)) {//elseif (style == bj_CORPSETYPE_BONE) then
				SetUnitAnimation(bj_lastCreatedUnit, "decay bone");//call SetUnitAnimation(bj_lastCreatedUnit, "decay bone")
				GroupAddUnit(bj_suspendDecayBoneGroup, bj_lastCreatedUnit);//call GroupAddUnit(bj_suspendDecayBoneGroup, bj_lastCreatedUnit)
			} else {//else
				//
				SetUnitAnimation(bj_lastCreatedUnit, "decay bone");//call SetUnitAnimation(bj_lastCreatedUnit, "decay bone")
				GroupAddUnit(bj_suspendDecayBoneGroup, bj_lastCreatedUnit);//call GroupAddUnit(bj_suspendDecayBoneGroup, bj_lastCreatedUnit)
			}//endif
			TimerStart(bj_delayedSuspendDecayTimer, 0.05, false, null);//call TimerStart(bj_delayedSuspendDecayTimer, 0.05, false, null)
			return bj_lastCreatedUnit;//return bj_lastCreatedUnit
		}//endfunction
		//
		private float GetUnitStateSwap(unitstate whichState, unit whichUnit) {//function GetUnitStateSwap takes unitstate whichState, unit whichUnit returns real
			return GetUnitState(whichUnit, whichState);//return GetUnitState(whichUnit, whichState)
		}//endfunction
		//
		private float GetUnitStatePercent(unit whichUnit, unitstate whichState, unitstate whichMaxState) {//function GetUnitStatePercent takes unit whichUnit, unitstate whichState, unitstate whichMaxState returns real
			float value = GetUnitState(whichUnit, whichState);//local real value    = GetUnitState(whichUnit, whichState)
			float maxValue = GetUnitState(whichUnit, whichMaxState);//local real maxValue = GetUnitState(whichUnit, whichMaxState)
			//
			if ((whichUnit == null) || (maxValue == 0)) {//if (whichUnit == null) or (maxValue == 0) then
				return 0.0;//return 0.0
			}//endif
			return value / maxValue * 100.0;//return value / maxValue * 100.0
		}//endfunction
		//
		private float GetUnitLifePercent(unit whichUnit) {//function GetUnitLifePercent takes unit whichUnit returns real
			return GetUnitStatePercent(whichUnit, UNIT_STATE_LIFE, UNIT_STATE_MAX_LIFE);//return GetUnitStatePercent(whichUnit, UNIT_STATE_LIFE, UNIT_STATE_MAX_LIFE)
		}//endfunction
		//
		private float GetUnitManaPercent(unit whichUnit) {//function GetUnitManaPercent takes unit whichUnit returns real
			return GetUnitStatePercent(whichUnit, UNIT_STATE_MANA, UNIT_STATE_MAX_MANA);//return GetUnitStatePercent(whichUnit, UNIT_STATE_MANA, UNIT_STATE_MAX_MANA)
		}//endfunction
		//
		private void SelectUnitSingle(unit whichUnit) {//function SelectUnitSingle takes unit whichUnit returns nothing
			ClearSelection();//call ClearSelection()
			SelectUnit(whichUnit, true);//call SelectUnit(whichUnit, true)
		}//endfunction
		//
		private void SelectGroupBJEnum() {//function SelectGroupBJEnum takes nothing returns nothing
			SelectUnit(GetEnumUnit(), true);//call SelectUnit( GetEnumUnit(), true )
		}//endfunction
		//
		private void SelectGroupBJ(group g) {//function SelectGroupBJ takes group g returns nothing
			ClearSelection();//call ClearSelection()
			ForGroup(g, function SelectGroupBJEnum);//call ForGroup( g, function SelectGroupBJEnum )
		}//endfunction
		//
		private void SelectUnitAdd(unit whichUnit) {//function SelectUnitAdd takes unit whichUnit returns nothing
			SelectUnit(whichUnit, true);//call SelectUnit(whichUnit, true)
		}//endfunction
		//
		private void SelectUnitRemove(unit whichUnit) {//function SelectUnitRemove takes unit whichUnit returns nothing
			SelectUnit(whichUnit, false);//call SelectUnit(whichUnit, false)
		}//endfunction
		//
		private void ClearSelectionForPlayer(player whichPlayer) {//function ClearSelectionForPlayer takes player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				ClearSelection();//call ClearSelection()
			}//endif
		}//endfunction
		//
		private void SelectUnitForPlayerSingle(unit whichUnit, player whichPlayer) {//function SelectUnitForPlayerSingle takes unit whichUnit, player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				ClearSelection();//call ClearSelection()
				SelectUnit(whichUnit, true);//call SelectUnit(whichUnit, true)
			}//endif
		}//endfunction
		//
		private void SelectGroupForPlayerBJ(group g, player whichPlayer) {//function SelectGroupForPlayerBJ takes group g, player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				ClearSelection();//call ClearSelection()
				ForGroup(g, function SelectGroupBJEnum);//call ForGroup( g, function SelectGroupBJEnum )
			}//endif
		}//endfunction
		//
		private void SelectUnitAddForPlayer(unit whichUnit, player whichPlayer) {//function SelectUnitAddForPlayer takes unit whichUnit, player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SelectUnit(whichUnit, true);//call SelectUnit(whichUnit, true)
			}//endif
		}//endfunction
		//
		private void SelectUnitRemoveForPlayer(unit whichUnit, player whichPlayer) {//function SelectUnitRemoveForPlayer takes unit whichUnit, player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				SelectUnit(whichUnit, false);//call SelectUnit(whichUnit, false)
			}//endif
		}//endfunction
		//
		private void SetUnitLifeBJ(unit whichUnit, float newValue) {//function SetUnitLifeBJ takes unit whichUnit, real newValue returns nothing
			SetUnitState(whichUnit, UNIT_STATE_LIFE, RMaxBJ(0,newValue));//call SetUnitState(whichUnit, UNIT_STATE_LIFE, RMaxBJ(0,newValue))
		}//endfunction
		//
		private void SetUnitManaBJ(unit whichUnit, float newValue) {//function SetUnitManaBJ takes unit whichUnit, real newValue returns nothing
			SetUnitState(whichUnit, UNIT_STATE_MANA, RMaxBJ(0,newValue));//call SetUnitState(whichUnit, UNIT_STATE_MANA, RMaxBJ(0,newValue))
		}//endfunction
		//
		private void SetUnitLifePercentBJ(unit whichUnit, float percent) {//function SetUnitLifePercentBJ takes unit whichUnit, real percent returns nothing
			SetUnitState(whichUnit, UNIT_STATE_LIFE, GetUnitState(whichUnit, UNIT_STATE_MAX_LIFE) * RMaxBJ(0,percent) * 0.01);//call SetUnitState(whichUnit, UNIT_STATE_LIFE, GetUnitState(whichUnit, UNIT_STATE_MAX_LIFE) * RMaxBJ(0,percent) * 0.01)
		}//endfunction
		//
		private void SetUnitManaPercentBJ(unit whichUnit, float percent) {//function SetUnitManaPercentBJ takes unit whichUnit, real percent returns nothing
			SetUnitState(whichUnit, UNIT_STATE_MANA, GetUnitState(whichUnit, UNIT_STATE_MAX_MANA) * RMaxBJ(0,percent) * 0.01);//call SetUnitState(whichUnit, UNIT_STATE_MANA, GetUnitState(whichUnit, UNIT_STATE_MAX_MANA) * RMaxBJ(0,percent) * 0.01)
		}//endfunction
		//
		private bool IsUnitDeadBJ(unit whichUnit) {//function IsUnitDeadBJ takes unit whichUnit returns boolean
			return GetUnitState(whichUnit, UNIT_STATE_LIFE) <= 0;//return GetUnitState(whichUnit, UNIT_STATE_LIFE) <= 0
		}//endfunction
		//
		private bool IsUnitAliveBJ(unit whichUnit) {//function IsUnitAliveBJ takes unit whichUnit returns boolean
			return !IsUnitDeadBJ(whichUnit);//return not IsUnitDeadBJ(whichUnit)
		}//endfunction
		//
		private void IsUnitGroupDeadBJEnum() {//function IsUnitGroupDeadBJEnum takes nothing returns nothing
			if (!IsUnitDeadBJ(GetEnumUnit())) {//if not IsUnitDeadBJ(GetEnumUnit()) then
				bj_isUnitGroupDeadResult = false;//set bj_isUnitGroupDeadResult = false
			}//endif
		}//endfunction
		//
		//
		//
		private bool IsUnitGroupDeadBJ(group g) {//function IsUnitGroupDeadBJ takes group g returns boolean
			//
			//
			bool wantDestroy = bj_wantDestroyGroup;//local boolean wantDestroy = bj_wantDestroyGroup
			bj_wantDestroyGroup = false;//set bj_wantDestroyGroup = false
			bj_isUnitGroupDeadResult = true;//set bj_isUnitGroupDeadResult = true
			ForGroup(g, function IsUnitGroupDeadBJEnum);//call ForGroup(g, function IsUnitGroupDeadBJEnum)
			//
			if ((wantDestroy)) {//if (wantDestroy) then
				DestroyGroup(g);//call DestroyGroup(g)
			}//endif
			return bj_isUnitGroupDeadResult;//return bj_isUnitGroupDeadResult
		}//endfunction
		//
		private void IsUnitGroupEmptyBJEnum() {//function IsUnitGroupEmptyBJEnum takes nothing returns nothing
			bj_isUnitGroupEmptyResult = false;//set bj_isUnitGroupEmptyResult = false
		}//endfunction
		//
		//
		//
		private bool IsUnitGroupEmptyBJ(group g) {//function IsUnitGroupEmptyBJ takes group g returns boolean
			//
			//
			bool wantDestroy = bj_wantDestroyGroup;//local boolean wantDestroy = bj_wantDestroyGroup
			bj_wantDestroyGroup = false;//set bj_wantDestroyGroup = false
			bj_isUnitGroupEmptyResult = true;//set bj_isUnitGroupEmptyResult = true
			ForGroup(g, function IsUnitGroupEmptyBJEnum);//call ForGroup(g, function IsUnitGroupEmptyBJEnum)
			//
			if ((wantDestroy)) {//if (wantDestroy) then
				DestroyGroup(g);//call DestroyGroup(g)
			}//endif
			return bj_isUnitGroupEmptyResult;//return bj_isUnitGroupEmptyResult
		}//endfunction
		//
		private void IsUnitGroupInRectBJEnum() {//function IsUnitGroupInRectBJEnum takes nothing returns nothing
			if (!RectContainsUnit(bj_isUnitGroupInRectRect, GetEnumUnit())) {//if not RectContainsUnit(bj_isUnitGroupInRectRect, GetEnumUnit()) then
				bj_isUnitGroupInRectResult = false;//set bj_isUnitGroupInRectResult = false
			}//endif
		}//endfunction
		//
		//
		//
		private bool IsUnitGroupInRectBJ(group g, rect r) {//function IsUnitGroupInRectBJ takes group g, rect r returns boolean
			bj_isUnitGroupInRectResult = true;//set bj_isUnitGroupInRectResult = true
			bj_isUnitGroupInRectRect = r;//set bj_isUnitGroupInRectRect = r
			ForGroup(g, function IsUnitGroupInRectBJEnum);//call ForGroup(g, function IsUnitGroupInRectBJEnum)
			return bj_isUnitGroupInRectResult;//return bj_isUnitGroupInRectResult
		}//endfunction
		//
		private bool IsUnitHiddenBJ(unit whichUnit) {//function IsUnitHiddenBJ takes unit whichUnit returns boolean
			return IsUnitHidden(whichUnit);//return IsUnitHidden(whichUnit)
		}//endfunction
		//
		private void ShowUnitHide(unit whichUnit) {//function ShowUnitHide takes unit whichUnit returns nothing
			ShowUnit(whichUnit, false);//call ShowUnit(whichUnit, false)
		}//endfunction
		//
		private void ShowUnitShow(unit whichUnit) {//function ShowUnitShow takes unit whichUnit returns nothing
			//
			if ((IsUnitType(whichUnit, UNIT_TYPE_HERO) && IsUnitDeadBJ(whichUnit))) {//if (IsUnitType(whichUnit, UNIT_TYPE_HERO) and IsUnitDeadBJ(whichUnit)) then
				return;//return
			}//endif
			ShowUnit(whichUnit, true);//call ShowUnit(whichUnit, true)
		}//endfunction
		//
		private bool IssueHauntOrderAtLocBJFilter() {//function IssueHauntOrderAtLocBJFilter takes nothing returns boolean
			return GetUnitTypeId(GetFilterUnit()) == 'ngol';//return GetUnitTypeId(GetFilterUnit()) == 'ngol'
		}//endfunction
		//
		private bool IssueHauntOrderAtLocBJ(unit whichPeon, location loc) {//function IssueHauntOrderAtLocBJ takes unit whichPeon, location loc returns boolean
			group g = null;//local group g = null
			unit goldMine = null;//local unit goldMine = null
			//
			g = CreateGroup();//set g = CreateGroup()
			GroupEnumUnitsInRangeOfLoc(g, loc, 2*bj_CELLWIDTH, filterIssueHauntOrderAtLocBJ);//call GroupEnumUnitsInRangeOfLoc(g, loc, 2*bj_CELLWIDTH, filterIssueHauntOrderAtLocBJ)
			goldMine = FirstOfGroup(g);//set goldMine = FirstOfGroup(g)
			DestroyGroup(g);//call DestroyGroup(g)
			//
			if ((goldMine == null)) {//if (goldMine == null) then
				return false;//return false
			}//endif
			//
			return IssueTargetOrderById(whichPeon, 'ugol', goldMine);//return IssueTargetOrderById(whichPeon, 'ugol', goldMine)
		}//endfunction
		//
		private bool IssueBuildOrderByIdLocBJ(unit whichPeon, int unitId, location loc) {//function IssueBuildOrderByIdLocBJ takes unit whichPeon, integer unitId, location loc returns boolean
			if ((unitId == 'ugol')) {//if (unitId == 'ugol') then
				return IssueHauntOrderAtLocBJ(whichPeon, loc);//return IssueHauntOrderAtLocBJ(whichPeon, loc)
			} else {//else
				return IssueBuildOrderById(whichPeon, unitId, GetLocationX(loc), GetLocationY(loc));//return IssueBuildOrderById(whichPeon, unitId, GetLocationX(loc), GetLocationY(loc))
			}//endif
		}//endfunction
		//
		private bool IssueTrainOrderByIdBJ(unit whichUnit, int unitId) {//function IssueTrainOrderByIdBJ takes unit whichUnit, integer unitId returns boolean
			return IssueImmediateOrderById(whichUnit, unitId);//return IssueImmediateOrderById(whichUnit, unitId)
		}//endfunction
		//
		private bool GroupTrainOrderByIdBJ(group g, int unitId) {//function GroupTrainOrderByIdBJ takes group g, integer unitId returns boolean
			return GroupImmediateOrderById(g, unitId);//return GroupImmediateOrderById(g, unitId)
		}//endfunction
		//
		private bool IssueUpgradeOrderByIdBJ(unit whichUnit, int techId) {//function IssueUpgradeOrderByIdBJ takes unit whichUnit, integer techId returns boolean
			return IssueImmediateOrderById(whichUnit, techId);//return IssueImmediateOrderById(whichUnit, techId)
		}//endfunction
		//
		private unit GetAttackedUnitBJ() {//function GetAttackedUnitBJ takes nothing returns unit
			return GetTriggerUnit();//return GetTriggerUnit()
		}//endfunction
		//
		private void SetUnitFlyHeightBJ(unit whichUnit, float newHeight, float rate) {//function SetUnitFlyHeightBJ takes unit whichUnit, real newHeight, real rate returns nothing
			SetUnitFlyHeight(whichUnit, newHeight, rate);//call SetUnitFlyHeight(whichUnit, newHeight, rate)
		}//endfunction
		//
		private void SetUnitTurnSpeedBJ(unit whichUnit, float turnSpeed) {//function SetUnitTurnSpeedBJ takes unit whichUnit, real turnSpeed returns nothing
			SetUnitTurnSpeed(whichUnit, turnSpeed);//call SetUnitTurnSpeed(whichUnit, turnSpeed)
		}//endfunction
		//
		private void SetUnitPropWindowBJ(unit whichUnit, float propWindow) {//function SetUnitPropWindowBJ takes unit whichUnit, real propWindow returns nothing
			float angle = propWindow;//local real angle = propWindow
			if ((angle <= 0)) {//if (angle <= 0) then
				angle = 1;//set angle = 1
			} else if ((angle >= 360)) {//elseif (angle >= 360) then
				angle = 359;//set angle = 359
			}//endif
			angle = angle * bj_DEGTORAD;//set angle = angle * bj_DEGTORAD
			SetUnitPropWindow(whichUnit, angle);//call SetUnitPropWindow(whichUnit, angle)
		}//endfunction
		//
		private float GetUnitPropWindowBJ(unit whichUnit) {//function GetUnitPropWindowBJ takes unit whichUnit returns real
			return GetUnitPropWindow(whichUnit) * bj_RADTODEG;//return GetUnitPropWindow(whichUnit) * bj_RADTODEG
		}//endfunction
		//
		private float GetUnitDefaultPropWindowBJ(unit whichUnit) {//function GetUnitDefaultPropWindowBJ takes unit whichUnit returns real
			return GetUnitDefaultPropWindow(whichUnit);//return GetUnitDefaultPropWindow(whichUnit)
		}//endfunction
		//
		private void SetUnitBlendTimeBJ(unit whichUnit, float blendTime) {//function SetUnitBlendTimeBJ takes unit whichUnit, real blendTime returns nothing
			SetUnitBlendTime(whichUnit, blendTime);//call SetUnitBlendTime(whichUnit, blendTime)
		}//endfunction
		//
		private void SetUnitAcquireRangeBJ(unit whichUnit, float acquireRange) {//function SetUnitAcquireRangeBJ takes unit whichUnit, real acquireRange returns nothing
			SetUnitAcquireRange(whichUnit, acquireRange);//call SetUnitAcquireRange(whichUnit, acquireRange)
		}//endfunction
		//
		private void UnitSetCanSleepBJ(unit whichUnit, bool canSleep) {//function UnitSetCanSleepBJ takes unit whichUnit, boolean canSleep returns nothing
			UnitAddSleep(whichUnit, canSleep);//call UnitAddSleep(whichUnit, canSleep)
		}//endfunction
		//
		private bool UnitCanSleepBJ(unit whichUnit) {//function UnitCanSleepBJ takes unit whichUnit returns boolean
			return UnitCanSleep(whichUnit);//return UnitCanSleep(whichUnit)
		}//endfunction
		//
		private void UnitWakeUpBJ(unit whichUnit) {//function UnitWakeUpBJ takes unit whichUnit returns nothing
			UnitWakeUp(whichUnit);//call UnitWakeUp(whichUnit)
		}//endfunction
		//
		private bool UnitIsSleepingBJ(unit whichUnit) {//function UnitIsSleepingBJ takes unit whichUnit returns boolean
			return UnitIsSleeping(whichUnit);//return UnitIsSleeping(whichUnit)
		}//endfunction
		//
		private void WakePlayerUnitsEnum() {//function WakePlayerUnitsEnum takes nothing returns nothing
			UnitWakeUp(GetEnumUnit());//call UnitWakeUp(GetEnumUnit())
		}//endfunction
		//
		private void WakePlayerUnits(player whichPlayer) {//function WakePlayerUnits takes player whichPlayer returns nothing
			group g = CreateGroup();//local group g = CreateGroup()
			GroupEnumUnitsOfPlayer(g, whichPlayer, null);//call GroupEnumUnitsOfPlayer(g, whichPlayer, null)
			ForGroup(g, function WakePlayerUnitsEnum);//call ForGroup(g, function WakePlayerUnitsEnum)
			DestroyGroup(g);//call DestroyGroup(g)
		}//endfunction
		//
		private void EnableCreepSleepBJ(bool enable) {//function EnableCreepSleepBJ takes boolean enable returns nothing
			SetPlayerState(Player(PLAYER_NEUTRAL_AGGRESSIVE), PLAYER_STATE_NO_CREEP_SLEEP, IntegerTertiaryOp(enable, 0, 1));//call SetPlayerState(Player(PLAYER_NEUTRAL_AGGRESSIVE), PLAYER_STATE_NO_CREEP_SLEEP, IntegerTertiaryOp(enable, 0, 1))
			//
			if ((!enable)) {//if (not enable) then
				WakePlayerUnits(Player(PLAYER_NEUTRAL_AGGRESSIVE));//call WakePlayerUnits(Player(PLAYER_NEUTRAL_AGGRESSIVE))
			}//endif
		}//endfunction
		//
		private bool UnitGenerateAlarms(unit whichUnit, bool generate) {//function UnitGenerateAlarms takes unit whichUnit, boolean generate returns boolean
			return UnitIgnoreAlarm(whichUnit, !generate);//return UnitIgnoreAlarm(whichUnit, not generate)
		}//endfunction
		//
		private bool DoesUnitGenerateAlarms(unit whichUnit) {//function DoesUnitGenerateAlarms takes unit whichUnit returns boolean
			return !UnitIgnoreAlarmToggled(whichUnit);//return not UnitIgnoreAlarmToggled(whichUnit)
		}//endfunction
		//
		private void PauseAllUnitsBJEnum() {//function PauseAllUnitsBJEnum takes nothing returns nothing
			PauseUnit(GetEnumUnit(), bj_pauseAllUnitsFlag);//call PauseUnit( GetEnumUnit(), bj_pauseAllUnitsFlag )
		}//endfunction
		//
		//
		private void PauseAllUnitsBJ(bool pause) {//function PauseAllUnitsBJ takes boolean pause returns nothing
			int index;//local integer index
			player indexPlayer;//local player  indexPlayer
			group g;//local group   g
			bj_pauseAllUnitsFlag = pause;//set bj_pauseAllUnitsFlag = pause
			g = CreateGroup();//set g = CreateGroup()
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player( index );//set indexPlayer = Player( index )
				//
				if ((GetPlayerController( indexPlayer ) == MAP_CONTROL_COMPUTER)) {//if (GetPlayerController( indexPlayer ) == MAP_CONTROL_COMPUTER) then
					PauseCompAI(indexPlayer, pause);//call PauseCompAI( indexPlayer, pause )
				}//endif
				//
				GroupEnumUnitsOfPlayer(g, indexPlayer, null);//call GroupEnumUnitsOfPlayer( g, indexPlayer, null )
				ForGroup(g, function PauseAllUnitsBJEnum);//call ForGroup( g, function PauseAllUnitsBJEnum )
				GroupClear(g);//call GroupClear( g )
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen index == bj_MAX_PLAYER_SLOTS
			}//endloop
			DestroyGroup(g);//call DestroyGroup(g)
		}//endfunction
		//
		private void PauseUnitBJ(bool pause, unit whichUnit) {//function PauseUnitBJ takes boolean pause, unit whichUnit returns nothing
			PauseUnit(whichUnit, pause);//call PauseUnit(whichUnit, pause)
		}//endfunction
		//
		private bool IsUnitPausedBJ(unit whichUnit) {//function IsUnitPausedBJ takes unit whichUnit returns boolean
			return IsUnitPaused(whichUnit);//return IsUnitPaused(whichUnit)
		}//endfunction
		//
		private void UnitPauseTimedLifeBJ(bool flag, unit whichUnit) {//function UnitPauseTimedLifeBJ takes boolean flag, unit whichUnit returns nothing
			UnitPauseTimedLife(whichUnit, flag);//call UnitPauseTimedLife(whichUnit, flag)
		}//endfunction
		//
		private void UnitApplyTimedLifeBJ(float duration, int buffId, unit whichUnit) {//function UnitApplyTimedLifeBJ takes real duration, integer buffId, unit whichUnit returns nothing
			UnitApplyTimedLife(whichUnit, buffId, duration);//call UnitApplyTimedLife(whichUnit, buffId, duration)
		}//endfunction
		//
		private void UnitShareVisionBJ(bool share, unit whichUnit, player whichPlayer) {//function UnitShareVisionBJ takes boolean share, unit whichUnit, player whichPlayer returns nothing
			UnitShareVision(whichUnit, whichPlayer, share);//call UnitShareVision(whichUnit, whichPlayer, share)
		}//endfunction
		//
		private void UnitRemoveBuffsBJ(int buffType, unit whichUnit) {//function UnitRemoveBuffsBJ takes integer buffType, unit whichUnit returns nothing
			if ((buffType == bj_REMOVEBUFFS_POSITIVE)) {//if (buffType == bj_REMOVEBUFFS_POSITIVE) then
				UnitRemoveBuffs(whichUnit, true, false);//call UnitRemoveBuffs(whichUnit, true, false)
			} else if ((buffType == bj_REMOVEBUFFS_NEGATIVE)) {//elseif (buffType == bj_REMOVEBUFFS_NEGATIVE) then
				UnitRemoveBuffs(whichUnit, false, true);//call UnitRemoveBuffs(whichUnit, false, true)
			} else if ((buffType == bj_REMOVEBUFFS_ALL)) {//elseif (buffType == bj_REMOVEBUFFS_ALL) then
				UnitRemoveBuffs(whichUnit, true, true);//call UnitRemoveBuffs(whichUnit, true, true)
			} else if ((buffType == bj_REMOVEBUFFS_NONTLIFE)) {//elseif (buffType == bj_REMOVEBUFFS_NONTLIFE) then
				UnitRemoveBuffsEx(whichUnit, true, true, false, false, false, true, false);//call UnitRemoveBuffsEx(whichUnit, true, true, false, false, false, true, false)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private void UnitRemoveBuffsExBJ(int polarity, int resist, unit whichUnit, bool bTLife, bool bAura) {//function UnitRemoveBuffsExBJ takes integer polarity, integer resist, unit whichUnit, boolean bTLife, boolean bAura returns nothing
			bool bPos = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_POSITIVE);//local boolean bPos   = (polarity == bj_BUFF_POLARITY_EITHER) or (polarity == bj_BUFF_POLARITY_POSITIVE)
			bool bNeg = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_NEGATIVE);//local boolean bNeg   = (polarity == bj_BUFF_POLARITY_EITHER) or (polarity == bj_BUFF_POLARITY_NEGATIVE)
			bool bMagic = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_MAGIC);//local boolean bMagic = (resist == bj_BUFF_RESIST_BOTH) or (resist == bj_BUFF_RESIST_MAGIC)
			bool bPhys = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_PHYSICAL);//local boolean bPhys  = (resist == bj_BUFF_RESIST_BOTH) or (resist == bj_BUFF_RESIST_PHYSICAL)
			UnitRemoveBuffsEx(whichUnit, bPos, bNeg, bMagic, bPhys, bTLife, bAura, false);//call UnitRemoveBuffsEx(whichUnit, bPos, bNeg, bMagic, bPhys, bTLife, bAura, false)
		}//endfunction
		//
		private int UnitCountBuffsExBJ(int polarity, int resist, unit whichUnit, bool bTLife, bool bAura) {//function UnitCountBuffsExBJ takes integer polarity, integer resist, unit whichUnit, boolean bTLife, boolean bAura returns integer
			bool bPos = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_POSITIVE);//local boolean bPos   = (polarity == bj_BUFF_POLARITY_EITHER) or (polarity == bj_BUFF_POLARITY_POSITIVE)
			bool bNeg = (polarity == bj_BUFF_POLARITY_EITHER) || (polarity == bj_BUFF_POLARITY_NEGATIVE);//local boolean bNeg   = (polarity == bj_BUFF_POLARITY_EITHER) or (polarity == bj_BUFF_POLARITY_NEGATIVE)
			bool bMagic = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_MAGIC);//local boolean bMagic = (resist == bj_BUFF_RESIST_BOTH) or (resist == bj_BUFF_RESIST_MAGIC)
			bool bPhys = (resist == bj_BUFF_RESIST_BOTH) || (resist == bj_BUFF_RESIST_PHYSICAL);//local boolean bPhys  = (resist == bj_BUFF_RESIST_BOTH) or (resist == bj_BUFF_RESIST_PHYSICAL)
			return UnitCountBuffsEx(whichUnit, bPos, bNeg, bMagic, bPhys, bTLife, bAura, false);//return UnitCountBuffsEx(whichUnit, bPos, bNeg, bMagic, bPhys, bTLife, bAura, false)
		}//endfunction
		//
		private bool UnitRemoveAbilityBJ(int abilityId, unit whichUnit) {//function UnitRemoveAbilityBJ takes integer abilityId, unit whichUnit returns boolean
			return UnitRemoveAbility(whichUnit, abilityId);//return UnitRemoveAbility(whichUnit, abilityId)
		}//endfunction
		//
		private bool UnitAddAbilityBJ(int abilityId, unit whichUnit) {//function UnitAddAbilityBJ takes integer abilityId, unit whichUnit returns boolean
			return UnitAddAbility(whichUnit, abilityId);//return UnitAddAbility(whichUnit, abilityId)
		}//endfunction
		//
		private bool UnitRemoveTypeBJ(unittype whichType, unit whichUnit) {//function UnitRemoveTypeBJ takes unittype whichType, unit whichUnit returns boolean
			return UnitRemoveType(whichUnit, whichType);//return UnitRemoveType(whichUnit, whichType)
		}//endfunction
		//
		private bool UnitAddTypeBJ(unittype whichType, unit whichUnit) {//function UnitAddTypeBJ takes unittype whichType, unit whichUnit returns boolean
			return UnitAddType(whichUnit, whichType);//return UnitAddType(whichUnit, whichType)
		}//endfunction
		//
		private bool UnitMakeAbilityPermanentBJ(bool permanent, int abilityId, unit whichUnit) {//function UnitMakeAbilityPermanentBJ takes boolean permanent, integer abilityId, unit whichUnit returns boolean
			return UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);//return UnitMakeAbilityPermanent(whichUnit, permanent, abilityId)
		}//endfunction
		//
		private void SetUnitExplodedBJ(unit whichUnit, bool exploded) {//function SetUnitExplodedBJ takes unit whichUnit, boolean exploded returns nothing
			SetUnitExploded(whichUnit, exploded);//call SetUnitExploded(whichUnit, exploded)
		}//endfunction
		//
		private void ExplodeUnitBJ(unit whichUnit) {//function ExplodeUnitBJ takes unit whichUnit returns nothing
			SetUnitExploded(whichUnit, true);//call SetUnitExploded(whichUnit, true)
			KillUnit(whichUnit);//call KillUnit(whichUnit)
		}//endfunction
		//
		private unit GetTransportUnitBJ() {//function GetTransportUnitBJ takes nothing returns unit
			return GetTransportUnit();//return GetTransportUnit()
		}//endfunction
		//
		private unit GetLoadedUnitBJ() {//function GetLoadedUnitBJ takes nothing returns unit
			return GetLoadedUnit();//return GetLoadedUnit()
		}//endfunction
		//
		private bool IsUnitInTransportBJ(unit whichUnit, unit whichTransport) {//function IsUnitInTransportBJ takes unit whichUnit, unit whichTransport returns boolean
			return IsUnitInTransport(whichUnit, whichTransport);//return IsUnitInTransport(whichUnit, whichTransport)
		}//endfunction
		//
		private bool IsUnitLoadedBJ(unit whichUnit) {//function IsUnitLoadedBJ takes unit whichUnit returns boolean
			return IsUnitLoaded(whichUnit);//return IsUnitLoaded(whichUnit)
		}//endfunction
		//
		private bool IsUnitIllusionBJ(unit whichUnit) {//function IsUnitIllusionBJ takes unit whichUnit returns boolean
			return IsUnitIllusion(whichUnit);//return IsUnitIllusion(whichUnit)
		}//endfunction
		//
		//
		//
		//
		private unit ReplaceUnitBJ(unit whichUnit, int newUnitId, int unitStateMethod) {//function ReplaceUnitBJ takes unit whichUnit, integer newUnitId, integer unitStateMethod returns unit
			unit oldUnit = whichUnit;//local unit    oldUnit = whichUnit
			unit newUnit;//local unit    newUnit
			bool wasHidden;//local boolean wasHidden
			int index;//local integer index
			item indexItem;//local item    indexItem
			float oldRatio;//local real    oldRatio
			//
			if ((oldUnit == null)) {//if (oldUnit == null) then
				bj_lastReplacedUnit = oldUnit;//set bj_lastReplacedUnit = oldUnit
				return oldUnit;//return oldUnit
			}//endif
			//
			wasHidden = IsUnitHidden(oldUnit);//set wasHidden = IsUnitHidden(oldUnit)
			ShowUnit(oldUnit, false);//call ShowUnit(oldUnit, false)
			//
			if ((newUnitId == 'ugol')) {//if (newUnitId == 'ugol') then
				newUnit = CreateBlightedGoldmine(GetOwningPlayer(oldUnit), GetUnitX(oldUnit), GetUnitY(oldUnit), GetUnitFacing(oldUnit));//set newUnit = CreateBlightedGoldmine(GetOwningPlayer(oldUnit), GetUnitX(oldUnit), GetUnitY(oldUnit), GetUnitFacing(oldUnit))
			} else {//else
				newUnit = CreateUnit(GetOwningPlayer(oldUnit), newUnitId, GetUnitX(oldUnit), GetUnitY(oldUnit), GetUnitFacing(oldUnit));//set newUnit = CreateUnit(GetOwningPlayer(oldUnit), newUnitId, GetUnitX(oldUnit), GetUnitY(oldUnit), GetUnitFacing(oldUnit))
			}//endif
			//
			if ((unitStateMethod == bj_UNIT_STATE_METHOD_RELATIVE)) {//if (unitStateMethod == bj_UNIT_STATE_METHOD_RELATIVE) then
				//
				//
				if ((GetUnitState(oldUnit, UNIT_STATE_MAX_LIFE) > 0)) {//if (GetUnitState(oldUnit, UNIT_STATE_MAX_LIFE) > 0) then
					oldRatio = GetUnitState(oldUnit, UNIT_STATE_LIFE) / GetUnitState(oldUnit, UNIT_STATE_MAX_LIFE);//set oldRatio = GetUnitState(oldUnit, UNIT_STATE_LIFE) / GetUnitState(oldUnit, UNIT_STATE_MAX_LIFE)
					SetUnitState(newUnit, UNIT_STATE_LIFE, oldRatio * GetUnitState(newUnit, UNIT_STATE_MAX_LIFE));//call SetUnitState(newUnit, UNIT_STATE_LIFE, oldRatio * GetUnitState(newUnit, UNIT_STATE_MAX_LIFE))
				}//endif
				if ((GetUnitState(oldUnit, UNIT_STATE_MAX_MANA) > 0) && (GetUnitState(newUnit, UNIT_STATE_MAX_MANA) > 0)) {//if (GetUnitState(oldUnit, UNIT_STATE_MAX_MANA) > 0) and (GetUnitState(newUnit, UNIT_STATE_MAX_MANA) > 0) then
					oldRatio = GetUnitState(oldUnit, UNIT_STATE_MANA) / GetUnitState(oldUnit, UNIT_STATE_MAX_MANA);//set oldRatio = GetUnitState(oldUnit, UNIT_STATE_MANA) / GetUnitState(oldUnit, UNIT_STATE_MAX_MANA)
					SetUnitState(newUnit, UNIT_STATE_MANA, oldRatio * GetUnitState(newUnit, UNIT_STATE_MAX_MANA));//call SetUnitState(newUnit, UNIT_STATE_MANA, oldRatio * GetUnitState(newUnit, UNIT_STATE_MAX_MANA))
				}//endif
			} else if ((unitStateMethod == bj_UNIT_STATE_METHOD_ABSOLUTE)) {//elseif (unitStateMethod == bj_UNIT_STATE_METHOD_ABSOLUTE) then
				//
				//
				SetUnitState(newUnit, UNIT_STATE_LIFE, GetUnitState(oldUnit, UNIT_STATE_LIFE));//call SetUnitState(newUnit, UNIT_STATE_LIFE, GetUnitState(oldUnit, UNIT_STATE_LIFE))
				if ((GetUnitState(newUnit, UNIT_STATE_MAX_MANA) > 0)) {//if (GetUnitState(newUnit, UNIT_STATE_MAX_MANA) > 0) then
					SetUnitState(newUnit, UNIT_STATE_MANA, GetUnitState(oldUnit, UNIT_STATE_MANA));//call SetUnitState(newUnit, UNIT_STATE_MANA, GetUnitState(oldUnit, UNIT_STATE_MANA))
				}//endif
			} else if ((unitStateMethod == bj_UNIT_STATE_METHOD_DEFAULTS)) {//elseif (unitStateMethod == bj_UNIT_STATE_METHOD_DEFAULTS) then
				//
			} else if ((unitStateMethod == bj_UNIT_STATE_METHOD_MAXIMUM)) {//elseif (unitStateMethod == bj_UNIT_STATE_METHOD_MAXIMUM) then
				//
				SetUnitState(newUnit, UNIT_STATE_LIFE, GetUnitState(newUnit, UNIT_STATE_MAX_LIFE));//call SetUnitState(newUnit, UNIT_STATE_LIFE, GetUnitState(newUnit, UNIT_STATE_MAX_LIFE))
				SetUnitState(newUnit, UNIT_STATE_MANA, GetUnitState(newUnit, UNIT_STATE_MAX_MANA));//call SetUnitState(newUnit, UNIT_STATE_MANA, GetUnitState(newUnit, UNIT_STATE_MAX_MANA))
			} else {//else
				//
			}//endif
			//
			//
			SetResourceAmount(newUnit, GetResourceAmount(oldUnit));//call SetResourceAmount(newUnit, GetResourceAmount(oldUnit))
			//
			if ((IsUnitType(oldUnit, UNIT_TYPE_HERO) && IsUnitType(newUnit, UNIT_TYPE_HERO))) {//if (IsUnitType(oldUnit, UNIT_TYPE_HERO) and IsUnitType(newUnit, UNIT_TYPE_HERO)) then
				SetHeroXP(newUnit, GetHeroXP(oldUnit), false);//call SetHeroXP(newUnit, GetHeroXP(oldUnit), false)
				index = 0;//set index = 0
				while (true) {//loop
					indexItem = UnitItemInSlot(oldUnit, index);//set indexItem = UnitItemInSlot(oldUnit, index)
					if ((indexItem != null)) {//if (indexItem != null) then
						UnitRemoveItem(oldUnit, indexItem);//call UnitRemoveItem(oldUnit, indexItem)
						UnitAddItem(newUnit, indexItem);//call UnitAddItem(newUnit, indexItem)
					}//endif
					index = index + 1;//set index = index + 1
					if (index >= bj_MAX_INVENTORY) { break; }//exitwhen index >= bj_MAX_INVENTORY
				}//endloop
			}//endif
			//
			//
			if (wasHidden) {//if wasHidden then
				KillUnit(oldUnit);//call KillUnit(oldUnit)
				RemoveUnit(oldUnit);//call RemoveUnit(oldUnit)
			} else {//else
				RemoveUnit(oldUnit);//call RemoveUnit(oldUnit)
			}//endif
			bj_lastReplacedUnit = newUnit;//set bj_lastReplacedUnit = newUnit
			return newUnit;//return newUnit
		}//endfunction
		//
		private unit GetLastReplacedUnitBJ() {//function GetLastReplacedUnitBJ takes nothing returns unit
			return bj_lastReplacedUnit;//return bj_lastReplacedUnit
		}//endfunction
		//
		private void SetUnitPositionLocFacingBJ(unit whichUnit, location loc, float facing) {//function SetUnitPositionLocFacingBJ takes unit whichUnit, location loc, real facing returns nothing
			SetUnitPositionLoc(whichUnit, loc);//call SetUnitPositionLoc(whichUnit, loc)
			SetUnitFacing(whichUnit, facing);//call SetUnitFacing(whichUnit, facing)
		}//endfunction
		//
		private void SetUnitPositionLocFacingLocBJ(unit whichUnit, location loc, location lookAt) {//function SetUnitPositionLocFacingLocBJ takes unit whichUnit, location loc, location lookAt returns nothing
			SetUnitPositionLoc(whichUnit, loc);//call SetUnitPositionLoc(whichUnit, loc)
			SetUnitFacing(whichUnit, AngleBetweenPoints(loc, lookAt));//call SetUnitFacing(whichUnit, AngleBetweenPoints(loc, lookAt))
		}//endfunction
		//
		private void AddItemToStockBJ(int itemId, unit whichUnit, int currentStock, int stockMax) {//function AddItemToStockBJ takes integer itemId, unit whichUnit, integer currentStock, integer stockMax returns nothing
			AddItemToStock(whichUnit, itemId, currentStock, stockMax);//call AddItemToStock(whichUnit, itemId, currentStock, stockMax)
		}//endfunction
		//
		private void AddUnitToStockBJ(int unitId, unit whichUnit, int currentStock, int stockMax) {//function AddUnitToStockBJ takes integer unitId, unit whichUnit, integer currentStock, integer stockMax returns nothing
			AddUnitToStock(whichUnit, unitId, currentStock, stockMax);//call AddUnitToStock(whichUnit, unitId, currentStock, stockMax)
		}//endfunction
		//
		private void RemoveItemFromStockBJ(int itemId, unit whichUnit) {//function RemoveItemFromStockBJ takes integer itemId, unit whichUnit returns nothing
			RemoveItemFromStock(whichUnit, itemId);//call RemoveItemFromStock(whichUnit, itemId)
		}//endfunction
		//
		private void RemoveUnitFromStockBJ(int unitId, unit whichUnit) {//function RemoveUnitFromStockBJ takes integer unitId, unit whichUnit returns nothing
			RemoveUnitFromStock(whichUnit, unitId);//call RemoveUnitFromStock(whichUnit, unitId)
		}//endfunction
		//
		private void SetUnitUseFoodBJ(bool enable, unit whichUnit) {//function SetUnitUseFoodBJ takes boolean enable, unit whichUnit returns nothing
			SetUnitUseFood(whichUnit, enable);//call SetUnitUseFood(whichUnit, enable)
		}//endfunction
		//
		private bool UnitDamagePointLoc(unit whichUnit, float delay, float radius, location loc, float amount, attacktype whichAttack, damagetype whichDamage) {//function UnitDamagePointLoc takes unit whichUnit, real delay, real radius, location loc, real amount, attacktype whichAttack, damagetype whichDamage returns boolean
			return UnitDamagePoint(whichUnit, delay, radius, GetLocationX(loc), GetLocationY(loc), amount, true, false, whichAttack, whichDamage, WEAPON_TYPE_WHOKNOWS);//return UnitDamagePoint(whichUnit, delay, radius, GetLocationX(loc), GetLocationY(loc), amount, true, false, whichAttack, whichDamage, WEAPON_TYPE_WHOKNOWS)
		}//endfunction
		//
		private bool UnitDamageTargetBJ(unit whichUnit, unit target, float amount, attacktype whichAttack, damagetype whichDamage) {//function UnitDamageTargetBJ takes unit whichUnit, unit target, real amount, attacktype whichAttack, damagetype whichDamage returns boolean
			return UnitDamageTarget(whichUnit, target, amount, true, false, whichAttack, whichDamage, WEAPON_TYPE_WHOKNOWS);//return UnitDamageTarget(whichUnit, target, amount, true, false, whichAttack, whichDamage, WEAPON_TYPE_WHOKNOWS)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private destructable CreateDestructableLoc(int objectid, location loc, float facing, float scale, int variation) {//function CreateDestructableLoc takes integer objectid, location loc, real facing, real scale, integer variation returns destructable
			bj_lastCreatedDestructable = CreateDestructable(objectid, GetLocationX(loc), GetLocationY(loc), facing, scale, variation);//set bj_lastCreatedDestructable = CreateDestructable(objectid, GetLocationX(loc), GetLocationY(loc), facing, scale, variation)
			return bj_lastCreatedDestructable;//return bj_lastCreatedDestructable
		}//endfunction
		//
		private destructable CreateDeadDestructableLocBJ(int objectid, location loc, float facing, float scale, int variation) {//function CreateDeadDestructableLocBJ takes integer objectid, location loc, real facing, real scale, integer variation returns destructable
			bj_lastCreatedDestructable = CreateDeadDestructable(objectid, GetLocationX(loc), GetLocationY(loc), facing, scale, variation);//set bj_lastCreatedDestructable = CreateDeadDestructable(objectid, GetLocationX(loc), GetLocationY(loc), facing, scale, variation)
			return bj_lastCreatedDestructable;//return bj_lastCreatedDestructable
		}//endfunction
		//
		private destructable GetLastCreatedDestructable() {//function GetLastCreatedDestructable takes nothing returns destructable
			return bj_lastCreatedDestructable;//return bj_lastCreatedDestructable
		}//endfunction
		//
		private void ShowDestructableBJ(bool flag, destructable d) {//function ShowDestructableBJ takes boolean flag, destructable d returns nothing
			ShowDestructable(d, flag);//call ShowDestructable(d, flag)
		}//endfunction
		//
		private void SetDestructableInvulnerableBJ(destructable d, bool flag) {//function SetDestructableInvulnerableBJ takes destructable d, boolean flag returns nothing
			SetDestructableInvulnerable(d, flag);//call SetDestructableInvulnerable(d, flag)
		}//endfunction
		//
		private bool IsDestructableInvulnerableBJ(destructable d) {//function IsDestructableInvulnerableBJ takes destructable d returns boolean
			return IsDestructableInvulnerable(d);//return IsDestructableInvulnerable(d)
		}//endfunction
		//
		private location GetDestructableLoc(destructable whichDestructable) {//function GetDestructableLoc takes destructable whichDestructable returns location
			return Location(GetDestructableX(whichDestructable), GetDestructableY(whichDestructable));//return Location(GetDestructableX(whichDestructable), GetDestructableY(whichDestructable))
		}//endfunction
		//
		private void EnumDestructablesInRectAll(rect r, code actionFunc) {//function EnumDestructablesInRectAll takes rect r, code actionFunc returns nothing
			EnumDestructablesInRect(r, null, actionFunc);//call EnumDestructablesInRect(r, null, actionFunc)
		}//endfunction
		//
		private bool EnumDestructablesInCircleBJFilter() {//function EnumDestructablesInCircleBJFilter takes nothing returns boolean
			location destLoc = GetDestructableLoc(GetFilterDestructable());//local location destLoc = GetDestructableLoc(GetFilterDestructable())
			bool result;//local boolean result
			result = DistanceBetweenPoints(destLoc, bj_enumDestructableCenter) <= bj_enumDestructableRadius;//set result = DistanceBetweenPoints(destLoc, bj_enumDestructableCenter) <= bj_enumDestructableRadius
			RemoveLocation(destLoc);//call RemoveLocation(destLoc)
			return result;//return result
		}//endfunction
		//
		private bool IsDestructableDeadBJ(destructable d) {//function IsDestructableDeadBJ takes destructable d returns boolean
			return GetDestructableLife(d) <= 0;//return GetDestructableLife(d) <= 0
		}//endfunction
		//
		private bool IsDestructableAliveBJ(destructable d) {//function IsDestructableAliveBJ takes destructable d returns boolean
			return !IsDestructableDeadBJ(d);//return not IsDestructableDeadBJ(d)
		}//endfunction
		//
		//
		//
		private void RandomDestructableInRectBJEnum() {//function RandomDestructableInRectBJEnum takes nothing returns nothing
			bj_destRandomConsidered = bj_destRandomConsidered + 1;//set bj_destRandomConsidered = bj_destRandomConsidered + 1
			if ((GetRandomInt(1,bj_destRandomConsidered) == 1)) {//if (GetRandomInt(1,bj_destRandomConsidered) == 1) then
				bj_destRandomCurrentPick = GetEnumDestructable();//set bj_destRandomCurrentPick = GetEnumDestructable()
			}//endif
		}//endfunction
		//
		//
		//
		private destructable RandomDestructableInRectBJ(rect r, boolexpr filter) {//function RandomDestructableInRectBJ takes rect r, boolexpr filter returns destructable
			bj_destRandomConsidered = 0;//set bj_destRandomConsidered = 0
			bj_destRandomCurrentPick = null;//set bj_destRandomCurrentPick = null
			EnumDestructablesInRect(r, filter, function RandomDestructableInRectBJEnum);//call EnumDestructablesInRect(r, filter, function RandomDestructableInRectBJEnum)
			DestroyBoolExpr(filter);//call DestroyBoolExpr(filter)
			return bj_destRandomCurrentPick;//return bj_destRandomCurrentPick
		}//endfunction
		//
		//
		//
		private destructable RandomDestructableInRectSimpleBJ(rect r) {//function RandomDestructableInRectSimpleBJ takes rect r returns destructable
			return RandomDestructableInRectBJ(r, null);//return RandomDestructableInRectBJ(r, null)
		}//endfunction
		//
		//
		//
		//
		private void EnumDestructablesInCircleBJ(float radius, location loc, code actionFunc) {//function EnumDestructablesInCircleBJ takes real radius, location loc, code actionFunc returns nothing
			rect r;//local rect r
			if ((radius >= 0)) {//if (radius >= 0) then
				bj_enumDestructableCenter = loc;//set bj_enumDestructableCenter = loc
				bj_enumDestructableRadius = radius;//set bj_enumDestructableRadius = radius
				r = GetRectFromCircleBJ(loc, radius);//set r = GetRectFromCircleBJ(loc, radius)
				EnumDestructablesInRect(r, filterEnumDestructablesInCircleBJ, actionFunc);//call EnumDestructablesInRect(r, filterEnumDestructablesInCircleBJ, actionFunc)
				RemoveRect(r);//call RemoveRect(r)
			}//endif
		}//endfunction
		//
		private void SetDestructableLifePercentBJ(destructable d, float percent) {//function SetDestructableLifePercentBJ takes destructable d, real percent returns nothing
			SetDestructableLife(d, GetDestructableMaxLife(d) * percent * 0.01);//call SetDestructableLife(d, GetDestructableMaxLife(d) * percent * 0.01)
		}//endfunction
		//
		private void SetDestructableMaxLifeBJ(destructable d, float max) {//function SetDestructableMaxLifeBJ takes destructable d, real max returns nothing
			SetDestructableMaxLife(d, max);//call SetDestructableMaxLife(d, max)
		}//endfunction
		//
		private void ModifyGateBJ(int gateOperation, destructable d) {//function ModifyGateBJ takes integer gateOperation, destructable d returns nothing
			if ((gateOperation == bj_GATEOPERATION_CLOSE)) {//if (gateOperation == bj_GATEOPERATION_CLOSE) then
				if ((GetDestructableLife(d) <= 0)) {//if (GetDestructableLife(d) <= 0) then
					DestructableRestoreLife(d, GetDestructableMaxLife(d), true);//call DestructableRestoreLife(d, GetDestructableMaxLife(d), true)
				}//endif
				SetDestructableAnimation(d, "stand");//call SetDestructableAnimation(d, "stand")
			} else if ((gateOperation == bj_GATEOPERATION_OPEN)) {//elseif (gateOperation == bj_GATEOPERATION_OPEN) then
				if ((GetDestructableLife(d) > 0)) {//if (GetDestructableLife(d) > 0) then
					KillDestructable(d);//call KillDestructable(d)
				}//endif
				SetDestructableAnimation(d, "death alternate");//call SetDestructableAnimation(d, "death alternate")
			} else if ((gateOperation == bj_GATEOPERATION_DESTROY)) {//elseif (gateOperation == bj_GATEOPERATION_DESTROY) then
				if ((GetDestructableLife(d) > 0)) {//if (GetDestructableLife(d) > 0) then
					KillDestructable(d);//call KillDestructable(d)
				}//endif
				SetDestructableAnimation(d, "death");//call SetDestructableAnimation(d, "death")
			} else {//else
				//
			}//endif
		}//endfunction
		//
		//
		//
		private int GetElevatorHeight(destructable d) {//function GetElevatorHeight takes destructable d returns integer
			int height;//local integer height
			height = 1 + R2I(GetDestructableOccluderHeight(d) / bj_CLIFFHEIGHT);//set height = 1 + R2I(GetDestructableOccluderHeight(d) / bj_CLIFFHEIGHT)
			if ((height < 1) || (height > 3)) {//if (height < 1) or (height > 3) then
				height = 1;//set height = 1
			}//endif
			return height;//return height
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void ChangeElevatorHeight(destructable d, int newHeight) {//function ChangeElevatorHeight takes destructable d, integer newHeight returns nothing
			int oldHeight;//local integer oldHeight
			//
			newHeight = IMaxBJ(1, newHeight);//set newHeight = IMaxBJ(1, newHeight)
			newHeight = IMinBJ(3, newHeight);//set newHeight = IMinBJ(3, newHeight)
			//
			oldHeight = GetElevatorHeight(d);//set oldHeight = GetElevatorHeight(d)
			//
			SetDestructableOccluderHeight(d, bj_CLIFFHEIGHT*(newHeight-1));//call SetDestructableOccluderHeight(d, bj_CLIFFHEIGHT*(newHeight-1))
			if ((newHeight == 1)) {//if (newHeight == 1) then
				if ((oldHeight == 2)) {//if (oldHeight == 2) then
					SetDestructableAnimation(d, "birth");//call SetDestructableAnimation(d, "birth")
					QueueDestructableAnimation(d, "stand");//call QueueDestructableAnimation(d, "stand")
				} else if ((oldHeight == 3)) {//elseif (oldHeight == 3) then
					SetDestructableAnimation(d, "birth third");//call SetDestructableAnimation(d, "birth third")
					QueueDestructableAnimation(d, "stand");//call QueueDestructableAnimation(d, "stand")
				} else {//else
					//
					SetDestructableAnimation(d, "stand");//call SetDestructableAnimation(d, "stand")
				}//endif
			} else if ((newHeight == 2)) {//elseif (newHeight == 2) then
				if ((oldHeight == 1)) {//if (oldHeight == 1) then
					SetDestructableAnimation(d, "death");//call SetDestructableAnimation(d, "death")
					QueueDestructableAnimation(d, "stand second");//call QueueDestructableAnimation(d, "stand second")
				} else if ((oldHeight == 3)) {//elseif (oldHeight == 3) then
					SetDestructableAnimation(d, "birth second");//call SetDestructableAnimation(d, "birth second")
					QueueDestructableAnimation(d, "stand second");//call QueueDestructableAnimation(d, "stand second")
				} else {//else
					//
					SetDestructableAnimation(d, "stand second");//call SetDestructableAnimation(d, "stand second")
				}//endif
			} else if ((newHeight == 3)) {//elseif (newHeight == 3) then
				if ((oldHeight == 1)) {//if (oldHeight == 1) then
					SetDestructableAnimation(d, "death third");//call SetDestructableAnimation(d, "death third")
					QueueDestructableAnimation(d, "stand third");//call QueueDestructableAnimation(d, "stand third")
				} else if ((oldHeight == 2)) {//elseif (oldHeight == 2) then
					SetDestructableAnimation(d, "death second");//call SetDestructableAnimation(d, "death second")
					QueueDestructableAnimation(d, "stand third");//call QueueDestructableAnimation(d, "stand third")
				} else {//else
					//
					SetDestructableAnimation(d, "stand third");//call SetDestructableAnimation(d, "stand third")
				}//endif
			} else {//else
				//
			}//endif
		}//endfunction
		//
		//
		//
		//
		private void NudgeUnitsInRectEnum() {//function NudgeUnitsInRectEnum takes nothing returns nothing
			unit nudgee = GetEnumUnit();//local unit nudgee = GetEnumUnit()
			SetUnitPosition(nudgee, GetUnitX(nudgee), GetUnitY(nudgee));//call SetUnitPosition(nudgee, GetUnitX(nudgee), GetUnitY(nudgee))
		}//endfunction
		//
		private void NudgeItemsInRectEnum() {//function NudgeItemsInRectEnum takes nothing returns nothing
			item nudgee = GetEnumItem();//local item nudgee = GetEnumItem()
			SetItemPosition(nudgee, GetItemX(nudgee), GetItemY(nudgee));//call SetItemPosition(nudgee, GetItemX(nudgee), GetItemY(nudgee))
		}//endfunction
		//
		//
		//
		//
		//
		private void NudgeObjectsInRect(rect nudgeArea) {//function NudgeObjectsInRect takes rect nudgeArea returns nothing
			group g;//local group        g
			g = CreateGroup();//set g = CreateGroup()
			GroupEnumUnitsInRect(g, nudgeArea, null);//call GroupEnumUnitsInRect(g, nudgeArea, null)
			ForGroup(g, function NudgeUnitsInRectEnum);//call ForGroup(g, function NudgeUnitsInRectEnum)
			DestroyGroup(g);//call DestroyGroup(g)
			EnumItemsInRect(nudgeArea, null, function NudgeItemsInRectEnum);//call EnumItemsInRect(nudgeArea, null, function NudgeItemsInRectEnum)
		}//endfunction
		//
		private void NearbyElevatorExistsEnum() {//function NearbyElevatorExistsEnum takes nothing returns nothing
			destructable d = GetEnumDestructable();//local destructable d     = GetEnumDestructable()
			int dType = GetDestructableTypeId(d);//local integer      dType = GetDestructableTypeId(d)
			if ((dType == bj_ELEVATOR_CODE01) || (dType == bj_ELEVATOR_CODE02)) {//if (dType == bj_ELEVATOR_CODE01) or (dType == bj_ELEVATOR_CODE02) then
				bj_elevatorNeighbor = d;//set bj_elevatorNeighbor = d
			}//endif
		}//endfunction
		//
		private bool NearbyElevatorExists(float x, float y) {//function NearbyElevatorExists takes real x, real y returns boolean
			float findThreshold = 32;//local real findThreshold = 32
			rect r;//local rect r
			//
			r = Rect(x - findThreshold, y - findThreshold, x + findThreshold, y + findThreshold);//set r = Rect(x - findThreshold, y - findThreshold, x + findThreshold, y + findThreshold)
			bj_elevatorNeighbor = null;//set bj_elevatorNeighbor = null
			EnumDestructablesInRect(r, null, function NearbyElevatorExistsEnum);//call EnumDestructablesInRect(r, null, function NearbyElevatorExistsEnum)
			RemoveRect(r);//call RemoveRect(r)
			return bj_elevatorNeighbor != null;//return bj_elevatorNeighbor != null
		}//endfunction
		//
		private void FindElevatorWallBlockerEnum() {//function FindElevatorWallBlockerEnum takes nothing returns nothing
			bj_elevatorWallBlocker = GetEnumDestructable();//set bj_elevatorWallBlocker = GetEnumDestructable()
		}//endfunction
		//
		//
		//
		//
		//
		private void ChangeElevatorWallBlocker(float x, float y, float facing, bool open) {//function ChangeElevatorWallBlocker takes real x, real y, real facing, boolean open returns nothing
			destructable blocker = null;//local destructable blocker = null
			float findThreshold = 32;//local real         findThreshold = 32
			float nudgeLength = 4.25 * bj_CELLWIDTH;//local real         nudgeLength   = 4.25 * bj_CELLWIDTH
			float nudgeWidth = 1.25 * bj_CELLWIDTH;//local real         nudgeWidth    = 1.25 * bj_CELLWIDTH
			rect r;//local rect         r
			//
			r = Rect(x - findThreshold, y - findThreshold, x + findThreshold, y + findThreshold);//set r = Rect(x - findThreshold, y - findThreshold, x + findThreshold, y + findThreshold)
			bj_elevatorWallBlocker = null;//set bj_elevatorWallBlocker = null
			EnumDestructablesInRect(r, null, function FindElevatorWallBlockerEnum);//call EnumDestructablesInRect(r, null, function FindElevatorWallBlockerEnum)
			RemoveRect(r);//call RemoveRect(r)
			blocker = bj_elevatorWallBlocker;//set blocker = bj_elevatorWallBlocker
			//
			if ((blocker == null)) {//if (blocker == null) then
				blocker = CreateDeadDestructable(bj_ELEVATOR_BLOCKER_CODE, x, y, facing, 1, 0);//set blocker = CreateDeadDestructable(bj_ELEVATOR_BLOCKER_CODE, x, y, facing, 1, 0)
			} else if ((GetDestructableTypeId(blocker) != bj_ELEVATOR_BLOCKER_CODE)) {//elseif (GetDestructableTypeId(blocker) != bj_ELEVATOR_BLOCKER_CODE) then
				//
				//
				//
				return;//return
			}//endif
			if ((open)) {//if (open) then
				//
				if ((GetDestructableLife(blocker) > 0)) {//if (GetDestructableLife(blocker) > 0) then
					KillDestructable(blocker);//call KillDestructable(blocker)
				}//endif
			} else {//else
				//
				if ((GetDestructableLife(blocker) <= 0)) {//if (GetDestructableLife(blocker) <= 0) then
					DestructableRestoreLife(blocker, GetDestructableMaxLife(blocker), false);//call DestructableRestoreLife(blocker, GetDestructableMaxLife(blocker), false)
				}//endif
				//
				if ((facing == 0)) {//if (facing == 0) then
					r = Rect(x - nudgeWidth/2, y - nudgeLength/2, x + nudgeWidth/2, y + nudgeLength/2);//set r = Rect(x - nudgeWidth/2, y - nudgeLength/2, x + nudgeWidth/2, y + nudgeLength/2)
					NudgeObjectsInRect(r);//call NudgeObjectsInRect(r)
					RemoveRect(r);//call RemoveRect(r)
				} else if ((facing == 90)) {//elseif (facing == 90) then
					r = Rect(x - nudgeLength/2, y - nudgeWidth/2, x + nudgeLength/2, y + nudgeWidth/2);//set r = Rect(x - nudgeLength/2, y - nudgeWidth/2, x + nudgeLength/2, y + nudgeWidth/2)
					NudgeObjectsInRect(r);//call NudgeObjectsInRect(r)
					RemoveRect(r);//call RemoveRect(r)
				} else {//else
					//
				}//endif
			}//endif
		}//endfunction
		//
		private void ChangeElevatorWalls(bool open, int walls, destructable d) {//function ChangeElevatorWalls takes boolean open, integer walls, destructable d returns nothing
			float x = GetDestructableX(d);//local real x = GetDestructableX(d)
			float y = GetDestructableY(d);//local real y = GetDestructableY(d)
			float distToBlocker = 192;//local real distToBlocker = 192
			float distToNeighbor = 256;//local real distToNeighbor = 256
			if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_EAST)) {//if (walls == bj_ELEVATOR_WALL_TYPE_ALL) or (walls == bj_ELEVATOR_WALL_TYPE_EAST) then
				if ((!NearbyElevatorExists(x + distToNeighbor, y))) {//if (not NearbyElevatorExists(x + distToNeighbor, y)) then
					ChangeElevatorWallBlocker(x + distToBlocker, y, 0, open);//call ChangeElevatorWallBlocker(x + distToBlocker, y, 0, open)
				}//endif
			}//endif
			if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_NORTH)) {//if (walls == bj_ELEVATOR_WALL_TYPE_ALL) or (walls == bj_ELEVATOR_WALL_TYPE_NORTH) then
				if ((!NearbyElevatorExists(x, y + distToNeighbor))) {//if (not NearbyElevatorExists(x, y + distToNeighbor)) then
					ChangeElevatorWallBlocker(x, y + distToBlocker, 90, open);//call ChangeElevatorWallBlocker(x, y + distToBlocker, 90, open)
				}//endif
			}//endif
			if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_SOUTH)) {//if (walls == bj_ELEVATOR_WALL_TYPE_ALL) or (walls == bj_ELEVATOR_WALL_TYPE_SOUTH) then
				if ((!NearbyElevatorExists(x, y - distToNeighbor))) {//if (not NearbyElevatorExists(x, y - distToNeighbor)) then
					ChangeElevatorWallBlocker(x, y - distToBlocker, 90, open);//call ChangeElevatorWallBlocker(x, y - distToBlocker, 90, open)
				}//endif
			}//endif
			if ((walls == bj_ELEVATOR_WALL_TYPE_ALL) || (walls == bj_ELEVATOR_WALL_TYPE_WEST)) {//if (walls == bj_ELEVATOR_WALL_TYPE_ALL) or (walls == bj_ELEVATOR_WALL_TYPE_WEST) then
				if ((!NearbyElevatorExists(x - distToNeighbor, y))) {//if (not NearbyElevatorExists(x - distToNeighbor, y)) then
					ChangeElevatorWallBlocker(x - distToBlocker, y, 0, open);//call ChangeElevatorWallBlocker(x - distToBlocker, y, 0, open)
				}//endif
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void WaygateActivateBJ(bool activate, unit waygate) {//function WaygateActivateBJ takes boolean activate, unit waygate returns nothing
			WaygateActivate(waygate, activate);//call WaygateActivate(waygate, activate)
		}//endfunction
		//
		private bool WaygateIsActiveBJ(unit waygate) {//function WaygateIsActiveBJ takes unit waygate returns boolean
			return WaygateIsActive(waygate);//return WaygateIsActive(waygate)
		}//endfunction
		//
		private void WaygateSetDestinationLocBJ(unit waygate, location loc) {//function WaygateSetDestinationLocBJ takes unit waygate, location loc returns nothing
			WaygateSetDestination(waygate, GetLocationX(loc), GetLocationY(loc));//call WaygateSetDestination(waygate, GetLocationX(loc), GetLocationY(loc))
		}//endfunction
		//
		private location WaygateGetDestinationLocBJ(unit waygate) {//function WaygateGetDestinationLocBJ takes unit waygate returns location
			return Location(WaygateGetDestinationX(waygate), WaygateGetDestinationY(waygate));//return Location(WaygateGetDestinationX(waygate), WaygateGetDestinationY(waygate))
		}//endfunction
		//
		private void UnitSetUsesAltIconBJ(bool flag, unit whichUnit) {//function UnitSetUsesAltIconBJ takes boolean flag, unit whichUnit returns nothing
			UnitSetUsesAltIcon(whichUnit, flag);//call UnitSetUsesAltIcon(whichUnit, flag)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void ForceUIKeyBJ(player whichPlayer, string key) {//function ForceUIKeyBJ takes player whichPlayer, string key returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				ForceUIKey(key);//call ForceUIKey(key)
			}//endif
		}//endfunction
		//
		private void ForceUICancelBJ(player whichPlayer) {//function ForceUICancelBJ takes player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				ForceUICancel();//call ForceUICancel()
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void ForGroupBJ(group whichGroup, code callback) {//function ForGroupBJ takes group whichGroup, code callback returns nothing
			//
			//
			bool wantDestroy = bj_wantDestroyGroup;//local boolean wantDestroy = bj_wantDestroyGroup
			bj_wantDestroyGroup = false;//set bj_wantDestroyGroup = false
			ForGroup(whichGroup, callback);//call ForGroup(whichGroup, callback)
			//
			if ((wantDestroy)) {//if (wantDestroy) then
				DestroyGroup(whichGroup);//call DestroyGroup(whichGroup)
			}//endif
		}//endfunction
		//
		private void GroupAddUnitSimple(unit whichUnit, group whichGroup) {//function GroupAddUnitSimple takes unit whichUnit, group whichGroup returns nothing
			GroupAddUnit(whichGroup, whichUnit);//call GroupAddUnit(whichGroup, whichUnit)
		}//endfunction
		//
		private void GroupRemoveUnitSimple(unit whichUnit, group whichGroup) {//function GroupRemoveUnitSimple takes unit whichUnit, group whichGroup returns nothing
			GroupRemoveUnit(whichGroup, whichUnit);//call GroupRemoveUnit(whichGroup, whichUnit)
		}//endfunction
		//
		private void GroupAddGroupEnum() {//function GroupAddGroupEnum takes nothing returns nothing
			GroupAddUnit(bj_groupAddGroupDest, GetEnumUnit());//call GroupAddUnit(bj_groupAddGroupDest, GetEnumUnit())
		}//endfunction
		//
		private void GroupAddGroup(group sourceGroup, group destGroup) {//function GroupAddGroup takes group sourceGroup, group destGroup returns nothing
			//
			//
			bool wantDestroy = bj_wantDestroyGroup;//local boolean wantDestroy = bj_wantDestroyGroup
			bj_wantDestroyGroup = false;//set bj_wantDestroyGroup = false
			bj_groupAddGroupDest = destGroup;//set bj_groupAddGroupDest = destGroup
			ForGroup(sourceGroup, function GroupAddGroupEnum);//call ForGroup(sourceGroup, function GroupAddGroupEnum)
			//
			if ((wantDestroy)) {//if (wantDestroy) then
				DestroyGroup(sourceGroup);//call DestroyGroup(sourceGroup)
			}//endif
		}//endfunction
		//
		private void GroupRemoveGroupEnum() {//function GroupRemoveGroupEnum takes nothing returns nothing
			GroupRemoveUnit(bj_groupRemoveGroupDest, GetEnumUnit());//call GroupRemoveUnit(bj_groupRemoveGroupDest, GetEnumUnit())
		}//endfunction
		//
		private void GroupRemoveGroup(group sourceGroup, group destGroup) {//function GroupRemoveGroup takes group sourceGroup, group destGroup returns nothing
			//
			//
			bool wantDestroy = bj_wantDestroyGroup;//local boolean wantDestroy = bj_wantDestroyGroup
			bj_wantDestroyGroup = false;//set bj_wantDestroyGroup = false
			bj_groupRemoveGroupDest = destGroup;//set bj_groupRemoveGroupDest = destGroup
			ForGroup(sourceGroup, function GroupRemoveGroupEnum);//call ForGroup(sourceGroup, function GroupRemoveGroupEnum)
			//
			if ((wantDestroy)) {//if (wantDestroy) then
				DestroyGroup(sourceGroup);//call DestroyGroup(sourceGroup)
			}//endif
		}//endfunction
		//
		private void ForceAddPlayerSimple(player whichPlayer, force whichForce) {//function ForceAddPlayerSimple takes player whichPlayer, force whichForce returns nothing
			ForceAddPlayer(whichForce, whichPlayer);//call ForceAddPlayer(whichForce, whichPlayer)
		}//endfunction
		//
		private void ForceRemovePlayerSimple(player whichPlayer, force whichForce) {//function ForceRemovePlayerSimple takes player whichPlayer, force whichForce returns nothing
			ForceRemovePlayer(whichForce, whichPlayer);//call ForceRemovePlayer(whichForce, whichPlayer)
		}//endfunction
		//
		//
		//
		//
		//
		//
		//
		private void GroupPickRandomUnitEnum() {//function GroupPickRandomUnitEnum takes nothing returns nothing
			bj_groupRandomConsidered = bj_groupRandomConsidered + 1;//set bj_groupRandomConsidered = bj_groupRandomConsidered + 1
			if ((GetRandomInt(1,bj_groupRandomConsidered) == 1)) {//if (GetRandomInt(1,bj_groupRandomConsidered) == 1) then
				bj_groupRandomCurrentPick = GetEnumUnit();//set bj_groupRandomCurrentPick = GetEnumUnit()
			}//endif
		}//endfunction
		//
		//
		//
		private unit GroupPickRandomUnit(group whichGroup) {//function GroupPickRandomUnit takes group whichGroup returns unit
			//
			//
			bool wantDestroy = bj_wantDestroyGroup;//local boolean wantDestroy = bj_wantDestroyGroup
			bj_wantDestroyGroup = false;//set bj_wantDestroyGroup = false
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered = 0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick = null
			ForGroup(whichGroup, function GroupPickRandomUnitEnum);//call ForGroup(whichGroup, function GroupPickRandomUnitEnum)
			//
			if ((wantDestroy)) {//if (wantDestroy) then
				DestroyGroup(whichGroup);//call DestroyGroup(whichGroup)
			}//endif
			return bj_groupRandomCurrentPick;//return bj_groupRandomCurrentPick
		}//endfunction
		//
		//
		//
		private void ForcePickRandomPlayerEnum() {//function ForcePickRandomPlayerEnum takes nothing returns nothing
			bj_forceRandomConsidered = bj_forceRandomConsidered + 1;//set bj_forceRandomConsidered = bj_forceRandomConsidered + 1
			if ((GetRandomInt(1,bj_forceRandomConsidered) == 1)) {//if (GetRandomInt(1,bj_forceRandomConsidered) == 1) then
				bj_forceRandomCurrentPick = GetEnumPlayer();//set bj_forceRandomCurrentPick = GetEnumPlayer()
			}//endif
		}//endfunction
		//
		//
		//
		private player ForcePickRandomPlayer(force whichForce) {//function ForcePickRandomPlayer takes force whichForce returns player
			bj_forceRandomConsidered = 0;//set bj_forceRandomConsidered = 0
			bj_forceRandomCurrentPick = null;//set bj_forceRandomCurrentPick = null
			ForForce(whichForce, function ForcePickRandomPlayerEnum);//call ForForce(whichForce, function ForcePickRandomPlayerEnum)
			return bj_forceRandomCurrentPick;//return bj_forceRandomCurrentPick
		}//endfunction
		//
		private void EnumUnitsSelected(player whichPlayer, boolexpr enumFilter, code enumAction) {//function EnumUnitsSelected takes player whichPlayer, boolexpr enumFilter, code enumAction returns nothing
			group g = CreateGroup();//local group g = CreateGroup()
			SyncSelections();//call SyncSelections()
			GroupEnumUnitsSelected(g, whichPlayer, enumFilter);//call GroupEnumUnitsSelected(g, whichPlayer, enumFilter)
			DestroyBoolExpr(enumFilter);//call DestroyBoolExpr(enumFilter)
			ForGroup(g, enumAction);//call ForGroup(g, enumAction)
			DestroyGroup(g);//call DestroyGroup(g)
		}//endfunction
		//
		private group GetUnitsInRectMatching(rect r, boolexpr filter) {//function GetUnitsInRectMatching takes rect r, boolexpr filter returns group
			group g = CreateGroup();//local group g = CreateGroup()
			GroupEnumUnitsInRect(g, r, filter);//call GroupEnumUnitsInRect(g, r, filter)
			DestroyBoolExpr(filter);//call DestroyBoolExpr(filter)
			return g;//return g
		}//endfunction
		//
		private group GetUnitsInRectAll(rect r) {//function GetUnitsInRectAll takes rect r returns group
			return GetUnitsInRectMatching(r, null);//return GetUnitsInRectMatching(r, null)
		}//endfunction
		//
		private bool GetUnitsInRectOfPlayerFilter() {//function GetUnitsInRectOfPlayerFilter takes nothing returns boolean
			return GetOwningPlayer(GetFilterUnit()) == bj_groupEnumOwningPlayer;//return GetOwningPlayer(GetFilterUnit()) == bj_groupEnumOwningPlayer
		}//endfunction
		//
		private group GetUnitsInRectOfPlayer(rect r, player whichPlayer) {//function GetUnitsInRectOfPlayer takes rect r, player whichPlayer returns group
			group g = CreateGroup();//local group g = CreateGroup()
			bj_groupEnumOwningPlayer = whichPlayer;//set bj_groupEnumOwningPlayer = whichPlayer
			GroupEnumUnitsInRect(g, r, filterGetUnitsInRectOfPlayer);//call GroupEnumUnitsInRect(g, r, filterGetUnitsInRectOfPlayer)
			return g;//return g
		}//endfunction
		//
		private group GetUnitsInRangeOfLocMatching(float radius, location whichLocation, boolexpr filter) {//function GetUnitsInRangeOfLocMatching takes real radius, location whichLocation, boolexpr filter returns group
			group g = CreateGroup();//local group g = CreateGroup()
			GroupEnumUnitsInRangeOfLoc(g, whichLocation, radius, filter);//call GroupEnumUnitsInRangeOfLoc(g, whichLocation, radius, filter)
			DestroyBoolExpr(filter);//call DestroyBoolExpr(filter)
			return g;//return g
		}//endfunction
		//
		private group GetUnitsInRangeOfLocAll(float radius, location whichLocation) {//function GetUnitsInRangeOfLocAll takes real radius, location whichLocation returns group
			return GetUnitsInRangeOfLocMatching(radius, whichLocation, null);//return GetUnitsInRangeOfLocMatching(radius, whichLocation, null)
		}//endfunction
		//
		private bool GetUnitsOfTypeIdAllFilter() {//function GetUnitsOfTypeIdAllFilter takes nothing returns boolean
			return GetUnitTypeId(GetFilterUnit()) == bj_groupEnumTypeId;//return GetUnitTypeId(GetFilterUnit()) == bj_groupEnumTypeId
		}//endfunction
		//
		private group GetUnitsOfTypeIdAll(int unitid) {//function GetUnitsOfTypeIdAll takes integer unitid returns group
			group result = CreateGroup();//local group   result = CreateGroup()
			group g = CreateGroup();//local group   g      = CreateGroup()
			int index;//local integer index
			index = 0;//set index = 0
			while (true) {//loop
				bj_groupEnumTypeId = unitid;//set bj_groupEnumTypeId = unitid
				GroupClear(g);//call GroupClear(g)
				GroupEnumUnitsOfPlayer(g, Player(index), filterGetUnitsOfTypeIdAll);//call GroupEnumUnitsOfPlayer(g, Player(index), filterGetUnitsOfTypeIdAll)
				GroupAddGroup(g, result);//call GroupAddGroup(g, result)
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen index == bj_MAX_PLAYER_SLOTS
			}//endloop
			DestroyGroup(g);//call DestroyGroup(g)
			return result;//return result
		}//endfunction
		//
		private group GetUnitsOfPlayerMatching(player whichPlayer, boolexpr filter) {//function GetUnitsOfPlayerMatching takes player whichPlayer, boolexpr filter returns group
			group g = CreateGroup();//local group g = CreateGroup()
			GroupEnumUnitsOfPlayer(g, whichPlayer, filter);//call GroupEnumUnitsOfPlayer(g, whichPlayer, filter)
			DestroyBoolExpr(filter);//call DestroyBoolExpr(filter)
			return g;//return g
		}//endfunction
		//
		private group GetUnitsOfPlayerAll(player whichPlayer) {//function GetUnitsOfPlayerAll takes player whichPlayer returns group
			return GetUnitsOfPlayerMatching(whichPlayer, null);//return GetUnitsOfPlayerMatching(whichPlayer, null)
		}//endfunction
		//
		private bool GetUnitsOfPlayerAndTypeIdFilter() {//function GetUnitsOfPlayerAndTypeIdFilter takes nothing returns boolean
			return GetUnitTypeId(GetFilterUnit()) == bj_groupEnumTypeId;//return GetUnitTypeId(GetFilterUnit()) == bj_groupEnumTypeId
		}//endfunction
		//
		private group GetUnitsOfPlayerAndTypeId(player whichPlayer, int unitid) {//function GetUnitsOfPlayerAndTypeId takes player whichPlayer, integer unitid returns group
			group g = CreateGroup();//local group g = CreateGroup()
			bj_groupEnumTypeId = unitid;//set bj_groupEnumTypeId = unitid
			GroupEnumUnitsOfPlayer(g, whichPlayer, filterGetUnitsOfPlayerAndTypeId);//call GroupEnumUnitsOfPlayer(g, whichPlayer, filterGetUnitsOfPlayerAndTypeId)
			return g;//return g
		}//endfunction
		//
		private group GetUnitsSelectedAll(player whichPlayer) {//function GetUnitsSelectedAll takes player whichPlayer returns group
			group g = CreateGroup();//local group g = CreateGroup()
			SyncSelections();//call SyncSelections()
			GroupEnumUnitsSelected(g, whichPlayer, null);//call GroupEnumUnitsSelected(g, whichPlayer, null)
			return g;//return g
		}//endfunction
		//
		private force GetForceOfPlayer(player whichPlayer) {//function GetForceOfPlayer takes player whichPlayer returns force
			force f = CreateForce();//local force f = CreateForce()
			ForceAddPlayer(f, whichPlayer);//call ForceAddPlayer(f, whichPlayer)
			return f;//return f
		}//endfunction
		//
		private force GetPlayersAll() {//function GetPlayersAll takes nothing returns force
			return bj_FORCE_ALL_PLAYERS;//return bj_FORCE_ALL_PLAYERS
		}//endfunction
		//
		private force GetPlayersByMapControl(mapcontrol whichControl) {//function GetPlayersByMapControl takes mapcontrol whichControl returns force
			force f = CreateForce();//local force f = CreateForce()
			int playerIndex;//local integer playerIndex
			player indexPlayer;//local player  indexPlayer
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if (GetPlayerController(indexPlayer) == whichControl) {//if GetPlayerController(indexPlayer) == whichControl then
					ForceAddPlayer(f, indexPlayer);//call ForceAddPlayer(f, indexPlayer)
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen playerIndex == bj_MAX_PLAYER_SLOTS
			}//endloop
			return f;//return f
		}//endfunction
		//
		private force GetPlayersAllies(player whichPlayer) {//function GetPlayersAllies takes player whichPlayer returns force
			force f = CreateForce();//local force f = CreateForce()
			ForceEnumAllies(f, whichPlayer, null);//call ForceEnumAllies(f, whichPlayer, null)
			return f;//return f
		}//endfunction
		//
		private force GetPlayersEnemies(player whichPlayer) {//function GetPlayersEnemies takes player whichPlayer returns force
			force f = CreateForce();//local force f = CreateForce()
			ForceEnumEnemies(f, whichPlayer, null);//call ForceEnumEnemies(f, whichPlayer, null)
			return f;//return f
		}//endfunction
		//
		private force GetPlayersMatching(boolexpr filter) {//function GetPlayersMatching takes boolexpr filter returns force
			force f = CreateForce();//local force f = CreateForce()
			ForceEnumPlayers(f, filter);//call ForceEnumPlayers(f, filter)
			DestroyBoolExpr(filter);//call DestroyBoolExpr(filter)
			return f;//return f
		}//endfunction
		//
		private void CountUnitsInGroupEnum() {//function CountUnitsInGroupEnum takes nothing returns nothing
			bj_groupCountUnits = bj_groupCountUnits + 1;//set bj_groupCountUnits = bj_groupCountUnits + 1
		}//endfunction
		//
		private int CountUnitsInGroup(group g) {//function CountUnitsInGroup takes group g returns integer
			//
			//
			bool wantDestroy = bj_wantDestroyGroup;//local boolean wantDestroy = bj_wantDestroyGroup
			bj_wantDestroyGroup = false;//set bj_wantDestroyGroup = false
			bj_groupCountUnits = 0;//set bj_groupCountUnits = 0
			ForGroup(g, function CountUnitsInGroupEnum);//call ForGroup(g, function CountUnitsInGroupEnum)
			//
			if ((wantDestroy)) {//if (wantDestroy) then
				DestroyGroup(g);//call DestroyGroup(g)
			}//endif
			return bj_groupCountUnits;//return bj_groupCountUnits
		}//endfunction
		//
		private void CountPlayersInForceEnum() {//function CountPlayersInForceEnum takes nothing returns nothing
			bj_forceCountPlayers = bj_forceCountPlayers + 1;//set bj_forceCountPlayers = bj_forceCountPlayers + 1
		}//endfunction
		//
		private int CountPlayersInForceBJ(force f) {//function CountPlayersInForceBJ takes force f returns integer
			bj_forceCountPlayers = 0;//set bj_forceCountPlayers = 0
			ForForce(f, function CountPlayersInForceEnum);//call ForForce(f, function CountPlayersInForceEnum)
			return bj_forceCountPlayers;//return bj_forceCountPlayers
		}//endfunction
		//
		private void GetRandomSubGroupEnum() {//function GetRandomSubGroupEnum takes nothing returns nothing
			if ((bj_randomSubGroupWant > 0)) {//if (bj_randomSubGroupWant > 0) then
				if ((bj_randomSubGroupWant >= bj_randomSubGroupTotal) || (GetRandomReal(0,1) < bj_randomSubGroupChance)) {//if (bj_randomSubGroupWant >= bj_randomSubGroupTotal) or (GetRandomReal(0,1) < bj_randomSubGroupChance) then
					//
					GroupAddUnit(bj_randomSubGroupGroup, GetEnumUnit());//call GroupAddUnit(bj_randomSubGroupGroup, GetEnumUnit())
					bj_randomSubGroupWant = bj_randomSubGroupWant - 1;//set bj_randomSubGroupWant = bj_randomSubGroupWant - 1
				}//endif
			}//endif
			bj_randomSubGroupTotal = bj_randomSubGroupTotal - 1;//set bj_randomSubGroupTotal = bj_randomSubGroupTotal - 1
		}//endfunction
		//
		private group GetRandomSubGroup(int count, group sourceGroup) {//function GetRandomSubGroup takes integer count, group sourceGroup returns group
			group g = CreateGroup();//local group g = CreateGroup()
			bj_randomSubGroupGroup = g;//set bj_randomSubGroupGroup = g
			bj_randomSubGroupWant = count;//set bj_randomSubGroupWant  = count
			bj_randomSubGroupTotal = CountUnitsInGroup(sourceGroup);//set bj_randomSubGroupTotal = CountUnitsInGroup(sourceGroup)
			if ((bj_randomSubGroupWant <= 0 || bj_randomSubGroupTotal <= 0)) {//if (bj_randomSubGroupWant <= 0 or bj_randomSubGroupTotal <= 0) then
				return g;//return g
			}//endif
			bj_randomSubGroupChance = I2R(bj_randomSubGroupWant) / I2R(bj_randomSubGroupTotal);//set bj_randomSubGroupChance = I2R(bj_randomSubGroupWant) / I2R(bj_randomSubGroupTotal)
			ForGroup(sourceGroup, function GetRandomSubGroupEnum);//call ForGroup(sourceGroup, function GetRandomSubGroupEnum)
			return g;//return g
		}//endfunction
		//
		private bool LivingPlayerUnitsOfTypeIdFilter() {//function LivingPlayerUnitsOfTypeIdFilter takes nothing returns boolean
			unit filterUnit = GetFilterUnit();//local unit filterUnit = GetFilterUnit()
			return IsUnitAliveBJ(filterUnit) && GetUnitTypeId(filterUnit) == bj_livingPlayerUnitsTypeId;//return IsUnitAliveBJ(filterUnit) and GetUnitTypeId(filterUnit) == bj_livingPlayerUnitsTypeId
		}//endfunction
		//
		private int CountLivingPlayerUnitsOfTypeId(int unitId, player whichPlayer) {//function CountLivingPlayerUnitsOfTypeId takes integer unitId, player whichPlayer returns integer
			group g;//local group g
			int matchedCount;//local integer matchedCount
			g = CreateGroup();//set g = CreateGroup()
			bj_livingPlayerUnitsTypeId = unitId;//set bj_livingPlayerUnitsTypeId = unitId
			GroupEnumUnitsOfPlayer(g, whichPlayer, filterLivingPlayerUnitsOfTypeId);//call GroupEnumUnitsOfPlayer(g, whichPlayer, filterLivingPlayerUnitsOfTypeId)
			matchedCount = CountUnitsInGroup(g);//set matchedCount = CountUnitsInGroup(g)
			DestroyGroup(g);//call DestroyGroup(g)
			return matchedCount;//return matchedCount
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void ResetUnitAnimation(unit whichUnit) {//function ResetUnitAnimation takes unit whichUnit returns nothing
			SetUnitAnimation(whichUnit, "stand");//call SetUnitAnimation(whichUnit, "stand")
		}//endfunction
		//
		private void SetUnitTimeScalePercent(unit whichUnit, float percentScale) {//function SetUnitTimeScalePercent takes unit whichUnit, real percentScale returns nothing
			SetUnitTimeScale(whichUnit, percentScale * 0.01);//call SetUnitTimeScale(whichUnit, percentScale * 0.01)
		}//endfunction
		//
		private void SetUnitScalePercent(unit whichUnit, float percentScaleX, float percentScaleY, float percentScaleZ) {//function SetUnitScalePercent takes unit whichUnit, real percentScaleX, real percentScaleY, real percentScaleZ returns nothing
			SetUnitScale(whichUnit, percentScaleX * 0.01, percentScaleY * 0.01, percentScaleZ * 0.01);//call SetUnitScale(whichUnit, percentScaleX * 0.01, percentScaleY * 0.01, percentScaleZ * 0.01)
		}//endfunction
		//
		//
		//
		//
		//
		private void SetUnitVertexColorBJ(unit whichUnit, float red, float green, float blue, float transparency) {//function SetUnitVertexColorBJ takes unit whichUnit, real red, real green, real blue, real transparency returns nothing
			SetUnitVertexColor(whichUnit, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call SetUnitVertexColor(whichUnit, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void UnitAddIndicatorBJ(unit whichUnit, float red, float green, float blue, float transparency) {//function UnitAddIndicatorBJ takes unit whichUnit, real red, real green, real blue, real transparency returns nothing
			AddIndicator(whichUnit, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call AddIndicator(whichUnit, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void DestructableAddIndicatorBJ(destructable whichDestructable, float red, float green, float blue, float transparency) {//function DestructableAddIndicatorBJ takes destructable whichDestructable, real red, real green, real blue, real transparency returns nothing
			AddIndicator(whichDestructable, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call AddIndicator(whichDestructable, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void ItemAddIndicatorBJ(item whichItem, float red, float green, float blue, float transparency) {//function ItemAddIndicatorBJ takes item whichItem, real red, real green, real blue, real transparency returns nothing
			AddIndicator(whichItem, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call AddIndicator(whichItem, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		//
		//
		private void SetUnitFacingToFaceLocTimed(unit whichUnit, location target, float duration) {//function SetUnitFacingToFaceLocTimed takes unit whichUnit, location target, real duration returns nothing
			location unitLoc = GetUnitLoc(whichUnit);//local location unitLoc = GetUnitLoc(whichUnit)
			SetUnitFacingTimed(whichUnit, AngleBetweenPoints(unitLoc, target), duration);//call SetUnitFacingTimed(whichUnit, AngleBetweenPoints(unitLoc, target), duration)
			RemoveLocation(unitLoc);//call RemoveLocation(unitLoc)
		}//endfunction
		//
		//
		//
		private void SetUnitFacingToFaceUnitTimed(unit whichUnit, unit target, float duration) {//function SetUnitFacingToFaceUnitTimed takes unit whichUnit, unit target, real duration returns nothing
			location unitLoc = GetUnitLoc(target);//local location unitLoc = GetUnitLoc(target)
			SetUnitFacingToFaceLocTimed(whichUnit, unitLoc, duration);//call SetUnitFacingToFaceLocTimed(whichUnit, unitLoc, duration)
			RemoveLocation(unitLoc);//call RemoveLocation(unitLoc)
		}//endfunction
		//
		private void QueueUnitAnimationBJ(unit whichUnit, string whichAnimation) {//function QueueUnitAnimationBJ takes unit whichUnit, string whichAnimation returns nothing
			QueueUnitAnimation(whichUnit, whichAnimation);//call QueueUnitAnimation(whichUnit, whichAnimation)
		}//endfunction
		//
		private void SetDestructableAnimationBJ(destructable d, string whichAnimation) {//function SetDestructableAnimationBJ takes destructable d, string whichAnimation returns nothing
			SetDestructableAnimation(d, whichAnimation);//call SetDestructableAnimation(d, whichAnimation)
		}//endfunction
		//
		private void QueueDestructableAnimationBJ(destructable d, string whichAnimation) {//function QueueDestructableAnimationBJ takes destructable d, string whichAnimation returns nothing
			QueueDestructableAnimation(d, whichAnimation);//call QueueDestructableAnimation(d, whichAnimation)
		}//endfunction
		//
		private void SetDestAnimationSpeedPercent(destructable d, float percentScale) {//function SetDestAnimationSpeedPercent takes destructable d, real percentScale returns nothing
			SetDestructableAnimationSpeed(d, percentScale * 0.01);//call SetDestructableAnimationSpeed(d, percentScale * 0.01)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void DialogDisplayBJ(bool flag, dialog whichDialog, player whichPlayer) {//function DialogDisplayBJ takes boolean flag, dialog whichDialog, player whichPlayer returns nothing
			DialogDisplay(whichPlayer, whichDialog, flag);//call DialogDisplay(whichPlayer, whichDialog, flag)
		}//endfunction
		//
		private void DialogSetMessageBJ(dialog whichDialog, string message) {//function DialogSetMessageBJ takes dialog whichDialog, string message returns nothing
			DialogSetMessage(whichDialog, message);//call DialogSetMessage(whichDialog, message)
		}//endfunction
		//
		private button DialogAddButtonBJ(dialog whichDialog, string buttonText) {//function DialogAddButtonBJ takes dialog whichDialog, string buttonText returns button
			bj_lastCreatedButton = DialogAddButton(whichDialog, buttonText,0);//set bj_lastCreatedButton = DialogAddButton(whichDialog, buttonText,0)
			return bj_lastCreatedButton;//return bj_lastCreatedButton
		}//endfunction
		//
		private button DialogAddButtonWithHotkeyBJ(dialog whichDialog, string buttonText, int hotkey) {//function DialogAddButtonWithHotkeyBJ takes dialog whichDialog, string buttonText, integer hotkey returns button
			bj_lastCreatedButton = DialogAddButton(whichDialog, buttonText,hotkey);//set bj_lastCreatedButton = DialogAddButton(whichDialog, buttonText,hotkey)
			return bj_lastCreatedButton;//return bj_lastCreatedButton
		}//endfunction
		//
		private void DialogClearBJ(dialog whichDialog) {//function DialogClearBJ takes dialog whichDialog returns nothing
			DialogClear(whichDialog);//call DialogClear(whichDialog)
		}//endfunction
		//
		private button GetLastCreatedButtonBJ() {//function GetLastCreatedButtonBJ takes nothing returns button
			return bj_lastCreatedButton;//return bj_lastCreatedButton
		}//endfunction
		//
		private button GetClickedButtonBJ() {//function GetClickedButtonBJ takes nothing returns button
			return GetClickedButton();//return GetClickedButton()
		}//endfunction
		//
		private dialog GetClickedDialogBJ() {//function GetClickedDialogBJ takes nothing returns dialog
			return GetClickedDialog();//return GetClickedDialog()
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void SetPlayerAllianceBJ(player sourcePlayer, alliancetype whichAllianceSetting, bool value, player otherPlayer) {//function SetPlayerAllianceBJ takes player sourcePlayer, alliancetype whichAllianceSetting, boolean value, player otherPlayer returns nothing
			//
			if ((sourcePlayer == otherPlayer)) {//if (sourcePlayer == otherPlayer) then
				return;//return
			}//endif
			SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);//call SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value)
		}//endfunction
		//
		//
		//
		private void SetPlayerAllianceStateAllyBJ(player sourcePlayer, player otherPlayer, bool flag) {//function SetPlayerAllianceStateAllyBJ takes player sourcePlayer, player otherPlayer, boolean flag returns nothing
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_PASSIVE,       flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_PASSIVE,       flag)
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_HELP_REQUEST,  flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_HELP_REQUEST,  flag)
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_HELP_RESPONSE, flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_HELP_RESPONSE, flag)
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_XP,     flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_XP,     flag)
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_SPELLS, flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_SPELLS, flag)
		}//endfunction
		//
		//
		//
		private void SetPlayerAllianceStateVisionBJ(player sourcePlayer, player otherPlayer, bool flag) {//function SetPlayerAllianceStateVisionBJ takes player sourcePlayer, player otherPlayer, boolean flag returns nothing
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_VISION, flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_VISION, flag)
		}//endfunction
		//
		//
		//
		private void SetPlayerAllianceStateControlBJ(player sourcePlayer, player otherPlayer, bool flag) {//function SetPlayerAllianceStateControlBJ takes player sourcePlayer, player otherPlayer, boolean flag returns nothing
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_CONTROL, flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_CONTROL, flag)
		}//endfunction
		//
		//
		//
		//
		private void SetPlayerAllianceStateFullControlBJ(player sourcePlayer, player otherPlayer, bool flag) {//function SetPlayerAllianceStateFullControlBJ takes player sourcePlayer, player otherPlayer, boolean flag returns nothing
			SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, flag);//call SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, flag)
		}//endfunction
		//
		private void SetPlayerAllianceStateBJ(player sourcePlayer, player otherPlayer, int allianceState) {//function SetPlayerAllianceStateBJ takes player sourcePlayer, player otherPlayer, integer allianceState returns nothing
			//
			if ((sourcePlayer == otherPlayer)) {//if (sourcePlayer == otherPlayer) then
				return;//return
			}//endif
			if (allianceState == bj_ALLIANCE_UNALLIED) {//if allianceState == bj_ALLIANCE_UNALLIED then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, false )
			} else if (allianceState == bj_ALLIANCE_UNALLIED_VISION) {//elseif allianceState == bj_ALLIANCE_UNALLIED_VISION then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, false )
			} else if (allianceState == bj_ALLIANCE_ALLIED) {//elseif allianceState == bj_ALLIANCE_ALLIED then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, false )
			} else if (allianceState == bj_ALLIANCE_ALLIED_VISION) {//elseif allianceState == bj_ALLIANCE_ALLIED_VISION then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, false )
			} else if (allianceState == bj_ALLIANCE_ALLIED_UNITS) {//elseif allianceState == bj_ALLIANCE_ALLIED_UNITS then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, false )
			} else if (allianceState == bj_ALLIANCE_ALLIED_ADVUNITS) {//elseif allianceState == bj_ALLIANCE_ALLIED_ADVUNITS then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, true  )
			} else if (allianceState == bj_ALLIANCE_NEUTRAL) {//elseif allianceState == bj_ALLIANCE_NEUTRAL then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, false )
				SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_PASSIVE, true);//call SetPlayerAlliance( sourcePlayer, otherPlayer, ALLIANCE_PASSIVE, true )
			} else if (allianceState == bj_ALLIANCE_NEUTRAL_VISION) {//elseif allianceState == bj_ALLIANCE_NEUTRAL_VISION then
				SetPlayerAllianceStateAllyBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateAllyBJ(        sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateVisionBJ(sourcePlayer, otherPlayer, true);//call SetPlayerAllianceStateVisionBJ(      sourcePlayer, otherPlayer, true  )
				SetPlayerAllianceStateControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateControlBJ(     sourcePlayer, otherPlayer, false )
				SetPlayerAllianceStateFullControlBJ(sourcePlayer, otherPlayer, false);//call SetPlayerAllianceStateFullControlBJ( sourcePlayer, otherPlayer, false )
				SetPlayerAlliance(sourcePlayer, otherPlayer, ALLIANCE_PASSIVE, true);//call SetPlayerAlliance( sourcePlayer, otherPlayer, ALLIANCE_PASSIVE, true )
			} else {//else
				//
			}//endif
		}//endfunction
		//
		//
		//
		private void SetForceAllianceStateBJ(force sourceForce, force targetForce, int allianceState) {//function SetForceAllianceStateBJ takes force sourceForce, force targetForce, integer allianceState returns nothing
			int sourceIndex;//local integer sourceIndex
			int targetIndex;//local integer targetIndex
			sourceIndex = 0;//set sourceIndex = 0
			while (true) {//loop
				if ((sourceForce==bj_FORCE_ALL_PLAYERS || IsPlayerInForce(Player(sourceIndex), sourceForce))) {//if (sourceForce==bj_FORCE_ALL_PLAYERS or IsPlayerInForce(Player(sourceIndex), sourceForce)) then
					targetIndex = 0;//set targetIndex = 0
					while (true) {//loop
						if ((targetForce==bj_FORCE_ALL_PLAYERS || IsPlayerInForce(Player(targetIndex), targetForce))) {//if (targetForce==bj_FORCE_ALL_PLAYERS or IsPlayerInForce(Player(targetIndex), targetForce)) then
							SetPlayerAllianceStateBJ(Player(sourceIndex), Player(targetIndex), allianceState);//call SetPlayerAllianceStateBJ(Player(sourceIndex), Player(targetIndex), allianceState)
						}//endif
						targetIndex = targetIndex + 1;//set targetIndex = targetIndex + 1
						if (targetIndex == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen targetIndex == bj_MAX_PLAYER_SLOTS
					}//endloop
				}//endif
				sourceIndex = sourceIndex + 1;//set sourceIndex = sourceIndex + 1
				if (sourceIndex == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen sourceIndex == bj_MAX_PLAYER_SLOTS
			}//endloop
		}//endfunction
		//
		//
		//
		private bool PlayersAreCoAllied(player playerA, player playerB) {//function PlayersAreCoAllied takes player playerA, player playerB returns boolean
			//
			if ((playerA == playerB)) {//if (playerA == playerB) then
				return true;//return true
			}//endif
			//
			if (GetPlayerAlliance(playerA, playerB, ALLIANCE_PASSIVE)) {//if GetPlayerAlliance(playerA, playerB, ALLIANCE_PASSIVE) then
				if (GetPlayerAlliance(playerB, playerA, ALLIANCE_PASSIVE)) {//if GetPlayerAlliance(playerB, playerA, ALLIANCE_PASSIVE) then
					return true;//return true
				}//endif
			}//endif
			return false;//return false
		}//endfunction
		//
		//
		//
		//
		private void ShareEverythingWithTeamAI(player whichPlayer) {//function ShareEverythingWithTeamAI takes player whichPlayer returns nothing
			int playerIndex;//local integer playerIndex
			player indexPlayer;//local player  indexPlayer
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if ((PlayersAreCoAllied(whichPlayer, indexPlayer) && whichPlayer != indexPlayer)) {//if (PlayersAreCoAllied(whichPlayer, indexPlayer) and whichPlayer != indexPlayer) then
					if ((GetPlayerController(indexPlayer) == MAP_CONTROL_COMPUTER)) {//if (GetPlayerController(indexPlayer) == MAP_CONTROL_COMPUTER) then
						SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_VISION, true);//call SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_VISION, true)
						SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_CONTROL, true);//call SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_CONTROL, true)
						SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, true);//call SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, true)
					}//endif
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		private void ShareEverythingWithTeam(player whichPlayer) {//function ShareEverythingWithTeam takes player whichPlayer returns nothing
			int playerIndex;//local integer playerIndex
			player indexPlayer;//local player  indexPlayer
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if ((PlayersAreCoAllied(whichPlayer, indexPlayer) && whichPlayer != indexPlayer)) {//if (PlayersAreCoAllied(whichPlayer, indexPlayer) and whichPlayer != indexPlayer) then
					SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_VISION, true);//call SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_VISION, true)
					SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_CONTROL, true);//call SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_CONTROL, true)
					SetPlayerAlliance(indexPlayer, whichPlayer, ALLIANCE_SHARED_CONTROL, true);//call SetPlayerAlliance(indexPlayer, whichPlayer, ALLIANCE_SHARED_CONTROL, true)
					SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, true);//call SetPlayerAlliance(whichPlayer, indexPlayer, ALLIANCE_SHARED_ADVANCED_CONTROL, true)
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		//
		private void ConfigureNeutralVictim() {//function ConfigureNeutralVictim takes nothing returns nothing
			int index;//local integer index
			player indexPlayer;//local player indexPlayer
			player neutralVictim = Player(bj_PLAYER_NEUTRAL_VICTIM);//local player neutralVictim = Player(bj_PLAYER_NEUTRAL_VICTIM)
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				SetPlayerAlliance(neutralVictim, indexPlayer, ALLIANCE_PASSIVE, true);//call SetPlayerAlliance(neutralVictim, indexPlayer, ALLIANCE_PASSIVE, true)
				SetPlayerAlliance(indexPlayer, neutralVictim, ALLIANCE_PASSIVE, false);//call SetPlayerAlliance(indexPlayer, neutralVictim, ALLIANCE_PASSIVE, false)
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
			//
			indexPlayer = Player(PLAYER_NEUTRAL_AGGRESSIVE);//set indexPlayer = Player(PLAYER_NEUTRAL_AGGRESSIVE)
			SetPlayerAlliance(neutralVictim, indexPlayer, ALLIANCE_PASSIVE, true);//call SetPlayerAlliance(neutralVictim, indexPlayer, ALLIANCE_PASSIVE, true)
			SetPlayerAlliance(indexPlayer, neutralVictim, ALLIANCE_PASSIVE, true);//call SetPlayerAlliance(indexPlayer, neutralVictim, ALLIANCE_PASSIVE, true)
			//
			SetPlayerState(neutralVictim, PLAYER_STATE_GIVES_BOUNTY, 0);//call SetPlayerState(neutralVictim, PLAYER_STATE_GIVES_BOUNTY, 0)
		}//endfunction
		//
		private void MakeUnitsPassiveForPlayerEnum() {//function MakeUnitsPassiveForPlayerEnum takes nothing returns nothing
			SetUnitOwner(GetEnumUnit(), Player(bj_PLAYER_NEUTRAL_VICTIM), false);//call SetUnitOwner(GetEnumUnit(), Player(bj_PLAYER_NEUTRAL_VICTIM), false)
		}//endfunction
		//
		//
		//
		private void MakeUnitsPassiveForPlayer(player whichPlayer) {//function MakeUnitsPassiveForPlayer takes player whichPlayer returns nothing
			group playerUnits = CreateGroup();//local group   playerUnits = CreateGroup()
			CachePlayerHeroData(whichPlayer);//call CachePlayerHeroData(whichPlayer)
			GroupEnumUnitsOfPlayer(playerUnits, whichPlayer, null);//call GroupEnumUnitsOfPlayer(playerUnits, whichPlayer, null)
			ForGroup(playerUnits, function MakeUnitsPassiveForPlayerEnum);//call ForGroup(playerUnits, function MakeUnitsPassiveForPlayerEnum)
			DestroyGroup(playerUnits);//call DestroyGroup(playerUnits)
		}//endfunction
		//
		//
		//
		private void MakeUnitsPassiveForTeam(player whichPlayer) {//function MakeUnitsPassiveForTeam takes player whichPlayer returns nothing
			int playerIndex;//local integer playerIndex
			player indexPlayer;//local player  indexPlayer
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if (PlayersAreCoAllied(whichPlayer, indexPlayer)) {//if PlayersAreCoAllied(whichPlayer, indexPlayer) then
					MakeUnitsPassiveForPlayer(indexPlayer);//call MakeUnitsPassiveForPlayer(indexPlayer)
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		private bool AllowVictoryDefeat(playergameresult gameResult) {//function AllowVictoryDefeat takes playergameresult gameResult returns boolean
			if ((gameResult == PLAYER_GAME_RESULT_VICTORY)) {//if (gameResult == PLAYER_GAME_RESULT_VICTORY) then
				return !IsNoVictoryCheat();//return not IsNoVictoryCheat()
			}//endif
			if ((gameResult == PLAYER_GAME_RESULT_DEFEAT)) {//if (gameResult == PLAYER_GAME_RESULT_DEFEAT) then
				return !IsNoDefeatCheat();//return not IsNoDefeatCheat()
			}//endif
			if ((gameResult == PLAYER_GAME_RESULT_NEUTRAL)) {//if (gameResult == PLAYER_GAME_RESULT_NEUTRAL) then
				return (!IsNoVictoryCheat()) && (!IsNoDefeatCheat());//return (not IsNoVictoryCheat()) and (not IsNoDefeatCheat())
			}//endif
			return true;//return true
		}//endfunction
		//
		private void EndGameBJ() {//function EndGameBJ takes nothing returns nothing
			EndGame(true);//call EndGame( true )
		}//endfunction
		//
		private void MeleeVictoryDialogBJ(player whichPlayer, bool leftGame) {//function MeleeVictoryDialogBJ takes player whichPlayer, boolean leftGame returns nothing
			trigger t = CreateTrigger();//local trigger t = CreateTrigger()
			dialog d = DialogCreate();//local dialog  d = DialogCreate()
			string formatString;//local string formatString
			//
			if ((leftGame)) {//if (leftGame) then
				formatString = GetLocalizedString( "PLAYER_LEFT_GAME" );//set formatString = GetLocalizedString( "PLAYER_LEFT_GAME" )
			} else {//else
				formatString = GetLocalizedString( "PLAYER_VICTORIOUS" );//set formatString = GetLocalizedString( "PLAYER_VICTORIOUS" )
			}//endif
			DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, formatString);//call DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, formatString)
			DialogSetMessage(d, GetLocalizedString( "GAMEOVER_VICTORY_MSG" ));//call DialogSetMessage( d, GetLocalizedString( "GAMEOVER_VICTORY_MSG" ) )
			DialogAddButton(d, GetLocalizedString( "GAMEOVER_CONTINUE_GAME" ), GetLocalizedHotkey("GAMEOVER_CONTINUE_GAME"));//call DialogAddButton( d, GetLocalizedString( "GAMEOVER_CONTINUE_GAME" ), GetLocalizedHotkey("GAMEOVER_CONTINUE_GAME") )
			t = CreateTrigger();//set t = CreateTrigger()
			TriggerRegisterDialogButtonEvent(t, DialogAddQuitButton( d, true, GetLocalizedString( "GAMEOVER_QUIT_GAME" ), GetLocalizedHotkey("GAMEOVER_QUIT_GAME") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddQuitButton( d, true, GetLocalizedString( "GAMEOVER_QUIT_GAME" ), GetLocalizedHotkey("GAMEOVER_QUIT_GAME") ) )
			DialogDisplay(whichPlayer, d, true);//call DialogDisplay( whichPlayer, d, true )
			StartSoundForPlayerBJ(whichPlayer, bj_victoryDialogSound);//call StartSoundForPlayerBJ( whichPlayer, bj_victoryDialogSound )
		}//endfunction
		//
		private void MeleeDefeatDialogBJ(player whichPlayer, bool leftGame) {//function MeleeDefeatDialogBJ takes player whichPlayer, boolean leftGame returns nothing
			trigger t = CreateTrigger();//local trigger t = CreateTrigger()
			dialog d = DialogCreate();//local dialog  d = DialogCreate()
			string formatString;//local string formatString
			//
			if ((leftGame)) {//if (leftGame) then
				formatString = GetLocalizedString( "PLAYER_LEFT_GAME" );//set formatString = GetLocalizedString( "PLAYER_LEFT_GAME" )
			} else {//else
				formatString = GetLocalizedString( "PLAYER_DEFEATED" );//set formatString = GetLocalizedString( "PLAYER_DEFEATED" )
			}//endif
			DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, formatString);//call DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, formatString)
			DialogSetMessage(d, GetLocalizedString( "GAMEOVER_DEFEAT_MSG" ));//call DialogSetMessage( d, GetLocalizedString( "GAMEOVER_DEFEAT_MSG" ) )
			//
			if ((!bj_meleeGameOver && IsMapFlagSet(MAP_OBSERVERS_ON_DEATH))) {//if (not bj_meleeGameOver and IsMapFlagSet(MAP_OBSERVERS_ON_DEATH)) then
				DialogAddButton(d, GetLocalizedString( "GAMEOVER_CONTINUE_OBSERVING" ), GetLocalizedHotkey("GAMEOVER_CONTINUE_OBSERVING"));//call DialogAddButton( d, GetLocalizedString( "GAMEOVER_CONTINUE_OBSERVING" ), GetLocalizedHotkey("GAMEOVER_CONTINUE_OBSERVING") )
			}//endif
			t = CreateTrigger();//set t = CreateTrigger()
			TriggerRegisterDialogButtonEvent(t, DialogAddQuitButton( d, true, GetLocalizedString( "GAMEOVER_QUIT_GAME" ), GetLocalizedHotkey("GAMEOVER_QUIT_GAME") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddQuitButton( d, true, GetLocalizedString( "GAMEOVER_QUIT_GAME" ), GetLocalizedHotkey("GAMEOVER_QUIT_GAME") ) )
			DialogDisplay(whichPlayer, d, true);//call DialogDisplay( whichPlayer, d, true )
			StartSoundForPlayerBJ(whichPlayer, bj_defeatDialogSound);//call StartSoundForPlayerBJ( whichPlayer, bj_defeatDialogSound )
		}//endfunction
		//
		private void GameOverDialogBJ(player whichPlayer, bool leftGame) {//function GameOverDialogBJ takes player whichPlayer, boolean leftGame returns nothing
			trigger t = CreateTrigger();//local trigger t = CreateTrigger()
			dialog d = DialogCreate();//local dialog  d = DialogCreate()
			string s;//local string  s
			//
			DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString( "PLAYER_LEFT_GAME" ));//call DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString( "PLAYER_LEFT_GAME" ))
			if ((GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0)) {//if (GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0) then
				s = GetLocalizedString( "GAMEOVER_DISCONNECTED" );//set s = GetLocalizedString( "GAMEOVER_DISCONNECTED" )
			} else {//else
				s = GetLocalizedString( "GAMEOVER_GAME_OVER" );//set s = GetLocalizedString( "GAMEOVER_GAME_OVER" )
			}//endif
			DialogSetMessage(d, s);//call DialogSetMessage( d, s )
			t = CreateTrigger();//set t = CreateTrigger()
			TriggerRegisterDialogButtonEvent(t, DialogAddQuitButton( d, true, GetLocalizedString( "GAMEOVER_OK" ), GetLocalizedHotkey("GAMEOVER_OK") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddQuitButton( d, true, GetLocalizedString( "GAMEOVER_OK" ), GetLocalizedHotkey("GAMEOVER_OK") ) )
			DialogDisplay(whichPlayer, d, true);//call DialogDisplay( whichPlayer, d, true )
			StartSoundForPlayerBJ(whichPlayer, bj_defeatDialogSound);//call StartSoundForPlayerBJ( whichPlayer, bj_defeatDialogSound )
		}//endfunction
		//
		private void RemovePlayerPreserveUnitsBJ(player whichPlayer, playergameresult gameResult, bool leftGame) {//function RemovePlayerPreserveUnitsBJ takes player whichPlayer, playergameresult gameResult, boolean leftGame returns nothing
			if (AllowVictoryDefeat(gameResult)) {//if AllowVictoryDefeat(gameResult) then
				RemovePlayer(whichPlayer, gameResult);//call RemovePlayer(whichPlayer, gameResult)
				if (( gameResult == PLAYER_GAME_RESULT_VICTORY )) {//if( gameResult == PLAYER_GAME_RESULT_VICTORY ) then
					MeleeVictoryDialogBJ(whichPlayer, leftGame);//call MeleeVictoryDialogBJ( whichPlayer, leftGame )
					return;//return
				} else if (( gameResult == PLAYER_GAME_RESULT_DEFEAT )) {//elseif( gameResult == PLAYER_GAME_RESULT_DEFEAT ) then
					MeleeDefeatDialogBJ(whichPlayer, leftGame);//call MeleeDefeatDialogBJ( whichPlayer, leftGame )
				} else {//else
					GameOverDialogBJ(whichPlayer, leftGame);//call GameOverDialogBJ( whichPlayer, leftGame )
				}//endif
			}//endif
		}//endfunction
		//
		private void CustomVictoryOkBJ() {//function CustomVictoryOkBJ takes nothing returns nothing
			if (bj_isSinglePlayer) {//if bj_isSinglePlayer then
				PauseGame(false);//call PauseGame( false )
				//
				SetGameDifficulty(GetDefaultDifficulty());//call SetGameDifficulty(GetDefaultDifficulty())
			}//endif
			if ((bj_changeLevelMapName == null)) {//if (bj_changeLevelMapName == null) then
				EndGame(bj_changeLevelShowScores);//call EndGame( bj_changeLevelShowScores )
			} else {//else
				ChangeLevel(bj_changeLevelMapName, bj_changeLevelShowScores);//call ChangeLevel( bj_changeLevelMapName, bj_changeLevelShowScores )
			}//endif
		}//endfunction
		//
		private void CustomVictoryQuitBJ() {//function CustomVictoryQuitBJ takes nothing returns nothing
			if (bj_isSinglePlayer) {//if bj_isSinglePlayer then
				PauseGame(false);//call PauseGame( false )
				//
				SetGameDifficulty(GetDefaultDifficulty());//call SetGameDifficulty(GetDefaultDifficulty())
			}//endif
			EndGame(bj_changeLevelShowScores);//call EndGame( bj_changeLevelShowScores )
		}//endfunction
		//
		private void CustomVictoryDialogBJ(player whichPlayer) {//function CustomVictoryDialogBJ takes player whichPlayer returns nothing
			trigger t = CreateTrigger();//local trigger t = CreateTrigger()
			dialog d = DialogCreate();//local dialog  d = DialogCreate()
			DialogSetMessage(d, GetLocalizedString( "GAMEOVER_VICTORY_MSG" ));//call DialogSetMessage( d, GetLocalizedString( "GAMEOVER_VICTORY_MSG" ) )
			t = CreateTrigger();//set t = CreateTrigger()
			TriggerRegisterDialogButtonEvent(t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_CONTINUE" ), GetLocalizedHotkey("GAMEOVER_CONTINUE") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_CONTINUE" ), GetLocalizedHotkey("GAMEOVER_CONTINUE") ) )
			TriggerAddAction(t, function CustomVictoryOkBJ);//call TriggerAddAction( t, function CustomVictoryOkBJ )
			t = CreateTrigger();//set t = CreateTrigger()
			TriggerRegisterDialogButtonEvent(t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_QUIT_MISSION" ), GetLocalizedHotkey("GAMEOVER_QUIT_MISSION") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_QUIT_MISSION" ), GetLocalizedHotkey("GAMEOVER_QUIT_MISSION") ) )
			TriggerAddAction(t, function CustomVictoryQuitBJ);//call TriggerAddAction( t, function CustomVictoryQuitBJ )
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				EnableUserControl(true);//call EnableUserControl( true )
				if (bj_isSinglePlayer) {//if bj_isSinglePlayer then
					PauseGame(true);//call PauseGame( true )
				}//endif
				EnableUserUI(false);//call EnableUserUI(false)
			}//endif
			DialogDisplay(whichPlayer, d, true);//call DialogDisplay( whichPlayer, d, true )
			VolumeGroupSetVolumeForPlayerBJ(whichPlayer, SOUND_VOLUMEGROUP_UI, 1.0);//call VolumeGroupSetVolumeForPlayerBJ( whichPlayer, SOUND_VOLUMEGROUP_UI, 1.0 )
			StartSoundForPlayerBJ(whichPlayer, bj_victoryDialogSound);//call StartSoundForPlayerBJ( whichPlayer, bj_victoryDialogSound )
		}//endfunction
		//
		private void CustomVictorySkipBJ(player whichPlayer) {//function CustomVictorySkipBJ takes player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				if (bj_isSinglePlayer) {//if bj_isSinglePlayer then
					//
					SetGameDifficulty(GetDefaultDifficulty());//call SetGameDifficulty(GetDefaultDifficulty())
				}//endif
				if ((bj_changeLevelMapName == null)) {//if (bj_changeLevelMapName == null) then
					EndGame(bj_changeLevelShowScores);//call EndGame( bj_changeLevelShowScores )
				} else {//else
					ChangeLevel(bj_changeLevelMapName, bj_changeLevelShowScores);//call ChangeLevel( bj_changeLevelMapName, bj_changeLevelShowScores )
				}//endif
			}//endif
		}//endfunction
		//
		private void CustomVictoryBJ(player whichPlayer, bool showDialog, bool showScores) {//function CustomVictoryBJ takes player whichPlayer, boolean showDialog, boolean showScores returns nothing
			if (AllowVictoryDefeat( PLAYER_GAME_RESULT_VICTORY )) {//if AllowVictoryDefeat( PLAYER_GAME_RESULT_VICTORY ) then
				RemovePlayer(whichPlayer, PLAYER_GAME_RESULT_VICTORY);//call RemovePlayer( whichPlayer, PLAYER_GAME_RESULT_VICTORY )
				if (!bj_isSinglePlayer) {//if not bj_isSinglePlayer then
					DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString( "PLAYER_VICTORIOUS" ));//call DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString( "PLAYER_VICTORIOUS" ) )
				}//endif
				//
				if ((GetPlayerController(whichPlayer) == MAP_CONTROL_USER)) {//if (GetPlayerController(whichPlayer) == MAP_CONTROL_USER) then
					bj_changeLevelShowScores = showScores;//set bj_changeLevelShowScores = showScores
					if (showDialog) {//if showDialog then
						CustomVictoryDialogBJ(whichPlayer);//call CustomVictoryDialogBJ( whichPlayer )
					} else {//else
						CustomVictorySkipBJ(whichPlayer);//call CustomVictorySkipBJ( whichPlayer )
					}//endif
				}//endif
			}//endif
		}//endfunction
		//
		private void CustomDefeatRestartBJ() {//function CustomDefeatRestartBJ takes nothing returns nothing
			PauseGame(false);//call PauseGame( false )
			RestartGame(true);//call RestartGame( true )
		}//endfunction
		//
		private void CustomDefeatReduceDifficultyBJ() {//function CustomDefeatReduceDifficultyBJ takes nothing returns nothing
			gamedifficulty diff = GetGameDifficulty();//local gamedifficulty diff = GetGameDifficulty()
			PauseGame(false);//call PauseGame( false )
			//
			if ((diff == MAP_DIFFICULTY_EASY)) {//if (diff == MAP_DIFFICULTY_EASY) then
				//
			} else if ((diff == MAP_DIFFICULTY_NORMAL)) {//elseif (diff == MAP_DIFFICULTY_NORMAL) then
				SetGameDifficulty(MAP_DIFFICULTY_EASY);//call SetGameDifficulty(MAP_DIFFICULTY_EASY)
			} else if ((diff == MAP_DIFFICULTY_HARD)) {//elseif (diff == MAP_DIFFICULTY_HARD) then
				SetGameDifficulty(MAP_DIFFICULTY_NORMAL);//call SetGameDifficulty(MAP_DIFFICULTY_NORMAL)
			} else {//else
				//
			}//endif
			RestartGame(true);//call RestartGame( true )
		}//endfunction
		//
		private void CustomDefeatLoadBJ() {//function CustomDefeatLoadBJ takes nothing returns nothing
			PauseGame(false);//call PauseGame( false )
			DisplayLoadDialog();//call DisplayLoadDialog()
		}//endfunction
		//
		private void CustomDefeatQuitBJ() {//function CustomDefeatQuitBJ takes nothing returns nothing
			if (bj_isSinglePlayer) {//if bj_isSinglePlayer then
				PauseGame(false);//call PauseGame( false )
			}//endif
			//
			SetGameDifficulty(GetDefaultDifficulty());//call SetGameDifficulty(GetDefaultDifficulty())
			EndGame(true);//call EndGame( true )
		}//endfunction
		//
		private void CustomDefeatDialogBJ(player whichPlayer, string message) {//function CustomDefeatDialogBJ takes player whichPlayer, string message returns nothing
			trigger t = CreateTrigger();//local trigger t = CreateTrigger()
			dialog d = DialogCreate();//local dialog  d = DialogCreate()
			DialogSetMessage(d, message);//call DialogSetMessage( d, message )
			if (bj_isSinglePlayer) {//if bj_isSinglePlayer then
				t = CreateTrigger();//set t = CreateTrigger()
				TriggerRegisterDialogButtonEvent(t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_RESTART" ), GetLocalizedHotkey("GAMEOVER_RESTART") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_RESTART" ), GetLocalizedHotkey("GAMEOVER_RESTART") ) )
				TriggerAddAction(t, function CustomDefeatRestartBJ);//call TriggerAddAction( t, function CustomDefeatRestartBJ )
				if ((GetGameDifficulty() != MAP_DIFFICULTY_EASY)) {//if (GetGameDifficulty() != MAP_DIFFICULTY_EASY) then
					t = CreateTrigger();//set t = CreateTrigger()
					TriggerRegisterDialogButtonEvent(t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_REDUCE_DIFFICULTY" ), GetLocalizedHotkey("GAMEOVER_REDUCE_DIFFICULTY") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_REDUCE_DIFFICULTY" ), GetLocalizedHotkey("GAMEOVER_REDUCE_DIFFICULTY") ) )
					TriggerAddAction(t, function CustomDefeatReduceDifficultyBJ);//call TriggerAddAction( t, function CustomDefeatReduceDifficultyBJ )
				}//endif
				t = CreateTrigger();//set t = CreateTrigger()
				TriggerRegisterDialogButtonEvent(t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_LOAD" ), GetLocalizedHotkey("GAMEOVER_LOAD") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_LOAD" ), GetLocalizedHotkey("GAMEOVER_LOAD") ) )
				TriggerAddAction(t, function CustomDefeatLoadBJ);//call TriggerAddAction( t, function CustomDefeatLoadBJ )
			}//endif
			t = CreateTrigger();//set t = CreateTrigger()
			TriggerRegisterDialogButtonEvent(t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_QUIT_MISSION" ), GetLocalizedHotkey("GAMEOVER_QUIT_MISSION") ));//call TriggerRegisterDialogButtonEvent( t, DialogAddButton( d, GetLocalizedString( "GAMEOVER_QUIT_MISSION" ), GetLocalizedHotkey("GAMEOVER_QUIT_MISSION") ) )
			TriggerAddAction(t, function CustomDefeatQuitBJ);//call TriggerAddAction( t, function CustomDefeatQuitBJ )
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				EnableUserControl(true);//call EnableUserControl( true )
				if (bj_isSinglePlayer) {//if bj_isSinglePlayer then
					PauseGame(true);//call PauseGame( true )
				}//endif
				EnableUserUI(false);//call EnableUserUI(false)
			}//endif
			DialogDisplay(whichPlayer, d, true);//call DialogDisplay( whichPlayer, d, true )
			VolumeGroupSetVolumeForPlayerBJ(whichPlayer, SOUND_VOLUMEGROUP_UI, 1.0);//call VolumeGroupSetVolumeForPlayerBJ( whichPlayer, SOUND_VOLUMEGROUP_UI, 1.0 )
			StartSoundForPlayerBJ(whichPlayer, bj_defeatDialogSound);//call StartSoundForPlayerBJ( whichPlayer, bj_defeatDialogSound )
		}//endfunction
		//
		private void CustomDefeatBJ(player whichPlayer, string message) {//function CustomDefeatBJ takes player whichPlayer, string message returns nothing
			if (AllowVictoryDefeat( PLAYER_GAME_RESULT_DEFEAT )) {//if AllowVictoryDefeat( PLAYER_GAME_RESULT_DEFEAT ) then
				RemovePlayer(whichPlayer, PLAYER_GAME_RESULT_DEFEAT);//call RemovePlayer( whichPlayer, PLAYER_GAME_RESULT_DEFEAT )
				if (!bj_isSinglePlayer) {//if not bj_isSinglePlayer then
					DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString( "PLAYER_DEFEATED" ));//call DisplayTimedTextFromPlayer(whichPlayer, 0, 0, 60, GetLocalizedString( "PLAYER_DEFEATED" ) )
				}//endif
				//
				if ((GetPlayerController(whichPlayer) == MAP_CONTROL_USER)) {//if (GetPlayerController(whichPlayer) == MAP_CONTROL_USER) then
					CustomDefeatDialogBJ(whichPlayer, message);//call CustomDefeatDialogBJ( whichPlayer, message )
				}//endif
			}//endif
		}//endfunction
		//
		private void SetNextLevelBJ(string nextLevel) {//function SetNextLevelBJ takes string nextLevel returns nothing
			if ((nextLevel == "")) {//if (nextLevel == "") then
				bj_changeLevelMapName = null;//set bj_changeLevelMapName = null
			} else {//else
				bj_changeLevelMapName = nextLevel;//set bj_changeLevelMapName = nextLevel
			}//endif
		}//endfunction
		//
		private void SetPlayerOnScoreScreenBJ(bool flag, player whichPlayer) {//function SetPlayerOnScoreScreenBJ takes boolean flag, player whichPlayer returns nothing
			SetPlayerOnScoreScreen(whichPlayer, flag);//call SetPlayerOnScoreScreen(whichPlayer, flag)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private quest CreateQuestBJ(int questType, string title, string description, string iconPath) {//function CreateQuestBJ takes integer questType, string title, string description, string iconPath returns quest
			bool required = (questType == bj_QUESTTYPE_REQ_DISCOVERED) || (questType == bj_QUESTTYPE_REQ_UNDISCOVERED);//local boolean required   = (questType == bj_QUESTTYPE_REQ_DISCOVERED) or (questType == bj_QUESTTYPE_REQ_UNDISCOVERED)
			bool discovered = (questType == bj_QUESTTYPE_REQ_DISCOVERED) || (questType == bj_QUESTTYPE_OPT_DISCOVERED);//local boolean discovered = (questType == bj_QUESTTYPE_REQ_DISCOVERED) or (questType == bj_QUESTTYPE_OPT_DISCOVERED)
			bj_lastCreatedQuest = CreateQuest();//set bj_lastCreatedQuest = CreateQuest()
			QuestSetTitle(bj_lastCreatedQuest, title);//call QuestSetTitle(bj_lastCreatedQuest, title)
			QuestSetDescription(bj_lastCreatedQuest, description);//call QuestSetDescription(bj_lastCreatedQuest, description)
			QuestSetIconPath(bj_lastCreatedQuest, iconPath);//call QuestSetIconPath(bj_lastCreatedQuest, iconPath)
			QuestSetRequired(bj_lastCreatedQuest, required);//call QuestSetRequired(bj_lastCreatedQuest, required)
			QuestSetDiscovered(bj_lastCreatedQuest, discovered);//call QuestSetDiscovered(bj_lastCreatedQuest, discovered)
			QuestSetCompleted(bj_lastCreatedQuest, false);//call QuestSetCompleted(bj_lastCreatedQuest, false)
			return bj_lastCreatedQuest;//return bj_lastCreatedQuest
		}//endfunction
		//
		private void DestroyQuestBJ(quest whichQuest) {//function DestroyQuestBJ takes quest whichQuest returns nothing
			DestroyQuest(whichQuest);//call DestroyQuest(whichQuest)
		}//endfunction
		//
		private void QuestSetEnabledBJ(bool enabled, quest whichQuest) {//function QuestSetEnabledBJ takes boolean enabled, quest whichQuest returns nothing
			QuestSetEnabled(whichQuest, enabled);//call QuestSetEnabled(whichQuest, enabled)
		}//endfunction
		//
		private void QuestSetTitleBJ(quest whichQuest, string title) {//function QuestSetTitleBJ takes quest whichQuest, string title returns nothing
			QuestSetTitle(whichQuest, title);//call QuestSetTitle(whichQuest, title)
		}//endfunction
		//
		private void QuestSetDescriptionBJ(quest whichQuest, string description) {//function QuestSetDescriptionBJ takes quest whichQuest, string description returns nothing
			QuestSetDescription(whichQuest, description);//call QuestSetDescription(whichQuest, description)
		}//endfunction
		//
		private void QuestSetCompletedBJ(quest whichQuest, bool completed) {//function QuestSetCompletedBJ takes quest whichQuest, boolean completed returns nothing
			QuestSetCompleted(whichQuest, completed);//call QuestSetCompleted(whichQuest, completed)
		}//endfunction
		//
		private void QuestSetFailedBJ(quest whichQuest, bool failed) {//function QuestSetFailedBJ takes quest whichQuest, boolean failed returns nothing
			QuestSetFailed(whichQuest, failed);//call QuestSetFailed(whichQuest, failed)
		}//endfunction
		//
		private void QuestSetDiscoveredBJ(quest whichQuest, bool discovered) {//function QuestSetDiscoveredBJ takes quest whichQuest, boolean discovered returns nothing
			QuestSetDiscovered(whichQuest, discovered);//call QuestSetDiscovered(whichQuest, discovered)
		}//endfunction
		//
		private quest GetLastCreatedQuestBJ() {//function GetLastCreatedQuestBJ takes nothing returns quest
			return bj_lastCreatedQuest;//return bj_lastCreatedQuest
		}//endfunction
		//
		private questitem CreateQuestItemBJ(quest whichQuest, string description) {//function CreateQuestItemBJ takes quest whichQuest, string description returns questitem
			bj_lastCreatedQuestItem = QuestCreateItem(whichQuest);//set bj_lastCreatedQuestItem = QuestCreateItem(whichQuest)
			QuestItemSetDescription(bj_lastCreatedQuestItem, description);//call QuestItemSetDescription(bj_lastCreatedQuestItem, description)
			QuestItemSetCompleted(bj_lastCreatedQuestItem, false);//call QuestItemSetCompleted(bj_lastCreatedQuestItem, false)
			return bj_lastCreatedQuestItem;//return bj_lastCreatedQuestItem
		}//endfunction
		//
		private void QuestItemSetDescriptionBJ(questitem whichQuestItem, string description) {//function QuestItemSetDescriptionBJ takes questitem whichQuestItem, string description returns nothing
			QuestItemSetDescription(whichQuestItem, description);//call QuestItemSetDescription(whichQuestItem, description)
		}//endfunction
		//
		private void QuestItemSetCompletedBJ(questitem whichQuestItem, bool completed) {//function QuestItemSetCompletedBJ takes questitem whichQuestItem, boolean completed returns nothing
			QuestItemSetCompleted(whichQuestItem, completed);//call QuestItemSetCompleted(whichQuestItem, completed)
		}//endfunction
		//
		private questitem GetLastCreatedQuestItemBJ() {//function GetLastCreatedQuestItemBJ takes nothing returns questitem
			return bj_lastCreatedQuestItem;//return bj_lastCreatedQuestItem
		}//endfunction
		//
		private defeatcondition CreateDefeatConditionBJ(string description) {//function CreateDefeatConditionBJ takes string description returns defeatcondition
			bj_lastCreatedDefeatCondition = CreateDefeatCondition();//set bj_lastCreatedDefeatCondition = CreateDefeatCondition()
			DefeatConditionSetDescription(bj_lastCreatedDefeatCondition, description);//call DefeatConditionSetDescription(bj_lastCreatedDefeatCondition, description)
			return bj_lastCreatedDefeatCondition;//return bj_lastCreatedDefeatCondition
		}//endfunction
		//
		private void DestroyDefeatConditionBJ(defeatcondition whichCondition) {//function DestroyDefeatConditionBJ takes defeatcondition whichCondition returns nothing
			DestroyDefeatCondition(whichCondition);//call DestroyDefeatCondition(whichCondition)
		}//endfunction
		//
		private void DefeatConditionSetDescriptionBJ(defeatcondition whichCondition, string description) {//function DefeatConditionSetDescriptionBJ takes defeatcondition whichCondition, string description returns nothing
			DefeatConditionSetDescription(whichCondition, description);//call DefeatConditionSetDescription(whichCondition, description)
		}//endfunction
		//
		private defeatcondition GetLastCreatedDefeatConditionBJ() {//function GetLastCreatedDefeatConditionBJ takes nothing returns defeatcondition
			return bj_lastCreatedDefeatCondition;//return bj_lastCreatedDefeatCondition
		}//endfunction
		//
		private void FlashQuestDialogButtonBJ() {//function FlashQuestDialogButtonBJ takes nothing returns nothing
			FlashQuestDialogButton();//call FlashQuestDialogButton()
		}//endfunction
		//
		private void QuestMessageBJ(force f, int messageType, string message) {//function QuestMessageBJ takes force f, integer messageType, string message returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), f))) {//if (IsPlayerInForce(GetLocalPlayer(), f)) then
				//
				if ((messageType == bj_QUESTMESSAGE_DISCOVERED)) {//if (messageType == bj_QUESTMESSAGE_DISCOVERED) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUEST, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUEST, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUEST, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUEST, message)
					StartSound(bj_questDiscoveredSound);//call StartSound(bj_questDiscoveredSound)
					FlashQuestDialogButton();//call FlashQuestDialogButton()
				} else if ((messageType == bj_QUESTMESSAGE_UPDATED)) {//elseif (messageType == bj_QUESTMESSAGE_UPDATED) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTUPDATE, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTUPDATE, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTUPDATE, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTUPDATE, message)
					StartSound(bj_questUpdatedSound);//call StartSound(bj_questUpdatedSound)
					FlashQuestDialogButton();//call FlashQuestDialogButton()
				} else if ((messageType == bj_QUESTMESSAGE_COMPLETED)) {//elseif (messageType == bj_QUESTMESSAGE_COMPLETED) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTDONE, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTDONE, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTDONE, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTDONE, message)
					StartSound(bj_questCompletedSound);//call StartSound(bj_questCompletedSound)
					FlashQuestDialogButton();//call FlashQuestDialogButton()
				} else if ((messageType == bj_QUESTMESSAGE_FAILED)) {//elseif (messageType == bj_QUESTMESSAGE_FAILED) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTFAILED, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTFAILED, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTFAILED, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTFAILED, message)
					StartSound(bj_questFailedSound);//call StartSound(bj_questFailedSound)
					FlashQuestDialogButton();//call FlashQuestDialogButton()
				} else if ((messageType == bj_QUESTMESSAGE_REQUIREMENT)) {//elseif (messageType == bj_QUESTMESSAGE_REQUIREMENT) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTREQUIREMENT, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_QUESTREQUIREMENT, message)
				} else if ((messageType == bj_QUESTMESSAGE_MISSIONFAILED)) {//elseif (messageType == bj_QUESTMESSAGE_MISSIONFAILED) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_MISSIONFAILED, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_MISSIONFAILED, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_MISSIONFAILED, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_MISSIONFAILED, message)
					StartSound(bj_questFailedSound);//call StartSound(bj_questFailedSound)
				} else if ((messageType == bj_QUESTMESSAGE_HINT)) {//elseif (messageType == bj_QUESTMESSAGE_HINT) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_HINT, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_HINT, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_HINT, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_HINT, message)
					StartSound(bj_questHintSound);//call StartSound(bj_questHintSound)
				} else if ((messageType == bj_QUESTMESSAGE_ALWAYSHINT)) {//elseif (messageType == bj_QUESTMESSAGE_ALWAYSHINT) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ALWAYSHINT, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ALWAYSHINT, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ALWAYSHINT, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ALWAYSHINT, message)
					StartSound(bj_questHintSound);//call StartSound(bj_questHintSound)
				} else if ((messageType == bj_QUESTMESSAGE_SECRET)) {//elseif (messageType == bj_QUESTMESSAGE_SECRET) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_SECRET, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_SECRET, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_SECRET, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_SECRET, message)
					StartSound(bj_questSecretSound);//call StartSound(bj_questSecretSound)
				} else if ((messageType == bj_QUESTMESSAGE_UNITACQUIRED)) {//elseif (messageType == bj_QUESTMESSAGE_UNITACQUIRED) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITACQUIRED, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITACQUIRED, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITACQUIRED, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITACQUIRED, message)
					StartSound(bj_questHintSound);//call StartSound(bj_questHintSound)
				} else if ((messageType == bj_QUESTMESSAGE_UNITAVAILABLE)) {//elseif (messageType == bj_QUESTMESSAGE_UNITAVAILABLE) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITAVAILABLE, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITAVAILABLE, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITAVAILABLE, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_UNITAVAILABLE, message)
					StartSound(bj_questHintSound);//call StartSound(bj_questHintSound)
				} else if ((messageType == bj_QUESTMESSAGE_ITEMACQUIRED)) {//elseif (messageType == bj_QUESTMESSAGE_ITEMACQUIRED) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ITEMACQUIRED, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ITEMACQUIRED, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ITEMACQUIRED, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_ITEMACQUIRED, message)
					StartSound(bj_questItemAcquiredSound);//call StartSound(bj_questItemAcquiredSound)
				} else if ((messageType == bj_QUESTMESSAGE_WARNING)) {//elseif (messageType == bj_QUESTMESSAGE_WARNING) then
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_WARNING, " ");//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_WARNING, " ")
					DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_WARNING, message);//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_TEXT_DELAY_WARNING, message)
					StartSound(bj_questWarningSound);//call StartSound(bj_questWarningSound)
				} else {//else
					//
				}//endif
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private timer StartTimerBJ(timer t, bool periodic, float timeout) {//function StartTimerBJ takes timer t, boolean periodic, real timeout returns timer
			bj_lastStartedTimer = t;//set bj_lastStartedTimer = t
			TimerStart(t, timeout, periodic, null);//call TimerStart(t, timeout, periodic, null)
			return bj_lastStartedTimer;//return bj_lastStartedTimer
		}//endfunction
		//
		private timer CreateTimerBJ(bool periodic, float timeout) {//function CreateTimerBJ takes boolean periodic, real timeout returns timer
			bj_lastStartedTimer = CreateTimer();//set bj_lastStartedTimer = CreateTimer()
			TimerStart(bj_lastStartedTimer, timeout, periodic, null);//call TimerStart(bj_lastStartedTimer, timeout, periodic, null)
			return bj_lastStartedTimer;//return bj_lastStartedTimer
		}//endfunction
		//
		private void DestroyTimerBJ(timer whichTimer) {//function DestroyTimerBJ takes timer whichTimer returns nothing
			DestroyTimer(whichTimer);//call DestroyTimer(whichTimer)
		}//endfunction
		//
		private void PauseTimerBJ(bool pause, timer whichTimer) {//function PauseTimerBJ takes boolean pause, timer whichTimer returns nothing
			if (pause) {//if pause then
				PauseTimer(whichTimer);//call PauseTimer(whichTimer)
			} else {//else
				ResumeTimer(whichTimer);//call ResumeTimer(whichTimer)
			}//endif
		}//endfunction
		//
		private timer GetLastCreatedTimerBJ() {//function GetLastCreatedTimerBJ takes nothing returns timer
			return bj_lastStartedTimer;//return bj_lastStartedTimer
		}//endfunction
		//
		private timerdialog CreateTimerDialogBJ(timer t, string title) {//function CreateTimerDialogBJ takes timer t, string title returns timerdialog
			bj_lastCreatedTimerDialog = CreateTimerDialog(t);//set bj_lastCreatedTimerDialog = CreateTimerDialog(t)
			TimerDialogSetTitle(bj_lastCreatedTimerDialog, title);//call TimerDialogSetTitle(bj_lastCreatedTimerDialog, title)
			TimerDialogDisplay(bj_lastCreatedTimerDialog, true);//call TimerDialogDisplay(bj_lastCreatedTimerDialog, true)
			return bj_lastCreatedTimerDialog;//return bj_lastCreatedTimerDialog
		}//endfunction
		//
		private void DestroyTimerDialogBJ(timerdialog td) {//function DestroyTimerDialogBJ takes timerdialog td returns nothing
			DestroyTimerDialog(td);//call DestroyTimerDialog(td)
		}//endfunction
		//
		private void TimerDialogSetTitleBJ(timerdialog td, string title) {//function TimerDialogSetTitleBJ takes timerdialog td, string title returns nothing
			TimerDialogSetTitle(td, title);//call TimerDialogSetTitle(td, title)
		}//endfunction
		//
		private void TimerDialogSetTitleColorBJ(timerdialog td, float red, float green, float blue, float transparency) {//function TimerDialogSetTitleColorBJ takes timerdialog td, real red, real green, real blue, real transparency returns nothing
			TimerDialogSetTitleColor(td, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call TimerDialogSetTitleColor(td, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void TimerDialogSetTimeColorBJ(timerdialog td, float red, float green, float blue, float transparency) {//function TimerDialogSetTimeColorBJ takes timerdialog td, real red, real green, real blue, real transparency returns nothing
			TimerDialogSetTimeColor(td, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call TimerDialogSetTimeColor(td, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void TimerDialogSetSpeedBJ(timerdialog td, float speedMultFactor) {//function TimerDialogSetSpeedBJ takes timerdialog td, real speedMultFactor returns nothing
			TimerDialogSetSpeed(td, speedMultFactor);//call TimerDialogSetSpeed(td, speedMultFactor)
		}//endfunction
		//
		private void TimerDialogDisplayForPlayerBJ(bool show, timerdialog td, player whichPlayer) {//function TimerDialogDisplayForPlayerBJ takes boolean show, timerdialog td, player whichPlayer returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				TimerDialogDisplay(td, show);//call TimerDialogDisplay(td, show)
			}//endif
		}//endfunction
		//
		private void TimerDialogDisplayBJ(bool show, timerdialog td) {//function TimerDialogDisplayBJ takes boolean show, timerdialog td returns nothing
			TimerDialogDisplay(td, show);//call TimerDialogDisplay(td, show)
		}//endfunction
		//
		private timerdialog GetLastCreatedTimerDialogBJ() {//function GetLastCreatedTimerDialogBJ takes nothing returns timerdialog
			return bj_lastCreatedTimerDialog;//return bj_lastCreatedTimerDialog
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void LeaderboardResizeBJ(leaderboard lb) {//function LeaderboardResizeBJ takes leaderboard lb returns nothing
			int size = LeaderboardGetItemCount(lb);//local integer size = LeaderboardGetItemCount(lb)
			if ((LeaderboardGetLabelText(lb) == "")) {//if (LeaderboardGetLabelText(lb) == "") then
				size = size - 1;//set size = size - 1
			}//endif
			LeaderboardSetSizeByItemCount(lb, size);//call LeaderboardSetSizeByItemCount(lb, size)
		}//endfunction
		//
		private void LeaderboardSetPlayerItemValueBJ(player whichPlayer, leaderboard lb, int val) {//function LeaderboardSetPlayerItemValueBJ takes player whichPlayer, leaderboard lb, integer val returns nothing
			LeaderboardSetItemValue(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), val);//call LeaderboardSetItemValue(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), val)
		}//endfunction
		//
		private void LeaderboardSetPlayerItemLabelBJ(player whichPlayer, leaderboard lb, string val) {//function LeaderboardSetPlayerItemLabelBJ takes player whichPlayer, leaderboard lb, string val returns nothing
			LeaderboardSetItemLabel(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), val);//call LeaderboardSetItemLabel(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), val)
		}//endfunction
		//
		private void LeaderboardSetPlayerItemStyleBJ(player whichPlayer, leaderboard lb, bool showLabel, bool showValue, bool showIcon) {//function LeaderboardSetPlayerItemStyleBJ takes player whichPlayer, leaderboard lb, boolean showLabel, boolean showValue, boolean showIcon returns nothing
			LeaderboardSetItemStyle(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), showLabel, showValue, showIcon);//call LeaderboardSetItemStyle(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), showLabel, showValue, showIcon)
		}//endfunction
		//
		private void LeaderboardSetPlayerItemLabelColorBJ(player whichPlayer, leaderboard lb, float red, float green, float blue, float transparency) {//function LeaderboardSetPlayerItemLabelColorBJ takes player whichPlayer, leaderboard lb, real red, real green, real blue, real transparency returns nothing
			LeaderboardSetItemLabelColor(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call LeaderboardSetItemLabelColor(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void LeaderboardSetPlayerItemValueColorBJ(player whichPlayer, leaderboard lb, float red, float green, float blue, float transparency) {//function LeaderboardSetPlayerItemValueColorBJ takes player whichPlayer, leaderboard lb, real red, real green, real blue, real transparency returns nothing
			LeaderboardSetItemValueColor(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call LeaderboardSetItemValueColor(lb, LeaderboardGetPlayerIndex(lb, whichPlayer), PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void LeaderboardSetLabelColorBJ(leaderboard lb, float red, float green, float blue, float transparency) {//function LeaderboardSetLabelColorBJ takes leaderboard lb, real red, real green, real blue, real transparency returns nothing
			LeaderboardSetLabelColor(lb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call LeaderboardSetLabelColor(lb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void LeaderboardSetValueColorBJ(leaderboard lb, float red, float green, float blue, float transparency) {//function LeaderboardSetValueColorBJ takes leaderboard lb, real red, real green, real blue, real transparency returns nothing
			LeaderboardSetValueColor(lb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call LeaderboardSetValueColor(lb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void LeaderboardSetLabelBJ(leaderboard lb, string label) {//function LeaderboardSetLabelBJ takes leaderboard lb, string label returns nothing
			LeaderboardSetLabel(lb, label);//call LeaderboardSetLabel(lb, label)
			LeaderboardResizeBJ(lb);//call LeaderboardResizeBJ(lb)
		}//endfunction
		//
		private void LeaderboardSetStyleBJ(leaderboard lb, bool showLabel, bool showNames, bool showValues, bool showIcons) {//function LeaderboardSetStyleBJ takes leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons returns nothing
			LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);//call LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons)
		}//endfunction
		//
		private int LeaderboardGetItemCountBJ(leaderboard lb) {//function LeaderboardGetItemCountBJ takes leaderboard lb returns integer
			return LeaderboardGetItemCount(lb);//return LeaderboardGetItemCount(lb)
		}//endfunction
		//
		private bool LeaderboardHasPlayerItemBJ(leaderboard lb, player whichPlayer) {//function LeaderboardHasPlayerItemBJ takes leaderboard lb, player whichPlayer returns boolean
			return LeaderboardHasPlayerItem(lb, whichPlayer);//return LeaderboardHasPlayerItem(lb, whichPlayer)
		}//endfunction
		//
		private void ForceSetLeaderboardBJ(leaderboard lb, force toForce) {//function ForceSetLeaderboardBJ takes leaderboard lb, force toForce returns nothing
			int index;//local integer index
			player indexPlayer;//local player  indexPlayer
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				if (IsPlayerInForce(indexPlayer, toForce)) {//if IsPlayerInForce(indexPlayer, toForce) then
					PlayerSetLeaderboard(indexPlayer, lb);//call PlayerSetLeaderboard(indexPlayer, lb)
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		private leaderboard CreateLeaderboardBJ(force toForce, string label) {//function CreateLeaderboardBJ takes force toForce, string label returns leaderboard
			bj_lastCreatedLeaderboard = CreateLeaderboard();//set bj_lastCreatedLeaderboard = CreateLeaderboard()
			LeaderboardSetLabel(bj_lastCreatedLeaderboard, label);//call LeaderboardSetLabel(bj_lastCreatedLeaderboard, label)
			ForceSetLeaderboardBJ(bj_lastCreatedLeaderboard, toForce);//call ForceSetLeaderboardBJ(bj_lastCreatedLeaderboard, toForce)
			LeaderboardDisplay(bj_lastCreatedLeaderboard, true);//call LeaderboardDisplay(bj_lastCreatedLeaderboard, true)
			return bj_lastCreatedLeaderboard;//return bj_lastCreatedLeaderboard
		}//endfunction
		//
		private void DestroyLeaderboardBJ(leaderboard lb) {//function DestroyLeaderboardBJ takes leaderboard lb returns nothing
			DestroyLeaderboard(lb);//call DestroyLeaderboard(lb)
		}//endfunction
		//
		private void LeaderboardDisplayBJ(bool show, leaderboard lb) {//function LeaderboardDisplayBJ takes boolean show, leaderboard lb returns nothing
			LeaderboardDisplay(lb, show);//call LeaderboardDisplay(lb, show)
		}//endfunction
		//
		private void LeaderboardAddItemBJ(player whichPlayer, leaderboard lb, string label, int value) {//function LeaderboardAddItemBJ takes player whichPlayer, leaderboard lb, string label, integer value returns nothing
			if ((LeaderboardHasPlayerItem(lb, whichPlayer))) {//if (LeaderboardHasPlayerItem(lb, whichPlayer)) then
				LeaderboardRemovePlayerItem(lb, whichPlayer);//call LeaderboardRemovePlayerItem(lb, whichPlayer)
			}//endif
			LeaderboardAddItem(lb, label, value, whichPlayer);//call LeaderboardAddItem(lb, label, value, whichPlayer)
			LeaderboardResizeBJ(lb);//call LeaderboardResizeBJ(lb)
			//
		}//endfunction
		//
		private void LeaderboardRemovePlayerItemBJ(player whichPlayer, leaderboard lb) {//function LeaderboardRemovePlayerItemBJ takes player whichPlayer, leaderboard lb returns nothing
			LeaderboardRemovePlayerItem(lb, whichPlayer);//call LeaderboardRemovePlayerItem(lb, whichPlayer)
			LeaderboardResizeBJ(lb);//call LeaderboardResizeBJ(lb)
		}//endfunction
		//
		private void LeaderboardSortItemsBJ(leaderboard lb, int sortType, bool ascending) {//function LeaderboardSortItemsBJ takes leaderboard lb, integer sortType, boolean ascending returns nothing
			if ((sortType == bj_SORTTYPE_SORTBYVALUE)) {//if (sortType == bj_SORTTYPE_SORTBYVALUE) then
				LeaderboardSortItemsByValue(lb, ascending);//call LeaderboardSortItemsByValue(lb, ascending)
			} else if ((sortType == bj_SORTTYPE_SORTBYPLAYER)) {//elseif (sortType == bj_SORTTYPE_SORTBYPLAYER) then
				LeaderboardSortItemsByPlayer(lb, ascending);//call LeaderboardSortItemsByPlayer(lb, ascending)
			} else if ((sortType == bj_SORTTYPE_SORTBYLABEL)) {//elseif (sortType == bj_SORTTYPE_SORTBYLABEL) then
				LeaderboardSortItemsByLabel(lb, ascending);//call LeaderboardSortItemsByLabel(lb, ascending)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private void LeaderboardSortItemsByPlayerBJ(leaderboard lb, bool ascending) {//function LeaderboardSortItemsByPlayerBJ takes leaderboard lb, boolean ascending returns nothing
			LeaderboardSortItemsByPlayer(lb, ascending);//call LeaderboardSortItemsByPlayer(lb, ascending)
		}//endfunction
		//
		private void LeaderboardSortItemsByLabelBJ(leaderboard lb, bool ascending) {//function LeaderboardSortItemsByLabelBJ takes leaderboard lb, boolean ascending returns nothing
			LeaderboardSortItemsByLabel(lb, ascending);//call LeaderboardSortItemsByLabel(lb, ascending)
		}//endfunction
		//
		private int LeaderboardGetPlayerIndexBJ(player whichPlayer, leaderboard lb) {//function LeaderboardGetPlayerIndexBJ takes player whichPlayer, leaderboard lb returns integer
			return LeaderboardGetPlayerIndex(lb, whichPlayer) + 1;//return LeaderboardGetPlayerIndex(lb, whichPlayer) + 1
		}//endfunction
		//
		//
		//
		//
		private player LeaderboardGetIndexedPlayerBJ(int position, leaderboard lb) {//function LeaderboardGetIndexedPlayerBJ takes integer position, leaderboard lb returns player
			int index;//local integer index
			player indexPlayer;//local player  indexPlayer
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				if ((LeaderboardGetPlayerIndex(lb, indexPlayer) == position - 1)) {//if (LeaderboardGetPlayerIndex(lb, indexPlayer) == position - 1) then
					return indexPlayer;//return indexPlayer
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
			return Player(PLAYER_NEUTRAL_PASSIVE);//return Player(PLAYER_NEUTRAL_PASSIVE)
		}//endfunction
		//
		private leaderboard PlayerGetLeaderboardBJ(player whichPlayer) {//function PlayerGetLeaderboardBJ takes player whichPlayer returns leaderboard
			return PlayerGetLeaderboard(whichPlayer);//return PlayerGetLeaderboard(whichPlayer)
		}//endfunction
		//
		private leaderboard GetLastCreatedLeaderboard() {//function GetLastCreatedLeaderboard takes nothing returns leaderboard
			return bj_lastCreatedLeaderboard;//return bj_lastCreatedLeaderboard
		}//endfunction
		//
		//
		//
		//
		//
		//
		private multiboard CreateMultiboardBJ(int cols, int rows, string title) {//function CreateMultiboardBJ takes integer cols, integer rows, string title returns multiboard
			bj_lastCreatedMultiboard = CreateMultiboard();//set bj_lastCreatedMultiboard = CreateMultiboard()
			MultiboardSetRowCount(bj_lastCreatedMultiboard, rows);//call MultiboardSetRowCount(bj_lastCreatedMultiboard, rows)
			MultiboardSetColumnCount(bj_lastCreatedMultiboard, cols);//call MultiboardSetColumnCount(bj_lastCreatedMultiboard, cols)
			MultiboardSetTitleText(bj_lastCreatedMultiboard, title);//call MultiboardSetTitleText(bj_lastCreatedMultiboard, title)
			MultiboardDisplay(bj_lastCreatedMultiboard, true);//call MultiboardDisplay(bj_lastCreatedMultiboard, true)
			return bj_lastCreatedMultiboard;//return bj_lastCreatedMultiboard
		}//endfunction
		//
		private void DestroyMultiboardBJ(multiboard mb) {//function DestroyMultiboardBJ takes multiboard mb returns nothing
			DestroyMultiboard(mb);//call DestroyMultiboard(mb)
		}//endfunction
		//
		private multiboard GetLastCreatedMultiboard() {//function GetLastCreatedMultiboard takes nothing returns multiboard
			return bj_lastCreatedMultiboard;//return bj_lastCreatedMultiboard
		}//endfunction
		//
		private void MultiboardDisplayBJ(bool show, multiboard mb) {//function MultiboardDisplayBJ takes boolean show, multiboard mb returns nothing
			MultiboardDisplay(mb, show);//call MultiboardDisplay(mb, show)
		}//endfunction
		//
		private void MultiboardMinimizeBJ(bool minimize, multiboard mb) {//function MultiboardMinimizeBJ takes boolean minimize, multiboard mb returns nothing
			MultiboardMinimize(mb, minimize);//call MultiboardMinimize(mb, minimize)
		}//endfunction
		//
		private void MultiboardSetTitleTextColorBJ(multiboard mb, float red, float green, float blue, float transparency) {//function MultiboardSetTitleTextColorBJ takes multiboard mb, real red, real green, real blue, real transparency returns nothing
			MultiboardSetTitleTextColor(mb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call MultiboardSetTitleTextColor(mb, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void MultiboardAllowDisplayBJ(bool flag) {//function MultiboardAllowDisplayBJ takes boolean flag returns nothing
			MultiboardSuppressDisplay(not flag);//call MultiboardSuppressDisplay(not flag)
		}//endfunction
		//
		private void MultiboardSetItemStyleBJ(multiboard mb, int col, int row, bool showValue, bool showIcon) {//function MultiboardSetItemStyleBJ takes multiboard mb, integer col, integer row, boolean showValue, boolean showIcon returns nothing
			int curRow = 0;//local integer curRow = 0
			int curCol = 0;//local integer curCol = 0
			int numRows = MultiboardGetRowCount(mb);//local integer numRows = MultiboardGetRowCount(mb)
			int numCols = MultiboardGetColumnCount(mb);//local integer numCols = MultiboardGetColumnCount(mb)
			multiboarditem mbitem = null;//local multiboarditem mbitem = null
			//
			while (true) {//loop
				curRow = curRow + 1;//set curRow = curRow + 1
				if (curRow > numRows) { break; }//exitwhen curRow > numRows
				//
				if ((row == 0 || row == curRow)) {//if (row == 0 or row == curRow) then
					//
					curCol = 0;//set curCol = 0
					while (true) {//loop
						curCol = curCol + 1;//set curCol = curCol + 1
						if (curCol > numCols) { break; }//exitwhen curCol > numCols
						//
						if ((col == 0 || col == curCol)) {//if (col == 0 or col == curCol) then
							mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);//set mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1)
							MultiboardSetItemStyle(mbitem, showValue, showIcon);//call MultiboardSetItemStyle(mbitem, showValue, showIcon)
							MultiboardReleaseItem(mbitem);//call MultiboardReleaseItem(mbitem)
						}//endif
					}//endloop
				}//endif
			}//endloop
		}//endfunction
		//
		private void MultiboardSetItemValueBJ(multiboard mb, int col, int row, string val) {//function MultiboardSetItemValueBJ takes multiboard mb, integer col, integer row, string val returns nothing
			int curRow = 0;//local integer curRow = 0
			int curCol = 0;//local integer curCol = 0
			int numRows = MultiboardGetRowCount(mb);//local integer numRows = MultiboardGetRowCount(mb)
			int numCols = MultiboardGetColumnCount(mb);//local integer numCols = MultiboardGetColumnCount(mb)
			multiboarditem mbitem = null;//local multiboarditem mbitem = null
			//
			while (true) {//loop
				curRow = curRow + 1;//set curRow = curRow + 1
				if (curRow > numRows) { break; }//exitwhen curRow > numRows
				//
				if ((row == 0 || row == curRow)) {//if (row == 0 or row == curRow) then
					//
					curCol = 0;//set curCol = 0
					while (true) {//loop
						curCol = curCol + 1;//set curCol = curCol + 1
						if (curCol > numCols) { break; }//exitwhen curCol > numCols
						//
						if ((col == 0 || col == curCol)) {//if (col == 0 or col == curCol) then
							mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);//set mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1)
							MultiboardSetItemValue(mbitem, val);//call MultiboardSetItemValue(mbitem, val)
							MultiboardReleaseItem(mbitem);//call MultiboardReleaseItem(mbitem)
						}//endif
					}//endloop
				}//endif
			}//endloop
		}//endfunction
		//
		private void MultiboardSetItemColorBJ(multiboard mb, int col, int row, float red, float green, float blue, float transparency) {//function MultiboardSetItemColorBJ takes multiboard mb, integer col, integer row, real red, real green, real blue, real transparency returns nothing
			int curRow = 0;//local integer curRow = 0
			int curCol = 0;//local integer curCol = 0
			int numRows = MultiboardGetRowCount(mb);//local integer numRows = MultiboardGetRowCount(mb)
			int numCols = MultiboardGetColumnCount(mb);//local integer numCols = MultiboardGetColumnCount(mb)
			multiboarditem mbitem = null;//local multiboarditem mbitem = null
			//
			while (true) {//loop
				curRow = curRow + 1;//set curRow = curRow + 1
				if (curRow > numRows) { break; }//exitwhen curRow > numRows
				//
				if ((row == 0 || row == curRow)) {//if (row == 0 or row == curRow) then
					//
					curCol = 0;//set curCol = 0
					while (true) {//loop
						curCol = curCol + 1;//set curCol = curCol + 1
						if (curCol > numCols) { break; }//exitwhen curCol > numCols
						//
						if ((col == 0 || col == curCol)) {//if (col == 0 or col == curCol) then
							mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);//set mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1)
							MultiboardSetItemValueColor(mbitem, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call MultiboardSetItemValueColor(mbitem, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
							MultiboardReleaseItem(mbitem);//call MultiboardReleaseItem(mbitem)
						}//endif
					}//endloop
				}//endif
			}//endloop
		}//endfunction
		//
		private void MultiboardSetItemWidthBJ(multiboard mb, int col, int row, float width) {//function MultiboardSetItemWidthBJ takes multiboard mb, integer col, integer row, real width returns nothing
			int curRow = 0;//local integer curRow = 0
			int curCol = 0;//local integer curCol = 0
			int numRows = MultiboardGetRowCount(mb);//local integer numRows = MultiboardGetRowCount(mb)
			int numCols = MultiboardGetColumnCount(mb);//local integer numCols = MultiboardGetColumnCount(mb)
			multiboarditem mbitem = null;//local multiboarditem mbitem = null
			//
			while (true) {//loop
				curRow = curRow + 1;//set curRow = curRow + 1
				if (curRow > numRows) { break; }//exitwhen curRow > numRows
				//
				if ((row == 0 || row == curRow)) {//if (row == 0 or row == curRow) then
					//
					curCol = 0;//set curCol = 0
					while (true) {//loop
						curCol = curCol + 1;//set curCol = curCol + 1
						if (curCol > numCols) { break; }//exitwhen curCol > numCols
						//
						if ((col == 0 || col == curCol)) {//if (col == 0 or col == curCol) then
							mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);//set mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1)
							MultiboardSetItemWidth(mbitem, width/100.0);//call MultiboardSetItemWidth(mbitem, width/100.0)
							MultiboardReleaseItem(mbitem);//call MultiboardReleaseItem(mbitem)
						}//endif
					}//endloop
				}//endif
			}//endloop
		}//endfunction
		//
		private void MultiboardSetItemIconBJ(multiboard mb, int col, int row, string iconFileName) {//function MultiboardSetItemIconBJ takes multiboard mb, integer col, integer row, string iconFileName returns nothing
			int curRow = 0;//local integer curRow = 0
			int curCol = 0;//local integer curCol = 0
			int numRows = MultiboardGetRowCount(mb);//local integer numRows = MultiboardGetRowCount(mb)
			int numCols = MultiboardGetColumnCount(mb);//local integer numCols = MultiboardGetColumnCount(mb)
			multiboarditem mbitem = null;//local multiboarditem mbitem = null
			//
			while (true) {//loop
				curRow = curRow + 1;//set curRow = curRow + 1
				if (curRow > numRows) { break; }//exitwhen curRow > numRows
				//
				if ((row == 0 || row == curRow)) {//if (row == 0 or row == curRow) then
					//
					curCol = 0;//set curCol = 0
					while (true) {//loop
						curCol = curCol + 1;//set curCol = curCol + 1
						if (curCol > numCols) { break; }//exitwhen curCol > numCols
						//
						if ((col == 0 || col == curCol)) {//if (col == 0 or col == curCol) then
							mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1);//set mbitem = MultiboardGetItem(mb, curRow - 1, curCol - 1)
							MultiboardSetItemIcon(mbitem, iconFileName);//call MultiboardSetItemIcon(mbitem, iconFileName)
							MultiboardReleaseItem(mbitem);//call MultiboardReleaseItem(mbitem)
						}//endif
					}//endloop
				}//endif
			}//endloop
		}//endfunction
		//
		//
		//
		//
		//
		//
		//
		//
		//
		private float TextTagSize2Height(float size) {//function TextTagSize2Height takes real size returns real
			return size * 0.023 / 10;//return size * 0.023 / 10
		}//endfunction
		//
		//
		//
		//
		private float TextTagSpeed2Velocity(float speed) {//function TextTagSpeed2Velocity takes real speed returns real
			return speed * 0.071 / 128;//return speed * 0.071 / 128
		}//endfunction
		//
		private void SetTextTagColorBJ(texttag tt, float red, float green, float blue, float transparency) {//function SetTextTagColorBJ takes texttag tt, real red, real green, real blue, real transparency returns nothing
			SetTextTagColor(tt, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency));//call SetTextTagColor(tt, PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100.0-transparency))
		}//endfunction
		//
		private void SetTextTagVelocityBJ(texttag tt, float speed, float angle) {//function SetTextTagVelocityBJ takes texttag tt, real speed, real angle returns nothing
			float vel = TextTagSpeed2Velocity(speed);//local real vel = TextTagSpeed2Velocity(speed)
			float xvel = vel * Cos(angle * bj_DEGTORAD);//local real xvel = vel * Cos(angle * bj_DEGTORAD)
			float yvel = vel * Sin(angle * bj_DEGTORAD);//local real yvel = vel * Sin(angle * bj_DEGTORAD)
			SetTextTagVelocity(tt, xvel, yvel);//call SetTextTagVelocity(tt, xvel, yvel)
		}//endfunction
		//
		private void SetTextTagTextBJ(texttag tt, string s, float size) {//function SetTextTagTextBJ takes texttag tt, string s, real size returns nothing
			float textHeight = TextTagSize2Height(size);//local real textHeight = TextTagSize2Height(size)
			SetTextTagText(tt, s, textHeight);//call SetTextTagText(tt, s, textHeight)
		}//endfunction
		//
		private void SetTextTagPosBJ(texttag tt, location loc, float zOffset) {//function SetTextTagPosBJ takes texttag tt, location loc, real zOffset returns nothing
			SetTextTagPos(tt, GetLocationX(loc), GetLocationY(loc), zOffset);//call SetTextTagPos(tt, GetLocationX(loc), GetLocationY(loc), zOffset)
		}//endfunction
		//
		private void SetTextTagPosUnitBJ(texttag tt, unit whichUnit, float zOffset) {//function SetTextTagPosUnitBJ takes texttag tt, unit whichUnit, real zOffset returns nothing
			SetTextTagPosUnit(tt, whichUnit, zOffset);//call SetTextTagPosUnit(tt, whichUnit, zOffset)
		}//endfunction
		//
		private void SetTextTagSuspendedBJ(texttag tt, bool flag) {//function SetTextTagSuspendedBJ takes texttag tt, boolean flag returns nothing
			SetTextTagSuspended(tt, flag);//call SetTextTagSuspended(tt, flag)
		}//endfunction
		//
		private void SetTextTagPermanentBJ(texttag tt, bool flag) {//function SetTextTagPermanentBJ takes texttag tt, boolean flag returns nothing
			SetTextTagPermanent(tt, flag);//call SetTextTagPermanent(tt, flag)
		}//endfunction
		//
		private void SetTextTagAgeBJ(texttag tt, float age) {//function SetTextTagAgeBJ takes texttag tt, real age returns nothing
			SetTextTagAge(tt, age);//call SetTextTagAge(tt, age)
		}//endfunction
		//
		private void SetTextTagLifespanBJ(texttag tt, float lifespan) {//function SetTextTagLifespanBJ takes texttag tt, real lifespan returns nothing
			SetTextTagLifespan(tt, lifespan);//call SetTextTagLifespan(tt, lifespan)
		}//endfunction
		//
		private void SetTextTagFadepointBJ(texttag tt, float fadepoint) {//function SetTextTagFadepointBJ takes texttag tt, real fadepoint returns nothing
			SetTextTagFadepoint(tt, fadepoint);//call SetTextTagFadepoint(tt, fadepoint)
		}//endfunction
		//
		private texttag CreateTextTagLocBJ(string s, location loc, float zOffset, float size, float red, float green, float blue, float transparency) {//function CreateTextTagLocBJ takes string s, location loc, real zOffset, real size, real red, real green, real blue, real transparency returns texttag
			bj_lastCreatedTextTag = CreateTextTag();//set bj_lastCreatedTextTag = CreateTextTag()
			SetTextTagTextBJ(bj_lastCreatedTextTag, s, size);//call SetTextTagTextBJ(bj_lastCreatedTextTag, s, size)
			SetTextTagPosBJ(bj_lastCreatedTextTag, loc, zOffset);//call SetTextTagPosBJ(bj_lastCreatedTextTag, loc, zOffset)
			SetTextTagColorBJ(bj_lastCreatedTextTag, red, green, blue, transparency);//call SetTextTagColorBJ(bj_lastCreatedTextTag, red, green, blue, transparency)
			return bj_lastCreatedTextTag;//return bj_lastCreatedTextTag
		}//endfunction
		//
		private texttag CreateTextTagUnitBJ(string s, unit whichUnit, float zOffset, float size, float red, float green, float blue, float transparency) {//function CreateTextTagUnitBJ takes string s, unit whichUnit, real zOffset, real size, real red, real green, real blue, real transparency returns texttag
			bj_lastCreatedTextTag = CreateTextTag();//set bj_lastCreatedTextTag = CreateTextTag()
			SetTextTagTextBJ(bj_lastCreatedTextTag, s, size);//call SetTextTagTextBJ(bj_lastCreatedTextTag, s, size)
			SetTextTagPosUnitBJ(bj_lastCreatedTextTag, whichUnit, zOffset);//call SetTextTagPosUnitBJ(bj_lastCreatedTextTag, whichUnit, zOffset)
			SetTextTagColorBJ(bj_lastCreatedTextTag, red, green, blue, transparency);//call SetTextTagColorBJ(bj_lastCreatedTextTag, red, green, blue, transparency)
			return bj_lastCreatedTextTag;//return bj_lastCreatedTextTag
		}//endfunction
		//
		private void DestroyTextTagBJ(texttag tt) {//function DestroyTextTagBJ takes texttag tt returns nothing
			DestroyTextTag(tt);//call DestroyTextTag(tt)
		}//endfunction
		//
		private void ShowTextTagForceBJ(bool show, texttag tt, force whichForce) {//function ShowTextTagForceBJ takes boolean show, texttag tt, force whichForce returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), whichForce))) {//if (IsPlayerInForce(GetLocalPlayer(), whichForce)) then
				//
				SetTextTagVisibility(tt, show);//call SetTextTagVisibility(tt, show)
			}//endif
		}//endfunction
		//
		private texttag GetLastCreatedTextTag() {//function GetLastCreatedTextTag takes nothing returns texttag
			return bj_lastCreatedTextTag;//return bj_lastCreatedTextTag
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void PauseGameOn() {//function PauseGameOn takes nothing returns nothing
			PauseGame(true);//call PauseGame(true)
		}//endfunction
		//
		private void PauseGameOff() {//function PauseGameOff takes nothing returns nothing
			PauseGame(false);//call PauseGame(false)
		}//endfunction
		//
		private void SetUserControlForceOn(force whichForce) {//function SetUserControlForceOn takes force whichForce returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), whichForce))) {//if (IsPlayerInForce(GetLocalPlayer(), whichForce)) then
				//
				EnableUserControl(true);//call EnableUserControl(true)
			}//endif
		}//endfunction
		//
		private void SetUserControlForceOff(force whichForce) {//function SetUserControlForceOff takes force whichForce returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), whichForce))) {//if (IsPlayerInForce(GetLocalPlayer(), whichForce)) then
				//
				EnableUserControl(false);//call EnableUserControl(false)
			}//endif
		}//endfunction
		//
		private void ShowInterfaceForceOn(force whichForce, float fadeDuration) {//function ShowInterfaceForceOn takes force whichForce, real fadeDuration returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), whichForce))) {//if (IsPlayerInForce(GetLocalPlayer(), whichForce)) then
				//
				ShowInterface(true, fadeDuration);//call ShowInterface(true, fadeDuration)
			}//endif
		}//endfunction
		//
		private void ShowInterfaceForceOff(force whichForce, float fadeDuration) {//function ShowInterfaceForceOff takes force whichForce, real fadeDuration returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), whichForce))) {//if (IsPlayerInForce(GetLocalPlayer(), whichForce)) then
				//
				ShowInterface(false, fadeDuration);//call ShowInterface(false, fadeDuration)
			}//endif
		}//endfunction
		//
		private void PingMinimapForForce(force whichForce, float x, float y, float duration) {//function PingMinimapForForce takes force whichForce, real x, real y, real duration returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), whichForce))) {//if (IsPlayerInForce(GetLocalPlayer(), whichForce)) then
				//
				PingMinimap(x, y, duration);//call PingMinimap(x, y, duration)
				//
			}//endif
		}//endfunction
		//
		private void PingMinimapLocForForce(force whichForce, location loc, float duration) {//function PingMinimapLocForForce takes force whichForce, location loc, real duration returns nothing
			PingMinimapForForce(whichForce, GetLocationX(loc), GetLocationY(loc), duration);//call PingMinimapForForce(whichForce, GetLocationX(loc), GetLocationY(loc), duration)
		}//endfunction
		//
		private void PingMinimapForPlayer(player whichPlayer, float x, float y, float duration) {//function PingMinimapForPlayer takes player whichPlayer, real x, real y, real duration returns nothing
			if ((GetLocalPlayer() == whichPlayer)) {//if (GetLocalPlayer() == whichPlayer) then
				//
				PingMinimap(x, y, duration);//call PingMinimap(x, y, duration)
				//
			}//endif
		}//endfunction
		//
		private void PingMinimapLocForPlayer(player whichPlayer, location loc, float duration) {//function PingMinimapLocForPlayer takes player whichPlayer, location loc, real duration returns nothing
			PingMinimapForPlayer(whichPlayer, GetLocationX(loc), GetLocationY(loc), duration);//call PingMinimapForPlayer(whichPlayer, GetLocationX(loc), GetLocationY(loc), duration)
		}//endfunction
		//
		private void PingMinimapForForceEx(force whichForce, float x, float y, float duration, int style, float red, float green, float blue) {//function PingMinimapForForceEx takes force whichForce, real x, real y, real duration, integer style, real red, real green, real blue returns nothing
			int red255 = PercentTo255(red);//local integer red255   = PercentTo255(red)
			int green255 = PercentTo255(green);//local integer green255 = PercentTo255(green)
			int blue255 = PercentTo255(blue);//local integer blue255  = PercentTo255(blue)
			if ((IsPlayerInForce(GetLocalPlayer(), whichForce))) {//if (IsPlayerInForce(GetLocalPlayer(), whichForce)) then
				//
				//
				if ((red255 == 255) && (green255 == 0) && (blue255 == 0)) {//if (red255 == 255) and (green255 == 0) and (blue255 == 0) then
					red255 = 254;//set red255 = 254
				}//endif
				if ((style == bj_MINIMAPPINGSTYLE_SIMPLE)) {//if (style == bj_MINIMAPPINGSTYLE_SIMPLE) then
					PingMinimapEx(x, y, duration, red255, green255, blue255, false);//call PingMinimapEx(x, y, duration, red255, green255, blue255, false)
				} else if ((style == bj_MINIMAPPINGSTYLE_FLASHY)) {//elseif (style == bj_MINIMAPPINGSTYLE_FLASHY) then
					PingMinimapEx(x, y, duration, red255, green255, blue255, true);//call PingMinimapEx(x, y, duration, red255, green255, blue255, true)
				} else if ((style == bj_MINIMAPPINGSTYLE_ATTACK)) {//elseif (style == bj_MINIMAPPINGSTYLE_ATTACK) then
					PingMinimapEx(x, y, duration, 255, 0, 0, false);//call PingMinimapEx(x, y, duration, 255, 0, 0, false)
				} else {//else
					//
				}//endif
				//
			}//endif
		}//endfunction
		//
		private void PingMinimapLocForForceEx(force whichForce, location loc, float duration, int style, float red, float green, float blue) {//function PingMinimapLocForForceEx takes force whichForce, location loc, real duration, integer style, real red, real green, real blue returns nothing
			PingMinimapForForceEx(whichForce, GetLocationX(loc), GetLocationY(loc), duration, style, red, green, blue);//call PingMinimapForForceEx(whichForce, GetLocationX(loc), GetLocationY(loc), duration, style, red, green, blue)
		}//endfunction
		//
		private void EnableWorldFogBoundaryBJ(bool enable, force f) {//function EnableWorldFogBoundaryBJ takes boolean enable, force f returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), f))) {//if (IsPlayerInForce(GetLocalPlayer(), f)) then
				//
				EnableWorldFogBoundary(enable);//call EnableWorldFogBoundary(enable)
			}//endif
		}//endfunction
		//
		private void EnableOcclusionBJ(bool enable, force f) {//function EnableOcclusionBJ takes boolean enable, force f returns nothing
			if ((IsPlayerInForce(GetLocalPlayer(), f))) {//if (IsPlayerInForce(GetLocalPlayer(), f)) then
				//
				EnableOcclusion(enable);//call EnableOcclusion(enable)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		//
		//
		private void CancelCineSceneBJ() {//function CancelCineSceneBJ takes nothing returns nothing
			StopSoundBJ(bj_cineSceneLastSound, true);//call StopSoundBJ(bj_cineSceneLastSound, true)
			EndCinematicScene();//call EndCinematicScene()
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void TryInitCinematicBehaviorBJ() {//function TryInitCinematicBehaviorBJ takes nothing returns nothing
			int index;//local integer index
			if ((bj_cineSceneBeingSkipped == null)) {//if (bj_cineSceneBeingSkipped == null) then
				bj_cineSceneBeingSkipped = CreateTrigger();//set bj_cineSceneBeingSkipped = CreateTrigger()
				index = 0;//set index = 0
				while (true) {//loop
					TriggerRegisterPlayerEvent(bj_cineSceneBeingSkipped, Player(index), EVENT_PLAYER_END_CINEMATIC);//call TriggerRegisterPlayerEvent(bj_cineSceneBeingSkipped, Player(index), EVENT_PLAYER_END_CINEMATIC)
					index = index + 1;//set index = index + 1
					if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
				}//endloop
				TriggerAddAction(bj_cineSceneBeingSkipped, function CancelCineSceneBJ);//call TriggerAddAction(bj_cineSceneBeingSkipped, function CancelCineSceneBJ)
			}//endif
		}//endfunction
		//
		private void SetCinematicSceneBJ(sound soundHandle, int portraitUnitId, playercolor color, string speakerTitle, string text, float sceneDuration, float voiceoverDuration) {//function SetCinematicSceneBJ takes sound soundHandle, integer portraitUnitId, playercolor color, string speakerTitle, string text, real sceneDuration, real voiceoverDuration returns nothing
			bj_cineSceneLastSound = soundHandle;//set bj_cineSceneLastSound = soundHandle
			PlaySoundBJ(soundHandle);//call PlaySoundBJ(soundHandle)
			SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);//call SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration)
		}//endfunction
		//
		private float GetTransmissionDuration(sound soundHandle, int timeType, float timeVal) {//function GetTransmissionDuration takes sound soundHandle, integer timeType, real timeVal returns real
			float duration;//local real duration
			if ((timeType == bj_TIMETYPE_ADD)) {//if (timeType == bj_TIMETYPE_ADD) then
				duration = GetSoundDurationBJ(soundHandle) + timeVal;//set duration = GetSoundDurationBJ(soundHandle) + timeVal
			} else if ((timeType == bj_TIMETYPE_SET)) {//elseif (timeType == bj_TIMETYPE_SET) then
				duration = timeVal;//set duration = timeVal
			} else if ((timeType == bj_TIMETYPE_SUB)) {//elseif (timeType == bj_TIMETYPE_SUB) then
				duration = GetSoundDurationBJ(soundHandle) - timeVal;//set duration = GetSoundDurationBJ(soundHandle) - timeVal
			} else {//else
				//
				duration = GetSoundDurationBJ(soundHandle);//set duration = GetSoundDurationBJ(soundHandle)
			}//endif
			//
			if ((duration < 0)) {//if (duration < 0) then
				duration = 0;//set duration = 0
			}//endif
			return duration;//return duration
		}//endfunction
		//
		private void WaitTransmissionDuration(sound soundHandle, int timeType, float timeVal) {//function WaitTransmissionDuration takes sound soundHandle, integer timeType, real timeVal returns nothing
			if ((timeType == bj_TIMETYPE_SET)) {//if (timeType == bj_TIMETYPE_SET) then
				//
				TriggerSleepAction(timeVal);//call TriggerSleepAction(timeVal)
			} else if ((soundHandle == null)) {//elseif (soundHandle == null) then
				//
				TriggerSleepAction(bj_NOTHING_SOUND_DURATION);//call TriggerSleepAction(bj_NOTHING_SOUND_DURATION)
			} else if ((timeType == bj_TIMETYPE_SUB)) {//elseif (timeType == bj_TIMETYPE_SUB) then
				//
				//
				WaitForSoundBJ(soundHandle, timeVal);//call WaitForSoundBJ(soundHandle, timeVal)
			} else if ((timeType == bj_TIMETYPE_ADD)) {//elseif (timeType == bj_TIMETYPE_ADD) then
				//
				//
				WaitForSoundBJ(soundHandle, 0);//call WaitForSoundBJ(soundHandle, 0)
				TriggerSleepAction(timeVal);//call TriggerSleepAction(timeVal)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private void DoTransmissionBasicsXYBJ(int unitId, playercolor color, float x, float y, sound soundHandle, string unitName, string message, float duration) {//function DoTransmissionBasicsXYBJ takes integer unitId, playercolor color, real x, real y, sound soundHandle, string unitName, string message, real duration returns nothing
			SetCinematicSceneBJ(soundHandle, unitId, color, unitName, message, duration + bj_TRANSMISSION_PORT_HANGTIME, duration);//call SetCinematicSceneBJ(soundHandle, unitId, color, unitName, message, duration + bj_TRANSMISSION_PORT_HANGTIME, duration)
			if ((unitId != 0)) {//if (unitId != 0) then
				PingMinimap(x, y, bj_TRANSMISSION_PING_TIME);//call PingMinimap(x, y, bj_TRANSMISSION_PING_TIME)
				//
			}//endif
		}//endfunction
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
		private void TransmissionFromUnitWithNameBJ(force toForce, unit whichUnit, string unitName, sound soundHandle, string message, int timeType, float timeVal, bool wait) {//function TransmissionFromUnitWithNameBJ takes force toForce, unit whichUnit, string unitName, sound soundHandle, string message, integer timeType, real timeVal, boolean wait returns nothing
			TryInitCinematicBehaviorBJ();//call TryInitCinematicBehaviorBJ()
			//
			timeVal = RMaxBJ(timeVal, 0);//set timeVal = RMaxBJ(timeVal, 0)
			bj_lastTransmissionDuration = GetTransmissionDuration(soundHandle, timeType, timeVal);//set bj_lastTransmissionDuration = GetTransmissionDuration(soundHandle, timeType, timeVal)
			bj_lastPlayedSound = soundHandle;//set bj_lastPlayedSound = soundHandle
			if ((IsPlayerInForce(GetLocalPlayer(), toForce))) {//if (IsPlayerInForce(GetLocalPlayer(), toForce)) then
				//
				if ((whichUnit == null)) {//if (whichUnit == null) then
					//
					DoTransmissionBasicsXYBJ(0, PLAYER_COLOR_RED, 0, 0, soundHandle, unitName, message, bj_lastTransmissionDuration);//call DoTransmissionBasicsXYBJ(0, PLAYER_COLOR_RED, 0, 0, soundHandle, unitName, message, bj_lastTransmissionDuration)
				} else {//else
					DoTransmissionBasicsXYBJ(GetUnitTypeId(whichUnit), GetPlayerColor(GetOwningPlayer(whichUnit)), GetUnitX(whichUnit), GetUnitY(whichUnit), soundHandle, unitName, message, bj_lastTransmissionDuration);//call DoTransmissionBasicsXYBJ(GetUnitTypeId(whichUnit), GetPlayerColor(GetOwningPlayer(whichUnit)), GetUnitX(whichUnit), GetUnitY(whichUnit), soundHandle, unitName, message, bj_lastTransmissionDuration)
					if ((!IsUnitHidden(whichUnit))) {//if (not IsUnitHidden(whichUnit)) then
						UnitAddIndicator(whichUnit, bj_TRANSMISSION_IND_RED, bj_TRANSMISSION_IND_BLUE, bj_TRANSMISSION_IND_GREEN, bj_TRANSMISSION_IND_ALPHA);//call UnitAddIndicator(whichUnit, bj_TRANSMISSION_IND_RED, bj_TRANSMISSION_IND_BLUE, bj_TRANSMISSION_IND_GREEN, bj_TRANSMISSION_IND_ALPHA)
					}//endif
				}//endif
			}//endif
			if (wait && (bj_lastTransmissionDuration > 0)) {//if wait and (bj_lastTransmissionDuration > 0) then
				//
				WaitTransmissionDuration(soundHandle, timeType, timeVal);//call WaitTransmissionDuration(soundHandle, timeType, timeVal)
			}//endif
		}//endfunction
		//
		//
		//
		//
		private void TransmissionFromUnitTypeWithNameBJ(force toForce, player fromPlayer, int unitId, string unitName, location loc, sound soundHandle, string message, int timeType, float timeVal, bool wait) {//function TransmissionFromUnitTypeWithNameBJ takes force toForce, player fromPlayer, integer unitId, string unitName, location loc, sound soundHandle, string message, integer timeType, real timeVal, boolean wait returns nothing
			TryInitCinematicBehaviorBJ();//call TryInitCinematicBehaviorBJ()
			//
			timeVal = RMaxBJ(timeVal, 0);//set timeVal = RMaxBJ(timeVal, 0)
			bj_lastTransmissionDuration = GetTransmissionDuration(soundHandle, timeType, timeVal);//set bj_lastTransmissionDuration = GetTransmissionDuration(soundHandle, timeType, timeVal)
			bj_lastPlayedSound = soundHandle;//set bj_lastPlayedSound = soundHandle
			if ((IsPlayerInForce(GetLocalPlayer(), toForce))) {//if (IsPlayerInForce(GetLocalPlayer(), toForce)) then
				//
				DoTransmissionBasicsXYBJ(unitId, GetPlayerColor(fromPlayer), GetLocationX(loc), GetLocationY(loc), soundHandle, unitName, message, bj_lastTransmissionDuration);//call DoTransmissionBasicsXYBJ(unitId, GetPlayerColor(fromPlayer), GetLocationX(loc), GetLocationY(loc), soundHandle, unitName, message, bj_lastTransmissionDuration)
			}//endif
			if (wait && (bj_lastTransmissionDuration > 0)) {//if wait and (bj_lastTransmissionDuration > 0) then
				//
				WaitTransmissionDuration(soundHandle, timeType, timeVal);//call WaitTransmissionDuration(soundHandle, timeType, timeVal)
			}//endif
		}//endfunction
		//
		private float GetLastTransmissionDurationBJ() {//function GetLastTransmissionDurationBJ takes nothing returns real
			return bj_lastTransmissionDuration;//return bj_lastTransmissionDuration
		}//endfunction
		//
		private void ForceCinematicSubtitlesBJ(bool flag) {//function ForceCinematicSubtitlesBJ takes boolean flag returns nothing
			ForceCinematicSubtitles(flag);//call ForceCinematicSubtitles(flag)
		}//endfunction
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
		//
		//
		//
		private void CinematicModeExBJ(bool cineMode, force forForce, float interfaceFadeTime) {//function CinematicModeExBJ takes boolean cineMode, force forForce, real interfaceFadeTime returns nothing
			//
			if ((!bj_gameStarted)) {//if (not bj_gameStarted) then
				interfaceFadeTime = 0;//set interfaceFadeTime = 0
			}//endif
			if ((cineMode)) {//if (cineMode) then
				//
				if ((!bj_cineModeAlreadyIn)) {//if (not bj_cineModeAlreadyIn) then
					bj_cineModeAlreadyIn = true;//set bj_cineModeAlreadyIn = true
					bj_cineModePriorSpeed = GetGameSpeed();//set bj_cineModePriorSpeed = GetGameSpeed()
					bj_cineModePriorFogSetting = IsFogEnabled();//set bj_cineModePriorFogSetting = IsFogEnabled()
					bj_cineModePriorMaskSetting = IsFogMaskEnabled();//set bj_cineModePriorMaskSetting = IsFogMaskEnabled()
					bj_cineModePriorDawnDusk = IsDawnDuskEnabled();//set bj_cineModePriorDawnDusk = IsDawnDuskEnabled()
					bj_cineModeSavedSeed = GetRandomInt(0, 1000000);//set bj_cineModeSavedSeed = GetRandomInt(0, 1000000)
				}//endif
				//
				if ((IsPlayerInForce(GetLocalPlayer(), forForce))) {//if (IsPlayerInForce(GetLocalPlayer(), forForce)) then
					//
					ClearTextMessages();//call ClearTextMessages()
					ShowInterface(false, interfaceFadeTime);//call ShowInterface(false, interfaceFadeTime)
					EnableUserControl(false);//call EnableUserControl(false)
					EnableOcclusion(false);//call EnableOcclusion(false)
					SetCineModeVolumeGroupsBJ();//call SetCineModeVolumeGroupsBJ()
				}//endif
				//
				SetGameSpeed(bj_CINEMODE_GAMESPEED);//call SetGameSpeed(bj_CINEMODE_GAMESPEED)
				SetMapFlag(MAP_LOCK_SPEED, true);//call SetMapFlag(MAP_LOCK_SPEED, true)
				FogMaskEnable(false);//call FogMaskEnable(false)
				FogEnable(false);//call FogEnable(false)
				EnableWorldFogBoundary(false);//call EnableWorldFogBoundary(false)
				EnableDawnDusk(false);//call EnableDawnDusk(false)
				//
				SetRandomSeed(0);//call SetRandomSeed(0)
			} else {//else
				bj_cineModeAlreadyIn = false;//set bj_cineModeAlreadyIn = false
				//
				if ((IsPlayerInForce(GetLocalPlayer(), forForce))) {//if (IsPlayerInForce(GetLocalPlayer(), forForce)) then
					//
					ShowInterface(true, interfaceFadeTime);//call ShowInterface(true, interfaceFadeTime)
					EnableUserControl(true);//call EnableUserControl(true)
					EnableOcclusion(true);//call EnableOcclusion(true)
					VolumeGroupReset();//call VolumeGroupReset()
					EndThematicMusic();//call EndThematicMusic()
					CameraResetSmoothingFactorBJ();//call CameraResetSmoothingFactorBJ()
				}//endif
				//
				SetMapFlag(MAP_LOCK_SPEED, false);//call SetMapFlag(MAP_LOCK_SPEED, false)
				SetGameSpeed(bj_cineModePriorSpeed);//call SetGameSpeed(bj_cineModePriorSpeed)
				FogMaskEnable(bj_cineModePriorMaskSetting);//call FogMaskEnable(bj_cineModePriorMaskSetting)
				FogEnable(bj_cineModePriorFogSetting);//call FogEnable(bj_cineModePriorFogSetting)
				EnableWorldFogBoundary(true);//call EnableWorldFogBoundary(true)
				EnableDawnDusk(bj_cineModePriorDawnDusk);//call EnableDawnDusk(bj_cineModePriorDawnDusk)
				SetRandomSeed(bj_cineModeSavedSeed);//call SetRandomSeed(bj_cineModeSavedSeed)
			}//endif
		}//endfunction
		//
		private void CinematicModeBJ(bool cineMode, force forForce) {//function CinematicModeBJ takes boolean cineMode, force forForce returns nothing
			CinematicModeExBJ(cineMode, forForce, bj_CINEMODE_INTERFACEFADE);//call CinematicModeExBJ(cineMode, forForce, bj_CINEMODE_INTERFACEFADE)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void DisplayCineFilterBJ(bool flag) {//function DisplayCineFilterBJ takes boolean flag returns nothing
			DisplayCineFilter(flag);//call DisplayCineFilter(flag)
		}//endfunction
		//
		private void CinematicFadeCommonBJ(float red, float green, float blue, float duration, string tex, float startTrans, float endTrans) {//function CinematicFadeCommonBJ takes real red, real green, real blue, real duration, string tex, real startTrans, real endTrans returns nothing
			if ((duration == 0)) {//if (duration == 0) then
				//
				//
				startTrans = endTrans;//set startTrans = endTrans
			}//endif
			EnableUserUI(false);//call EnableUserUI(false)
			SetCineFilterTexture(tex);//call SetCineFilterTexture(tex)
			SetCineFilterBlendMode(BLEND_MODE_BLEND);//call SetCineFilterBlendMode(BLEND_MODE_BLEND)
			SetCineFilterTexMapFlags(TEXMAP_FLAG_NONE);//call SetCineFilterTexMapFlags(TEXMAP_FLAG_NONE)
			SetCineFilterStartUV(0, 0, 1, 1);//call SetCineFilterStartUV(0, 0, 1, 1)
			SetCineFilterEndUV(0, 0, 1, 1);//call SetCineFilterEndUV(0, 0, 1, 1)
			SetCineFilterStartColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100-startTrans));//call SetCineFilterStartColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100-startTrans))
			SetCineFilterEndColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100-endTrans));//call SetCineFilterEndColor(PercentTo255(red), PercentTo255(green), PercentTo255(blue), PercentTo255(100-endTrans))
			SetCineFilterDuration(duration);//call SetCineFilterDuration(duration)
			DisplayCineFilter(true);//call DisplayCineFilter(true)
		}//endfunction
		//
		private void FinishCinematicFadeBJ() {//function FinishCinematicFadeBJ takes nothing returns nothing
			DestroyTimer(bj_cineFadeFinishTimer);//call DestroyTimer(bj_cineFadeFinishTimer)
			bj_cineFadeFinishTimer = null;//set bj_cineFadeFinishTimer = null
			DisplayCineFilter(false);//call DisplayCineFilter(false)
			EnableUserUI(true);//call EnableUserUI(true)
		}//endfunction
		//
		private void FinishCinematicFadeAfterBJ(float duration) {//function FinishCinematicFadeAfterBJ takes real duration returns nothing
			//
			bj_cineFadeFinishTimer = CreateTimer();//set bj_cineFadeFinishTimer = CreateTimer()
			TimerStart(bj_cineFadeFinishTimer, duration, false, function FinishCinematicFadeBJ);//call TimerStart(bj_cineFadeFinishTimer, duration, false, function FinishCinematicFadeBJ)
		}//endfunction
		//
		private void ContinueCinematicFadeBJ() {//function ContinueCinematicFadeBJ takes nothing returns nothing
			DestroyTimer(bj_cineFadeContinueTimer);//call DestroyTimer(bj_cineFadeContinueTimer)
			bj_cineFadeContinueTimer = null;//set bj_cineFadeContinueTimer = null
			CinematicFadeCommonBJ(bj_cineFadeContinueRed, bj_cineFadeContinueGreen, bj_cineFadeContinueBlue, bj_cineFadeContinueDuration, bj_cineFadeContinueTex, bj_cineFadeContinueTrans, 100);//call CinematicFadeCommonBJ(bj_cineFadeContinueRed, bj_cineFadeContinueGreen, bj_cineFadeContinueBlue, bj_cineFadeContinueDuration, bj_cineFadeContinueTex, bj_cineFadeContinueTrans, 100)
		}//endfunction
		//
		private void ContinueCinematicFadeAfterBJ(float duration, float red, float green, float blue, float trans, string tex) {//function ContinueCinematicFadeAfterBJ takes real duration, real red, real green, real blue, real trans, string tex returns nothing
			bj_cineFadeContinueRed = red;//set bj_cineFadeContinueRed = red
			bj_cineFadeContinueGreen = green;//set bj_cineFadeContinueGreen = green
			bj_cineFadeContinueBlue = blue;//set bj_cineFadeContinueBlue = blue
			bj_cineFadeContinueTrans = trans;//set bj_cineFadeContinueTrans = trans
			bj_cineFadeContinueDuration = duration;//set bj_cineFadeContinueDuration = duration
			bj_cineFadeContinueTex = tex;//set bj_cineFadeContinueTex = tex
			//
			bj_cineFadeContinueTimer = CreateTimer();//set bj_cineFadeContinueTimer = CreateTimer()
			TimerStart(bj_cineFadeContinueTimer, duration, false, function ContinueCinematicFadeBJ);//call TimerStart(bj_cineFadeContinueTimer, duration, false, function ContinueCinematicFadeBJ)
		}//endfunction
		//
		private void AbortCinematicFadeBJ() {//function AbortCinematicFadeBJ takes nothing returns nothing
			if ((bj_cineFadeContinueTimer != null)) {//if (bj_cineFadeContinueTimer != null) then
				DestroyTimer(bj_cineFadeContinueTimer);//call DestroyTimer(bj_cineFadeContinueTimer)
			}//endif
			if ((bj_cineFadeFinishTimer != null)) {//if (bj_cineFadeFinishTimer != null) then
				DestroyTimer(bj_cineFadeFinishTimer);//call DestroyTimer(bj_cineFadeFinishTimer)
			}//endif
		}//endfunction
		//
		private void CinematicFadeBJ(int fadetype, float duration, string tex, float red, float green, float blue, float trans) {//function CinematicFadeBJ takes integer fadetype, real duration, string tex, real red, real green, real blue, real trans returns nothing
			if ((fadetype == bj_CINEFADETYPE_FADEOUT)) {//if (fadetype == bj_CINEFADETYPE_FADEOUT) then
				//
				AbortCinematicFadeBJ();//call AbortCinematicFadeBJ()
				CinematicFadeCommonBJ(red, green, blue, duration, tex, 100, trans);//call CinematicFadeCommonBJ(red, green, blue, duration, tex, 100, trans)
			} else if ((fadetype == bj_CINEFADETYPE_FADEIN)) {//elseif (fadetype == bj_CINEFADETYPE_FADEIN) then
				//
				AbortCinematicFadeBJ();//call AbortCinematicFadeBJ()
				CinematicFadeCommonBJ(red, green, blue, duration, tex, trans, 100);//call CinematicFadeCommonBJ(red, green, blue, duration, tex, trans, 100)
				FinishCinematicFadeAfterBJ(duration);//call FinishCinematicFadeAfterBJ(duration)
			} else if ((fadetype == bj_CINEFADETYPE_FADEOUTIN)) {//elseif (fadetype == bj_CINEFADETYPE_FADEOUTIN) then
				//
				if ((duration > 0)) {//if (duration > 0) then
					AbortCinematicFadeBJ();//call AbortCinematicFadeBJ()
					CinematicFadeCommonBJ(red, green, blue, duration * 0.5, tex, 100, trans);//call CinematicFadeCommonBJ(red, green, blue, duration * 0.5, tex, 100, trans)
					ContinueCinematicFadeAfterBJ(duration * 0.5, red, green, blue, trans, tex);//call ContinueCinematicFadeAfterBJ(duration * 0.5, red, green, blue, trans, tex)
					FinishCinematicFadeAfterBJ(duration);//call FinishCinematicFadeAfterBJ(duration)
				}//endif
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private void CinematicFilterGenericBJ(float duration, blendmode bmode, string tex, float red0, float green0, float blue0, float trans0, float red1, float green1, float blue1, float trans1) {//function CinematicFilterGenericBJ takes real duration, blendmode bmode, string tex, real red0, real green0, real blue0, real trans0, real red1, real green1, real blue1, real trans1 returns nothing
			AbortCinematicFadeBJ();//call AbortCinematicFadeBJ()
			SetCineFilterTexture(tex);//call SetCineFilterTexture(tex)
			SetCineFilterBlendMode(bmode);//call SetCineFilterBlendMode(bmode)
			SetCineFilterTexMapFlags(TEXMAP_FLAG_NONE);//call SetCineFilterTexMapFlags(TEXMAP_FLAG_NONE)
			SetCineFilterStartUV(0, 0, 1, 1);//call SetCineFilterStartUV(0, 0, 1, 1)
			SetCineFilterEndUV(0, 0, 1, 1);//call SetCineFilterEndUV(0, 0, 1, 1)
			SetCineFilterStartColor(PercentTo255(red0), PercentTo255(green0), PercentTo255(blue0), PercentTo255(100-trans0));//call SetCineFilterStartColor(PercentTo255(red0), PercentTo255(green0), PercentTo255(blue0), PercentTo255(100-trans0))
			SetCineFilterEndColor(PercentTo255(red1), PercentTo255(green1), PercentTo255(blue1), PercentTo255(100-trans1));//call SetCineFilterEndColor(PercentTo255(red1), PercentTo255(green1), PercentTo255(blue1), PercentTo255(100-trans1))
			SetCineFilterDuration(duration);//call SetCineFilterDuration(duration)
			DisplayCineFilter(true);//call DisplayCineFilter(true)
		}//endfunction
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
		private void RescueUnitBJ(unit whichUnit, player rescuer, bool changeColor) {//function RescueUnitBJ takes unit whichUnit, player rescuer, boolean changeColor returns nothing
			if (IsUnitDeadBJ(whichUnit) || (GetOwningPlayer(whichUnit) == rescuer)) {//if IsUnitDeadBJ(whichUnit) or (GetOwningPlayer(whichUnit) == rescuer) then
				return;//return
			}//endif
			StartSound(bj_rescueSound);//call StartSound(bj_rescueSound)
			SetUnitOwner(whichUnit, rescuer, changeColor);//call SetUnitOwner(whichUnit, rescuer, changeColor)
			UnitAddIndicator(whichUnit, 0, 255, 0, 255);//call UnitAddIndicator(whichUnit, 0, 255, 0, 255)
			PingMinimapForPlayer(rescuer, GetUnitX(whichUnit), GetUnitY(whichUnit), bj_RESCUE_PING_TIME);//call PingMinimapForPlayer(rescuer, GetUnitX(whichUnit), GetUnitY(whichUnit), bj_RESCUE_PING_TIME)
		}//endfunction
		//
		private void TriggerActionUnitRescuedBJ() {//function TriggerActionUnitRescuedBJ takes nothing returns nothing
			unit theUnit = GetTriggerUnit();//local unit theUnit = GetTriggerUnit()
			if (IsUnitType(theUnit, UNIT_TYPE_STRUCTURE)) {//if IsUnitType(theUnit, UNIT_TYPE_STRUCTURE) then
				RescueUnitBJ(theUnit, GetOwningPlayer(GetRescuer()), bj_rescueChangeColorBldg);//call RescueUnitBJ(theUnit, GetOwningPlayer(GetRescuer()), bj_rescueChangeColorBldg)
			} else {//else
				RescueUnitBJ(theUnit, GetOwningPlayer(GetRescuer()), bj_rescueChangeColorUnit);//call RescueUnitBJ(theUnit, GetOwningPlayer(GetRescuer()), bj_rescueChangeColorUnit)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		private void TryInitRescuableTriggersBJ() {//function TryInitRescuableTriggersBJ takes nothing returns nothing
			int index;//local integer index
			if ((bj_rescueUnitBehavior == null)) {//if (bj_rescueUnitBehavior == null) then
				bj_rescueUnitBehavior = CreateTrigger();//set bj_rescueUnitBehavior = CreateTrigger()
				index = 0;//set index = 0
				while (true) {//loop
					TriggerRegisterPlayerUnitEvent(bj_rescueUnitBehavior, Player(index), EVENT_PLAYER_UNIT_RESCUED, null);//call TriggerRegisterPlayerUnitEvent(bj_rescueUnitBehavior, Player(index), EVENT_PLAYER_UNIT_RESCUED, null)
					index = index + 1;//set index = index + 1
					if (index == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen index == bj_MAX_PLAYER_SLOTS
				}//endloop
				TriggerAddAction(bj_rescueUnitBehavior, function TriggerActionUnitRescuedBJ);//call TriggerAddAction(bj_rescueUnitBehavior, function TriggerActionUnitRescuedBJ)
			}//endif
		}//endfunction
		//
		//
		//
		//
		private void SetRescueUnitColorChangeBJ(bool changeColor) {//function SetRescueUnitColorChangeBJ takes boolean changeColor returns nothing
			bj_rescueChangeColorUnit = changeColor;//set bj_rescueChangeColorUnit = changeColor
		}//endfunction
		//
		//
		//
		//
		private void SetRescueBuildingColorChangeBJ(bool changeColor) {//function SetRescueBuildingColorChangeBJ takes boolean changeColor returns nothing
			bj_rescueChangeColorBldg = changeColor;//set bj_rescueChangeColorBldg = changeColor
		}//endfunction
		//
		private void MakeUnitRescuableToForceBJEnum() {//function MakeUnitRescuableToForceBJEnum takes nothing returns nothing
			TryInitRescuableTriggersBJ();//call TryInitRescuableTriggersBJ()
			SetUnitRescuable(bj_makeUnitRescuableUnit, GetEnumPlayer(), bj_makeUnitRescuableFlag);//call SetUnitRescuable(bj_makeUnitRescuableUnit, GetEnumPlayer(), bj_makeUnitRescuableFlag)
		}//endfunction
		//
		private void MakeUnitRescuableToForceBJ(unit whichUnit, bool isRescuable, force whichForce) {//function MakeUnitRescuableToForceBJ takes unit whichUnit, boolean isRescuable, force whichForce returns nothing
			//
			bj_makeUnitRescuableUnit = whichUnit;//set bj_makeUnitRescuableUnit = whichUnit
			bj_makeUnitRescuableFlag = isRescuable;//set bj_makeUnitRescuableFlag = isRescuable
			ForForce(whichForce, function MakeUnitRescuableToForceBJEnum);//call ForForce(whichForce, function MakeUnitRescuableToForceBJEnum)
		}//endfunction
		//
		private void InitRescuableBehaviorBJ() {//function InitRescuableBehaviorBJ takes nothing returns nothing
			int index;//local integer index
			index = 0;//set index = 0
			while (true) {//loop
				//
				//
				if ((GetPlayerController(Player(index)) == MAP_CONTROL_RESCUABLE)) {//if (GetPlayerController(Player(index)) == MAP_CONTROL_RESCUABLE) then
					TryInitRescuableTriggersBJ();//call TryInitRescuableTriggersBJ()
					return;//return
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void SetPlayerTechResearchedSwap(int techid, int levels, player whichPlayer) {//function SetPlayerTechResearchedSwap takes integer techid, integer levels, player whichPlayer returns nothing
			SetPlayerTechResearched(whichPlayer, techid, levels);//call SetPlayerTechResearched(whichPlayer, techid, levels)
		}//endfunction
		//
		private void SetPlayerTechMaxAllowedSwap(int techid, int maximum, player whichPlayer) {//function SetPlayerTechMaxAllowedSwap takes integer techid, integer maximum, player whichPlayer returns nothing
			SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);//call SetPlayerTechMaxAllowed(whichPlayer, techid, maximum)
		}//endfunction
		//
		private void SetPlayerMaxHeroesAllowed(int maximum, player whichPlayer) {//function SetPlayerMaxHeroesAllowed takes integer maximum, player whichPlayer returns nothing
			SetPlayerTechMaxAllowed(whichPlayer, 'HERO', maximum);//call SetPlayerTechMaxAllowed(whichPlayer, 'HERO', maximum)
		}//endfunction
		//
		private int GetPlayerTechCountSimple(int techid, player whichPlayer) {//function GetPlayerTechCountSimple takes integer techid, player whichPlayer returns integer
			return GetPlayerTechCount(whichPlayer, techid, true);//return GetPlayerTechCount(whichPlayer, techid, true)
		}//endfunction
		//
		private int GetPlayerTechMaxAllowedSwap(int techid, player whichPlayer) {//function GetPlayerTechMaxAllowedSwap takes integer techid, player whichPlayer returns integer
			return GetPlayerTechMaxAllowed(whichPlayer, techid);//return GetPlayerTechMaxAllowed(whichPlayer, techid)
		}//endfunction
		//
		private void SetPlayerAbilityAvailableBJ(bool avail, int abilid, player whichPlayer) {//function SetPlayerAbilityAvailableBJ takes boolean avail, integer abilid, player whichPlayer returns nothing
			SetPlayerAbilityAvailable(whichPlayer, abilid, avail);//call SetPlayerAbilityAvailable(whichPlayer, abilid, avail)
		}//endfunction
		//
		//
		//
		//
		//
		private void SetCampaignMenuRaceBJ(int campaignNumber) {//function SetCampaignMenuRaceBJ takes integer campaignNumber returns nothing
			if ((campaignNumber == bj_CAMPAIGN_INDEX_T)) {//if (campaignNumber == bj_CAMPAIGN_INDEX_T) then
				SetCampaignMenuRace(RACE_OTHER);//call SetCampaignMenuRace(RACE_OTHER)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_H)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_H) then
				SetCampaignMenuRace(RACE_HUMAN);//call SetCampaignMenuRace(RACE_HUMAN)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_U)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_U) then
				SetCampaignMenuRace(RACE_UNDEAD);//call SetCampaignMenuRace(RACE_UNDEAD)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_O)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_O) then
				SetCampaignMenuRace(RACE_ORC);//call SetCampaignMenuRace(RACE_ORC)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_N)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_N) then
				SetCampaignMenuRace(RACE_NIGHTELF);//call SetCampaignMenuRace(RACE_NIGHTELF)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_XN)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_XN) then
				SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XN);//call SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XN)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_XH)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_XH) then
				SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XH);//call SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XH)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_XU)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_XU) then
				SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XU);//call SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XU)
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_XO)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_XO) then
				SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XO);//call SetCampaignMenuRaceEx(bj_CAMPAIGN_OFFSET_XO)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		//
		private void SetMissionAvailableBJ(bool available, int missionIndex) {//function SetMissionAvailableBJ takes boolean available, integer missionIndex returns nothing
			int campaignNumber = missionIndex / 1000;//local integer campaignNumber = missionIndex / 1000
			int missionNumber = missionIndex - campaignNumber * 1000;//local integer missionNumber = missionIndex - campaignNumber * 1000
			SetMissionAvailable(campaignNumber, missionNumber, available);//call SetMissionAvailable(campaignNumber, missionNumber, available)
		}//endfunction
		//
		private void SetCampaignAvailableBJ(bool available, int campaignNumber) {//function SetCampaignAvailableBJ takes boolean available, integer campaignNumber returns nothing
			int campaignOffset;//local integer campaignOffset
			if ((campaignNumber == bj_CAMPAIGN_INDEX_H)) {//if (campaignNumber == bj_CAMPAIGN_INDEX_H) then
				SetTutorialCleared(true);//call SetTutorialCleared(true)
			}//endif
			if ((campaignNumber == bj_CAMPAIGN_INDEX_XN)) {//if (campaignNumber == bj_CAMPAIGN_INDEX_XN) then
				campaignOffset = bj_CAMPAIGN_OFFSET_XN;//set campaignOffset = bj_CAMPAIGN_OFFSET_XN
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_XH)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_XH) then
				campaignOffset = bj_CAMPAIGN_OFFSET_XH;//set campaignOffset = bj_CAMPAIGN_OFFSET_XH
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_XU)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_XU) then
				campaignOffset = bj_CAMPAIGN_OFFSET_XU;//set campaignOffset = bj_CAMPAIGN_OFFSET_XU
			} else if ((campaignNumber == bj_CAMPAIGN_INDEX_XO)) {//elseif (campaignNumber == bj_CAMPAIGN_INDEX_XO) then
				campaignOffset = bj_CAMPAIGN_OFFSET_XO;//set campaignOffset = bj_CAMPAIGN_OFFSET_XO
			} else {//else
				campaignOffset = campaignNumber;//set campaignOffset = campaignNumber
			}//endif
			SetCampaignAvailable(campaignOffset, available);//call SetCampaignAvailable(campaignOffset, available)
			SetCampaignMenuRaceBJ(campaignNumber);//call SetCampaignMenuRaceBJ(campaignNumber)
			ForceCampaignSelectScreen();//call ForceCampaignSelectScreen()
		}//endfunction
		//
		private void SetCinematicAvailableBJ(bool available, int cinematicIndex) {//function SetCinematicAvailableBJ takes boolean available, integer cinematicIndex returns nothing
			if (( cinematicIndex == bj_CINEMATICINDEX_TOP )) {//if ( cinematicIndex == bj_CINEMATICINDEX_TOP ) then
				SetOpCinematicAvailable(bj_CAMPAIGN_INDEX_T, available);//call SetOpCinematicAvailable( bj_CAMPAIGN_INDEX_T, available )
				PlayCinematic("TutorialOp");//call PlayCinematic( "TutorialOp" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_HOP)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_HOP) then
				SetOpCinematicAvailable(bj_CAMPAIGN_INDEX_H, available);//call SetOpCinematicAvailable( bj_CAMPAIGN_INDEX_H, available )
				PlayCinematic("HumanOp");//call PlayCinematic( "HumanOp" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_HED)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_HED) then
				SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_H, available);//call SetEdCinematicAvailable( bj_CAMPAIGN_INDEX_H, available )
				PlayCinematic("HumanEd");//call PlayCinematic( "HumanEd" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_OOP)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_OOP) then
				SetOpCinematicAvailable(bj_CAMPAIGN_INDEX_O, available);//call SetOpCinematicAvailable( bj_CAMPAIGN_INDEX_O, available )
				PlayCinematic("OrcOp");//call PlayCinematic( "OrcOp" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_OED)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_OED) then
				SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_O, available);//call SetEdCinematicAvailable( bj_CAMPAIGN_INDEX_O, available )
				PlayCinematic("OrcEd");//call PlayCinematic( "OrcEd" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_UOP)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_UOP) then
				SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_U, available);//call SetEdCinematicAvailable( bj_CAMPAIGN_INDEX_U, available )
				PlayCinematic("UndeadOp");//call PlayCinematic( "UndeadOp" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_UED)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_UED) then
				SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_U, available);//call SetEdCinematicAvailable( bj_CAMPAIGN_INDEX_U, available )
				PlayCinematic("UndeadEd");//call PlayCinematic( "UndeadEd" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_NOP)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_NOP) then
				SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_N, available);//call SetEdCinematicAvailable( bj_CAMPAIGN_INDEX_N, available )
				PlayCinematic("NightElfOp");//call PlayCinematic( "NightElfOp" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_NED)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_NED) then
				SetEdCinematicAvailable(bj_CAMPAIGN_INDEX_N, available);//call SetEdCinematicAvailable( bj_CAMPAIGN_INDEX_N, available )
				PlayCinematic("NightElfEd");//call PlayCinematic( "NightElfEd" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_XOP)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_XOP) then
				SetOpCinematicAvailable(bj_CAMPAIGN_OFFSET_XN, available);//call SetOpCinematicAvailable( bj_CAMPAIGN_OFFSET_XN, available )
				PlayCinematic("IntroX");//call PlayCinematic( "IntroX" )
			} else if ((cinematicIndex == bj_CINEMATICINDEX_XED)) {//elseif (cinematicIndex == bj_CINEMATICINDEX_XED) then
				SetEdCinematicAvailable(bj_CAMPAIGN_OFFSET_XU, available);//call SetEdCinematicAvailable( bj_CAMPAIGN_OFFSET_XU, available )
				PlayCinematic("OutroX");//call PlayCinematic( "OutroX" )
			} else {//else
				//
			}//endif
		}//endfunction
		//
		private gamecache InitGameCacheBJ(string campaignFile) {//function InitGameCacheBJ takes string campaignFile returns gamecache
			bj_lastCreatedGameCache = InitGameCache(campaignFile);//set bj_lastCreatedGameCache = InitGameCache(campaignFile)
			return bj_lastCreatedGameCache;//return bj_lastCreatedGameCache
		}//endfunction
		//
		private bool SaveGameCacheBJ(gamecache cache) {//function SaveGameCacheBJ takes gamecache cache returns boolean
			return SaveGameCache(cache);//return SaveGameCache(cache)
		}//endfunction
		//
		private gamecache GetLastCreatedGameCacheBJ() {//function GetLastCreatedGameCacheBJ takes nothing returns gamecache
			return bj_lastCreatedGameCache;//return bj_lastCreatedGameCache
		}//endfunction
		//
		private hashtable InitHashtableBJ() {//function InitHashtableBJ takes nothing returns hashtable
			bj_lastCreatedHashtable = InitHashtable();//set bj_lastCreatedHashtable = InitHashtable()
			return bj_lastCreatedHashtable;//return bj_lastCreatedHashtable
		}//endfunction
		//
		private hashtable GetLastCreatedHashtableBJ() {//function GetLastCreatedHashtableBJ takes nothing returns hashtable
			return bj_lastCreatedHashtable;//return bj_lastCreatedHashtable
		}//endfunction
		//
		private void StoreRealBJ(float value, string key, string missionKey, gamecache cache) {//function StoreRealBJ takes real value, string key, string missionKey, gamecache cache returns nothing
			StoreReal(cache, missionKey, key, value);//call StoreReal(cache, missionKey, key, value)
		}//endfunction
		//
		private void StoreIntegerBJ(int value, string key, string missionKey, gamecache cache) {//function StoreIntegerBJ takes integer value, string key, string missionKey, gamecache cache returns nothing
			StoreInteger(cache, missionKey, key, value);//call StoreInteger(cache, missionKey, key, value)
		}//endfunction
		//
		private void StoreBooleanBJ(bool value, string key, string missionKey, gamecache cache) {//function StoreBooleanBJ takes boolean value, string key, string missionKey, gamecache cache returns nothing
			StoreBoolean(cache, missionKey, key, value);//call StoreBoolean(cache, missionKey, key, value)
		}//endfunction
		//
		private bool StoreStringBJ(string value, string key, string missionKey, gamecache cache) {//function StoreStringBJ takes string value, string key, string missionKey, gamecache cache returns boolean
			return StoreString(cache, missionKey, key, value);//return StoreString(cache, missionKey, key, value)
		}//endfunction
		//
		private bool StoreUnitBJ(unit whichUnit, string key, string missionKey, gamecache cache) {//function StoreUnitBJ takes unit whichUnit, string key, string missionKey, gamecache cache returns boolean
			return StoreUnit(cache, missionKey, key, whichUnit);//return StoreUnit(cache, missionKey, key, whichUnit)
		}//endfunction
		//
		private void SaveRealBJ(float value, int key, int missionKey, hashtable table) {//function SaveRealBJ takes real value, integer key, integer missionKey, hashtable table returns nothing
			SaveReal(table, missionKey, key, value);//call SaveReal(table, missionKey, key, value)
		}//endfunction
		//
		private void SaveIntegerBJ(int value, int key, int missionKey, hashtable table) {//function SaveIntegerBJ takes integer value, integer key, integer missionKey, hashtable table returns nothing
			SaveInteger(table, missionKey, key, value);//call SaveInteger(table, missionKey, key, value)
		}//endfunction
		//
		private void SaveBooleanBJ(bool value, int key, int missionKey, hashtable table) {//function SaveBooleanBJ takes boolean value, integer key, integer missionKey, hashtable table returns nothing
			SaveBoolean(table, missionKey, key, value);//call SaveBoolean(table, missionKey, key, value)
		}//endfunction
		//
		private bool SaveStringBJ(string value, int key, int missionKey, hashtable table) {//function SaveStringBJ takes string value, integer key, integer missionKey, hashtable table returns boolean
			return SaveStr(table, missionKey, key, value);//return SaveStr(table, missionKey, key, value)
		}//endfunction
		//
		private bool SavePlayerHandleBJ(player whichPlayer, int key, int missionKey, hashtable table) {//function SavePlayerHandleBJ takes player whichPlayer, integer key, integer missionKey, hashtable table returns boolean
			return SavePlayerHandle(table, missionKey, key, whichPlayer);//return SavePlayerHandle(table, missionKey, key, whichPlayer)
		}//endfunction
		//
		private bool SaveWidgetHandleBJ(widget whichWidget, int key, int missionKey, hashtable table) {//function SaveWidgetHandleBJ takes widget whichWidget, integer key, integer missionKey, hashtable table returns boolean
			return SaveWidgetHandle(table, missionKey, key, whichWidget);//return SaveWidgetHandle(table, missionKey, key, whichWidget)
		}//endfunction
		//
		private bool SaveDestructableHandleBJ(destructable whichDestructable, int key, int missionKey, hashtable table) {//function SaveDestructableHandleBJ takes destructable whichDestructable, integer key, integer missionKey, hashtable table returns boolean
			return SaveDestructableHandle(table, missionKey, key, whichDestructable);//return SaveDestructableHandle(table, missionKey, key, whichDestructable)
		}//endfunction
		//
		private bool SaveItemHandleBJ(item whichItem, int key, int missionKey, hashtable table) {//function SaveItemHandleBJ takes item whichItem, integer key, integer missionKey, hashtable table returns boolean
			return SaveItemHandle(table, missionKey, key, whichItem);//return SaveItemHandle(table, missionKey, key, whichItem)
		}//endfunction
		//
		private bool SaveUnitHandleBJ(unit whichUnit, int key, int missionKey, hashtable table) {//function SaveUnitHandleBJ takes unit whichUnit, integer key, integer missionKey, hashtable table returns boolean
			return SaveUnitHandle(table, missionKey, key, whichUnit);//return SaveUnitHandle(table, missionKey, key, whichUnit)
		}//endfunction
		//
		private bool SaveAbilityHandleBJ(ability whichAbility, int key, int missionKey, hashtable table) {//function SaveAbilityHandleBJ takes ability whichAbility, integer key, integer missionKey, hashtable table returns boolean
			return SaveAbilityHandle(table, missionKey, key, whichAbility);//return SaveAbilityHandle(table, missionKey, key, whichAbility)
		}//endfunction
		//
		private bool SaveTimerHandleBJ(timer whichTimer, int key, int missionKey, hashtable table) {//function SaveTimerHandleBJ takes timer whichTimer, integer key, integer missionKey, hashtable table returns boolean
			return SaveTimerHandle(table, missionKey, key, whichTimer);//return SaveTimerHandle(table, missionKey, key, whichTimer)
		}//endfunction
		//
		private bool SaveTriggerHandleBJ(trigger whichTrigger, int key, int missionKey, hashtable table) {//function SaveTriggerHandleBJ takes trigger whichTrigger, integer key, integer missionKey, hashtable table returns boolean
			return SaveTriggerHandle(table, missionKey, key, whichTrigger);//return SaveTriggerHandle(table, missionKey, key, whichTrigger)
		}//endfunction
		//
		private bool SaveTriggerConditionHandleBJ(triggercondition whichTriggercondition, int key, int missionKey, hashtable table) {//function SaveTriggerConditionHandleBJ takes triggercondition whichTriggercondition, integer key, integer missionKey, hashtable table returns boolean
			return SaveTriggerConditionHandle(table, missionKey, key, whichTriggercondition);//return SaveTriggerConditionHandle(table, missionKey, key, whichTriggercondition)
		}//endfunction
		//
		private bool SaveTriggerActionHandleBJ(triggeraction whichTriggeraction, int key, int missionKey, hashtable table) {//function SaveTriggerActionHandleBJ takes triggeraction whichTriggeraction, integer key, integer missionKey, hashtable table returns boolean
			return SaveTriggerActionHandle(table, missionKey, key, whichTriggeraction);//return SaveTriggerActionHandle(table, missionKey, key, whichTriggeraction)
		}//endfunction
		//
		private bool SaveTriggerEventHandleBJ(event whichEvent, int key, int missionKey, hashtable table) {//function SaveTriggerEventHandleBJ takes event whichEvent, integer key, integer missionKey, hashtable table returns boolean
			return SaveTriggerEventHandle(table, missionKey, key, whichEvent);//return SaveTriggerEventHandle(table, missionKey, key, whichEvent)
		}//endfunction
		//
		private bool SaveForceHandleBJ(force whichForce, int key, int missionKey, hashtable table) {//function SaveForceHandleBJ takes force whichForce, integer key, integer missionKey, hashtable table returns boolean
			return SaveForceHandle(table, missionKey, key, whichForce);//return SaveForceHandle(table, missionKey, key, whichForce)
		}//endfunction
		//
		private bool SaveGroupHandleBJ(group whichGroup, int key, int missionKey, hashtable table) {//function SaveGroupHandleBJ takes group whichGroup, integer key, integer missionKey, hashtable table returns boolean
			return SaveGroupHandle(table, missionKey, key, whichGroup);//return SaveGroupHandle(table, missionKey, key, whichGroup)
		}//endfunction
		//
		private bool SaveLocationHandleBJ(location whichLocation, int key, int missionKey, hashtable table) {//function SaveLocationHandleBJ takes location whichLocation, integer key, integer missionKey, hashtable table returns boolean
			return SaveLocationHandle(table, missionKey, key, whichLocation);//return SaveLocationHandle(table, missionKey, key, whichLocation)
		}//endfunction
		//
		private bool SaveRectHandleBJ(rect whichRect, int key, int missionKey, hashtable table) {//function SaveRectHandleBJ takes rect whichRect, integer key, integer missionKey, hashtable table returns boolean
			return SaveRectHandle(table, missionKey, key, whichRect);//return SaveRectHandle(table, missionKey, key, whichRect)
		}//endfunction
		//
		private bool SaveBooleanExprHandleBJ(boolexpr whichBoolexpr, int key, int missionKey, hashtable table) {//function SaveBooleanExprHandleBJ takes boolexpr whichBoolexpr, integer key, integer missionKey, hashtable table returns boolean
			return SaveBooleanExprHandle(table, missionKey, key, whichBoolexpr);//return SaveBooleanExprHandle(table, missionKey, key, whichBoolexpr)
		}//endfunction
		//
		private bool SaveSoundHandleBJ(sound whichSound, int key, int missionKey, hashtable table) {//function SaveSoundHandleBJ takes sound whichSound, integer key, integer missionKey, hashtable table returns boolean
			return SaveSoundHandle(table, missionKey, key, whichSound);//return SaveSoundHandle(table, missionKey, key, whichSound)
		}//endfunction
		//
		private bool SaveEffectHandleBJ(effect whichEffect, int key, int missionKey, hashtable table) {//function SaveEffectHandleBJ takes effect whichEffect, integer key, integer missionKey, hashtable table returns boolean
			return SaveEffectHandle(table, missionKey, key, whichEffect);//return SaveEffectHandle(table, missionKey, key, whichEffect)
		}//endfunction
		//
		private bool SaveUnitPoolHandleBJ(unitpool whichUnitpool, int key, int missionKey, hashtable table) {//function SaveUnitPoolHandleBJ takes unitpool whichUnitpool, integer key, integer missionKey, hashtable table returns boolean
			return SaveUnitPoolHandle(table, missionKey, key, whichUnitpool);//return SaveUnitPoolHandle(table, missionKey, key, whichUnitpool)
		}//endfunction
		//
		private bool SaveItemPoolHandleBJ(itempool whichItempool, int key, int missionKey, hashtable table) {//function SaveItemPoolHandleBJ takes itempool whichItempool, integer key, integer missionKey, hashtable table returns boolean
			return SaveItemPoolHandle(table, missionKey, key, whichItempool);//return SaveItemPoolHandle(table, missionKey, key, whichItempool)
		}//endfunction
		//
		private bool SaveQuestHandleBJ(quest whichQuest, int key, int missionKey, hashtable table) {//function SaveQuestHandleBJ takes quest whichQuest, integer key, integer missionKey, hashtable table returns boolean
			return SaveQuestHandle(table, missionKey, key, whichQuest);//return SaveQuestHandle(table, missionKey, key, whichQuest)
		}//endfunction
		//
		private bool SaveQuestItemHandleBJ(questitem whichQuestitem, int key, int missionKey, hashtable table) {//function SaveQuestItemHandleBJ takes questitem whichQuestitem, integer key, integer missionKey, hashtable table returns boolean
			return SaveQuestItemHandle(table, missionKey, key, whichQuestitem);//return SaveQuestItemHandle(table, missionKey, key, whichQuestitem)
		}//endfunction
		//
		private bool SaveDefeatConditionHandleBJ(defeatcondition whichDefeatcondition, int key, int missionKey, hashtable table) {//function SaveDefeatConditionHandleBJ takes defeatcondition whichDefeatcondition, integer key, integer missionKey, hashtable table returns boolean
			return SaveDefeatConditionHandle(table, missionKey, key, whichDefeatcondition);//return SaveDefeatConditionHandle(table, missionKey, key, whichDefeatcondition)
		}//endfunction
		//
		private bool SaveTimerDialogHandleBJ(timerdialog whichTimerdialog, int key, int missionKey, hashtable table) {//function SaveTimerDialogHandleBJ takes timerdialog whichTimerdialog, integer key, integer missionKey, hashtable table returns boolean
			return SaveTimerDialogHandle(table, missionKey, key, whichTimerdialog);//return SaveTimerDialogHandle(table, missionKey, key, whichTimerdialog)
		}//endfunction
		//
		private bool SaveLeaderboardHandleBJ(leaderboard whichLeaderboard, int key, int missionKey, hashtable table) {//function SaveLeaderboardHandleBJ takes leaderboard whichLeaderboard, integer key, integer missionKey, hashtable table returns boolean
			return SaveLeaderboardHandle(table, missionKey, key, whichLeaderboard);//return SaveLeaderboardHandle(table, missionKey, key, whichLeaderboard)
		}//endfunction
		//
		private bool SaveMultiboardHandleBJ(multiboard whichMultiboard, int key, int missionKey, hashtable table) {//function SaveMultiboardHandleBJ takes multiboard whichMultiboard, integer key, integer missionKey, hashtable table returns boolean
			return SaveMultiboardHandle(table, missionKey, key, whichMultiboard);//return SaveMultiboardHandle(table, missionKey, key, whichMultiboard)
		}//endfunction
		//
		private bool SaveMultiboardItemHandleBJ(multiboarditem whichMultiboarditem, int key, int missionKey, hashtable table) {//function SaveMultiboardItemHandleBJ takes multiboarditem whichMultiboarditem, integer key, integer missionKey, hashtable table returns boolean
			return SaveMultiboardItemHandle(table, missionKey, key, whichMultiboarditem);//return SaveMultiboardItemHandle(table, missionKey, key, whichMultiboarditem)
		}//endfunction
		//
		private bool SaveTrackableHandleBJ(trackable whichTrackable, int key, int missionKey, hashtable table) {//function SaveTrackableHandleBJ takes trackable whichTrackable, integer key, integer missionKey, hashtable table returns boolean
			return SaveTrackableHandle(table, missionKey, key, whichTrackable);//return SaveTrackableHandle(table, missionKey, key, whichTrackable)
		}//endfunction
		//
		private bool SaveDialogHandleBJ(dialog whichDialog, int key, int missionKey, hashtable table) {//function SaveDialogHandleBJ takes dialog whichDialog, integer key, integer missionKey, hashtable table returns boolean
			return SaveDialogHandle(table, missionKey, key, whichDialog);//return SaveDialogHandle(table, missionKey, key, whichDialog)
		}//endfunction
		//
		private bool SaveButtonHandleBJ(button whichButton, int key, int missionKey, hashtable table) {//function SaveButtonHandleBJ takes button whichButton, integer key, integer missionKey, hashtable table returns boolean
			return SaveButtonHandle(table, missionKey, key, whichButton);//return SaveButtonHandle(table, missionKey, key, whichButton)
		}//endfunction
		//
		private bool SaveTextTagHandleBJ(texttag whichTexttag, int key, int missionKey, hashtable table) {//function SaveTextTagHandleBJ takes texttag whichTexttag, integer key, integer missionKey, hashtable table returns boolean
			return SaveTextTagHandle(table, missionKey, key, whichTexttag);//return SaveTextTagHandle(table, missionKey, key, whichTexttag)
		}//endfunction
		//
		private bool SaveLightningHandleBJ(lightning whichLightning, int key, int missionKey, hashtable table) {//function SaveLightningHandleBJ takes lightning whichLightning, integer key, integer missionKey, hashtable table returns boolean
			return SaveLightningHandle(table, missionKey, key, whichLightning);//return SaveLightningHandle(table, missionKey, key, whichLightning)
		}//endfunction
		//
		private bool SaveImageHandleBJ(image whichImage, int key, int missionKey, hashtable table) {//function SaveImageHandleBJ takes image whichImage, integer key, integer missionKey, hashtable table returns boolean
			return SaveImageHandle(table, missionKey, key, whichImage);//return SaveImageHandle(table, missionKey, key, whichImage)
		}//endfunction
		//
		private bool SaveUbersplatHandleBJ(ubersplat whichUbersplat, int key, int missionKey, hashtable table) {//function SaveUbersplatHandleBJ takes ubersplat whichUbersplat, integer key, integer missionKey, hashtable table returns boolean
			return SaveUbersplatHandle(table, missionKey, key, whichUbersplat);//return SaveUbersplatHandle(table, missionKey, key, whichUbersplat)
		}//endfunction
		//
		private bool SaveRegionHandleBJ(region whichRegion, int key, int missionKey, hashtable table) {//function SaveRegionHandleBJ takes region whichRegion, integer key, integer missionKey, hashtable table returns boolean
			return SaveRegionHandle(table, missionKey, key, whichRegion);//return SaveRegionHandle(table, missionKey, key, whichRegion)
		}//endfunction
		//
		private bool SaveFogStateHandleBJ(fogstate whichFogState, int key, int missionKey, hashtable table) {//function SaveFogStateHandleBJ takes fogstate whichFogState, integer key, integer missionKey, hashtable table returns boolean
			return SaveFogStateHandle(table, missionKey, key, whichFogState);//return SaveFogStateHandle(table, missionKey, key, whichFogState)
		}//endfunction
		//
		private bool SaveFogModifierHandleBJ(fogmodifier whichFogModifier, int key, int missionKey, hashtable table) {//function SaveFogModifierHandleBJ takes fogmodifier whichFogModifier, integer key, integer missionKey, hashtable table returns boolean
			return SaveFogModifierHandle(table, missionKey, key, whichFogModifier);//return SaveFogModifierHandle(table, missionKey, key, whichFogModifier)
		}//endfunction
		//
		private bool SaveAgentHandleBJ(agent whichAgent, int key, int missionKey, hashtable table) {//function SaveAgentHandleBJ takes agent whichAgent, integer key, integer missionKey, hashtable table returns boolean
			return SaveAgentHandle(table, missionKey, key, whichAgent);//return SaveAgentHandle(table, missionKey, key, whichAgent)
		}//endfunction
		//
		private bool SaveHashtableHandleBJ(hashtable whichHashtable, int key, int missionKey, hashtable table) {//function SaveHashtableHandleBJ takes hashtable whichHashtable, integer key, integer missionKey, hashtable table returns boolean
			return SaveHashtableHandle(table, missionKey, key, whichHashtable);//return SaveHashtableHandle(table, missionKey, key, whichHashtable)
		}//endfunction
		//
		private float GetStoredRealBJ(string key, string missionKey, gamecache cache) {//function GetStoredRealBJ takes string key, string missionKey, gamecache cache returns real
			//
			return GetStoredReal(cache, missionKey, key);//return GetStoredReal(cache, missionKey, key)
		}//endfunction
		//
		private int GetStoredIntegerBJ(string key, string missionKey, gamecache cache) {//function GetStoredIntegerBJ takes string key, string missionKey, gamecache cache returns integer
			//
			return GetStoredInteger(cache, missionKey, key);//return GetStoredInteger(cache, missionKey, key)
		}//endfunction
		//
		private bool GetStoredBooleanBJ(string key, string missionKey, gamecache cache) {//function GetStoredBooleanBJ takes string key, string missionKey, gamecache cache returns boolean
			//
			return GetStoredBoolean(cache, missionKey, key);//return GetStoredBoolean(cache, missionKey, key)
		}//endfunction
		//
		private string GetStoredStringBJ(string key, string missionKey, gamecache cache) {//function GetStoredStringBJ takes string key, string missionKey, gamecache cache returns string
			string s;//local string s
			//
			s = GetStoredString(cache, missionKey, key);//set s = GetStoredString(cache, missionKey, key)
			if ((s == null)) {//if (s == null) then
				return "";//return ""
			} else {//else
				return s;//return s
			}//endif
		}//endfunction
		//
		private float LoadRealBJ(int key, int missionKey, hashtable table) {//function LoadRealBJ takes integer key, integer missionKey, hashtable table returns real
			//
			return LoadReal(table, missionKey, key);//return LoadReal(table, missionKey, key)
		}//endfunction
		//
		private int LoadIntegerBJ(int key, int missionKey, hashtable table) {//function LoadIntegerBJ takes integer key, integer missionKey, hashtable table returns integer
			//
			return LoadInteger(table, missionKey, key);//return LoadInteger(table, missionKey, key)
		}//endfunction
		//
		private bool LoadBooleanBJ(int key, int missionKey, hashtable table) {//function LoadBooleanBJ takes integer key, integer missionKey, hashtable table returns boolean
			//
			return LoadBoolean(table, missionKey, key);//return LoadBoolean(table, missionKey, key)
		}//endfunction
		//
		private string LoadStringBJ(int key, int missionKey, hashtable table) {//function LoadStringBJ takes integer key, integer missionKey, hashtable table returns string
			string s;//local string s
			//
			s = LoadStr(table, missionKey, key);//set s = LoadStr(table, missionKey, key)
			if ((s == null)) {//if (s == null) then
				return "";//return ""
			} else {//else
				return s;//return s
			}//endif
		}//endfunction
		//
		private player LoadPlayerHandleBJ(int key, int missionKey, hashtable table) {//function LoadPlayerHandleBJ takes integer key, integer missionKey, hashtable table returns player
			return LoadPlayerHandle(table, missionKey, key);//return LoadPlayerHandle(table, missionKey, key)
		}//endfunction
		//
		private widget LoadWidgetHandleBJ(int key, int missionKey, hashtable table) {//function LoadWidgetHandleBJ takes integer key, integer missionKey, hashtable table returns widget
			return LoadWidgetHandle(table, missionKey, key);//return LoadWidgetHandle(table, missionKey, key)
		}//endfunction
		//
		private destructable LoadDestructableHandleBJ(int key, int missionKey, hashtable table) {//function LoadDestructableHandleBJ takes integer key, integer missionKey, hashtable table returns destructable
			return LoadDestructableHandle(table, missionKey, key);//return LoadDestructableHandle(table, missionKey, key)
		}//endfunction
		//
		private item LoadItemHandleBJ(int key, int missionKey, hashtable table) {//function LoadItemHandleBJ takes integer key, integer missionKey, hashtable table returns item
			return LoadItemHandle(table, missionKey, key);//return LoadItemHandle(table, missionKey, key)
		}//endfunction
		//
		private unit LoadUnitHandleBJ(int key, int missionKey, hashtable table) {//function LoadUnitHandleBJ takes integer key, integer missionKey, hashtable table returns unit
			return LoadUnitHandle(table, missionKey, key);//return LoadUnitHandle(table, missionKey, key)
		}//endfunction
		//
		private ability LoadAbilityHandleBJ(int key, int missionKey, hashtable table) {//function LoadAbilityHandleBJ takes integer key, integer missionKey, hashtable table returns ability
			return LoadAbilityHandle(table, missionKey, key);//return LoadAbilityHandle(table, missionKey, key)
		}//endfunction
		//
		private timer LoadTimerHandleBJ(int key, int missionKey, hashtable table) {//function LoadTimerHandleBJ takes integer key, integer missionKey, hashtable table returns timer
			return LoadTimerHandle(table, missionKey, key);//return LoadTimerHandle(table, missionKey, key)
		}//endfunction
		//
		private trigger LoadTriggerHandleBJ(int key, int missionKey, hashtable table) {//function LoadTriggerHandleBJ takes integer key, integer missionKey, hashtable table returns trigger
			return LoadTriggerHandle(table, missionKey, key);//return LoadTriggerHandle(table, missionKey, key)
		}//endfunction
		//
		private triggercondition LoadTriggerConditionHandleBJ(int key, int missionKey, hashtable table) {//function LoadTriggerConditionHandleBJ takes integer key, integer missionKey, hashtable table returns triggercondition
			return LoadTriggerConditionHandle(table, missionKey, key);//return LoadTriggerConditionHandle(table, missionKey, key)
		}//endfunction
		//
		private triggeraction LoadTriggerActionHandleBJ(int key, int missionKey, hashtable table) {//function LoadTriggerActionHandleBJ takes integer key, integer missionKey, hashtable table returns triggeraction
			return LoadTriggerActionHandle(table, missionKey, key);//return LoadTriggerActionHandle(table, missionKey, key)
		}//endfunction
		//
		private event LoadTriggerEventHandleBJ(int key, int missionKey, hashtable table) {//function LoadTriggerEventHandleBJ takes integer key, integer missionKey, hashtable table returns event
			return LoadTriggerEventHandle(table, missionKey, key);//return LoadTriggerEventHandle(table, missionKey, key)
		}//endfunction
		//
		private force LoadForceHandleBJ(int key, int missionKey, hashtable table) {//function LoadForceHandleBJ takes integer key, integer missionKey, hashtable table returns force
			return LoadForceHandle(table, missionKey, key);//return LoadForceHandle(table, missionKey, key)
		}//endfunction
		//
		private group LoadGroupHandleBJ(int key, int missionKey, hashtable table) {//function LoadGroupHandleBJ takes integer key, integer missionKey, hashtable table returns group
			return LoadGroupHandle(table, missionKey, key);//return LoadGroupHandle(table, missionKey, key)
		}//endfunction
		//
		private location LoadLocationHandleBJ(int key, int missionKey, hashtable table) {//function LoadLocationHandleBJ takes integer key, integer missionKey, hashtable table returns location
			return LoadLocationHandle(table, missionKey, key);//return LoadLocationHandle(table, missionKey, key)
		}//endfunction
		//
		private rect LoadRectHandleBJ(int key, int missionKey, hashtable table) {//function LoadRectHandleBJ takes integer key, integer missionKey, hashtable table returns rect
			return LoadRectHandle(table, missionKey, key);//return LoadRectHandle(table, missionKey, key)
		}//endfunction
		//
		private boolexpr LoadBooleanExprHandleBJ(int key, int missionKey, hashtable table) {//function LoadBooleanExprHandleBJ takes integer key, integer missionKey, hashtable table returns boolexpr
			return LoadBooleanExprHandle(table, missionKey, key);//return LoadBooleanExprHandle(table, missionKey, key)
		}//endfunction
		//
		private sound LoadSoundHandleBJ(int key, int missionKey, hashtable table) {//function LoadSoundHandleBJ takes integer key, integer missionKey, hashtable table returns sound
			return LoadSoundHandle(table, missionKey, key);//return LoadSoundHandle(table, missionKey, key)
		}//endfunction
		//
		private effect LoadEffectHandleBJ(int key, int missionKey, hashtable table) {//function LoadEffectHandleBJ takes integer key, integer missionKey, hashtable table returns effect
			return LoadEffectHandle(table, missionKey, key);//return LoadEffectHandle(table, missionKey, key)
		}//endfunction
		//
		private unitpool LoadUnitPoolHandleBJ(int key, int missionKey, hashtable table) {//function LoadUnitPoolHandleBJ takes integer key, integer missionKey, hashtable table returns unitpool
			return LoadUnitPoolHandle(table, missionKey, key);//return LoadUnitPoolHandle(table, missionKey, key)
		}//endfunction
		//
		private itempool LoadItemPoolHandleBJ(int key, int missionKey, hashtable table) {//function LoadItemPoolHandleBJ takes integer key, integer missionKey, hashtable table returns itempool
			return LoadItemPoolHandle(table, missionKey, key);//return LoadItemPoolHandle(table, missionKey, key)
		}//endfunction
		//
		private quest LoadQuestHandleBJ(int key, int missionKey, hashtable table) {//function LoadQuestHandleBJ takes integer key, integer missionKey, hashtable table returns quest
			return LoadQuestHandle(table, missionKey, key);//return LoadQuestHandle(table, missionKey, key)
		}//endfunction
		//
		private questitem LoadQuestItemHandleBJ(int key, int missionKey, hashtable table) {//function LoadQuestItemHandleBJ takes integer key, integer missionKey, hashtable table returns questitem
			return LoadQuestItemHandle(table, missionKey, key);//return LoadQuestItemHandle(table, missionKey, key)
		}//endfunction
		//
		private defeatcondition LoadDefeatConditionHandleBJ(int key, int missionKey, hashtable table) {//function LoadDefeatConditionHandleBJ takes integer key, integer missionKey, hashtable table returns defeatcondition
			return LoadDefeatConditionHandle(table, missionKey, key);//return LoadDefeatConditionHandle(table, missionKey, key)
		}//endfunction
		//
		private timerdialog LoadTimerDialogHandleBJ(int key, int missionKey, hashtable table) {//function LoadTimerDialogHandleBJ takes integer key, integer missionKey, hashtable table returns timerdialog
			return LoadTimerDialogHandle(table, missionKey, key);//return LoadTimerDialogHandle(table, missionKey, key)
		}//endfunction
		//
		private leaderboard LoadLeaderboardHandleBJ(int key, int missionKey, hashtable table) {//function LoadLeaderboardHandleBJ takes integer key, integer missionKey, hashtable table returns leaderboard
			return LoadLeaderboardHandle(table, missionKey, key);//return LoadLeaderboardHandle(table, missionKey, key)
		}//endfunction
		//
		private multiboard LoadMultiboardHandleBJ(int key, int missionKey, hashtable table) {//function LoadMultiboardHandleBJ takes integer key, integer missionKey, hashtable table returns multiboard
			return LoadMultiboardHandle(table, missionKey, key);//return LoadMultiboardHandle(table, missionKey, key)
		}//endfunction
		//
		private multiboarditem LoadMultiboardItemHandleBJ(int key, int missionKey, hashtable table) {//function LoadMultiboardItemHandleBJ takes integer key, integer missionKey, hashtable table returns multiboarditem
			return LoadMultiboardItemHandle(table, missionKey, key);//return LoadMultiboardItemHandle(table, missionKey, key)
		}//endfunction
		//
		private trackable LoadTrackableHandleBJ(int key, int missionKey, hashtable table) {//function LoadTrackableHandleBJ takes integer key, integer missionKey, hashtable table returns trackable
			return LoadTrackableHandle(table, missionKey, key);//return LoadTrackableHandle(table, missionKey, key)
		}//endfunction
		//
		private dialog LoadDialogHandleBJ(int key, int missionKey, hashtable table) {//function LoadDialogHandleBJ takes integer key, integer missionKey, hashtable table returns dialog
			return LoadDialogHandle(table, missionKey, key);//return LoadDialogHandle(table, missionKey, key)
		}//endfunction
		//
		private button LoadButtonHandleBJ(int key, int missionKey, hashtable table) {//function LoadButtonHandleBJ takes integer key, integer missionKey, hashtable table returns button
			return LoadButtonHandle(table, missionKey, key);//return LoadButtonHandle(table, missionKey, key)
		}//endfunction
		//
		private texttag LoadTextTagHandleBJ(int key, int missionKey, hashtable table) {//function LoadTextTagHandleBJ takes integer key, integer missionKey, hashtable table returns texttag
			return LoadTextTagHandle(table, missionKey, key);//return LoadTextTagHandle(table, missionKey, key)
		}//endfunction
		//
		private lightning LoadLightningHandleBJ(int key, int missionKey, hashtable table) {//function LoadLightningHandleBJ takes integer key, integer missionKey, hashtable table returns lightning
			return LoadLightningHandle(table, missionKey, key);//return LoadLightningHandle(table, missionKey, key)
		}//endfunction
		//
		private image LoadImageHandleBJ(int key, int missionKey, hashtable table) {//function LoadImageHandleBJ takes integer key, integer missionKey, hashtable table returns image
			return LoadImageHandle(table, missionKey, key);//return LoadImageHandle(table, missionKey, key)
		}//endfunction
		//
		private ubersplat LoadUbersplatHandleBJ(int key, int missionKey, hashtable table) {//function LoadUbersplatHandleBJ takes integer key, integer missionKey, hashtable table returns ubersplat
			return LoadUbersplatHandle(table, missionKey, key);//return LoadUbersplatHandle(table, missionKey, key)
		}//endfunction
		//
		private region LoadRegionHandleBJ(int key, int missionKey, hashtable table) {//function LoadRegionHandleBJ takes integer key, integer missionKey, hashtable table returns region
			return LoadRegionHandle(table, missionKey, key);//return LoadRegionHandle(table, missionKey, key)
		}//endfunction
		//
		private fogstate LoadFogStateHandleBJ(int key, int missionKey, hashtable table) {//function LoadFogStateHandleBJ takes integer key, integer missionKey, hashtable table returns fogstate
			return LoadFogStateHandle(table, missionKey, key);//return LoadFogStateHandle(table, missionKey, key)
		}//endfunction
		//
		private fogmodifier LoadFogModifierHandleBJ(int key, int missionKey, hashtable table) {//function LoadFogModifierHandleBJ takes integer key, integer missionKey, hashtable table returns fogmodifier
			return LoadFogModifierHandle(table, missionKey, key);//return LoadFogModifierHandle(table, missionKey, key)
		}//endfunction
		//
		private hashtable LoadHashtableHandleBJ(int key, int missionKey, hashtable table) {//function LoadHashtableHandleBJ takes integer key, integer missionKey, hashtable table returns hashtable
			return LoadHashtableHandle(table, missionKey, key);//return LoadHashtableHandle(table, missionKey, key)
		}//endfunction
		//
		private unit RestoreUnitLocFacingAngleBJ(string key, string missionKey, gamecache cache, player forWhichPlayer, location loc, float facing) {//function RestoreUnitLocFacingAngleBJ takes string key, string missionKey, gamecache cache, player forWhichPlayer, location loc, real facing returns unit
			//
			bj_lastLoadedUnit = RestoreUnit(cache, missionKey, key, forWhichPlayer, GetLocationX(loc), GetLocationY(loc), facing);//set bj_lastLoadedUnit = RestoreUnit(cache, missionKey, key, forWhichPlayer, GetLocationX(loc), GetLocationY(loc), facing)
			return bj_lastLoadedUnit;//return bj_lastLoadedUnit
		}//endfunction
		//
		private unit RestoreUnitLocFacingPointBJ(string key, string missionKey, gamecache cache, player forWhichPlayer, location loc, location lookAt) {//function RestoreUnitLocFacingPointBJ takes string key, string missionKey, gamecache cache, player forWhichPlayer, location loc, location lookAt returns unit
			//
			return RestoreUnitLocFacingAngleBJ(key, missionKey, cache, forWhichPlayer, loc, AngleBetweenPoints(loc, lookAt));//return RestoreUnitLocFacingAngleBJ(key, missionKey, cache, forWhichPlayer, loc, AngleBetweenPoints(loc, lookAt))
		}//endfunction
		//
		private unit GetLastRestoredUnitBJ() {//function GetLastRestoredUnitBJ takes nothing returns unit
			return bj_lastLoadedUnit;//return bj_lastLoadedUnit
		}//endfunction
		//
		private void FlushGameCacheBJ(gamecache cache) {//function FlushGameCacheBJ takes gamecache cache returns nothing
			FlushGameCache(cache);//call FlushGameCache(cache)
		}//endfunction
		//
		private void FlushStoredMissionBJ(string missionKey, gamecache cache) {//function FlushStoredMissionBJ takes string missionKey, gamecache cache returns nothing
			FlushStoredMission(cache, missionKey);//call FlushStoredMission(cache, missionKey)
		}//endfunction
		//
		private void FlushParentHashtableBJ(hashtable table) {//function FlushParentHashtableBJ takes hashtable table returns nothing
			FlushParentHashtable(table);//call FlushParentHashtable(table)
		}//endfunction
		//
		private void FlushChildHashtableBJ(int missionKey, hashtable table) {//function FlushChildHashtableBJ takes integer missionKey, hashtable table returns nothing
			FlushChildHashtable(table, missionKey);//call FlushChildHashtable(table, missionKey)
		}//endfunction
		//
		private bool HaveStoredValue(string key, int valueType, string missionKey, gamecache cache) {//function HaveStoredValue takes string key, integer valueType, string missionKey, gamecache cache returns boolean
			if ((valueType == bj_GAMECACHE_BOOLEAN)) {//if (valueType == bj_GAMECACHE_BOOLEAN) then
				return HaveStoredBoolean(cache, missionKey, key);//return HaveStoredBoolean(cache, missionKey, key)
			} else if ((valueType == bj_GAMECACHE_INTEGER)) {//elseif (valueType == bj_GAMECACHE_INTEGER) then
				return HaveStoredInteger(cache, missionKey, key);//return HaveStoredInteger(cache, missionKey, key)
			} else if ((valueType == bj_GAMECACHE_REAL)) {//elseif (valueType == bj_GAMECACHE_REAL) then
				return HaveStoredReal(cache, missionKey, key);//return HaveStoredReal(cache, missionKey, key)
			} else if ((valueType == bj_GAMECACHE_UNIT)) {//elseif (valueType == bj_GAMECACHE_UNIT) then
				return HaveStoredUnit(cache, missionKey, key);//return HaveStoredUnit(cache, missionKey, key)
			} else if ((valueType == bj_GAMECACHE_STRING)) {//elseif (valueType == bj_GAMECACHE_STRING) then
				return HaveStoredString(cache, missionKey, key);//return HaveStoredString(cache, missionKey, key)
			} else {//else
				//
				return false;//return false
			}//endif
		}//endfunction
		//
		private bool HaveSavedValue(int key, int valueType, int missionKey, hashtable table) {//function HaveSavedValue takes integer key, integer valueType, integer missionKey, hashtable table returns boolean
			if ((valueType == bj_HASHTABLE_BOOLEAN)) {//if (valueType == bj_HASHTABLE_BOOLEAN) then
				return HaveSavedBoolean(table, missionKey, key);//return HaveSavedBoolean(table, missionKey, key)
			} else if ((valueType == bj_HASHTABLE_INTEGER)) {//elseif (valueType == bj_HASHTABLE_INTEGER) then
				return HaveSavedInteger(table, missionKey, key);//return HaveSavedInteger(table, missionKey, key)
			} else if ((valueType == bj_HASHTABLE_REAL)) {//elseif (valueType == bj_HASHTABLE_REAL) then
				return HaveSavedReal(table, missionKey, key);//return HaveSavedReal(table, missionKey, key)
			} else if ((valueType == bj_HASHTABLE_STRING)) {//elseif (valueType == bj_HASHTABLE_STRING) then
				return HaveSavedString(table, missionKey, key);//return HaveSavedString(table, missionKey, key)
			} else if ((valueType == bj_HASHTABLE_HANDLE)) {//elseif (valueType == bj_HASHTABLE_HANDLE) then
				return HaveSavedHandle(table, missionKey, key);//return HaveSavedHandle(table, missionKey, key)
			} else {//else
				//
				return false;//return false
			}//endif
		}//endfunction
		//
		private void ShowCustomCampaignButton(bool show, int whichButton) {//function ShowCustomCampaignButton takes boolean show, integer whichButton returns nothing
			SetCustomCampaignButtonVisible(whichButton - 1, show);//call SetCustomCampaignButtonVisible(whichButton - 1, show)
		}//endfunction
		//
		private bool IsCustomCampaignButtonVisibile(int whichButton) {//function IsCustomCampaignButtonVisibile takes integer whichButton returns boolean
			return GetCustomCampaignButtonVisible(whichButton - 1);//return GetCustomCampaignButtonVisible(whichButton - 1)
		}//endfunction
		//
		private void LoadGameBJ(string loadFileName, bool doScoreScreen) {//function LoadGameBJ takes string loadFileName, boolean doScoreScreen returns nothing
			LoadGame(loadFileName, doScoreScreen);//call LoadGame(loadFileName, doScoreScreen)
		}//endfunction
		//
		private void SaveAndChangeLevelBJ(string saveFileName, string newLevel, bool doScoreScreen) {//function SaveAndChangeLevelBJ takes string saveFileName, string newLevel, boolean doScoreScreen returns nothing
			SaveGame(saveFileName);//call SaveGame(saveFileName)
			ChangeLevel(newLevel, doScoreScreen);//call ChangeLevel(newLevel, doScoreScreen)
		}//endfunction
		//
		private void SaveAndLoadGameBJ(string saveFileName, string loadFileName, bool doScoreScreen) {//function SaveAndLoadGameBJ takes string saveFileName, string loadFileName, boolean doScoreScreen returns nothing
			SaveGame(saveFileName);//call SaveGame(saveFileName)
			LoadGame(loadFileName, doScoreScreen);//call LoadGame(loadFileName, doScoreScreen)
		}//endfunction
		//
		private bool RenameSaveDirectoryBJ(string sourceDirName, string destDirName) {//function RenameSaveDirectoryBJ takes string sourceDirName, string destDirName returns boolean
			return RenameSaveDirectory(sourceDirName, destDirName);//return RenameSaveDirectory(sourceDirName, destDirName)
		}//endfunction
		//
		private bool RemoveSaveDirectoryBJ(string sourceDirName) {//function RemoveSaveDirectoryBJ takes string sourceDirName returns boolean
			return RemoveSaveDirectory(sourceDirName);//return RemoveSaveDirectory(sourceDirName)
		}//endfunction
		//
		private bool CopySaveGameBJ(string sourceSaveName, string destSaveName) {//function CopySaveGameBJ takes string sourceSaveName, string destSaveName returns boolean
			return CopySaveGame(sourceSaveName, destSaveName);//return CopySaveGame(sourceSaveName, destSaveName)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private float GetPlayerStartLocationX(player whichPlayer) {//function GetPlayerStartLocationX takes player whichPlayer returns real
			return GetStartLocationX(GetPlayerStartLocation(whichPlayer));//return GetStartLocationX(GetPlayerStartLocation(whichPlayer))
		}//endfunction
		//
		private float GetPlayerStartLocationY(player whichPlayer) {//function GetPlayerStartLocationY takes player whichPlayer returns real
			return GetStartLocationY(GetPlayerStartLocation(whichPlayer));//return GetStartLocationY(GetPlayerStartLocation(whichPlayer))
		}//endfunction
		//
		private location GetPlayerStartLocationLoc(player whichPlayer) {//function GetPlayerStartLocationLoc takes player whichPlayer returns location
			return GetStartLocationLoc(GetPlayerStartLocation(whichPlayer));//return GetStartLocationLoc(GetPlayerStartLocation(whichPlayer))
		}//endfunction
		//
		private location GetRectCenter(rect whichRect) {//function GetRectCenter takes rect whichRect returns location
			return Location(GetRectCenterX(whichRect), GetRectCenterY(whichRect));//return Location(GetRectCenterX(whichRect), GetRectCenterY(whichRect))
		}//endfunction
		//
		private bool IsPlayerSlotState(player whichPlayer, playerslotstate whichState) {//function IsPlayerSlotState takes player whichPlayer, playerslotstate whichState returns boolean
			return GetPlayerSlotState(whichPlayer) == whichState;//return GetPlayerSlotState(whichPlayer) == whichState
		}//endfunction
		//
		private int GetFadeFromSeconds(float seconds) {//function GetFadeFromSeconds takes real seconds returns integer
			if ((seconds != 0)) {//if (seconds != 0) then
				return 128 / R2I(seconds);//return 128 / R2I(seconds)
			}//endif
			return 10000;//return 10000
		}//endfunction
		//
		private float GetFadeFromSecondsAsReal(float seconds) {//function GetFadeFromSecondsAsReal takes real seconds returns real
			if ((seconds != 0)) {//if (seconds != 0) then
				return 128.00 / seconds;//return 128.00 / seconds
			}//endif
			return 10000.00;//return 10000.00
		}//endfunction
		//
		private void AdjustPlayerStateSimpleBJ(player whichPlayer, playerstate whichPlayerState, int delta) {//function AdjustPlayerStateSimpleBJ takes player whichPlayer, playerstate whichPlayerState, integer delta returns nothing
			SetPlayerState(whichPlayer, whichPlayerState, GetPlayerState(whichPlayer, whichPlayerState) + delta);//call SetPlayerState(whichPlayer, whichPlayerState, GetPlayerState(whichPlayer, whichPlayerState) + delta)
		}//endfunction
		//
		private void AdjustPlayerStateBJ(int delta, player whichPlayer, playerstate whichPlayerState) {//function AdjustPlayerStateBJ takes integer delta, player whichPlayer, playerstate whichPlayerState returns nothing
			//
			//
			if ((delta > 0)) {//if (delta > 0) then
				if ((whichPlayerState == PLAYER_STATE_RESOURCE_GOLD)) {//if (whichPlayerState == PLAYER_STATE_RESOURCE_GOLD) then
					AdjustPlayerStateSimpleBJ(whichPlayer, PLAYER_STATE_GOLD_GATHERED, delta);//call AdjustPlayerStateSimpleBJ(whichPlayer, PLAYER_STATE_GOLD_GATHERED, delta)
				} else if ((whichPlayerState == PLAYER_STATE_RESOURCE_LUMBER)) {//elseif (whichPlayerState == PLAYER_STATE_RESOURCE_LUMBER) then
					AdjustPlayerStateSimpleBJ(whichPlayer, PLAYER_STATE_LUMBER_GATHERED, delta);//call AdjustPlayerStateSimpleBJ(whichPlayer, PLAYER_STATE_LUMBER_GATHERED, delta)
				}//endif
			}//endif
			AdjustPlayerStateSimpleBJ(whichPlayer, whichPlayerState, delta);//call AdjustPlayerStateSimpleBJ(whichPlayer, whichPlayerState, delta)
		}//endfunction
		//
		private void SetPlayerStateBJ(player whichPlayer, playerstate whichPlayerState, int value) {//function SetPlayerStateBJ takes player whichPlayer, playerstate whichPlayerState, integer value returns nothing
			int oldValue = GetPlayerState(whichPlayer, whichPlayerState);//local integer oldValue = GetPlayerState(whichPlayer, whichPlayerState)
			AdjustPlayerStateBJ(value - oldValue, whichPlayer, whichPlayerState);//call AdjustPlayerStateBJ(value - oldValue, whichPlayer, whichPlayerState)
		}//endfunction
		//
		private void SetPlayerFlagBJ(playerstate whichPlayerFlag, bool flag, player whichPlayer) {//function SetPlayerFlagBJ takes playerstate whichPlayerFlag, boolean flag, player whichPlayer returns nothing
			SetPlayerState(whichPlayer, whichPlayerFlag, IntegerTertiaryOp(flag, 1, 0));//call SetPlayerState(whichPlayer, whichPlayerFlag, IntegerTertiaryOp(flag, 1, 0))
		}//endfunction
		//
		private void SetPlayerTaxRateBJ(int rate, playerstate whichResource, player sourcePlayer, player otherPlayer) {//function SetPlayerTaxRateBJ takes integer rate, playerstate whichResource, player sourcePlayer, player otherPlayer returns nothing
			SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);//call SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate)
		}//endfunction
		//
		private int GetPlayerTaxRateBJ(playerstate whichResource, player sourcePlayer, player otherPlayer) {//function GetPlayerTaxRateBJ takes playerstate whichResource, player sourcePlayer, player otherPlayer returns integer
			return GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);//return GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource)
		}//endfunction
		//
		private bool IsPlayerFlagSetBJ(playerstate whichPlayerFlag, player whichPlayer) {//function IsPlayerFlagSetBJ takes playerstate whichPlayerFlag, player whichPlayer returns boolean
			return GetPlayerState(whichPlayer, whichPlayerFlag) == 1;//return GetPlayerState(whichPlayer, whichPlayerFlag) == 1
		}//endfunction
		//
		private void AddResourceAmountBJ(int delta, unit whichUnit) {//function AddResourceAmountBJ takes integer delta, unit whichUnit returns nothing
			AddResourceAmount(whichUnit, delta);//call AddResourceAmount(whichUnit, delta)
		}//endfunction
		//
		private int GetConvertedPlayerId(player whichPlayer) {//function GetConvertedPlayerId takes player whichPlayer returns integer
			return GetPlayerId(whichPlayer) + 1;//return GetPlayerId(whichPlayer) + 1
		}//endfunction
		//
		private player ConvertedPlayer(int convertedPlayerId) {//function ConvertedPlayer takes integer convertedPlayerId returns player
			return Player(convertedPlayerId - 1);//return Player(convertedPlayerId - 1)
		}//endfunction
		//
		private float GetRectWidthBJ(rect r) {//function GetRectWidthBJ takes rect r returns real
			return GetRectMaxX(r) - GetRectMinX(r);//return GetRectMaxX(r) - GetRectMinX(r)
		}//endfunction
		//
		private float GetRectHeightBJ(rect r) {//function GetRectHeightBJ takes rect r returns real
			return GetRectMaxY(r) - GetRectMinY(r);//return GetRectMaxY(r) - GetRectMinY(r)
		}//endfunction
		//
		//
		//
		private unit BlightGoldMineForPlayerBJ(unit goldMine, player whichPlayer) {//function BlightGoldMineForPlayerBJ takes unit goldMine, player whichPlayer returns unit
			float mineX;//local real    mineX
			float mineY;//local real    mineY
			int mineGold;//local integer mineGold
			unit newMine;//local unit    newMine
			//
			if (GetUnitTypeId(goldMine) != 'ngol') {//if GetUnitTypeId(goldMine) != 'ngol' then
				return null;//return null
			}//endif
			//
			mineX = GetUnitX(goldMine);//set mineX    = GetUnitX(goldMine)
			mineY = GetUnitY(goldMine);//set mineY    = GetUnitY(goldMine)
			mineGold = GetResourceAmount(goldMine);//set mineGold = GetResourceAmount(goldMine)
			RemoveUnit(goldMine);//call RemoveUnit(goldMine)
			//
			newMine = CreateBlightedGoldmine(whichPlayer, mineX, mineY, bj_UNIT_FACING);//set newMine = CreateBlightedGoldmine(whichPlayer, mineX, mineY, bj_UNIT_FACING)
			SetResourceAmount(newMine, mineGold);//call SetResourceAmount(newMine, mineGold)
			return newMine;//return newMine
		}//endfunction
		//
		private unit BlightGoldMineForPlayer(unit goldMine, player whichPlayer) {//function BlightGoldMineForPlayer takes unit goldMine, player whichPlayer returns unit
			bj_lastHauntedGoldMine = BlightGoldMineForPlayerBJ(goldMine, whichPlayer);//set bj_lastHauntedGoldMine = BlightGoldMineForPlayerBJ(goldMine, whichPlayer)
			return bj_lastHauntedGoldMine;//return bj_lastHauntedGoldMine
		}//endfunction
		//
		private unit GetLastHauntedGoldMine() {//function GetLastHauntedGoldMine takes nothing returns unit
			return bj_lastHauntedGoldMine;//return bj_lastHauntedGoldMine
		}//endfunction
		//
		private bool IsPointBlightedBJ(location where) {//function IsPointBlightedBJ takes location where returns boolean
			return IsPointBlighted(GetLocationX(where), GetLocationY(where));//return IsPointBlighted(GetLocationX(where), GetLocationY(where))
		}//endfunction
		//
		private void SetPlayerColorBJEnum() {//function SetPlayerColorBJEnum takes nothing returns nothing
			SetUnitColor(GetEnumUnit(), bj_setPlayerTargetColor);//call SetUnitColor(GetEnumUnit(), bj_setPlayerTargetColor)
		}//endfunction
		//
		private void SetPlayerColorBJ(player whichPlayer, playercolor color, bool changeExisting) {//function SetPlayerColorBJ takes player whichPlayer, playercolor color, boolean changeExisting returns nothing
			group g;//local group g
			SetPlayerColor(whichPlayer, color);//call SetPlayerColor(whichPlayer, color)
			if (changeExisting) {//if changeExisting then
				bj_setPlayerTargetColor = color;//set bj_setPlayerTargetColor = color
				g = CreateGroup();//set g = CreateGroup()
				GroupEnumUnitsOfPlayer(g, whichPlayer, null);//call GroupEnumUnitsOfPlayer(g, whichPlayer, null)
				ForGroup(g, function SetPlayerColorBJEnum);//call ForGroup(g, function SetPlayerColorBJEnum)
				DestroyGroup(g);//call DestroyGroup(g)
			}//endif
		}//endfunction
		//
		private void SetPlayerUnitAvailableBJ(int unitId, bool allowed, player whichPlayer) {//function SetPlayerUnitAvailableBJ takes integer unitId, boolean allowed, player whichPlayer returns nothing
			if (allowed) {//if allowed then
				SetPlayerTechMaxAllowed(whichPlayer, unitId, -1);//call SetPlayerTechMaxAllowed(whichPlayer, unitId, -1)
			} else {//else
				SetPlayerTechMaxAllowed(whichPlayer, unitId, 0);//call SetPlayerTechMaxAllowed(whichPlayer, unitId, 0)
			}//endif
		}//endfunction
		//
		private void LockGameSpeedBJ() {//function LockGameSpeedBJ takes nothing returns nothing
			SetMapFlag(MAP_LOCK_SPEED, true);//call SetMapFlag(MAP_LOCK_SPEED, true)
		}//endfunction
		//
		private void UnlockGameSpeedBJ() {//function UnlockGameSpeedBJ takes nothing returns nothing
			SetMapFlag(MAP_LOCK_SPEED, false);//call SetMapFlag(MAP_LOCK_SPEED, false)
		}//endfunction
		//
		private bool IssueTargetOrderBJ(unit whichUnit, string order, widget targetWidget) {//function IssueTargetOrderBJ takes unit whichUnit, string order, widget targetWidget returns boolean
			return IssueTargetOrder( whichUnit, order, targetWidget );//return IssueTargetOrder( whichUnit, order, targetWidget )
		}//endfunction
		//
		private bool IssuePointOrderLocBJ(unit whichUnit, string order, location whichLocation) {//function IssuePointOrderLocBJ takes unit whichUnit, string order, location whichLocation returns boolean
			return IssuePointOrderLoc( whichUnit, order, whichLocation );//return IssuePointOrderLoc( whichUnit, order, whichLocation )
		}//endfunction
		//
		//
		//
		//
		private bool IssueTargetDestructableOrder(unit whichUnit, string order, widget targetWidget) {//function IssueTargetDestructableOrder takes unit whichUnit, string order, widget targetWidget returns boolean
			return IssueTargetOrder( whichUnit, order, targetWidget );//return IssueTargetOrder( whichUnit, order, targetWidget )
		}//endfunction
		private bool IssueTargetItemOrder(unit whichUnit, string order, widget targetWidget) {//function IssueTargetItemOrder takes unit whichUnit, string order, widget targetWidget returns boolean
			return IssueTargetOrder( whichUnit, order, targetWidget );//return IssueTargetOrder( whichUnit, order, targetWidget )
		}//endfunction
		//
		private bool IssueImmediateOrderBJ(unit whichUnit, string order) {//function IssueImmediateOrderBJ takes unit whichUnit, string order returns boolean
			return IssueImmediateOrder( whichUnit, order );//return IssueImmediateOrder( whichUnit, order )
		}//endfunction
		//
		private bool GroupTargetOrderBJ(group whichGroup, string order, widget targetWidget) {//function GroupTargetOrderBJ takes group whichGroup, string order, widget targetWidget returns boolean
			return GroupTargetOrder( whichGroup, order, targetWidget );//return GroupTargetOrder( whichGroup, order, targetWidget )
		}//endfunction
		//
		private bool GroupPointOrderLocBJ(group whichGroup, string order, location whichLocation) {//function GroupPointOrderLocBJ takes group whichGroup, string order, location whichLocation returns boolean
			return GroupPointOrderLoc( whichGroup, order, whichLocation );//return GroupPointOrderLoc( whichGroup, order, whichLocation )
		}//endfunction
		//
		private bool GroupImmediateOrderBJ(group whichGroup, string order) {//function GroupImmediateOrderBJ takes group whichGroup, string order returns boolean
			return GroupImmediateOrder( whichGroup, order );//return GroupImmediateOrder( whichGroup, order )
		}//endfunction
		//
		//
		//
		//
		private bool GroupTargetDestructableOrder(group whichGroup, string order, widget targetWidget) {//function GroupTargetDestructableOrder takes group whichGroup, string order, widget targetWidget returns boolean
			return GroupTargetOrder( whichGroup, order, targetWidget );//return GroupTargetOrder( whichGroup, order, targetWidget )
		}//endfunction
		private bool GroupTargetItemOrder(group whichGroup, string order, widget targetWidget) {//function GroupTargetItemOrder takes group whichGroup, string order, widget targetWidget returns boolean
			return GroupTargetOrder( whichGroup, order, targetWidget );//return GroupTargetOrder( whichGroup, order, targetWidget )
		}//endfunction
		//
		private destructable GetDyingDestructable() {//function GetDyingDestructable takes nothing returns destructable
			return GetTriggerDestructable();//return GetTriggerDestructable()
		}//endfunction
		//
		//
		//
		private void SetUnitRallyPoint(unit whichUnit, location targPos) {//function SetUnitRallyPoint takes unit whichUnit, location targPos returns nothing
			IssuePointOrderLocBJ(whichUnit, "setrally", targPos);//call IssuePointOrderLocBJ(whichUnit, "setrally", targPos)
		}//endfunction
		//
		private void SetUnitRallyUnit(unit whichUnit, unit targUnit) {//function SetUnitRallyUnit takes unit whichUnit, unit targUnit returns nothing
			IssueTargetOrder(whichUnit, "setrally", targUnit);//call IssueTargetOrder(whichUnit, "setrally", targUnit)
		}//endfunction
		//
		private void SetUnitRallyDestructable(unit whichUnit, destructable targDest) {//function SetUnitRallyDestructable takes unit whichUnit, destructable targDest returns nothing
			IssueTargetOrder(whichUnit, "setrally", targDest);//call IssueTargetOrder(whichUnit, "setrally", targDest)
		}//endfunction
		//
		//
		//
		//
		//
		private void SaveDyingWidget() {//function SaveDyingWidget takes nothing returns nothing
			bj_lastDyingWidget = GetTriggerWidget();//set bj_lastDyingWidget = GetTriggerWidget()
		}//endfunction
		//
		private void SetBlightRectBJ(bool addBlight, player whichPlayer, rect r) {//function SetBlightRectBJ takes boolean addBlight, player whichPlayer, rect r returns nothing
			SetBlightRect(whichPlayer, r, addBlight);//call SetBlightRect(whichPlayer, r, addBlight)
		}//endfunction
		//
		private void SetBlightRadiusLocBJ(bool addBlight, player whichPlayer, location loc, float radius) {//function SetBlightRadiusLocBJ takes boolean addBlight, player whichPlayer, location loc, real radius returns nothing
			SetBlightLoc(whichPlayer, loc, radius, addBlight);//call SetBlightLoc(whichPlayer, loc, radius, addBlight)
		}//endfunction
		//
		private string GetAbilityName(int abilcode) {//function GetAbilityName takes integer abilcode returns string
			return GetObjectName(abilcode);//return GetObjectName(abilcode)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void MeleeStartingVisibility() {//function MeleeStartingVisibility takes nothing returns nothing
			//
			SetFloatGameState(GAME_STATE_TIME_OF_DAY, bj_MELEE_STARTING_TOD);//call SetFloatGameState(GAME_STATE_TIME_OF_DAY, bj_MELEE_STARTING_TOD)
			//
			//
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void MeleeStartingResources() {//function MeleeStartingResources takes nothing returns nothing
			int index;//local integer index
			player indexPlayer;//local player  indexPlayer
			version v;//local version v
			int startingGold;//local integer startingGold
			int startingLumber;//local integer startingLumber
			v = VersionGet();//set v = VersionGet()
			if ((v == VERSION_REIGN_OF_CHAOS)) {//if (v == VERSION_REIGN_OF_CHAOS) then
				startingGold = bj_MELEE_STARTING_GOLD_V0;//set startingGold = bj_MELEE_STARTING_GOLD_V0
				startingLumber = bj_MELEE_STARTING_LUMBER_V0;//set startingLumber = bj_MELEE_STARTING_LUMBER_V0
			} else {//else
				startingGold = bj_MELEE_STARTING_GOLD_V1;//set startingGold = bj_MELEE_STARTING_GOLD_V1
				startingLumber = bj_MELEE_STARTING_LUMBER_V1;//set startingLumber = bj_MELEE_STARTING_LUMBER_V1
			}//endif
			//
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING) then
					SetPlayerState(indexPlayer, PLAYER_STATE_RESOURCE_GOLD, startingGold);//call SetPlayerState(indexPlayer, PLAYER_STATE_RESOURCE_GOLD, startingGold)
					SetPlayerState(indexPlayer, PLAYER_STATE_RESOURCE_LUMBER, startingLumber);//call SetPlayerState(indexPlayer, PLAYER_STATE_RESOURCE_LUMBER, startingLumber)
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void ReducePlayerTechMaxAllowed(player whichPlayer, int techId, int limit) {//function ReducePlayerTechMaxAllowed takes player whichPlayer, integer techId, integer limit returns nothing
			int oldMax = GetPlayerTechMaxAllowed(whichPlayer, techId);//local integer oldMax = GetPlayerTechMaxAllowed(whichPlayer, techId)
			//
			if ((oldMax < 0 || oldMax > limit)) {//if (oldMax < 0 or oldMax > limit) then
				SetPlayerTechMaxAllowed(whichPlayer, techId, limit);//call SetPlayerTechMaxAllowed(whichPlayer, techId, limit)
			}//endif
		}//endfunction
		//
		private void MeleeStartingHeroLimit() {//function MeleeStartingHeroLimit takes nothing returns nothing
			int index;//local integer index
			index = 0;//set index = 0
			while (true) {//loop
				//
				SetPlayerMaxHeroesAllowed(bj_MELEE_HERO_LIMIT, Player(index));//call SetPlayerMaxHeroesAllowed(bj_MELEE_HERO_LIMIT, Player(index))
				//
				ReducePlayerTechMaxAllowed(Player(index), 'Hamg', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Hamg', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Hmkg', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Hmkg', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Hpal', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Hpal', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Hblm', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Hblm', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Obla', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Obla', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Ofar', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Ofar', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Otch', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Otch', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Oshd', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Oshd', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Edem', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Edem', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Ekee', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Ekee', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Emoo', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Emoo', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Ewar', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Ewar', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Udea', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Udea', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Udre', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Udre', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Ulic', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Ulic', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Ucrl', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Ucrl', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Npbm', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Npbm', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Nbrn', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Nbrn', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Nngs', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Nngs', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Nplh', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Nplh', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Nbst', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Nbst', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Nalc', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Nalc', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Ntin', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Ntin', bj_MELEE_HERO_TYPE_LIMIT)
				ReducePlayerTechMaxAllowed(Player(index), 'Nfir', bj_MELEE_HERO_TYPE_LIMIT);//call ReducePlayerTechMaxAllowed(Player(index), 'Nfir', bj_MELEE_HERO_TYPE_LIMIT)
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		//
		//
		//
		private bool MeleeTrainedUnitIsHeroBJFilter() {//function MeleeTrainedUnitIsHeroBJFilter takes nothing returns boolean
			return IsUnitType(GetFilterUnit(), UNIT_TYPE_HERO);//return IsUnitType(GetFilterUnit(), UNIT_TYPE_HERO)
		}//endfunction
		//
		//
		//
		//
		//
		private void MeleeGrantItemsToHero(unit whichUnit) {//function MeleeGrantItemsToHero takes unit whichUnit returns nothing
			int owner = GetPlayerId(GetOwningPlayer(whichUnit));//local integer owner   = GetPlayerId(GetOwningPlayer(whichUnit))
			//
			if ((bj_meleeTwinkedHeroes[owner] < bj_MELEE_MAX_TWINKED_HEROES)) {//if (bj_meleeTwinkedHeroes[owner] < bj_MELEE_MAX_TWINKED_HEROES) then
				UnitAddItemById(whichUnit, 'stwp');//call UnitAddItemById(whichUnit, 'stwp')
				bj_meleeTwinkedHeroes[owner] = bj_meleeTwinkedHeroes[owner] + 1;//set bj_meleeTwinkedHeroes[owner] = bj_meleeTwinkedHeroes[owner] + 1
			}//endif
		}//endfunction
		//
		private void MeleeGrantItemsToTrainedHero() {//function MeleeGrantItemsToTrainedHero takes nothing returns nothing
			MeleeGrantItemsToHero(GetTrainedUnit());//call MeleeGrantItemsToHero(GetTrainedUnit())
		}//endfunction
		//
		private void MeleeGrantItemsToHiredHero() {//function MeleeGrantItemsToHiredHero takes nothing returns nothing
			MeleeGrantItemsToHero(GetSoldUnit());//call MeleeGrantItemsToHero(GetSoldUnit())
		}//endfunction
		//
		private void MeleeGrantHeroItems() {//function MeleeGrantHeroItems takes nothing returns nothing
			int index;//local integer index
			trigger trig;//local trigger trig
			//
			index = 0;//set index = 0
			while (true) {//loop
				bj_meleeTwinkedHeroes[index] = 0;//set bj_meleeTwinkedHeroes[index] = 0
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen index == bj_MAX_PLAYER_SLOTS
			}//endloop
			//
			//
			index = 0;//set index = 0
			while (true) {//loop
				trig = CreateTrigger();//set trig = CreateTrigger()
				TriggerRegisterPlayerUnitEvent(trig, Player(index), EVENT_PLAYER_UNIT_TRAIN_FINISH, filterMeleeTrainedUnitIsHeroBJ);//call TriggerRegisterPlayerUnitEvent(trig, Player(index), EVENT_PLAYER_UNIT_TRAIN_FINISH, filterMeleeTrainedUnitIsHeroBJ)
				TriggerAddAction(trig, function MeleeGrantItemsToTrainedHero);//call TriggerAddAction(trig, function MeleeGrantItemsToTrainedHero)
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
			//
			//
			trig = CreateTrigger();//set trig = CreateTrigger()
			TriggerRegisterPlayerUnitEvent(trig, Player(PLAYER_NEUTRAL_PASSIVE), EVENT_PLAYER_UNIT_SELL, filterMeleeTrainedUnitIsHeroBJ);//call TriggerRegisterPlayerUnitEvent(trig, Player(PLAYER_NEUTRAL_PASSIVE), EVENT_PLAYER_UNIT_SELL, filterMeleeTrainedUnitIsHeroBJ)
			TriggerAddAction(trig, function MeleeGrantItemsToHiredHero);//call TriggerAddAction(trig, function MeleeGrantItemsToHiredHero)
			//
			//
			bj_meleeGrantHeroItems = true;//set bj_meleeGrantHeroItems = true
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void MeleeClearExcessUnit() {//function MeleeClearExcessUnit takes nothing returns nothing
			unit theUnit = GetEnumUnit();//local unit    theUnit = GetEnumUnit()
			int owner = GetPlayerId(GetOwningPlayer(theUnit));//local integer owner   = GetPlayerId(GetOwningPlayer(theUnit))
			if ((owner == PLAYER_NEUTRAL_AGGRESSIVE)) {//if (owner == PLAYER_NEUTRAL_AGGRESSIVE) then
				//
				RemoveUnit(GetEnumUnit());//call RemoveUnit(GetEnumUnit())
			} else if ((owner == PLAYER_NEUTRAL_PASSIVE)) {//elseif (owner == PLAYER_NEUTRAL_PASSIVE) then
				//
				if (!IsUnitType(theUnit, UNIT_TYPE_STRUCTURE)) {//if not IsUnitType(theUnit, UNIT_TYPE_STRUCTURE) then
					RemoveUnit(GetEnumUnit());//call RemoveUnit(GetEnumUnit())
				}//endif
			}//endif
		}//endfunction
		//
		private void MeleeClearNearbyUnits(float x, float y, float range) {//function MeleeClearNearbyUnits takes real x, real y, real range returns nothing
			group nearbyUnits;//local group nearbyUnits
			nearbyUnits = CreateGroup();//set nearbyUnits = CreateGroup()
			GroupEnumUnitsInRange(nearbyUnits, x, y, range, null);//call GroupEnumUnitsInRange(nearbyUnits, x, y, range, null)
			ForGroup(nearbyUnits, function MeleeClearExcessUnit);//call ForGroup(nearbyUnits, function MeleeClearExcessUnit)
			DestroyGroup(nearbyUnits);//call DestroyGroup(nearbyUnits)
		}//endfunction
		//
		private void MeleeClearExcessUnits() {//function MeleeClearExcessUnits takes nothing returns nothing
			int index;//local integer index
			float locX;//local real    locX
			float locY;//local real    locY
			player indexPlayer;//local player  indexPlayer
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				//
				if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING) then
					locX = GetStartLocationX(GetPlayerStartLocation(indexPlayer));//set locX = GetStartLocationX(GetPlayerStartLocation(indexPlayer))
					locY = GetStartLocationY(GetPlayerStartLocation(indexPlayer));//set locY = GetStartLocationY(GetPlayerStartLocation(indexPlayer))
					MeleeClearNearbyUnits(locX, locY, bj_MELEE_CLEAR_UNITS_RADIUS);//call MeleeClearNearbyUnits(locX, locY, bj_MELEE_CLEAR_UNITS_RADIUS)
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void MeleeEnumFindNearestMine() {//function MeleeEnumFindNearestMine takes nothing returns nothing
			unit enumUnit = GetEnumUnit();//local unit enumUnit = GetEnumUnit()
			float dist;//local real dist
			location unitLoc;//local location unitLoc
			if ((GetUnitTypeId(enumUnit) == 'ngol')) {//if (GetUnitTypeId(enumUnit) == 'ngol') then
				unitLoc = GetUnitLoc(enumUnit);//set unitLoc = GetUnitLoc(enumUnit)
				dist = DistanceBetweenPoints(unitLoc, bj_meleeNearestMineToLoc);//set dist = DistanceBetweenPoints(unitLoc, bj_meleeNearestMineToLoc)
				RemoveLocation(unitLoc);//call RemoveLocation(unitLoc)
				//
				if ((bj_meleeNearestMineDist < 0) || (dist < bj_meleeNearestMineDist)) {//if (bj_meleeNearestMineDist < 0) or (dist < bj_meleeNearestMineDist) then
					bj_meleeNearestMine = enumUnit;//set bj_meleeNearestMine = enumUnit
					bj_meleeNearestMineDist = dist;//set bj_meleeNearestMineDist = dist
				}//endif
			}//endif
		}//endfunction
		//
		private unit MeleeFindNearestMine(location src, float range) {//function MeleeFindNearestMine takes location src, real range returns unit
			group nearbyMines;//local group nearbyMines
			bj_meleeNearestMine = null;//set bj_meleeNearestMine = null
			bj_meleeNearestMineDist = -1;//set bj_meleeNearestMineDist = -1
			bj_meleeNearestMineToLoc = src;//set bj_meleeNearestMineToLoc = src
			nearbyMines = CreateGroup();//set nearbyMines = CreateGroup()
			GroupEnumUnitsInRangeOfLoc(nearbyMines, src, range, null);//call GroupEnumUnitsInRangeOfLoc(nearbyMines, src, range, null)
			ForGroup(nearbyMines, function MeleeEnumFindNearestMine);//call ForGroup(nearbyMines, function MeleeEnumFindNearestMine)
			DestroyGroup(nearbyMines);//call DestroyGroup(nearbyMines)
			return bj_meleeNearestMine;//return bj_meleeNearestMine
		}//endfunction
		//
		private unit MeleeRandomHeroLoc(player p, int id1, int id2, int id3, int id4, location loc) {//function MeleeRandomHeroLoc takes player p, integer id1, integer id2, integer id3, integer id4, location loc returns unit
			unit hero = null;//local unit    hero = null
			int roll;//local integer roll
			int pick;//local integer pick
			version v;//local version v
			//
			v = VersionGet();//set v = VersionGet()
			if ((v == VERSION_REIGN_OF_CHAOS)) {//if (v == VERSION_REIGN_OF_CHAOS) then
				roll = GetRandomInt(1,3);//set roll = GetRandomInt(1,3)
			} else {//else
				roll = GetRandomInt(1,4);//set roll = GetRandomInt(1,4)
			}//endif
			//
			if (roll == 1) {//if roll == 1 then
				pick = id1;//set pick = id1
			} else if (roll == 2) {//elseif roll == 2 then
				pick = id2;//set pick = id2
			} else if (roll == 3) {//elseif roll == 3 then
				pick = id3;//set pick = id3
			} else if (roll == 4) {//elseif roll == 4 then
				pick = id4;//set pick = id4
			} else {//else
				//
				pick = id1;//set pick = id1
			}//endif
			//
			hero = CreateUnitAtLoc(p, pick, loc, bj_UNIT_FACING);//set hero = CreateUnitAtLoc(p, pick, loc, bj_UNIT_FACING)
			if (bj_meleeGrantHeroItems) {//if bj_meleeGrantHeroItems then
				MeleeGrantItemsToHero(hero);//call MeleeGrantItemsToHero(hero)
			}//endif
			return hero;//return hero
		}//endfunction
		//
		//
		//
		private location MeleeGetProjectedLoc(location src, location targ, float distance, float deltaAngle) {//function MeleeGetProjectedLoc takes location src, location targ, real distance, real deltaAngle returns location
			float srcX = GetLocationX(src);//local real srcX = GetLocationX(src)
			float srcY = GetLocationY(src);//local real srcY = GetLocationY(src)
			float direction = Atan2(GetLocationY(targ) - srcY, GetLocationX(targ) - srcX) + deltaAngle;//local real direction = Atan2(GetLocationY(targ) - srcY, GetLocationX(targ) - srcX) + deltaAngle
			return Location(srcX + distance * Cos(direction), srcY + distance * Sin(direction));//return Location(srcX + distance * Cos(direction), srcY + distance * Sin(direction))
		}//endfunction
		//
		private float MeleeGetNearestValueWithin(float val, float minVal, float maxVal) {//function MeleeGetNearestValueWithin takes real val, real minVal, real maxVal returns real
			if ((val < minVal)) {//if (val < minVal) then
				return minVal;//return minVal
			} else if ((val > maxVal)) {//elseif (val > maxVal) then
				return maxVal;//return maxVal
			} else {//else
				return val;//return val
			}//endif
		}//endfunction
		//
		private location MeleeGetLocWithinRect(location src, rect r) {//function MeleeGetLocWithinRect takes location src, rect r returns location
			float withinX = MeleeGetNearestValueWithin(GetLocationX(src), GetRectMinX(r), GetRectMaxX(r));//local real withinX = MeleeGetNearestValueWithin(GetLocationX(src), GetRectMinX(r), GetRectMaxX(r))
			float withinY = MeleeGetNearestValueWithin(GetLocationY(src), GetRectMinY(r), GetRectMaxY(r));//local real withinY = MeleeGetNearestValueWithin(GetLocationY(src), GetRectMinY(r), GetRectMaxY(r))
			return Location(withinX, withinY);//return Location(withinX, withinY)
		}//endfunction
		//
		//
		//
		//
		//
		private void MeleeStartingUnitsHuman(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload) {//function MeleeStartingUnitsHuman takes player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload returns nothing
			bool useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);//local boolean  useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO)
			float unitSpacing = 64.00;//local real     unitSpacing   = 64.00
			unit nearestMine;//local unit     nearestMine
			location nearMineLoc;//local location nearMineLoc
			location heroLoc;//local location heroLoc
			float peonX;//local real     peonX
			float peonY;//local real     peonY
			unit townHall = null;//local unit     townHall = null
			if ((doPreload)) {//if (doPreload) then
				Preloader("scripts\\HumanMelee.pld");//call Preloader( "scripts\\HumanMelee.pld" )
			}//endif
			nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);//set nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS)
			if ((nearestMine != null)) {//if (nearestMine != null) then
				//
				townHall = CreateUnitAtLoc(whichPlayer, 'htow', startLoc, bj_UNIT_FACING);//set townHall = CreateUnitAtLoc(whichPlayer, 'htow', startLoc, bj_UNIT_FACING)
				//
				nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);//set nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0)
				peonX = GetLocationX(nearMineLoc);//set peonX = GetLocationX(nearMineLoc)
				peonY = GetLocationY(nearMineLoc);//set peonY = GetLocationY(nearMineLoc)
				CreateUnit(whichPlayer, 'hpea', peonX + 0.00 * unitSpacing, peonY + 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX + 0.00 * unitSpacing, peonY + 1.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX + 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX + 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX - 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX - 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX + 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX + 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX - 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX - 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING)
				//
				heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);//set heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45)
			} else {//else
				//
				townHall = CreateUnitAtLoc(whichPlayer, 'htow', startLoc, bj_UNIT_FACING);//set townHall = CreateUnitAtLoc(whichPlayer, 'htow', startLoc, bj_UNIT_FACING)
				//
				peonX = GetLocationX(startLoc);//set peonX = GetLocationX(startLoc)
				peonY = GetLocationY(startLoc) - 224.00;//set peonY = GetLocationY(startLoc) - 224.00
				CreateUnit(whichPlayer, 'hpea', peonX + 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX + 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX + 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX + 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX + 0.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX + 0.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX - 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX - 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'hpea', peonX - 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'hpea', peonX - 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				//
				heroLoc = Location(peonX, peonY - 2.00 * unitSpacing);//set heroLoc = Location(peonX, peonY - 2.00 * unitSpacing)
			}//endif
			if ((townHall != null)) {//if (townHall != null) then
				UnitAddAbilityBJ('Amic', townHall);//call UnitAddAbilityBJ('Amic', townHall)
				UnitMakeAbilityPermanentBJ(true, 'Amic', townHall);//call UnitMakeAbilityPermanentBJ(true, 'Amic', townHall)
			}//endif
			if ((doHeroes)) {//if (doHeroes) then
				//
				//
				if (useRandomHero) {//if useRandomHero then
					MeleeRandomHeroLoc(whichPlayer, 'Hamg', 'Hmkg', 'Hpal', 'Hblm', heroLoc);//call MeleeRandomHeroLoc(whichPlayer, 'Hamg', 'Hmkg', 'Hpal', 'Hblm', heroLoc)
				} else {//else
					SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);//call SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS)
				}//endif
			}//endif
			if ((doCamera)) {//if (doCamera) then
				//
				SetCameraPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraPositionForPlayer(whichPlayer, peonX, peonY)
				SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		private void MeleeStartingUnitsOrc(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload) {//function MeleeStartingUnitsOrc takes player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload returns nothing
			bool useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);//local boolean  useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO)
			float unitSpacing = 64.00;//local real     unitSpacing   = 64.00
			unit nearestMine;//local unit     nearestMine
			location nearMineLoc;//local location nearMineLoc
			location heroLoc;//local location heroLoc
			float peonX;//local real     peonX
			float peonY;//local real     peonY
			if ((doPreload)) {//if (doPreload) then
				Preloader("scripts\\OrcMelee.pld");//call Preloader( "scripts\\OrcMelee.pld" )
			}//endif
			nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);//set nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS)
			if ((nearestMine != null)) {//if (nearestMine != null) then
				//
				CreateUnitAtLoc(whichPlayer, 'ogre', startLoc, bj_UNIT_FACING);//call CreateUnitAtLoc(whichPlayer, 'ogre', startLoc, bj_UNIT_FACING)
				//
				nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);//set nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0)
				peonX = GetLocationX(nearMineLoc);//set peonX = GetLocationX(nearMineLoc)
				peonY = GetLocationY(nearMineLoc);//set peonY = GetLocationY(nearMineLoc)
				CreateUnit(whichPlayer, 'opeo', peonX + 0.00 * unitSpacing, peonY + 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX + 0.00 * unitSpacing, peonY + 1.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX + 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX + 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX - 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX - 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX + 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX + 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX - 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX - 0.60 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING)
				//
				heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);//set heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45)
			} else {//else
				//
				CreateUnitAtLoc(whichPlayer, 'ogre', startLoc, bj_UNIT_FACING);//call CreateUnitAtLoc(whichPlayer, 'ogre', startLoc, bj_UNIT_FACING)
				//
				peonX = GetLocationX(startLoc);//set peonX = GetLocationX(startLoc)
				peonY = GetLocationY(startLoc) - 224.00;//set peonY = GetLocationY(startLoc) - 224.00
				CreateUnit(whichPlayer, 'opeo', peonX + 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX + 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX + 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX + 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX + 0.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX + 0.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX - 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX - 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'opeo', peonX - 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'opeo', peonX - 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				//
				heroLoc = Location(peonX, peonY - 2.00 * unitSpacing);//set heroLoc = Location(peonX, peonY - 2.00 * unitSpacing)
			}//endif
			if ((doHeroes)) {//if (doHeroes) then
				//
				//
				if (useRandomHero) {//if useRandomHero then
					MeleeRandomHeroLoc(whichPlayer, 'Obla', 'Ofar', 'Otch', 'Oshd', heroLoc);//call MeleeRandomHeroLoc(whichPlayer, 'Obla', 'Ofar', 'Otch', 'Oshd', heroLoc)
				} else {//else
					SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);//call SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS)
				}//endif
			}//endif
			if ((doCamera)) {//if (doCamera) then
				//
				SetCameraPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraPositionForPlayer(whichPlayer, peonX, peonY)
				SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		//
		//
		private void MeleeStartingUnitsUndead(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload) {//function MeleeStartingUnitsUndead takes player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload returns nothing
			bool useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);//local boolean  useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO)
			float unitSpacing = 64.00;//local real     unitSpacing   = 64.00
			unit nearestMine;//local unit     nearestMine
			location nearMineLoc;//local location nearMineLoc
			location nearTownLoc;//local location nearTownLoc
			location heroLoc;//local location heroLoc
			float peonX;//local real     peonX
			float peonY;//local real     peonY
			float ghoulX;//local real     ghoulX
			float ghoulY;//local real     ghoulY
			if ((doPreload)) {//if (doPreload) then
				Preloader("scripts\\UndeadMelee.pld");//call Preloader( "scripts\\UndeadMelee.pld" )
			}//endif
			nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);//set nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS)
			if ((nearestMine != null)) {//if (nearestMine != null) then
				//
				CreateUnitAtLoc(whichPlayer, 'unpl', startLoc, bj_UNIT_FACING);//call CreateUnitAtLoc(whichPlayer, 'unpl', startLoc, bj_UNIT_FACING)
				//
				nearestMine = BlightGoldMineForPlayerBJ(nearestMine, whichPlayer);//set nearestMine = BlightGoldMineForPlayerBJ(nearestMine, whichPlayer)
				//
				nearTownLoc = MeleeGetProjectedLoc(startLoc, GetUnitLoc(nearestMine), 288, 0);//set nearTownLoc = MeleeGetProjectedLoc(startLoc, GetUnitLoc(nearestMine), 288, 0)
				ghoulX = GetLocationX(nearTownLoc);//set ghoulX = GetLocationX(nearTownLoc)
				ghoulY = GetLocationY(nearTownLoc);//set ghoulY = GetLocationY(nearTownLoc)
				bj_ghoul[GetPlayerId(whichPlayer)] = CreateUnit(whichPlayer, 'ugho', ghoulX + 0.00 * unitSpacing, ghoulY + 0.00 * unitSpacing, bj_UNIT_FACING);//set bj_ghoul[GetPlayerId(whichPlayer)] = CreateUnit(whichPlayer, 'ugho', ghoulX + 0.00 * unitSpacing, ghoulY + 0.00 * unitSpacing, bj_UNIT_FACING)
				//
				nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);//set nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0)
				peonX = GetLocationX(nearMineLoc);//set peonX = GetLocationX(nearMineLoc)
				peonY = GetLocationY(nearMineLoc);//set peonY = GetLocationY(nearMineLoc)
				CreateUnit(whichPlayer, 'uaco', peonX + 0.00 * unitSpacing, peonY + 0.50 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'uaco', peonX + 0.00 * unitSpacing, peonY + 0.50 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'uaco', peonX + 0.65 * unitSpacing, peonY - 0.50 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'uaco', peonX + 0.65 * unitSpacing, peonY - 0.50 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'uaco', peonX - 0.65 * unitSpacing, peonY - 0.50 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'uaco', peonX - 0.65 * unitSpacing, peonY - 0.50 * unitSpacing, bj_UNIT_FACING)
				//
				SetBlightLoc(whichPlayer,nearMineLoc, 768, true);//call SetBlightLoc(whichPlayer,nearMineLoc, 768, true)
				//
				heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);//set heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45)
			} else {//else
				//
				CreateUnitAtLoc(whichPlayer, 'unpl', startLoc, bj_UNIT_FACING);//call CreateUnitAtLoc(whichPlayer, 'unpl', startLoc, bj_UNIT_FACING)
				//
				peonX = GetLocationX(startLoc);//set peonX = GetLocationX(startLoc)
				peonY = GetLocationY(startLoc) - 224.00;//set peonY = GetLocationY(startLoc) - 224.00
				CreateUnit(whichPlayer, 'uaco', peonX - 1.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'uaco', peonX - 1.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'uaco', peonX - 0.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'uaco', peonX - 0.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'uaco', peonX + 0.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'uaco', peonX + 0.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ugho', peonX + 1.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ugho', peonX + 1.50 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				//
				SetBlightLoc(whichPlayer,startLoc, 768, true);//call SetBlightLoc(whichPlayer,startLoc, 768, true)
				//
				heroLoc = Location(peonX, peonY - 2.00 * unitSpacing);//set heroLoc = Location(peonX, peonY - 2.00 * unitSpacing)
			}//endif
			if ((doHeroes)) {//if (doHeroes) then
				//
				//
				if (useRandomHero) {//if useRandomHero then
					MeleeRandomHeroLoc(whichPlayer, 'Udea', 'Udre', 'Ulic', 'Ucrl', heroLoc);//call MeleeRandomHeroLoc(whichPlayer, 'Udea', 'Udre', 'Ulic', 'Ucrl', heroLoc)
				} else {//else
					SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);//call SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS)
				}//endif
			}//endif
			if ((doCamera)) {//if (doCamera) then
				//
				SetCameraPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraPositionForPlayer(whichPlayer, peonX, peonY)
				SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY)
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		private void MeleeStartingUnitsNightElf(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload) {//function MeleeStartingUnitsNightElf takes player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload returns nothing
			bool useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO);//local boolean  useRandomHero = IsMapFlagSet(MAP_RANDOM_HERO)
			float unitSpacing = 64.00;//local real     unitSpacing   = 64.00
			float minTreeDist = 3.50 * bj_CELLWIDTH;//local real     minTreeDist   = 3.50 * bj_CELLWIDTH
			float minWispDist = 1.75 * bj_CELLWIDTH;//local real     minWispDist   = 1.75 * bj_CELLWIDTH
			unit nearestMine;//local unit     nearestMine
			location nearMineLoc;//local location nearMineLoc
			location wispLoc;//local location wispLoc
			location heroLoc;//local location heroLoc
			float peonX;//local real     peonX
			float peonY;//local real     peonY
			unit tree;//local unit     tree
			if ((doPreload)) {//if (doPreload) then
				Preloader("scripts\\NightElfMelee.pld");//call Preloader( "scripts\\NightElfMelee.pld" )
			}//endif
			nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS);//set nearestMine = MeleeFindNearestMine(startLoc, bj_MELEE_MINE_SEARCH_RADIUS)
			if ((nearestMine != null)) {//if (nearestMine != null) then
				//
				//
				//
				nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 650, 0);//set nearMineLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 650, 0)
				nearMineLoc = MeleeGetLocWithinRect(nearMineLoc, GetRectFromCircleBJ(GetUnitLoc(nearestMine), minTreeDist));//set nearMineLoc = MeleeGetLocWithinRect(nearMineLoc, GetRectFromCircleBJ(GetUnitLoc(nearestMine), minTreeDist))
				tree = CreateUnitAtLoc(whichPlayer, 'etol', nearMineLoc, bj_UNIT_FACING);//set tree = CreateUnitAtLoc(whichPlayer, 'etol', nearMineLoc, bj_UNIT_FACING)
				IssueTargetOrder(tree, "entangleinstant", nearestMine);//call IssueTargetOrder(tree, "entangleinstant", nearestMine)
				//
				wispLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0);//set wispLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 320, 0)
				wispLoc = MeleeGetLocWithinRect(wispLoc, GetRectFromCircleBJ(GetUnitLoc(nearestMine), minWispDist));//set wispLoc = MeleeGetLocWithinRect(wispLoc, GetRectFromCircleBJ(GetUnitLoc(nearestMine), minWispDist))
				peonX = GetLocationX(wispLoc);//set peonX = GetLocationX(wispLoc)
				peonY = GetLocationY(wispLoc);//set peonY = GetLocationY(wispLoc)
				CreateUnit(whichPlayer, 'ewsp', peonX + 0.00 * unitSpacing, peonY + 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX + 0.00 * unitSpacing, peonY + 1.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX + 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX + 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX - 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX - 1.00 * unitSpacing, peonY + 0.15 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX + 0.58 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX + 0.58 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX - 0.58 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX - 0.58 * unitSpacing, peonY - 1.00 * unitSpacing, bj_UNIT_FACING)
				//
				heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45);//set heroLoc = MeleeGetProjectedLoc(GetUnitLoc(nearestMine), startLoc, 384, 45)
			} else {//else
				//
				CreateUnitAtLoc(whichPlayer, 'etol', startLoc, bj_UNIT_FACING);//call CreateUnitAtLoc(whichPlayer, 'etol', startLoc, bj_UNIT_FACING)
				//
				peonX = GetLocationX(startLoc);//set peonX = GetLocationX(startLoc)
				peonY = GetLocationY(startLoc) - 224.00;//set peonY = GetLocationY(startLoc) - 224.00
				CreateUnit(whichPlayer, 'ewsp', peonX - 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX - 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX - 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX - 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX + 0.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX + 0.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX + 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX + 1.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				CreateUnit(whichPlayer, 'ewsp', peonX + 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING);//call CreateUnit(whichPlayer, 'ewsp', peonX + 2.00 * unitSpacing, peonY + 0.00 * unitSpacing, bj_UNIT_FACING)
				//
				heroLoc = Location(peonX, peonY - 2.00 * unitSpacing);//set heroLoc = Location(peonX, peonY - 2.00 * unitSpacing)
			}//endif
			if ((doHeroes)) {//if (doHeroes) then
				//
				//
				if (useRandomHero) {//if useRandomHero then
					MeleeRandomHeroLoc(whichPlayer, 'Edem', 'Ekee', 'Emoo', 'Ewar', heroLoc);//call MeleeRandomHeroLoc(whichPlayer, 'Edem', 'Ekee', 'Emoo', 'Ewar', heroLoc)
				} else {//else
					SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);//call SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS)
				}//endif
			}//endif
			if ((doCamera)) {//if (doCamera) then
				//
				SetCameraPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraPositionForPlayer(whichPlayer, peonX, peonY)
				SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY);//call SetCameraQuickPositionForPlayer(whichPlayer, peonX, peonY)
			}//endif
		}//endfunction
		//
		//
		//
		//
		private void MeleeStartingUnitsUnknownRace(player whichPlayer, location startLoc, bool doHeroes, bool doCamera, bool doPreload) {//function MeleeStartingUnitsUnknownRace takes player whichPlayer, location startLoc, boolean doHeroes, boolean doCamera, boolean doPreload returns nothing
			int index;//local integer index
			if ((doPreload)) {//if (doPreload) then
			}//endif
			index = 0;//set index = 0
			while (true) {//loop
				CreateUnit(whichPlayer, 'nshe', GetLocationX(startLoc) + GetRandomReal(-256, 256), GetLocationY(startLoc) + GetRandomReal(-256, 256), GetRandomReal(0, 360));//call CreateUnit(whichPlayer, 'nshe', GetLocationX(startLoc) + GetRandomReal(-256, 256), GetLocationY(startLoc) + GetRandomReal(-256, 256), GetRandomReal(0, 360))
				index = index + 1;//set index = index + 1
				if (index == 12) { break; }//exitwhen index == 12
			}//endloop
			if ((doHeroes)) {//if (doHeroes) then
				//
				SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS);//call SetPlayerState(whichPlayer, PLAYER_STATE_RESOURCE_HERO_TOKENS, bj_MELEE_STARTING_HERO_TOKENS)
			}//endif
			if ((doCamera)) {//if (doCamera) then
				//
				SetCameraPositionLocForPlayer(whichPlayer, startLoc);//call SetCameraPositionLocForPlayer(whichPlayer, startLoc)
				SetCameraQuickPositionLocForPlayer(whichPlayer, startLoc);//call SetCameraQuickPositionLocForPlayer(whichPlayer, startLoc)
			}//endif
		}//endfunction
		//
		private void MeleeStartingUnits() {//function MeleeStartingUnits takes nothing returns nothing
			int index;//local integer  index
			player indexPlayer;//local player   indexPlayer
			location indexStartLoc;//local location indexStartLoc
			race indexRace;//local race     indexRace
			Preloader("scripts\\SharedMelee.pld");//call Preloader( "scripts\\SharedMelee.pld" )
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING) then
					indexStartLoc = GetStartLocationLoc(GetPlayerStartLocation(indexPlayer));//set indexStartLoc = GetStartLocationLoc(GetPlayerStartLocation(indexPlayer))
					indexRace = GetPlayerRace(indexPlayer);//set indexRace = GetPlayerRace(indexPlayer)
					//
					if ((indexRace == RACE_HUMAN)) {//if (indexRace == RACE_HUMAN) then
						MeleeStartingUnitsHuman(indexPlayer, indexStartLoc, true, true, true);//call MeleeStartingUnitsHuman(indexPlayer, indexStartLoc, true, true, true)
					} else if ((indexRace == RACE_ORC)) {//elseif (indexRace == RACE_ORC) then
						MeleeStartingUnitsOrc(indexPlayer, indexStartLoc, true, true, true);//call MeleeStartingUnitsOrc(indexPlayer, indexStartLoc, true, true, true)
					} else if ((indexRace == RACE_UNDEAD)) {//elseif (indexRace == RACE_UNDEAD) then
						MeleeStartingUnitsUndead(indexPlayer, indexStartLoc, true, true, true);//call MeleeStartingUnitsUndead(indexPlayer, indexStartLoc, true, true, true)
					} else if ((indexRace == RACE_NIGHTELF)) {//elseif (indexRace == RACE_NIGHTELF) then
						MeleeStartingUnitsNightElf(indexPlayer, indexStartLoc, true, true, true);//call MeleeStartingUnitsNightElf(indexPlayer, indexStartLoc, true, true, true)
					} else {//else
						MeleeStartingUnitsUnknownRace(indexPlayer, indexStartLoc, true, true, true);//call MeleeStartingUnitsUnknownRace(indexPlayer, indexStartLoc, true, true, true)
					}//endif
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		private void MeleeStartingUnitsForPlayer(race whichRace, player whichPlayer, location loc, bool doHeroes) {//function MeleeStartingUnitsForPlayer takes race whichRace, player whichPlayer, location loc, boolean doHeroes returns nothing
			//
			if ((whichRace == RACE_HUMAN)) {//if (whichRace == RACE_HUMAN) then
				MeleeStartingUnitsHuman(whichPlayer, loc, doHeroes, false, false);//call MeleeStartingUnitsHuman(whichPlayer, loc, doHeroes, false, false)
			} else if ((whichRace == RACE_ORC)) {//elseif (whichRace == RACE_ORC) then
				MeleeStartingUnitsOrc(whichPlayer, loc, doHeroes, false, false);//call MeleeStartingUnitsOrc(whichPlayer, loc, doHeroes, false, false)
			} else if ((whichRace == RACE_UNDEAD)) {//elseif (whichRace == RACE_UNDEAD) then
				MeleeStartingUnitsUndead(whichPlayer, loc, doHeroes, false, false);//call MeleeStartingUnitsUndead(whichPlayer, loc, doHeroes, false, false)
			} else if ((whichRace == RACE_NIGHTELF)) {//elseif (whichRace == RACE_NIGHTELF) then
				MeleeStartingUnitsNightElf(whichPlayer, loc, doHeroes, false, false);//call MeleeStartingUnitsNightElf(whichPlayer, loc, doHeroes, false, false)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void PickMeleeAI(player num, string s1, string s2, string s3) {//function PickMeleeAI takes player num, string s1, string s2, string s3 returns nothing
			int pick;//local integer pick
			//
			//
			//
			if (GetAIDifficulty(num) == AI_DIFFICULTY_NEWBIE) {//if GetAIDifficulty(num) == AI_DIFFICULTY_NEWBIE then
				StartMeleeAI(num,s1);//call StartMeleeAI(num,s1)
				return;//return
			}//endif
			if (s2 == null) {//if s2 == null then
				pick = 1;//set pick = 1
			} else if (s3 == null) {//elseif s3 == null then
				pick = GetRandomInt(1,2);//set pick = GetRandomInt(1,2)
			} else {//else
				pick = GetRandomInt(1,3);//set pick = GetRandomInt(1,3)
			}//endif
			if (pick == 1) {//if pick == 1 then
				StartMeleeAI(num,s1);//call StartMeleeAI(num,s1)
			} else if (pick == 2) {//elseif pick == 2 then
				StartMeleeAI(num,s2);//call StartMeleeAI(num,s2)
			} else {//else
				StartMeleeAI(num,s3);//call StartMeleeAI(num,s3)
			}//endif
		}//endfunction
		//
		private void MeleeStartingAI() {//function MeleeStartingAI takes nothing returns nothing
			int index;//local integer index
			player indexPlayer;//local player  indexPlayer
			race indexRace;//local race    indexRace
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING) then
					indexRace = GetPlayerRace(indexPlayer);//set indexRace = GetPlayerRace(indexPlayer)
					if ((GetPlayerController(indexPlayer) == MAP_CONTROL_COMPUTER)) {//if (GetPlayerController(indexPlayer) == MAP_CONTROL_COMPUTER) then
						//
						if ((indexRace == RACE_HUMAN)) {//if (indexRace == RACE_HUMAN) then
							PickMeleeAI(indexPlayer, "human.ai", null, null);//call PickMeleeAI(indexPlayer, "human.ai", null, null)
						} else if ((indexRace == RACE_ORC)) {//elseif (indexRace == RACE_ORC) then
							PickMeleeAI(indexPlayer, "orc.ai", null, null);//call PickMeleeAI(indexPlayer, "orc.ai", null, null)
						} else if ((indexRace == RACE_UNDEAD)) {//elseif (indexRace == RACE_UNDEAD) then
							PickMeleeAI(indexPlayer, "undead.ai", null, null);//call PickMeleeAI(indexPlayer, "undead.ai", null, null)
							RecycleGuardPosition(bj_ghoul[index]);//call RecycleGuardPosition(bj_ghoul[index])
						} else if ((indexRace == RACE_NIGHTELF)) {//elseif (indexRace == RACE_NIGHTELF) then
							PickMeleeAI(indexPlayer, "elf.ai", null, null);//call PickMeleeAI(indexPlayer, "elf.ai", null, null)
						} else {//else
							//
						}//endif
						ShareEverythingWithTeamAI(indexPlayer);//call ShareEverythingWithTeamAI(indexPlayer)
					}//endif
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		private void LockGuardPosition(unit targ) {//function LockGuardPosition takes unit targ returns nothing
			SetUnitCreepGuard(targ,true);//call SetUnitCreepGuard(targ,true)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private bool MeleePlayerIsOpponent(int playerIndex, int opponentIndex) {//function MeleePlayerIsOpponent takes integer playerIndex, integer opponentIndex returns boolean
			player thePlayer = Player(playerIndex);//local player thePlayer = Player(playerIndex)
			player theOpponent = Player(opponentIndex);//local player theOpponent = Player(opponentIndex)
			//
			if ((playerIndex == opponentIndex)) {//if (playerIndex == opponentIndex) then
				return false;//return false
			}//endif
			//
			if ((GetPlayerSlotState(theOpponent) != PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerSlotState(theOpponent) != PLAYER_SLOT_STATE_PLAYING) then
				return false;//return false
			}//endif
			//
			if ((bj_meleeDefeated[opponentIndex])) {//if (bj_meleeDefeated[opponentIndex]) then
				return false;//return false
			}//endif
			//
			if (GetPlayerAlliance(thePlayer, theOpponent, ALLIANCE_PASSIVE)) {//if GetPlayerAlliance(thePlayer, theOpponent, ALLIANCE_PASSIVE) then
				if (GetPlayerAlliance(theOpponent, thePlayer, ALLIANCE_PASSIVE)) {//if GetPlayerAlliance(theOpponent, thePlayer, ALLIANCE_PASSIVE) then
					if ((GetPlayerState(thePlayer, PLAYER_STATE_ALLIED_VICTORY) == 1)) {//if (GetPlayerState(thePlayer, PLAYER_STATE_ALLIED_VICTORY) == 1) then
						if ((GetPlayerState(theOpponent, PLAYER_STATE_ALLIED_VICTORY) == 1)) {//if (GetPlayerState(theOpponent, PLAYER_STATE_ALLIED_VICTORY) == 1) then
							return false;//return false
						}//endif
					}//endif
				}//endif
			}//endif
			return true;//return true
		}//endfunction
		//
		//
		//
		private int MeleeGetAllyStructureCount(player whichPlayer) {//function MeleeGetAllyStructureCount takes player whichPlayer returns integer
			int playerIndex;//local integer    playerIndex
			int buildingCount;//local integer    buildingCount
			player indexPlayer;//local player     indexPlayer
			//
			buildingCount = 0;//set buildingCount = 0
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				//
				//
				if ((PlayersAreCoAllied(whichPlayer, indexPlayer))) {//if (PlayersAreCoAllied(whichPlayer, indexPlayer)) then
					buildingCount = buildingCount + GetPlayerStructureCount(indexPlayer, true);//set buildingCount = buildingCount + GetPlayerStructureCount(indexPlayer, true)
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			return buildingCount;//return buildingCount
		}//endfunction
		//
		//
		//
		private int MeleeGetAllyCount(player whichPlayer) {//function MeleeGetAllyCount takes player whichPlayer returns integer
			int playerIndex;//local integer playerIndex
			int playerCount;//local integer playerCount
			player indexPlayer;//local player  indexPlayer
			//
			playerCount = 0;//set playerCount = 0
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if (PlayersAreCoAllied(whichPlayer, indexPlayer) && !bj_meleeDefeated[playerIndex] && (whichPlayer != indexPlayer)) {//if PlayersAreCoAllied(whichPlayer, indexPlayer) and not bj_meleeDefeated[playerIndex] and (whichPlayer != indexPlayer) then
					playerCount = playerCount + 1;//set playerCount = playerCount + 1
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			return playerCount;//return playerCount
		}//endfunction
		//
		//
		//
		//
		//
		//
		private int MeleeGetAllyKeyStructureCount(player whichPlayer) {//function MeleeGetAllyKeyStructureCount takes player whichPlayer returns integer
			int playerIndex;//local integer    playerIndex
			player indexPlayer;//local player     indexPlayer
			int keyStructs;//local integer    keyStructs
			//
			keyStructs = 0;//set keyStructs = 0
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if ((PlayersAreCoAllied(whichPlayer, indexPlayer))) {//if (PlayersAreCoAllied(whichPlayer, indexPlayer)) then
					keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "townhall", true, true);//set keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "townhall", true, true)
					keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "greathall", true, true);//set keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "greathall", true, true)
					keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "treeoflife", true, true);//set keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "treeoflife", true, true)
					keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "necropolis", true, true);//set keyStructs = keyStructs + GetPlayerTypedUnitCount(indexPlayer, "necropolis", true, true)
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			return keyStructs;//return keyStructs
		}//endfunction
		//
		//
		//
		private void MeleeDoDrawEnum() {//function MeleeDoDrawEnum takes nothing returns nothing
			player thePlayer = GetEnumPlayer();//local player thePlayer = GetEnumPlayer()
			CachePlayerHeroData(thePlayer);//call CachePlayerHeroData(thePlayer)
			RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_TIE, false);//call RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_TIE, false)
		}//endfunction
		//
		//
		//
		private void MeleeDoVictoryEnum() {//function MeleeDoVictoryEnum takes nothing returns nothing
			player thePlayer = GetEnumPlayer();//local player thePlayer = GetEnumPlayer()
			int playerIndex = GetPlayerId(thePlayer);//local integer playerIndex = GetPlayerId(thePlayer)
			if ((!bj_meleeVictoried[playerIndex])) {//if (not bj_meleeVictoried[playerIndex]) then
				bj_meleeVictoried[playerIndex] = true;//set bj_meleeVictoried[playerIndex] = true
				CachePlayerHeroData(thePlayer);//call CachePlayerHeroData(thePlayer)
				RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_VICTORY, false);//call RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_VICTORY, false)
			}//endif
		}//endfunction
		//
		//
		//
		private void MeleeDoDefeat(player whichPlayer) {//function MeleeDoDefeat takes player whichPlayer returns nothing
			bj_meleeDefeated[GetPlayerId(whichPlayer)] = true;//set bj_meleeDefeated[GetPlayerId(whichPlayer)] = true
			RemovePlayerPreserveUnitsBJ(whichPlayer, PLAYER_GAME_RESULT_DEFEAT, false);//call RemovePlayerPreserveUnitsBJ(whichPlayer, PLAYER_GAME_RESULT_DEFEAT, false)
		}//endfunction
		//
		//
		//
		private void MeleeDoDefeatEnum() {//function MeleeDoDefeatEnum takes nothing returns nothing
			player thePlayer = GetEnumPlayer();//local player thePlayer = GetEnumPlayer()
			//
			CachePlayerHeroData(thePlayer);//call CachePlayerHeroData(thePlayer)
			MakeUnitsPassiveForTeam(thePlayer);//call MakeUnitsPassiveForTeam(thePlayer)
			MeleeDoDefeat(thePlayer);//call MeleeDoDefeat(thePlayer)
		}//endfunction
		//
		//
		//
		private void MeleeDoLeave(player whichPlayer) {//function MeleeDoLeave takes player whichPlayer returns nothing
			if ((GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0)) {//if (GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0) then
				GameOverDialogBJ(whichPlayer, true);//call GameOverDialogBJ( whichPlayer, true )
			} else {//else
				bj_meleeDefeated[GetPlayerId(whichPlayer)] = true;//set bj_meleeDefeated[GetPlayerId(whichPlayer)] = true
				RemovePlayerPreserveUnitsBJ(whichPlayer, PLAYER_GAME_RESULT_DEFEAT, true);//call RemovePlayerPreserveUnitsBJ(whichPlayer, PLAYER_GAME_RESULT_DEFEAT, true)
			}//endif
		}//endfunction
		//
		//
		//
		private void MeleeRemoveObservers() {//function MeleeRemoveObservers takes nothing returns nothing
			int playerIndex;//local integer    playerIndex
			player indexPlayer;//local player     indexPlayer
			//
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if ((IsPlayerObserver(indexPlayer))) {//if (IsPlayerObserver(indexPlayer)) then
					RemovePlayerPreserveUnitsBJ(indexPlayer, PLAYER_GAME_RESULT_NEUTRAL, false);//call RemovePlayerPreserveUnitsBJ(indexPlayer, PLAYER_GAME_RESULT_NEUTRAL, false)
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		//
		//
		//
		private force MeleeCheckForVictors() {//function MeleeCheckForVictors takes nothing returns force
			int playerIndex;//local integer    playerIndex
			int opponentIndex;//local integer    opponentIndex
			force opponentlessPlayers = CreateForce();//local force      opponentlessPlayers = CreateForce()
			bool gameOver = false;//local boolean    gameOver = false
			//
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				if ((!bj_meleeDefeated[playerIndex])) {//if (not bj_meleeDefeated[playerIndex]) then
					//
					opponentIndex = 0;//set opponentIndex = 0
					while (true) {//loop
						//
						if (MeleePlayerIsOpponent(playerIndex, opponentIndex)) {//if MeleePlayerIsOpponent(playerIndex, opponentIndex) then
							return CreateForce();//return CreateForce()
						}//endif
						opponentIndex = opponentIndex + 1;//set opponentIndex = opponentIndex + 1
						if (opponentIndex == bj_MAX_PLAYERS) { break; }//exitwhen opponentIndex == bj_MAX_PLAYERS
					}//endloop
					//
					//
					ForceAddPlayer(opponentlessPlayers, Player(playerIndex));//call ForceAddPlayer(opponentlessPlayers, Player(playerIndex))
					gameOver = true;//set gameOver = true
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			//
			bj_meleeGameOver = gameOver;//set bj_meleeGameOver = gameOver
			return opponentlessPlayers;//return opponentlessPlayers
		}//endfunction
		//
		//
		//
		private void MeleeCheckForLosersAndVictors() {//function MeleeCheckForLosersAndVictors takes nothing returns nothing
			int playerIndex;//local integer    playerIndex
			player indexPlayer;//local player     indexPlayer
			force defeatedPlayers = CreateForce();//local force      defeatedPlayers = CreateForce()
			force victoriousPlayers;//local force      victoriousPlayers
			bool gameOver = false;//local boolean    gameOver = false
			//
			if ((bj_meleeGameOver)) {//if (bj_meleeGameOver) then
				return;//return
			}//endif
			//
			//
			//
			if ((GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0)) {//if (GetIntegerGameState(GAME_STATE_DISCONNECTED) != 0) then
				bj_meleeGameOver = true;//set bj_meleeGameOver = true
				return;//return
			}//endif
			//
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if ((!bj_meleeDefeated[playerIndex] && !bj_meleeVictoried[playerIndex])) {//if (not bj_meleeDefeated[playerIndex] and not bj_meleeVictoried[playerIndex]) then
					//
					if ((MeleeGetAllyStructureCount(indexPlayer) <= 0)) {//if (MeleeGetAllyStructureCount(indexPlayer) <= 0) then
						//
						//
						ForceAddPlayer(defeatedPlayers, Player(playerIndex));//call ForceAddPlayer(defeatedPlayers, Player(playerIndex))
						//
						//
						bj_meleeDefeated[playerIndex] = true;//set bj_meleeDefeated[playerIndex] = true
					}//endif
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			//
			victoriousPlayers = MeleeCheckForVictors();//set victoriousPlayers = MeleeCheckForVictors()
			//
			ForForce(defeatedPlayers, function MeleeDoDefeatEnum);//call ForForce(defeatedPlayers, function MeleeDoDefeatEnum)
			//
			ForForce(victoriousPlayers, function MeleeDoVictoryEnum);//call ForForce(victoriousPlayers, function MeleeDoVictoryEnum)
			//
			if ((bj_meleeGameOver)) {//if (bj_meleeGameOver) then
				MeleeRemoveObservers();//call MeleeRemoveObservers()
			}//endif
		}//endfunction
		//
		//
		//
		private string MeleeGetCrippledWarningMessage(player whichPlayer) {//function MeleeGetCrippledWarningMessage takes player whichPlayer returns string
			race r = GetPlayerRace(whichPlayer);//local race r = GetPlayerRace(whichPlayer)
			if ((r == RACE_HUMAN)) {//if (r == RACE_HUMAN) then
				return GetLocalizedString("CRIPPLE_WARNING_HUMAN");//return GetLocalizedString("CRIPPLE_WARNING_HUMAN")
			} else if ((r == RACE_ORC)) {//elseif (r == RACE_ORC) then
				return GetLocalizedString("CRIPPLE_WARNING_ORC");//return GetLocalizedString("CRIPPLE_WARNING_ORC")
			} else if ((r == RACE_NIGHTELF)) {//elseif (r == RACE_NIGHTELF) then
				return GetLocalizedString("CRIPPLE_WARNING_NIGHTELF");//return GetLocalizedString("CRIPPLE_WARNING_NIGHTELF")
			} else if ((r == RACE_UNDEAD)) {//elseif (r == RACE_UNDEAD) then
				return GetLocalizedString("CRIPPLE_WARNING_UNDEAD");//return GetLocalizedString("CRIPPLE_WARNING_UNDEAD")
			} else {//else
				//
				return "";//return ""
			}//endif
		}//endfunction
		//
		//
		//
		private string MeleeGetCrippledTimerMessage(player whichPlayer) {//function MeleeGetCrippledTimerMessage takes player whichPlayer returns string
			race r = GetPlayerRace(whichPlayer);//local race r = GetPlayerRace(whichPlayer)
			if ((r == RACE_HUMAN)) {//if (r == RACE_HUMAN) then
				return GetLocalizedString("CRIPPLE_TIMER_HUMAN");//return GetLocalizedString("CRIPPLE_TIMER_HUMAN")
			} else if ((r == RACE_ORC)) {//elseif (r == RACE_ORC) then
				return GetLocalizedString("CRIPPLE_TIMER_ORC");//return GetLocalizedString("CRIPPLE_TIMER_ORC")
			} else if ((r == RACE_NIGHTELF)) {//elseif (r == RACE_NIGHTELF) then
				return GetLocalizedString("CRIPPLE_TIMER_NIGHTELF");//return GetLocalizedString("CRIPPLE_TIMER_NIGHTELF")
			} else if ((r == RACE_UNDEAD)) {//elseif (r == RACE_UNDEAD) then
				return GetLocalizedString("CRIPPLE_TIMER_UNDEAD");//return GetLocalizedString("CRIPPLE_TIMER_UNDEAD")
			} else {//else
				//
				return "";//return ""
			}//endif
		}//endfunction
		//
		//
		//
		private string MeleeGetCrippledRevealedMessage(player whichPlayer) {//function MeleeGetCrippledRevealedMessage takes player whichPlayer returns string
			return GetLocalizedString("CRIPPLE_REVEALING_PREFIX") + GetPlayerName(whichPlayer) + GetLocalizedString("CRIPPLE_REVEALING_POSTFIX");//return GetLocalizedString("CRIPPLE_REVEALING_PREFIX") + GetPlayerName(whichPlayer) + GetLocalizedString("CRIPPLE_REVEALING_POSTFIX")
		}//endfunction
		//
		private void MeleeExposePlayer(player whichPlayer, bool expose) {//function MeleeExposePlayer takes player whichPlayer, boolean expose returns nothing
			int playerIndex;//local integer playerIndex
			player indexPlayer;//local player  indexPlayer
			force toExposeTo = CreateForce();//local force   toExposeTo = CreateForce()
			CripplePlayer(whichPlayer, toExposeTo, false);//call CripplePlayer( whichPlayer, toExposeTo, false )
			bj_playerIsExposed[GetPlayerId(whichPlayer)] = expose;//set bj_playerIsExposed[GetPlayerId(whichPlayer)] = expose
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				if ((!PlayersAreCoAllied(whichPlayer, indexPlayer))) {//if (not PlayersAreCoAllied(whichPlayer, indexPlayer)) then
					ForceAddPlayer(toExposeTo, indexPlayer);//call ForceAddPlayer( toExposeTo, indexPlayer )
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			CripplePlayer(whichPlayer, toExposeTo, expose);//call CripplePlayer( whichPlayer, toExposeTo, expose )
			DestroyForce(toExposeTo);//call DestroyForce(toExposeTo)
		}//endfunction
		//
		private void MeleeExposeAllPlayers() {//function MeleeExposeAllPlayers takes nothing returns nothing
			int playerIndex;//local integer playerIndex
			player indexPlayer;//local player  indexPlayer
			int playerIndex2;//local integer playerIndex2
			player indexPlayer2;//local player  indexPlayer2
			force toExposeTo = CreateForce();//local force   toExposeTo = CreateForce()
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				ForceClear(toExposeTo);//call ForceClear( toExposeTo )
				CripplePlayer(indexPlayer, toExposeTo, false);//call CripplePlayer( indexPlayer, toExposeTo, false )
				playerIndex2 = 0;//set playerIndex2 = 0
				while (true) {//loop
					indexPlayer2 = Player(playerIndex2);//set indexPlayer2 = Player(playerIndex2)
					if (playerIndex != playerIndex2) {//if playerIndex != playerIndex2 then
						if ((!PlayersAreCoAllied(indexPlayer, indexPlayer2))) {//if (not PlayersAreCoAllied(indexPlayer, indexPlayer2)) then
							ForceAddPlayer(toExposeTo, indexPlayer2);//call ForceAddPlayer( toExposeTo, indexPlayer2 )
						}//endif
					}//endif
					playerIndex2 = playerIndex2 + 1;//set playerIndex2 = playerIndex2 + 1
					if (playerIndex2 == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex2 == bj_MAX_PLAYERS
				}//endloop
				CripplePlayer(indexPlayer, toExposeTo, true);//call CripplePlayer( indexPlayer, toExposeTo, true )
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			DestroyForce(toExposeTo);//call DestroyForce( toExposeTo )
		}//endfunction
		//
		private void MeleeCrippledPlayerTimeout() {//function MeleeCrippledPlayerTimeout takes nothing returns nothing
			timer expiredTimer = GetExpiredTimer();//local timer expiredTimer = GetExpiredTimer()
			int playerIndex;//local integer playerIndex
			player exposedPlayer;//local player  exposedPlayer
			//
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				if ((bj_crippledTimer[playerIndex] == expiredTimer)) {//if (bj_crippledTimer[playerIndex] == expiredTimer) then
					if (true) { break; }//exitwhen true
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
			if ((playerIndex == bj_MAX_PLAYERS)) {//if (playerIndex == bj_MAX_PLAYERS) then
				return;//return
			}//endif
			exposedPlayer = Player(playerIndex);//set exposedPlayer = Player(playerIndex)
			if ((GetLocalPlayer() == exposedPlayer)) {//if (GetLocalPlayer() == exposedPlayer) then
				//
				//
				TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false);//call TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false)
			}//endif
			//
			DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, MeleeGetCrippledRevealedMessage(exposedPlayer));//call DisplayTimedTextToPlayer(GetLocalPlayer(), 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, MeleeGetCrippledRevealedMessage(exposedPlayer))
			//
			MeleeExposePlayer(exposedPlayer, true);//call MeleeExposePlayer(exposedPlayer, true)
		}//endfunction
		//
		private bool MeleePlayerIsCrippled(player whichPlayer) {//function MeleePlayerIsCrippled takes player whichPlayer returns boolean
			int allyStructures = MeleeGetAllyStructureCount(whichPlayer);//local integer allyStructures    = MeleeGetAllyStructureCount(whichPlayer)
			int allyKeyStructures = MeleeGetAllyKeyStructureCount(whichPlayer);//local integer allyKeyStructures = MeleeGetAllyKeyStructureCount(whichPlayer)
			//
			return (allyStructures > 0) && (allyKeyStructures <= 0);//return (allyStructures > 0) and (allyKeyStructures <= 0)
		}//endfunction
		//
		//
		//
		private void MeleeCheckForCrippledPlayers() {//function MeleeCheckForCrippledPlayers takes nothing returns nothing
			int playerIndex;//local integer    playerIndex
			player indexPlayer;//local player     indexPlayer
			force crippledPlayers = CreateForce();//local force      crippledPlayers = CreateForce()
			bool isNowCrippled;//local boolean    isNowCrippled
			race indexRace;//local race       indexRace
			//
			if (bj_finishSoonAllExposed) {//if bj_finishSoonAllExposed then
				return;//return
			}//endif
			//
			playerIndex = 0;//set playerIndex = 0
			while (true) {//loop
				indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
				isNowCrippled = MeleePlayerIsCrippled(indexPlayer);//set isNowCrippled = MeleePlayerIsCrippled(indexPlayer)
				if ((!bj_playerIsCrippled[playerIndex] && isNowCrippled)) {//if (not bj_playerIsCrippled[playerIndex] and isNowCrippled) then
					//
					bj_playerIsCrippled[playerIndex] = true;//set bj_playerIsCrippled[playerIndex] = true
					TimerStart(bj_crippledTimer[playerIndex], bj_MELEE_CRIPPLE_TIMEOUT, false, function MeleeCrippledPlayerTimeout);//call TimerStart(bj_crippledTimer[playerIndex], bj_MELEE_CRIPPLE_TIMEOUT, false, function MeleeCrippledPlayerTimeout)
					if ((GetLocalPlayer() == indexPlayer)) {//if (GetLocalPlayer() == indexPlayer) then
						//
						//
						TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], true);//call TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], true)
						//
						DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, MeleeGetCrippledWarningMessage(indexPlayer));//call DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, MeleeGetCrippledWarningMessage(indexPlayer))
					}//endif
				} else if ((bj_playerIsCrippled[playerIndex] && !isNowCrippled)) {//elseif (bj_playerIsCrippled[playerIndex] and not isNowCrippled) then
					//
					bj_playerIsCrippled[playerIndex] = false;//set bj_playerIsCrippled[playerIndex] = false
					PauseTimer(bj_crippledTimer[playerIndex]);//call PauseTimer(bj_crippledTimer[playerIndex])
					if ((GetLocalPlayer() == indexPlayer)) {//if (GetLocalPlayer() == indexPlayer) then
						//
						//
						TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false);//call TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false)
						//
						if ((MeleeGetAllyStructureCount(indexPlayer) > 0)) {//if (MeleeGetAllyStructureCount(indexPlayer) > 0) then
							if ((bj_playerIsExposed[playerIndex])) {//if (bj_playerIsExposed[playerIndex]) then
								DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, GetLocalizedString("CRIPPLE_UNREVEALED"));//call DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, GetLocalizedString("CRIPPLE_UNREVEALED"))
							} else {//else
								DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, GetLocalizedString("CRIPPLE_UNCRIPPLED"));//call DisplayTimedTextToPlayer(indexPlayer, 0, 0, bj_MELEE_CRIPPLE_MSG_DURATION, GetLocalizedString("CRIPPLE_UNCRIPPLED"))
							}//endif
						}//endif
					}//endif
					//
					MeleeExposePlayer(indexPlayer, false);//call MeleeExposePlayer(indexPlayer, false)
				}//endif
				playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
				if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		private void MeleeCheckLostUnit(unit lostUnit) {//function MeleeCheckLostUnit takes unit lostUnit returns nothing
			player lostUnitOwner = GetOwningPlayer(lostUnit);//local player lostUnitOwner = GetOwningPlayer(lostUnit)
			//
			if ((GetPlayerStructureCount(lostUnitOwner, true) <= 0)) {//if (GetPlayerStructureCount(lostUnitOwner, true) <= 0) then
				MeleeCheckForLosersAndVictors();//call MeleeCheckForLosersAndVictors()
			}//endif
			//
			//
			MeleeCheckForCrippledPlayers();//call MeleeCheckForCrippledPlayers()
		}//endfunction
		//
		//
		//
		//
		private void MeleeCheckAddedUnit(unit addedUnit) {//function MeleeCheckAddedUnit takes unit addedUnit returns nothing
			player addedUnitOwner = GetOwningPlayer(addedUnit);//local player addedUnitOwner = GetOwningPlayer(addedUnit)
			//
			if ((bj_playerIsCrippled[GetPlayerId(addedUnitOwner)])) {//if (bj_playerIsCrippled[GetPlayerId(addedUnitOwner)]) then
				MeleeCheckForCrippledPlayers();//call MeleeCheckForCrippledPlayers()
			}//endif
		}//endfunction
		//
		private void MeleeTriggerActionConstructCancel() {//function MeleeTriggerActionConstructCancel takes nothing returns nothing
			MeleeCheckLostUnit(GetCancelledStructure());//call MeleeCheckLostUnit(GetCancelledStructure())
		}//endfunction
		//
		private void MeleeTriggerActionUnitDeath() {//function MeleeTriggerActionUnitDeath takes nothing returns nothing
			if ((IsUnitType(GetDyingUnit(), UNIT_TYPE_STRUCTURE))) {//if (IsUnitType(GetDyingUnit(), UNIT_TYPE_STRUCTURE)) then
				MeleeCheckLostUnit(GetDyingUnit());//call MeleeCheckLostUnit(GetDyingUnit())
			}//endif
		}//endfunction
		//
		private void MeleeTriggerActionUnitConstructionStart() {//function MeleeTriggerActionUnitConstructionStart takes nothing returns nothing
			MeleeCheckAddedUnit(GetConstructingStructure());//call MeleeCheckAddedUnit(GetConstructingStructure())
		}//endfunction
		//
		private void MeleeTriggerActionPlayerDefeated() {//function MeleeTriggerActionPlayerDefeated takes nothing returns nothing
			player thePlayer = GetTriggerPlayer();//local player thePlayer = GetTriggerPlayer()
			CachePlayerHeroData(thePlayer);//call CachePlayerHeroData(thePlayer)
			if ((MeleeGetAllyCount(thePlayer) > 0)) {//if (MeleeGetAllyCount(thePlayer) > 0) then
				//
				//
				ShareEverythingWithTeam(thePlayer);//call ShareEverythingWithTeam(thePlayer)
				if ((!bj_meleeDefeated[GetPlayerId(thePlayer)])) {//if (not bj_meleeDefeated[GetPlayerId(thePlayer)]) then
					MeleeDoDefeat(thePlayer);//call MeleeDoDefeat(thePlayer)
				}//endif
			} else {//else
				//
				//
				MakeUnitsPassiveForTeam(thePlayer);//call MakeUnitsPassiveForTeam(thePlayer)
				if ((!bj_meleeDefeated[GetPlayerId(thePlayer)])) {//if (not bj_meleeDefeated[GetPlayerId(thePlayer)]) then
					MeleeDoDefeat(thePlayer);//call MeleeDoDefeat(thePlayer)
				}//endif
			}//endif
			MeleeCheckForLosersAndVictors();//call MeleeCheckForLosersAndVictors()
		}//endfunction
		//
		private void MeleeTriggerActionPlayerLeft() {//function MeleeTriggerActionPlayerLeft takes nothing returns nothing
			player thePlayer = GetTriggerPlayer();//local player thePlayer = GetTriggerPlayer()
			//
			if ((IsPlayerObserver(thePlayer))) {//if (IsPlayerObserver(thePlayer)) then
				RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_NEUTRAL, false);//call RemovePlayerPreserveUnitsBJ(thePlayer, PLAYER_GAME_RESULT_NEUTRAL, false)
				return;//return
			}//endif
			CachePlayerHeroData(thePlayer);//call CachePlayerHeroData(thePlayer)
			//
			//
			if ((MeleeGetAllyCount(thePlayer) > 0)) {//if (MeleeGetAllyCount(thePlayer) > 0) then
				//
				//
				ShareEverythingWithTeam(thePlayer);//call ShareEverythingWithTeam(thePlayer)
				MeleeDoLeave(thePlayer);//call MeleeDoLeave(thePlayer)
			} else {//else
				//
				//
				MakeUnitsPassiveForTeam(thePlayer);//call MakeUnitsPassiveForTeam(thePlayer)
				MeleeDoLeave(thePlayer);//call MeleeDoLeave(thePlayer)
			}//endif
			MeleeCheckForLosersAndVictors();//call MeleeCheckForLosersAndVictors()
		}//endfunction
		//
		private void MeleeTriggerActionAllianceChange() {//function MeleeTriggerActionAllianceChange takes nothing returns nothing
			MeleeCheckForLosersAndVictors();//call MeleeCheckForLosersAndVictors()
			MeleeCheckForCrippledPlayers();//call MeleeCheckForCrippledPlayers()
		}//endfunction
		//
		private void MeleeTriggerTournamentFinishSoon() {//function MeleeTriggerTournamentFinishSoon takes nothing returns nothing
			//
			int playerIndex;//local integer    playerIndex
			player indexPlayer;//local player     indexPlayer
			float timeRemaining = GetTournamentFinishSoonTimeRemaining();//local real       timeRemaining = GetTournamentFinishSoonTimeRemaining()
			if (!bj_finishSoonAllExposed) {//if not bj_finishSoonAllExposed then
				bj_finishSoonAllExposed = true;//set bj_finishSoonAllExposed = true
				//
				playerIndex = 0;//set playerIndex = 0
				while (true) {//loop
					indexPlayer = Player(playerIndex);//set indexPlayer = Player(playerIndex)
					if (bj_playerIsCrippled[playerIndex]) {//if bj_playerIsCrippled[playerIndex] then
						//
						bj_playerIsCrippled[playerIndex] = false;//set bj_playerIsCrippled[playerIndex] = false
						PauseTimer(bj_crippledTimer[playerIndex]);//call PauseTimer(bj_crippledTimer[playerIndex])
						if ((GetLocalPlayer() == indexPlayer)) {//if (GetLocalPlayer() == indexPlayer) then
							//
							//
							TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false);//call TimerDialogDisplay(bj_crippledTimerWindows[playerIndex], false)
						}//endif
					}//endif
					playerIndex = playerIndex + 1;//set playerIndex = playerIndex + 1
					if (playerIndex == bj_MAX_PLAYERS) { break; }//exitwhen playerIndex == bj_MAX_PLAYERS
				}//endloop
				//
				MeleeExposeAllPlayers();//call MeleeExposeAllPlayers()
			}//endif
			//
			TimerDialogDisplay(bj_finishSoonTimerDialog, true);//call TimerDialogDisplay(bj_finishSoonTimerDialog, true)
			TimerDialogSetRealTimeRemaining(bj_finishSoonTimerDialog, timeRemaining);//call TimerDialogSetRealTimeRemaining(bj_finishSoonTimerDialog, timeRemaining)
		}//endfunction
		//
		private bool MeleeWasUserPlayer(player whichPlayer) {//function MeleeWasUserPlayer takes player whichPlayer returns boolean
			playerslotstate slotState;//local playerslotstate slotState
			if ((GetPlayerController(whichPlayer) != MAP_CONTROL_USER)) {//if (GetPlayerController(whichPlayer) != MAP_CONTROL_USER) then
				return false;//return false
			}//endif
			slotState = GetPlayerSlotState(whichPlayer);//set slotState = GetPlayerSlotState(whichPlayer)
			return (slotState == PLAYER_SLOT_STATE_PLAYING || slotState == PLAYER_SLOT_STATE_LEFT);//return (slotState == PLAYER_SLOT_STATE_PLAYING or slotState == PLAYER_SLOT_STATE_LEFT)
		}//endfunction
		//
		private void MeleeTournamentFinishNowRuleA(int multiplier) {//function MeleeTournamentFinishNowRuleA takes integer multiplier returns nothing
			int[] playerScore;//local integer array playerScore
			int[] teamScore;//local integer array teamScore
			force[] teamForce;//local force array   teamForce
			int teamCount;//local integer       teamCount
			int index;//local integer       index
			player indexPlayer;//local player        indexPlayer
			int index2;//local integer       index2
			player indexPlayer2;//local player        indexPlayer2
			int bestTeam;//local integer       bestTeam
			int bestScore;//local integer       bestScore
			bool draw;//local boolean       draw
			//
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				if (MeleeWasUserPlayer(indexPlayer)) {//if MeleeWasUserPlayer(indexPlayer) then
					playerScore[index] = GetTournamentScore(indexPlayer);//set playerScore[index] = GetTournamentScore(indexPlayer)
					if (playerScore[index] <= 0) {//if playerScore[index] <= 0 then
						playerScore[index] = 1;//set playerScore[index] = 1
					}//endif
				} else {//else
					playerScore[index] = 0;//set playerScore[index] = 0
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
			//
			teamCount = 0;//set teamCount = 0
			index = 0;//set index = 0
			while (true) {//loop
				if (playerScore[index] != 0) {//if playerScore[index] != 0 then
					indexPlayer = Player(index);//set indexPlayer = Player(index)
					teamScore[teamCount] = 0;//set teamScore[teamCount] = 0
					teamForce[teamCount] = CreateForce();//set teamForce[teamCount] = CreateForce()
					index2 = index;//set index2 = index
					while (true) {//loop
						if (playerScore[index2] != 0) {//if playerScore[index2] != 0 then
							indexPlayer2 = Player(index2);//set indexPlayer2 = Player(index2)
							if (PlayersAreCoAllied(indexPlayer, indexPlayer2)) {//if PlayersAreCoAllied(indexPlayer, indexPlayer2) then
								teamScore[teamCount] = teamScore[teamCount] + playerScore[index2];//set teamScore[teamCount] = teamScore[teamCount] + playerScore[index2]
								ForceAddPlayer(teamForce[teamCount], indexPlayer2);//call ForceAddPlayer(teamForce[teamCount], indexPlayer2)
								playerScore[index2] = 0;//set playerScore[index2] = 0
							}//endif
						}//endif
						index2 = index2 + 1;//set index2 = index2 + 1
						if (index2 == bj_MAX_PLAYERS) { break; }//exitwhen index2 == bj_MAX_PLAYERS
					}//endloop
					teamCount = teamCount + 1;//set teamCount = teamCount + 1
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
			//
			bj_meleeGameOver = true;//set bj_meleeGameOver = true
			//
			if (teamCount != 0) {//if teamCount != 0 then
				//
				bestTeam = -1;//set bestTeam = -1
				bestScore = -1;//set bestScore = -1
				index = 0;//set index = 0
				while (true) {//loop
					if (teamScore[index] > bestScore) {//if teamScore[index] > bestScore then
						bestTeam = index;//set bestTeam = index
						bestScore = teamScore[index];//set bestScore = teamScore[index]
					}//endif
					index = index + 1;//set index = index + 1
					if (index == teamCount) { break; }//exitwhen index == teamCount
				}//endloop
				//
				//
				//
				draw = false;//set draw = false
				index = 0;//set index = 0
				while (true) {//loop
					if (index != bestTeam) {//if index != bestTeam then
						if (bestScore < (multiplier * teamScore[index])) {//if bestScore < (multiplier * teamScore[index]) then
							draw = true;//set draw = true
						}//endif
					}//endif
					index = index + 1;//set index = index + 1
					if (index == teamCount) { break; }//exitwhen index == teamCount
				}//endloop
				if (draw) {//if draw then
					//
					index = 0;//set index = 0
					while (true) {//loop
						ForForce(teamForce[index], function MeleeDoDrawEnum);//call ForForce(teamForce[index], function MeleeDoDrawEnum)
						index = index + 1;//set index = index + 1
						if (index == teamCount) { break; }//exitwhen index == teamCount
					}//endloop
				} else {//else
					//
					index = 0;//set index = 0
					while (true) {//loop
						if (index != bestTeam) {//if index != bestTeam then
							ForForce(teamForce[index], function MeleeDoDefeatEnum);//call ForForce(teamForce[index], function MeleeDoDefeatEnum)
						}//endif
						index = index + 1;//set index = index + 1
						if (index == teamCount) { break; }//exitwhen index == teamCount
					}//endloop
					//
					ForForce(teamForce[bestTeam], function MeleeDoVictoryEnum);//call ForForce(teamForce[bestTeam], function MeleeDoVictoryEnum)
				}//endif
			}//endif
		}//endfunction
		//
		private void MeleeTriggerTournamentFinishNow() {//function MeleeTriggerTournamentFinishNow takes nothing returns nothing
			int rule = GetTournamentFinishNowRule();//local integer rule = GetTournamentFinishNowRule()
			//
			if (bj_meleeGameOver) {//if bj_meleeGameOver then
				return;//return
			}//endif
			if ((rule == 1)) {//if (rule == 1) then
				//
				MeleeTournamentFinishNowRuleA(1);//call MeleeTournamentFinishNowRuleA(1)
			} else {//else
				//
				MeleeTournamentFinishNowRuleA(3);//call MeleeTournamentFinishNowRuleA(3)
			}//endif
			//
			MeleeRemoveObservers();//call MeleeRemoveObservers()
		}//endfunction
		//
		private void MeleeInitVictoryDefeat() {//function MeleeInitVictoryDefeat takes nothing returns nothing
			trigger trig;//local trigger    trig
			int index;//local integer    index
			player indexPlayer;//local player     indexPlayer
			//
			//
			bj_finishSoonTimerDialog = CreateTimerDialog(null);//set bj_finishSoonTimerDialog = CreateTimerDialog(null)
			//
			trig = CreateTrigger();//set trig = CreateTrigger()
			TriggerRegisterGameEvent(trig, EVENT_GAME_TOURNAMENT_FINISH_SOON);//call TriggerRegisterGameEvent(trig, EVENT_GAME_TOURNAMENT_FINISH_SOON)
			TriggerAddAction(trig, function MeleeTriggerTournamentFinishSoon);//call TriggerAddAction(trig, function MeleeTriggerTournamentFinishSoon)
			//
			trig = CreateTrigger();//set trig = CreateTrigger()
			TriggerRegisterGameEvent(trig, EVENT_GAME_TOURNAMENT_FINISH_NOW);//call TriggerRegisterGameEvent(trig, EVENT_GAME_TOURNAMENT_FINISH_NOW)
			TriggerAddAction(trig, function MeleeTriggerTournamentFinishNow);//call TriggerAddAction(trig, function MeleeTriggerTournamentFinishNow)
			//
			index = 0;//set index = 0
			while (true) {//loop
				indexPlayer = Player(index);//set indexPlayer = Player(index)
				//
				if ((GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerSlotState(indexPlayer) == PLAYER_SLOT_STATE_PLAYING) then
					bj_meleeDefeated[index] = false;//set bj_meleeDefeated[index] = false
					bj_meleeVictoried[index] = false;//set bj_meleeVictoried[index] = false
					//
					bj_playerIsCrippled[index] = false;//set bj_playerIsCrippled[index] = false
					bj_playerIsExposed[index] = false;//set bj_playerIsExposed[index] = false
					bj_crippledTimer[index] = CreateTimer();//set bj_crippledTimer[index] = CreateTimer()
					bj_crippledTimerWindows[index] = CreateTimerDialog(bj_crippledTimer[index]);//set bj_crippledTimerWindows[index] = CreateTimerDialog(bj_crippledTimer[index])
					TimerDialogSetTitle(bj_crippledTimerWindows[index], MeleeGetCrippledTimerMessage(indexPlayer));//call TimerDialogSetTitle(bj_crippledTimerWindows[index], MeleeGetCrippledTimerMessage(indexPlayer))
					//
					trig = CreateTrigger();//set trig = CreateTrigger()
					TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL, null);//call TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL, null)
					TriggerAddAction(trig, function MeleeTriggerActionConstructCancel);//call TriggerAddAction(trig, function MeleeTriggerActionConstructCancel)
					//
					trig = CreateTrigger();//set trig = CreateTrigger()
					TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_DEATH, null);//call TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_DEATH, null)
					TriggerAddAction(trig, function MeleeTriggerActionUnitDeath);//call TriggerAddAction(trig, function MeleeTriggerActionUnitDeath)
					//
					trig = CreateTrigger();//set trig = CreateTrigger()
					TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_CONSTRUCT_START, null);//call TriggerRegisterPlayerUnitEvent(trig, indexPlayer, EVENT_PLAYER_UNIT_CONSTRUCT_START, null)
					TriggerAddAction(trig, function MeleeTriggerActionUnitConstructionStart);//call TriggerAddAction(trig, function MeleeTriggerActionUnitConstructionStart)
					//
					trig = CreateTrigger();//set trig = CreateTrigger()
					TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_DEFEAT);//call TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_DEFEAT)
					TriggerAddAction(trig, function MeleeTriggerActionPlayerDefeated);//call TriggerAddAction(trig, function MeleeTriggerActionPlayerDefeated)
					//
					trig = CreateTrigger();//set trig = CreateTrigger()
					TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_LEAVE);//call TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_LEAVE)
					TriggerAddAction(trig, function MeleeTriggerActionPlayerLeft);//call TriggerAddAction(trig, function MeleeTriggerActionPlayerLeft)
					//
					trig = CreateTrigger();//set trig = CreateTrigger()
					TriggerRegisterPlayerAllianceChange(trig, indexPlayer, ALLIANCE_PASSIVE);//call TriggerRegisterPlayerAllianceChange(trig, indexPlayer, ALLIANCE_PASSIVE)
					TriggerRegisterPlayerStateEvent(trig, indexPlayer, PLAYER_STATE_ALLIED_VICTORY, EQUAL, 1);//call TriggerRegisterPlayerStateEvent(trig, indexPlayer, PLAYER_STATE_ALLIED_VICTORY, EQUAL, 1)
					TriggerAddAction(trig, function MeleeTriggerActionAllianceChange);//call TriggerAddAction(trig, function MeleeTriggerActionAllianceChange)
				} else {//else
					bj_meleeDefeated[index] = true;//set bj_meleeDefeated[index] = true
					bj_meleeVictoried[index] = false;//set bj_meleeVictoried[index] = false
					//
					if ((IsPlayerObserver(indexPlayer))) {//if (IsPlayerObserver(indexPlayer)) then
						//
						trig = CreateTrigger();//set trig = CreateTrigger()
						TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_LEAVE);//call TriggerRegisterPlayerEvent(trig, indexPlayer, EVENT_PLAYER_LEAVE)
						TriggerAddAction(trig, function MeleeTriggerActionPlayerLeft);//call TriggerAddAction(trig, function MeleeTriggerActionPlayerLeft)
					}//endif
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
			//
			//
			TimerStart(CreateTimer(), 2.0, false, function MeleeTriggerActionAllianceChange);//call TimerStart(CreateTimer(), 2.0, false, function MeleeTriggerActionAllianceChange)
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void CheckInitPlayerSlotAvailability() {//function CheckInitPlayerSlotAvailability takes nothing returns nothing
			int index;//local integer index
			if ((!bj_slotControlReady)) {//if (not bj_slotControlReady) then
				index = 0;//set index = 0
				while (true) {//loop
					bj_slotControlUsed[index] = false;//set bj_slotControlUsed[index] = false
					bj_slotControl[index] = MAP_CONTROL_USER;//set bj_slotControl[index] = MAP_CONTROL_USER
					index = index + 1;//set index = index + 1
					if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
				}//endloop
				bj_slotControlReady = true;//set bj_slotControlReady = true
			}//endif
		}//endfunction
		//
		private void SetPlayerSlotAvailable(player whichPlayer, mapcontrol control) {//function SetPlayerSlotAvailable takes player whichPlayer, mapcontrol control returns nothing
			int playerIndex = GetPlayerId(whichPlayer);//local integer playerIndex = GetPlayerId(whichPlayer)
			CheckInitPlayerSlotAvailability();//call CheckInitPlayerSlotAvailability()
			bj_slotControlUsed[playerIndex] = true;//set bj_slotControlUsed[playerIndex] = true
			bj_slotControl[playerIndex] = control;//set bj_slotControl[playerIndex] = control
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void TeamInitPlayerSlots(int teamCount) {//function TeamInitPlayerSlots takes integer teamCount returns nothing
			int index;//local integer index
			player indexPlayer;//local player  indexPlayer
			int team;//local integer team
			SetTeams(teamCount);//call SetTeams(teamCount)
			CheckInitPlayerSlotAvailability();//call CheckInitPlayerSlotAvailability()
			index = 0;//set index = 0
			team = 0;//set team = 0
			while (true) {//loop
				if ((bj_slotControlUsed[index])) {//if (bj_slotControlUsed[index]) then
					indexPlayer = Player(index);//set indexPlayer = Player(index)
					SetPlayerTeam(indexPlayer, team);//call SetPlayerTeam( indexPlayer, team )
					team = team + 1;//set team = team + 1
					if ((team >= teamCount)) {//if (team >= teamCount) then
						team = 0;//set team = 0
					}//endif
				}//endif
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		private void MeleeInitPlayerSlots() {//function MeleeInitPlayerSlots takes nothing returns nothing
			TeamInitPlayerSlots(bj_MAX_PLAYERS);//call TeamInitPlayerSlots(bj_MAX_PLAYERS)
		}//endfunction
		//
		private void FFAInitPlayerSlots() {//function FFAInitPlayerSlots takes nothing returns nothing
			TeamInitPlayerSlots(bj_MAX_PLAYERS);//call TeamInitPlayerSlots(bj_MAX_PLAYERS)
		}//endfunction
		//
		private void OneOnOneInitPlayerSlots() {//function OneOnOneInitPlayerSlots takes nothing returns nothing
			//
			SetTeams(2);//call SetTeams(2)
			SetPlayers(2);//call SetPlayers(2)
			TeamInitPlayerSlots(2);//call TeamInitPlayerSlots(2)
		}//endfunction
		//
		private void InitGenericPlayerSlots() {//function InitGenericPlayerSlots takes nothing returns nothing
			gametype gType = GetGameTypeSelected();//local gametype gType = GetGameTypeSelected()
			if ((gType == GAME_TYPE_MELEE)) {//if (gType == GAME_TYPE_MELEE) then
				MeleeInitPlayerSlots();//call MeleeInitPlayerSlots()
			} else if ((gType == GAME_TYPE_FFA)) {//elseif (gType == GAME_TYPE_FFA) then
				FFAInitPlayerSlots();//call FFAInitPlayerSlots()
			} else if ((gType == GAME_TYPE_USE_MAP_SETTINGS)) {//elseif (gType == GAME_TYPE_USE_MAP_SETTINGS) then
				//
			} else if ((gType == GAME_TYPE_ONE_ON_ONE)) {//elseif (gType == GAME_TYPE_ONE_ON_ONE) then
				OneOnOneInitPlayerSlots();//call OneOnOneInitPlayerSlots()
			} else if ((gType == GAME_TYPE_TWO_TEAM_PLAY)) {//elseif (gType == GAME_TYPE_TWO_TEAM_PLAY) then
				TeamInitPlayerSlots(2);//call TeamInitPlayerSlots(2)
			} else if ((gType == GAME_TYPE_THREE_TEAM_PLAY)) {//elseif (gType == GAME_TYPE_THREE_TEAM_PLAY) then
				TeamInitPlayerSlots(3);//call TeamInitPlayerSlots(3)
			} else if ((gType == GAME_TYPE_FOUR_TEAM_PLAY)) {//elseif (gType == GAME_TYPE_FOUR_TEAM_PLAY) then
				TeamInitPlayerSlots(4);//call TeamInitPlayerSlots(4)
			} else {//else
				//
			}//endif
		}//endfunction
		//
		//
		//
		//
		//
		//
		private void SetDNCSoundsDawn() {//function SetDNCSoundsDawn takes nothing returns nothing
			if (bj_useDawnDuskSounds) {//if bj_useDawnDuskSounds then
				StartSound(bj_dawnSound);//call StartSound(bj_dawnSound)
			}//endif
		}//endfunction
		//
		private void SetDNCSoundsDusk() {//function SetDNCSoundsDusk takes nothing returns nothing
			if (bj_useDawnDuskSounds) {//if bj_useDawnDuskSounds then
				StartSound(bj_duskSound);//call StartSound(bj_duskSound)
			}//endif
		}//endfunction
		//
		private void SetDNCSoundsDay() {//function SetDNCSoundsDay takes nothing returns nothing
			float ToD = GetTimeOfDay();//local real ToD = GetTimeOfDay()
			if ((ToD >= bj_TOD_DAWN && ToD < bj_TOD_DUSK) && !bj_dncIsDaytime) {//if (ToD >= bj_TOD_DAWN and ToD < bj_TOD_DUSK) and not bj_dncIsDaytime then
				bj_dncIsDaytime = true;//set bj_dncIsDaytime = true
				//
				StopSound(bj_nightAmbientSound, false, true);//call StopSound(bj_nightAmbientSound, false, true)
				StartSound(bj_dayAmbientSound);//call StartSound(bj_dayAmbientSound)
			}//endif
		}//endfunction
		//
		private void SetDNCSoundsNight() {//function SetDNCSoundsNight takes nothing returns nothing
			float ToD = GetTimeOfDay();//local real ToD = GetTimeOfDay()
			if ((ToD < bj_TOD_DAWN || ToD >= bj_TOD_DUSK) && bj_dncIsDaytime) {//if (ToD < bj_TOD_DAWN or ToD >= bj_TOD_DUSK) and bj_dncIsDaytime then
				bj_dncIsDaytime = false;//set bj_dncIsDaytime = false
				//
				StopSound(bj_dayAmbientSound, false, true);//call StopSound(bj_dayAmbientSound, false, true)
				StartSound(bj_nightAmbientSound);//call StartSound(bj_nightAmbientSound)
			}//endif
		}//endfunction
		//
		private void InitDNCSounds() {//function InitDNCSounds takes nothing returns nothing
			//
			bj_dawnSound = CreateSoundFromLabel("RoosterSound", false, false, false, 10000, 10000);//set bj_dawnSound = CreateSoundFromLabel("RoosterSound", false, false, false, 10000, 10000)
			bj_duskSound = CreateSoundFromLabel("WolfSound", false, false, false, 10000, 10000);//set bj_duskSound = CreateSoundFromLabel("WolfSound", false, false, false, 10000, 10000)
			//
			bj_dncSoundsDawn = CreateTrigger();//set bj_dncSoundsDawn = CreateTrigger()
			TriggerRegisterGameStateEvent(bj_dncSoundsDawn, GAME_STATE_TIME_OF_DAY, EQUAL, bj_TOD_DAWN);//call TriggerRegisterGameStateEvent(bj_dncSoundsDawn, GAME_STATE_TIME_OF_DAY, EQUAL, bj_TOD_DAWN)
			TriggerAddAction(bj_dncSoundsDawn, function SetDNCSoundsDawn);//call TriggerAddAction(bj_dncSoundsDawn, function SetDNCSoundsDawn)
			bj_dncSoundsDusk = CreateTrigger();//set bj_dncSoundsDusk = CreateTrigger()
			TriggerRegisterGameStateEvent(bj_dncSoundsDusk, GAME_STATE_TIME_OF_DAY, EQUAL, bj_TOD_DUSK);//call TriggerRegisterGameStateEvent(bj_dncSoundsDusk, GAME_STATE_TIME_OF_DAY, EQUAL, bj_TOD_DUSK)
			TriggerAddAction(bj_dncSoundsDusk, function SetDNCSoundsDusk);//call TriggerAddAction(bj_dncSoundsDusk, function SetDNCSoundsDusk)
			//
			bj_dncSoundsDay = CreateTrigger();//set bj_dncSoundsDay = CreateTrigger()
			TriggerRegisterGameStateEvent(bj_dncSoundsDay,   GAME_STATE_TIME_OF_DAY, GREATER_THAN_OR_EQUAL, bj_TOD_DAWN);//call TriggerRegisterGameStateEvent(bj_dncSoundsDay,   GAME_STATE_TIME_OF_DAY, GREATER_THAN_OR_EQUAL, bj_TOD_DAWN)
			TriggerRegisterGameStateEvent(bj_dncSoundsDay,   GAME_STATE_TIME_OF_DAY, LESS_THAN,             bj_TOD_DUSK);//call TriggerRegisterGameStateEvent(bj_dncSoundsDay,   GAME_STATE_TIME_OF_DAY, LESS_THAN,             bj_TOD_DUSK)
			TriggerAddAction(bj_dncSoundsDay, function SetDNCSoundsDay);//call TriggerAddAction(bj_dncSoundsDay, function SetDNCSoundsDay)
			bj_dncSoundsNight = CreateTrigger();//set bj_dncSoundsNight = CreateTrigger()
			TriggerRegisterGameStateEvent(bj_dncSoundsNight, GAME_STATE_TIME_OF_DAY, LESS_THAN,             bj_TOD_DAWN);//call TriggerRegisterGameStateEvent(bj_dncSoundsNight, GAME_STATE_TIME_OF_DAY, LESS_THAN,             bj_TOD_DAWN)
			TriggerRegisterGameStateEvent(bj_dncSoundsNight, GAME_STATE_TIME_OF_DAY, GREATER_THAN_OR_EQUAL, bj_TOD_DUSK);//call TriggerRegisterGameStateEvent(bj_dncSoundsNight, GAME_STATE_TIME_OF_DAY, GREATER_THAN_OR_EQUAL, bj_TOD_DUSK)
			TriggerAddAction(bj_dncSoundsNight, function SetDNCSoundsNight);//call TriggerAddAction(bj_dncSoundsNight, function SetDNCSoundsNight)
		}//endfunction
		//
		private void InitBlizzardGlobals() {//function InitBlizzardGlobals takes nothing returns nothing
			int index;//local integer index
			int userControlledPlayers;//local integer userControlledPlayers
			version v;//local version v
			//
			filterIssueHauntOrderAtLocBJ = Filter(function IssueHauntOrderAtLocBJFilter);//set filterIssueHauntOrderAtLocBJ = Filter(function IssueHauntOrderAtLocBJFilter)
			filterEnumDestructablesInCircleBJ = Filter(function EnumDestructablesInCircleBJFilter);//set filterEnumDestructablesInCircleBJ = Filter(function EnumDestructablesInCircleBJFilter)
			filterGetUnitsInRectOfPlayer = Filter(function GetUnitsInRectOfPlayerFilter);//set filterGetUnitsInRectOfPlayer = Filter(function GetUnitsInRectOfPlayerFilter)
			filterGetUnitsOfTypeIdAll = Filter(function GetUnitsOfTypeIdAllFilter);//set filterGetUnitsOfTypeIdAll = Filter(function GetUnitsOfTypeIdAllFilter)
			filterGetUnitsOfPlayerAndTypeId = Filter(function GetUnitsOfPlayerAndTypeIdFilter);//set filterGetUnitsOfPlayerAndTypeId = Filter(function GetUnitsOfPlayerAndTypeIdFilter)
			filterMeleeTrainedUnitIsHeroBJ = Filter(function MeleeTrainedUnitIsHeroBJFilter);//set filterMeleeTrainedUnitIsHeroBJ = Filter(function MeleeTrainedUnitIsHeroBJFilter)
			filterLivingPlayerUnitsOfTypeId = Filter(function LivingPlayerUnitsOfTypeIdFilter);//set filterLivingPlayerUnitsOfTypeId = Filter(function LivingPlayerUnitsOfTypeIdFilter)
			//
			index = 0;//set index = 0
			while (true) {//loop
				if (index == bj_MAX_PLAYER_SLOTS) { break; }//exitwhen index == bj_MAX_PLAYER_SLOTS
				bj_FORCE_PLAYER[index] = CreateForce();//set bj_FORCE_PLAYER[index] = CreateForce()
				ForceAddPlayer(bj_FORCE_PLAYER[index], Player(index));//call ForceAddPlayer(bj_FORCE_PLAYER[index], Player(index))
				index = index + 1;//set index = index + 1
			}//endloop
			bj_FORCE_ALL_PLAYERS = CreateForce();//set bj_FORCE_ALL_PLAYERS = CreateForce()
			ForceEnumPlayers(bj_FORCE_ALL_PLAYERS, null);//call ForceEnumPlayers(bj_FORCE_ALL_PLAYERS, null)
			//
			bj_cineModePriorSpeed = GetGameSpeed();//set bj_cineModePriorSpeed = GetGameSpeed()
			bj_cineModePriorFogSetting = IsFogEnabled();//set bj_cineModePriorFogSetting = IsFogEnabled()
			bj_cineModePriorMaskSetting = IsFogMaskEnabled();//set bj_cineModePriorMaskSetting = IsFogMaskEnabled()
			//
			index = 0;//set index = 0
			while (true) {//loop
				if (index >= bj_MAX_QUEUED_TRIGGERS) { break; }//exitwhen index >= bj_MAX_QUEUED_TRIGGERS
				bj_queuedExecTriggers[index] = null;//set bj_queuedExecTriggers[index] = null
				bj_queuedExecUseConds[index] = false;//set bj_queuedExecUseConds[index] = false
				index = index + 1;//set index = index + 1
			}//endloop
			//
			bj_isSinglePlayer = false;//set bj_isSinglePlayer = false
			userControlledPlayers = 0;//set userControlledPlayers = 0
			index = 0;//set index = 0
			while (true) {//loop
				if (index >= bj_MAX_PLAYERS) { break; }//exitwhen index >= bj_MAX_PLAYERS
				if ((GetPlayerController(Player(index)) == MAP_CONTROL_USER && GetPlayerSlotState(Player(index)) == PLAYER_SLOT_STATE_PLAYING)) {//if (GetPlayerController(Player(index)) == MAP_CONTROL_USER and GetPlayerSlotState(Player(index)) == PLAYER_SLOT_STATE_PLAYING) then
					userControlledPlayers = userControlledPlayers + 1;//set userControlledPlayers = userControlledPlayers + 1
				}//endif
				index = index + 1;//set index = index + 1
			}//endloop
			bj_isSinglePlayer = (userControlledPlayers == 1);//set bj_isSinglePlayer = (userControlledPlayers == 1)
			//
			//
			bj_rescueSound = CreateSoundFromLabel("Rescue", false, false, false, 10000, 10000);//set bj_rescueSound = CreateSoundFromLabel("Rescue", false, false, false, 10000, 10000)
			bj_questDiscoveredSound = CreateSoundFromLabel("QuestNew", false, false, false, 10000, 10000);//set bj_questDiscoveredSound = CreateSoundFromLabel("QuestNew", false, false, false, 10000, 10000)
			bj_questUpdatedSound = CreateSoundFromLabel("QuestUpdate", false, false, false, 10000, 10000);//set bj_questUpdatedSound = CreateSoundFromLabel("QuestUpdate", false, false, false, 10000, 10000)
			bj_questCompletedSound = CreateSoundFromLabel("QuestCompleted", false, false, false, 10000, 10000);//set bj_questCompletedSound = CreateSoundFromLabel("QuestCompleted", false, false, false, 10000, 10000)
			bj_questFailedSound = CreateSoundFromLabel("QuestFailed", false, false, false, 10000, 10000);//set bj_questFailedSound = CreateSoundFromLabel("QuestFailed", false, false, false, 10000, 10000)
			bj_questHintSound = CreateSoundFromLabel("Hint", false, false, false, 10000, 10000);//set bj_questHintSound = CreateSoundFromLabel("Hint", false, false, false, 10000, 10000)
			bj_questSecretSound = CreateSoundFromLabel("SecretFound", false, false, false, 10000, 10000);//set bj_questSecretSound = CreateSoundFromLabel("SecretFound", false, false, false, 10000, 10000)
			bj_questItemAcquiredSound = CreateSoundFromLabel("ItemReward", false, false, false, 10000, 10000);//set bj_questItemAcquiredSound = CreateSoundFromLabel("ItemReward", false, false, false, 10000, 10000)
			bj_questWarningSound = CreateSoundFromLabel("Warning", false, false, false, 10000, 10000);//set bj_questWarningSound = CreateSoundFromLabel("Warning", false, false, false, 10000, 10000)
			bj_victoryDialogSound = CreateSoundFromLabel("QuestCompleted", false, false, false, 10000, 10000);//set bj_victoryDialogSound = CreateSoundFromLabel("QuestCompleted", false, false, false, 10000, 10000)
			bj_defeatDialogSound = CreateSoundFromLabel("QuestFailed", false, false, false, 10000, 10000);//set bj_defeatDialogSound = CreateSoundFromLabel("QuestFailed", false, false, false, 10000, 10000)
			//
			DelayedSuspendDecayCreate();//call DelayedSuspendDecayCreate()
			//
			v = VersionGet();//set v = VersionGet()
			if ((v == VERSION_REIGN_OF_CHAOS)) {//if (v == VERSION_REIGN_OF_CHAOS) then
				bj_MELEE_MAX_TWINKED_HEROES = bj_MELEE_MAX_TWINKED_HEROES_V0;//set bj_MELEE_MAX_TWINKED_HEROES = bj_MELEE_MAX_TWINKED_HEROES_V0
			} else {//else
				bj_MELEE_MAX_TWINKED_HEROES = bj_MELEE_MAX_TWINKED_HEROES_V1;//set bj_MELEE_MAX_TWINKED_HEROES = bj_MELEE_MAX_TWINKED_HEROES_V1
			}//endif
		}//endfunction
		//
		private void InitQueuedTriggers() {//function InitQueuedTriggers takes nothing returns nothing
			bj_queuedExecTimeout = CreateTrigger();//set bj_queuedExecTimeout = CreateTrigger()
			TriggerRegisterTimerExpireEvent(bj_queuedExecTimeout, bj_queuedExecTimeoutTimer);//call TriggerRegisterTimerExpireEvent(bj_queuedExecTimeout, bj_queuedExecTimeoutTimer)
			TriggerAddAction(bj_queuedExecTimeout, function QueuedTriggerDoneBJ);//call TriggerAddAction(bj_queuedExecTimeout, function QueuedTriggerDoneBJ)
		}//endfunction
		//
		private void InitMapRects() {//function InitMapRects takes nothing returns nothing
			bj_mapInitialPlayableArea = Rect(GetCameraBoundMinX()-GetCameraMargin(CAMERA_MARGIN_LEFT), GetCameraBoundMinY()-GetCameraMargin(CAMERA_MARGIN_BOTTOM), GetCameraBoundMaxX()+GetCameraMargin(CAMERA_MARGIN_RIGHT), GetCameraBoundMaxY()+GetCameraMargin(CAMERA_MARGIN_TOP));//set bj_mapInitialPlayableArea = Rect(GetCameraBoundMinX()-GetCameraMargin(CAMERA_MARGIN_LEFT), GetCameraBoundMinY()-GetCameraMargin(CAMERA_MARGIN_BOTTOM), GetCameraBoundMaxX()+GetCameraMargin(CAMERA_MARGIN_RIGHT), GetCameraBoundMaxY()+GetCameraMargin(CAMERA_MARGIN_TOP))
			bj_mapInitialCameraBounds = GetCurrentCameraBoundsMapRectBJ();//set bj_mapInitialCameraBounds = GetCurrentCameraBoundsMapRectBJ()
		}//endfunction
		//
		private void InitSummonableCaps() {//function InitSummonableCaps takes nothing returns nothing
			int index;//local integer index
			index = 0;//set index = 0
			while (true) {//loop
				//
				//
				//
				if ((!GetPlayerTechResearched(Player(index), 'Rhrt', true))) {//if (not GetPlayerTechResearched(Player(index), 'Rhrt', true)) then
					SetPlayerTechMaxAllowed(Player(index), 'hrtt', 0);//call SetPlayerTechMaxAllowed(Player(index), 'hrtt', 0)
				}//endif
				//
				if ((!GetPlayerTechResearched(Player(index), 'Robk', true))) {//if (not GetPlayerTechResearched(Player(index), 'Robk', true)) then
					SetPlayerTechMaxAllowed(Player(index), 'otbk', 0);//call SetPlayerTechMaxAllowed(Player(index), 'otbk', 0)
				}//endif
				//
				SetPlayerTechMaxAllowed(Player(index), 'uske', bj_MAX_SKELETONS);//call SetPlayerTechMaxAllowed(Player(index), 'uske', bj_MAX_SKELETONS)
				index = index + 1;//set index = index + 1
				if (index == bj_MAX_PLAYERS) { break; }//exitwhen index == bj_MAX_PLAYERS
			}//endloop
		}//endfunction
		//
		//
		//
		private void UpdateStockAvailability(item whichItem) {//function UpdateStockAvailability takes item whichItem returns nothing
			itemtype iType = GetItemType(whichItem);//local itemtype iType  = GetItemType(whichItem)
			int iLevel = GetItemLevel(whichItem);//local integer  iLevel = GetItemLevel(whichItem)
			//
			if ((iType == ITEM_TYPE_PERMANENT)) {//if (iType == ITEM_TYPE_PERMANENT) then
				bj_stockAllowedPermanent[iLevel] = true;//set bj_stockAllowedPermanent[iLevel] = true
			} else if ((iType == ITEM_TYPE_CHARGED)) {//elseif (iType == ITEM_TYPE_CHARGED) then
				bj_stockAllowedCharged[iLevel] = true;//set bj_stockAllowedCharged[iLevel] = true
			} else if ((iType == ITEM_TYPE_ARTIFACT)) {//elseif (iType == ITEM_TYPE_ARTIFACT) then
				bj_stockAllowedArtifact[iLevel] = true;//set bj_stockAllowedArtifact[iLevel] = true
			} else {//else
				//
			}//endif
		}//endfunction
		//
		//
		//
		private void UpdateEachStockBuildingEnum() {//function UpdateEachStockBuildingEnum takes nothing returns nothing
			int iteration = 0;//local integer iteration = 0
			int pickedItemId;//local integer pickedItemId
			while (true) {//loop
				pickedItemId = ChooseRandomItemEx(bj_stockPickedItemType, bj_stockPickedItemLevel);//set pickedItemId = ChooseRandomItemEx(bj_stockPickedItemType, bj_stockPickedItemLevel)
				if (IsItemIdSellable(pickedItemId)) { break; }//exitwhen IsItemIdSellable(pickedItemId)
				//
				//
				iteration = iteration + 1;//set iteration = iteration + 1
				if ((iteration > bj_STOCK_MAX_ITERATIONS)) {//if (iteration > bj_STOCK_MAX_ITERATIONS) then
					return;//return
				}//endif
			}//endloop
			AddItemToStock(GetEnumUnit(), pickedItemId, 1, 1);//call AddItemToStock(GetEnumUnit(), pickedItemId, 1, 1)
		}//endfunction
		//
		private void UpdateEachStockBuilding(itemtype iType, int iLevel) {//function UpdateEachStockBuilding takes itemtype iType, integer iLevel returns nothing
			group g;//local group g
			bj_stockPickedItemType = iType;//set bj_stockPickedItemType = iType
			bj_stockPickedItemLevel = iLevel;//set bj_stockPickedItemLevel = iLevel
			g = CreateGroup();//set g = CreateGroup()
			GroupEnumUnitsOfType(g, "marketplace", null);//call GroupEnumUnitsOfType(g, "marketplace", null)
			ForGroup(g, function UpdateEachStockBuildingEnum);//call ForGroup(g, function UpdateEachStockBuildingEnum)
			DestroyGroup(g);//call DestroyGroup(g)
		}//endfunction
		//
		//
		//
		private void PerformStockUpdates() {//function PerformStockUpdates takes nothing returns nothing
			int pickedItemId;//local integer  pickedItemId
			itemtype pickedItemType;//local itemtype pickedItemType
			int pickedItemLevel = 0;//local integer  pickedItemLevel = 0
			int allowedCombinations = 0;//local integer  allowedCombinations = 0
			int iLevel;//local integer  iLevel
			//
			iLevel = 1;//set iLevel = 1
			while (true) {//loop
				if ((bj_stockAllowedPermanent[iLevel])) {//if (bj_stockAllowedPermanent[iLevel]) then
					allowedCombinations = allowedCombinations + 1;//set allowedCombinations = allowedCombinations + 1
					if ((GetRandomInt(1, allowedCombinations) == 1)) {//if (GetRandomInt(1, allowedCombinations) == 1) then
						pickedItemType = ITEM_TYPE_PERMANENT;//set pickedItemType = ITEM_TYPE_PERMANENT
						pickedItemLevel = iLevel;//set pickedItemLevel = iLevel
					}//endif
				}//endif
				if ((bj_stockAllowedCharged[iLevel])) {//if (bj_stockAllowedCharged[iLevel]) then
					allowedCombinations = allowedCombinations + 1;//set allowedCombinations = allowedCombinations + 1
					if ((GetRandomInt(1, allowedCombinations) == 1)) {//if (GetRandomInt(1, allowedCombinations) == 1) then
						pickedItemType = ITEM_TYPE_CHARGED;//set pickedItemType = ITEM_TYPE_CHARGED
						pickedItemLevel = iLevel;//set pickedItemLevel = iLevel
					}//endif
				}//endif
				if ((bj_stockAllowedArtifact[iLevel])) {//if (bj_stockAllowedArtifact[iLevel]) then
					allowedCombinations = allowedCombinations + 1;//set allowedCombinations = allowedCombinations + 1
					if ((GetRandomInt(1, allowedCombinations) == 1)) {//if (GetRandomInt(1, allowedCombinations) == 1) then
						pickedItemType = ITEM_TYPE_ARTIFACT;//set pickedItemType = ITEM_TYPE_ARTIFACT
						pickedItemLevel = iLevel;//set pickedItemLevel = iLevel
					}//endif
				}//endif
				iLevel = iLevel + 1;//set iLevel = iLevel + 1
				if (iLevel > bj_MAX_ITEM_LEVEL) { break; }//exitwhen iLevel > bj_MAX_ITEM_LEVEL
			}//endloop
			//
			if ((allowedCombinations == 0)) {//if (allowedCombinations == 0) then
				return;//return
			}//endif
			UpdateEachStockBuilding(pickedItemType, pickedItemLevel);//call UpdateEachStockBuilding(pickedItemType, pickedItemLevel)
		}//endfunction
		//
		//
		//
		private void StartStockUpdates() {//function StartStockUpdates takes nothing returns nothing
			PerformStockUpdates();//call PerformStockUpdates()
			TimerStart(bj_stockUpdateTimer, bj_STOCK_RESTOCK_INTERVAL, true, function PerformStockUpdates);//call TimerStart(bj_stockUpdateTimer, bj_STOCK_RESTOCK_INTERVAL, true, function PerformStockUpdates)
		}//endfunction
		//
		private void RemovePurchasedItem() {//function RemovePurchasedItem takes nothing returns nothing
			RemoveItemFromStock(GetSellingUnit(), GetItemTypeId(GetSoldItem()));//call RemoveItemFromStock(GetSellingUnit(), GetItemTypeId(GetSoldItem()))
		}//endfunction
		//
		private void InitNeutralBuildings() {//function InitNeutralBuildings takes nothing returns nothing
			int iLevel;//local integer iLevel
			//
			iLevel = 0;//set iLevel = 0
			while (true) {//loop
				bj_stockAllowedPermanent[iLevel] = false;//set bj_stockAllowedPermanent[iLevel] = false
				bj_stockAllowedCharged[iLevel] = false;//set bj_stockAllowedCharged[iLevel] = false
				bj_stockAllowedArtifact[iLevel] = false;//set bj_stockAllowedArtifact[iLevel] = false
				iLevel = iLevel + 1;//set iLevel = iLevel + 1
				if (iLevel > bj_MAX_ITEM_LEVEL) { break; }//exitwhen iLevel > bj_MAX_ITEM_LEVEL
			}//endloop
			//
			SetAllItemTypeSlots(bj_MAX_STOCK_ITEM_SLOTS);//call SetAllItemTypeSlots(bj_MAX_STOCK_ITEM_SLOTS)
			SetAllUnitTypeSlots(bj_MAX_STOCK_UNIT_SLOTS);//call SetAllUnitTypeSlots(bj_MAX_STOCK_UNIT_SLOTS)
			//
			bj_stockUpdateTimer = CreateTimer();//set bj_stockUpdateTimer = CreateTimer()
			TimerStart(bj_stockUpdateTimer, bj_STOCK_RESTOCK_INITIAL_DELAY, false, function StartStockUpdates);//call TimerStart(bj_stockUpdateTimer, bj_STOCK_RESTOCK_INITIAL_DELAY, false, function StartStockUpdates)
			//
			bj_stockItemPurchased = CreateTrigger();//set bj_stockItemPurchased = CreateTrigger()
			TriggerRegisterPlayerUnitEvent(bj_stockItemPurchased, Player(PLAYER_NEUTRAL_PASSIVE), EVENT_PLAYER_UNIT_SELL_ITEM, null);//call TriggerRegisterPlayerUnitEvent(bj_stockItemPurchased, Player(PLAYER_NEUTRAL_PASSIVE), EVENT_PLAYER_UNIT_SELL_ITEM, null)
			TriggerAddAction(bj_stockItemPurchased, function RemovePurchasedItem);//call TriggerAddAction(bj_stockItemPurchased, function RemovePurchasedItem)
		}//endfunction
		//
		private void MarkGameStarted() {//function MarkGameStarted takes nothing returns nothing
			bj_gameStarted = true;//set bj_gameStarted = true
			DestroyTimer(bj_gameStartedTimer);//call DestroyTimer(bj_gameStartedTimer)
		}//endfunction
		//
		private void DetectGameStarted() {//function DetectGameStarted takes nothing returns nothing
			bj_gameStartedTimer = CreateTimer();//set bj_gameStartedTimer = CreateTimer()
			TimerStart(bj_gameStartedTimer, bj_GAME_STARTED_THRESHOLD, false, function MarkGameStarted);//call TimerStart(bj_gameStartedTimer, bj_GAME_STARTED_THRESHOLD, false, function MarkGameStarted)
		}//endfunction
		//
		private void InitBlizzard() {//function InitBlizzard takes nothing returns nothing
			//
			//
			//
			ConfigureNeutralVictim();//call ConfigureNeutralVictim()
			InitBlizzardGlobals();//call InitBlizzardGlobals()
			InitQueuedTriggers();//call InitQueuedTriggers()
			InitRescuableBehaviorBJ();//call InitRescuableBehaviorBJ()
			InitDNCSounds();//call InitDNCSounds()
			InitMapRects();//call InitMapRects()
			InitSummonableCaps();//call InitSummonableCaps()
			InitNeutralBuildings();//call InitNeutralBuildings()
			DetectGameStarted();//call DetectGameStarted()
		}//endfunction
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
		private void RandomDistReset() {//function RandomDistReset takes nothing returns nothing
			bj_randDistCount = 0;//set bj_randDistCount = 0
		}//endfunction
		//
		private void RandomDistAddItem(int inID, int inChance) {//function RandomDistAddItem takes integer inID, integer inChance returns nothing
			bj_randDistID[bj_randDistCount] = inID;//set bj_randDistID[bj_randDistCount] = inID
			bj_randDistChance[bj_randDistCount] = inChance;//set bj_randDistChance[bj_randDistCount] = inChance
			bj_randDistCount = bj_randDistCount + 1;//set bj_randDistCount = bj_randDistCount + 1
		}//endfunction
		//
		private int RandomDistChoose() {//function RandomDistChoose takes nothing returns integer
			int sum = 0;//local integer sum = 0
			int chance = 0;//local integer chance = 0
			int index;//local integer index
			int foundID = -1;//local integer foundID = -1
			bool done;//local boolean done
			//
			if ((bj_randDistCount == 0)) {//if (bj_randDistCount == 0) then
				return -1;//return -1
			}//endif
			//
			index = 0;//set index = 0
			while (true) {//loop
				sum = sum + bj_randDistChance[index];//set sum = sum + bj_randDistChance[index]
				index = index + 1;//set index = index + 1
				if (index == bj_randDistCount) { break; }//exitwhen index == bj_randDistCount
			}//endloop
			//
			chance = GetRandomInt(1, sum);//set chance = GetRandomInt(1, sum)
			//
			index = 0;//set index = 0
			sum = 0;//set sum = 0
			done = false;//set done = false
			while (true) {//loop
				sum = sum + bj_randDistChance[index];//set sum = sum + bj_randDistChance[index]
				if ((chance <= sum)) {//if (chance <= sum) then
					foundID = bj_randDistID[index];//set foundID = bj_randDistID[index]
					done = true;//set done = true
				}//endif
				index = index + 1;//set index = index + 1
				if ((index == bj_randDistCount)) {//if (index == bj_randDistCount) then
					done = true;//set done = true
				}//endif
				if (done == true) { break; }//exitwhen done == true
			}//endloop
			return foundID;//return foundID
		}//endfunction
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
		private item UnitDropItem(unit inUnit, int inItemID) {//function UnitDropItem takes unit inUnit, integer inItemID returns item
			float x;//local real x
			float y;//local real y
			float radius = 32;//local real radius = 32
			float unitX;//local real unitX
			float unitY;//local real unitY
			item droppedItem;//local item droppedItem
			if ((inItemID == -1)) {//if (inItemID == -1) then
				return null;//return null
			}//endif
			unitX = GetUnitX(inUnit);//set unitX = GetUnitX(inUnit)
			unitY = GetUnitY(inUnit);//set unitY = GetUnitY(inUnit)
			x = GetRandomReal(unitX - radius, unitX + radius);//set x = GetRandomReal(unitX - radius, unitX + radius)
			y = GetRandomReal(unitY - radius, unitY + radius);//set y = GetRandomReal(unitY - radius, unitY + radius)
			droppedItem = CreateItem(inItemID, x, y);//set droppedItem = CreateItem(inItemID, x, y)
			SetItemDropID(droppedItem, GetUnitTypeId(inUnit));//call SetItemDropID(droppedItem, GetUnitTypeId(inUnit))
			UpdateStockAvailability(droppedItem);//call UpdateStockAvailability(droppedItem)
			return droppedItem;//return droppedItem
		}//endfunction
		//
		private item WidgetDropItem(widget inWidget, int inItemID) {//function WidgetDropItem takes widget inWidget, integer inItemID returns item
			float x;//local real x
			float y;//local real y
			float radius = 32;//local real radius = 32
			float widgetX;//local real widgetX
			float widgetY;//local real widgetY
			if ((inItemID == -1)) {//if (inItemID == -1) then
				return null;//return null
			}//endif
			widgetX = GetWidgetX(inWidget);//set widgetX = GetWidgetX(inWidget)
			widgetY = GetWidgetY(inWidget);//set widgetY = GetWidgetY(inWidget)
			x = GetRandomReal(widgetX - radius, widgetX + radius);//set x = GetRandomReal(widgetX - radius, widgetX + radius)
			y = GetRandomReal(widgetY - radius, widgetY + radius);//set y = GetRandomReal(widgetY - radius, widgetY + radius)
			return CreateItem(inItemID, x, y);//return CreateItem(inItemID, x, y)
		}//endfunction

	
	}
}

