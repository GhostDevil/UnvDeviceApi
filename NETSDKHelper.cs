using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace UnvDeviceApi.NETSDKHelper
{
    public enum NETDEV_CHANNEL_STATUS_E
    {
        NETDEV_CHL_STATUS_OFFLINE,
        NETDEV_CHL_STATUS_ONLINE,
        NETDEV_CHL_STATUS_VIDEO_LOST,

        NETDEV_CHL_STATUS_INVALID
    }

    public enum NETDEV_CAMERA_TYPE_E
    {
        NETDEV_CAMERA_TYPE_FIX = 0,
        NETDEV_CAMERA_TYPE_PTZ = 1,

        NETDEV_CAMERA_TYPE_INVALID = 0xFF
    }

    public enum NETDEV_RENDER_SCALE_E
    {
        NETDEV_RENDER_SCALE_FULL = 0,
        NETDEV_RENDER_SCALE_PROPORTION = 1,

        NETDEV_RENDER_SCALE_BUTT = 0xFF
    }

    public enum NETDEV_LIVE_STREAM_INDEX_E
    {
        NETDEV_LIVE_STREAM_INDEX_MAIN = 0,
        NETDEV_LIVE_STREAM_INDEX_AUX = 1,
        NETDEV_LIVE_STREAM_INDEX_THIRD = 2,

        NETDEV_LIVE_STREAM_INDEX_INVALID
    };

    public enum NETDEV_PICTURE_FORMAT_E
    {
        NETDEV_PICTURE_BMP = 0,                  /* bmp */
        NETDEV_PICTURE_JPG = 1,                  /* jpg */

        NETDEV_PICTURE_INVALID
    };

    public enum NETDEV_EXCEPTION_TYPE_E
    {
        /*  200~299 */

        /* 300~399 */
        NETDEV_EXCEPTION_REPORT_VOD_END = 300,
        NETDEV_EXCEPTION_REPORT_VOD_ABEND,
        NETDEV_EXCEPTION_REPORT_BACKUP_END,
        NETDEV_EXCEPTION_REPORT_BACKUP_DISC_OUT,
        NETDEV_EXCEPTION_REPORT_BACKUP_DISC_FULL,
        NETDEV_EXCEPTION_REPORT_BACKUP_ABEND,

        NETDEV_EXCEPTION_EXCHANGE = 0x8000,            /* 45S */

        NETDEV_EXCEPTION_REPORT_INVALID = 0xFFFF
    };

    public enum NETDEV_VIDEO_CODE_TYPE_E
    {
        NETDEV_VIDEO_CODE_MJPEG = 0,          /* MJPEG */
        NETDEV_VIDEO_CODE_H264 = 1,          /* H.264 */
        NETDEV_VIDEO_CODE_H265 = 2,          /* H.265 */
        NETDEV_VIDEO_CODE_INVALID
    };


    public enum NETDEV_CONFIG_COMMAND_E
    {
        NETDEV_GET_DEVICECFG = 100,            /* #NETDEV_DEVICE_INFO_S  Get device information, see #NETDEV_DEVICE_INFO_S */
        NETDEV_SET_DEVICECFG = 101,

        NETDEV_GET_NTPCFG = 110,            /* NTP#NETDEV_SYSTEM_NTP_INFO_S  Get NTP parameter, see #NETDEV_SYSTEM_NTP_INFO_S */
        NETDEV_SET_NTPCFG = 111,            /* NTP#NETDEV_SYSTEM_NTP_INFO_S  Set NTP parameter, see #NETDEV_SYSTEM_NTP_INFO_S */

        NETDEV_GET_STREAMCFG = 120,            /* #NETDEV_VIDEO_STREAM_INFO_S  Get video encoding parameter, see #NETDEV_VIDEO_STREAM_INFO_S */
        NETDEV_SET_STREAMCFG = 121,            /* #NETDEV_VIDEO_STREAM_INFO_S  Set video encoding parameter, see #NETDEV_VIDEO_STREAM_INFO_S */

        NETDEV_GET_PTZPRESETS = 130,            /* #NETDEV_PTZ_ALLPRESETS_S  Get PTZ preset, see #NETDEV_PTZ_ALLPRESETS_S */

        NETDEV_GET_OSDCFG = 140,            /* OSD#NETDEV_VIDEO_OSD_CFG_S  Get OSD configuration information, see #NETDEV_VIDEO_OSD_CFG_S */
        NETDEV_SET_OSDCFG = 141,            /* OSD#NETDEV_VIDEO_OSD_CFG_S  Set OSD configuration information, see #NETDEV_VIDEO_OSD_CFG_S */

        NETDEV_GET_ALARM_OUTPUTCFG = 150,            /* #NETDEV_ALARM_OUTPUT_LIST_S  Get boolean configuration information, see #NETDEV_ALARM_OUTPUT_LIST_S */
        NETDEV_SET_ALARM_OUTPUTCFG = 151,            /* #NETDEV_ALARM_OUTPUT_LIST_S       Set boolean configuration information, see #NETDEV_ALARM_OUTPUT_LIST_S */
        NETDEV_TRIGGER_ALARM_OUTPUT = 152,            /* LPNETDEV_TRIGGER_ALARM_OUTPUT_LIST_S  Trigger boolean    LPNETDEV_TRIGGER_ALARM_OUTPUT_LIST_S */
        NETDEV_GET_ALARM_INPUTCFG = 153,            /* #NETDEV_ALARM_INPUT_INFO_S Get the number of boolean inputs   see #NETDEV_ALARM_INPUT_INFO_S*/

        NETDEV_GET_IMAGECFG = 160,            /* #NETDEV_IMAGE_SETTING_S  Get image configuration information, see #NETDEV_IMAGE_SETTING_S */
        NETDEV_SET_IMAGECFG = 161,            /* #NETDEV_IMAGE_SETTING_S  Set image configuration information, see #NETDEV_IMAGE_SETTING_S */

        NETDEV_GET_NETWORKCFG = 170,            /* #NETDEV_IMAGE_SETTING_S  Get network configuration information, see #NETDEV_IMAGE_SETTING_S */
        NETDEV_SET_NETWORKCFG = 171,            /* #NETDEV_IMAGE_SETTING_S  Set network configuration information, see #NETDEV_IMAGE_SETTING_S */

        NETDEV_GET_PRIVACYMASKCFG = 180,            /* #NETDEV_PRIVACY_MASK_CFG_S  Get privacy mask configuration information, see #NETDEV_PRIVACY_MASK_CFG_S */
        NETDEV_SET_PRIVACYMASKCFG = 181,            /* #NETDEV_PRIVACY_MASK_CFG_S  Set privacy mask configuration information, see #NETDEV_PRIVACY_MASK_CFG_S */
        NETDEV_DELETE_PRIVACYMASKCFG = 182,            /* Delete privacy mask configuration information */

        NETDEV_GET_TAMPERALARM = 190,            /*  Get tamper alarm configuration information, see#NETDEV_TAMPER_ALARM_INFO_S */
        NETDEV_SET_TAMPERALARM = 191,            /*  Set tamper alarm configuration information, see#NETDEV_TAMPER_ALARM_INFO_S */

        NETDEV_GET_MOTIONALARM = 201,            /* Get motion alarm configuration information, see#NETDEV_MOTION_ALARM_INFO_S */
        NETDEV_SET_MOTIONALARM = 202,             /*  Set motion alarm configuration information, see#NETDEV_MOTION_ALARM_INFO_S */

        NETDEV_GET_DISKSINFO = 211,              /* 获取硬盘信息 参见#NETDEV_GET_DISKS_INFO_S  Get disks information, see#NETDEV_GET_DISKS_INFO_S */

        NETDEV_CFG_INVALID = 0xFFFF            /*   Invalid value */
    };

    /**
     * @enum tagNETDEVCFGCmd
     * @brief   Parameter configuration command words Enumeration definition
     * @attention  None
     */
    public enum NETDEV_DEVICETYPE_E
    {
        NETDEV_DTYPE_UNKNOWN = 0,            /* Unknown type */
        NETDEV_DTYPE_IPC = 1,            /* IPC range */
        NETDEV_DTYPE_IPC_FISHEYE = 2,            /*  fish eye IPC */
        NETDEV_DTYPE_NVR = 101,          /* NVR range */
        NETDEV_DTYPE_NVR_BACKUP = 102,          /* NVR back up */
        NETDEV_DTYPE_DC = 201,          /* DC range */
        NETDEV_DTYPE_EC = 301,          /* EC range */

        NETDEV_DTYPE_INVALID = 0xFFFF        /*  Invalid value */

    };

    public enum NETDEV_PROTOCAL_E
    {
        NETDEV_TRANSPROTOCAL_RTPTCP = 1,         /* TCP */
        NETDEV_TRANSPROTOCAL_RTPUDP = 2          /* UDP */
    };

    public enum NETDEV_PTZ_E
    {
        NETDEV_PTZ_FOCUSNEAR = 0x0202,       /* Focus near */
        NETDEV_PTZ_FOCUSFAR = 0x0204,       /* Focus far */
        NETDEV_PTZ_ZOOMTELE = 0x0302,       /*   Zoom in */
        NETDEV_PTZ_ZOOMWIDE = 0x0304,       /*   Zoom out */
        NETDEV_PTZ_TILTUP = 0x0402,         /*   Tilt up */
        NETDEV_PTZ_TILTDOWN = 0x0404,       /*   Tilt down */
        NETDEV_PTZ_PANRIGHT = 0x0502,       /*   Pan right */
        NETDEV_PTZ_PANLEFT = 0x0504,        /*   Pan left */
        NETDEV_PTZ_LEFTUP = 0x0702,         /*   Move up left */
        NETDEV_PTZ_LEFTDOWN = 0x0704,       /*   Move down left */
        NETDEV_PTZ_RIGHTUP = 0x0802,        /*   Move up right */
        NETDEV_PTZ_RIGHTDOWN = 0x0804,      /*   Move down right */

        NETDEV_PTZ_ALLSTOP = 0x0901,        /*   All-stop command word */

        NETDEV_PTZ_TRACKCRUISE = 0x1001,                /*   Start route patrol*/
        NETDEV_PTZ_TRACKCRUISESTOP = 0x1002,            /*   Stop route patrol*/
        NETDEV_PTZ_TRACKCRUISEREC = 0x1003,             /*   Start recording route */
        NETDEV_PTZ_TRACKCRUISERECSTOP = 0x1004,         /*   Stop recording route */
        NETDEV_PTZ_TRACKCRUISEADD = 0x1005,             /*   Add patrol route */
        NETDEV_PTZ_TRACKCRUISEDEL = 0x1006,             /*   Delete patrol route */

        NETDEV_PTZ_AREAZOOMIN = 0x1101,                 /*   Zoom in area */
        NETDEV_PTZ_AREAZOOMOUT = 0x1102,                /*   Zoom out area */
        NETDEV_PTZ_AREAZOOM3D = 0x1103,                 /* 3D  3D positioning */

        NETDEV_PTZ_BRUSHON = 0x0A01,                    /*   Wiper on */
        NETDEV_PTZ_BRUSHOFF = 0x0A02,                   /*   Wiper off */

        NETDEV_PTZ_LIGHTON = 0x0B01,                    /*   Lamp on */
        NETDEV_PTZ_LIGHTOFF = 0x0B02,                   /*   Lamp off */

        NETDEV_PTZ_HEATON = 0x0C01,                     /*   Heater on */
        NETDEV_PTZ_HEATOFF = 0x0C02,                    /*   Heater off */

        NETDEV_PTZ_SNOWREMOINGON = 0x0D01,              /*   Snowremoval on */
        NETDEV_PTZ_SNOWREMOINGOFF = 0x0D02,             /*   Snowremoval off  */

        NETDEV_PTZ_BUTT
    };

    public enum NETDEV_PTZ_PRESETCMD_E
    {
        NETDEV_PTZ_SET_PRESET = 0,            /*   Set preset */
        NETDEV_PTZ_CLE_PRESET = 1,            /*   Clear preset */
        NETDEV_PTZ_GOTO_PRESET = 2             /*   Go to preset */
    };
    /// <summary>
    /// 巡航控制
    /// </summary>
    public enum NETDEV_PTZ_CRUISECMD_E
    {
        /// <summary>
        /// 添加巡航点
        /// </summary>
        NETDEV_PTZ_ADD_CRUISE = 0,         /*    Add patrol route */
        /// <summary>
        /// 编辑巡航点
        /// </summary>
        NETDEV_PTZ_MODIFY_CRUISE = 1,         /*   Edit patrol route */
        /// <summary>
        /// 删除巡航点
        /// </summary>
        NETDEV_PTZ_DEL_CRUISE = 2,         /*   Delete patrol route */
        /// <summary>
        /// 开始巡航
        /// </summary>
        NETDEV_PTZ_RUN_CRUISE = 3,         /*   Start patrol */
        /// <summary>
        /// 停止巡航
        /// </summary>
        NETDEV_PTZ_STOP_CRUISE = 4          /*   Stop patrol */
    };

    public enum NETDEV_MEDIA_FILE_FORMAT_E
    {
        NETDEV_MEDIA_FILE_MP4 = 0,           /*   mp4 media file */
        NETDEV_MEDIA_FILE_TS = 1,            /*  TS media file */
        NETDEV_MEDIA_FILE_INVALID
    };

    public enum NETDEV_VOD_PLAY_STATUS_E
    {
        /**   Play status */
        NETDEV_PLAY_STATUS_16_BACKWARD = 0,        /* 16  Backward at 16x speed */
        NETDEV_PLAY_STATUS_8_BACKWARD = 1,        /* 8  Backward at 8x speed */
        NETDEV_PLAY_STATUS_4_BACKWARD = 2,        /* 4  Backward at 4x speed */
        NETDEV_PLAY_STATUS_2_BACKWARD = 3,        /* 2  Backward at 2x speed */
        NETDEV_PLAY_STATUS_1_BACKWARD = 4,        /*   Backward at normal speed */
        NETDEV_PLAY_STATUS_HALF_BACKWARD = 5,        /* 1/2  Backward at 1/2 speed */
        NETDEV_PLAY_STATUS_QUARTER_BACKWARD = 6,        /* 1/4  Backward at 1/4 speed */
        NETDEV_PLAY_STATUS_QUARTER_FORWARD = 7,        /* 1/4  Play at 1/4 speed */
        NETDEV_PLAY_STATUS_HALF_FORWARD = 8,        /* 1/2  Play at 1/2 speed */
        NETDEV_PLAY_STATUS_1_FORWARD = 9,        /*   Forward at normal speed */
        NETDEV_PLAY_STATUS_2_FORWARD = 10,       /* 2  Forward at 2x speed */
        NETDEV_PLAY_STATUS_4_FORWARD = 11,       /* 4  Forward at 4x speed */
        NETDEV_PLAY_STATUS_8_FORWARD = 12,       /* 8  Forward at 8x speed */
        NETDEV_PLAY_STATUS_16_FORWARD = 13,       /* 16  Forward at 16x speed */

        NETDEV_PLAY_STATUS_INVALID
    };

    public enum NETDEV_VOD_PLAY_CTRL_E
    {
        NETDEV_PLAY_CTRL_PLAY = 0,           /*   Play */
        NETDEV_PLAY_CTRL_PAUSE = 1,           /*   Pause */
        NETDEV_PLAY_CTRL_RESUME = 2,           /*   Resume */
        NETDEV_PLAY_CTRL_GETPLAYTIME = 3,           /*   Obtain playing time */
        NETDEV_PLAY_CTRL_SETPLAYTIME = 4,           /*   Configure playing time */
        NETDEV_PLAY_CTRL_GETPLAYSPEED = 5,           /*   Obtain playing speed */
        NETDEV_PLAY_CTRL_SETPLAYSPEED = 6            /*   Configure playing speed */
    };

    public enum NETDEV_HOSTTYPE_E
    {
        NETDEV_NETWORK_HOSTTYPE_IPV4 = 0,               /* IPv4 */
        NETDEV_NETWORK_HOSTTYPE_IPV6 = 1,               /* IPv6 */
        NETDEV_NETWORK_HOSTTYPE_DNS = 2                /* DNS */
    };
    public enum NETDEV_RELAYOUTPUT_STATE_E
    {
        NETDEV_BOOLEAN_STATUS_ACTIVE = 0,            /*   Triggered */
        NETDEV_BOOLEAN_STATUS_INACTIVE = 1             /*  Not triggered */
    };

    public enum NETDEV_OSD_TIME_FORMAT_CAP_E
    {
        NETDEV_OSD_TIME_FORMAT_CAP_HHMMSS = 0,          /* HH:mm:ss */
        NETDEV_OSD_TIME_FORMAT_CAP_HH_MM_SS_PM          /* hh:mm:ss tt */

    };

    public enum NETDEV_E_DOWNLOAD_SPEED_E
    {
        NETDEV_DOWNLOAD_SPEED_ONE = 0,          /*  1x */
        NETDEV_DOWNLOAD_SPEED_TWO,              /*  2x */
        NETDEV_DOWNLOAD_SPEED_FOUR,             /*  4x */
        NETDEV_DOWNLOAD_SPEED_EIGHT,            /*  8x */
        NETDEV_DOWNLOAD_SPEED_TWO_IFRAME,       /*  I2x */
        NETDEV_DOWNLOAD_SPEED_FOUR_IFRAME,      /*  I4x */
        NETDEV_DOWNLOAD_SPEED_EIGHT_IFRAME      /*  I8x */
    };

    public enum NETDEV_PROTOCOL_TYPE_E
    {
        NETDEV_NETWORK_PROTOCOLTYPE__HTTP = 0,
        NETDEV_NETWORK_PROTOCOLTYPE__HTTPS = 1,
        NETDEV_NETWORK_PROTOCOLTYPE__RTSP = 2
    };

    public enum NETDEV_TIME_ZONE_E
    {
        NETDEV_TIME_ZONE_W1200 = 0,              /* W12 */
        NETDEV_TIME_ZONE_W1100 = 1,              /* W11 */
        NETDEV_TIME_ZONE_W1000 = 2,              /* W10 */
        NETDEV_TIME_ZONE_W0900 = 3,              /* W9 */
        NETDEV_TIME_ZONE_W0800 = 4,              /* W8 */
        NETDEV_TIME_ZONE_W0700 = 5,              /* W7 */
        NETDEV_TIME_ZONE_W0600 = 6,              /* W6 */
        NETDEV_TIME_ZONE_W0500 = 7,              /* W5 */
        NETDEV_TIME_ZONE_W0430 = 8,              /* W4:30 */
        NETDEV_TIME_ZONE_W0400 = 9,              /* W4 */
        NETDEV_TIME_ZONE_W0330 = 10,             /* W3:30 */
        NETDEV_TIME_ZONE_W0300 = 11,             /* W3 */
        NETDEV_TIME_ZONE_W0200 = 12,             /* W2 */
        NETDEV_TIME_ZONE_W0100 = 13,             /* W1 */
        NETDEV_TIME_ZONE_0000 = 14,             /* W0 */
        NETDEV_TIME_ZONE_E0100 = 15,             /* E1 */
        NETDEV_TIME_ZONE_E0200 = 16,             /* E2 */
        NETDEV_TIME_ZONE_E0300 = 17,             /* E3 */
        NETDEV_TIME_ZONE_E0330 = 18,             /* E3:30 */
        NETDEV_TIME_ZONE_E0400 = 19,             /* E4 */
        NETDEV_TIME_ZONE_E0430 = 20,             /* E4:30 */
        NETDEV_TIME_ZONE_E0500 = 21,             /* E5 */
        NETDEV_TIME_ZONE_E0530 = 22,             /* E5:30 */
        NETDEV_TIME_ZONE_E0545 = 23,             /* E5:45 */
        NETDEV_TIME_ZONE_E0600 = 24,             /* E6 */
        NETDEV_TIME_ZONE_E0630 = 25,             /* E6:30 */
        NETDEV_TIME_ZONE_E0700 = 26,             /* E7 */
        NETDEV_TIME_ZONE_E0800 = 27,             /* E8 */
        NETDEV_TIME_ZONE_E0900 = 28,             /* E9 */
        NETDEV_TIME_ZONE_E0930 = 29,             /* E9:30 */
        NETDEV_TIME_ZONE_E1000 = 30,             /* E10 */
        NETDEV_TIME_ZONE_E1100 = 31,             /* E11 */
        NETDEV_TIME_ZONE_E1200 = 32,             /* E12 */
        NETDEV_TIME_ZONE_E1300 = 33,             /* E13 */

        NETDEV_TIME_ZONE_INVALID = 0xFF          /* Invalid value */
    };
    enum NETDEV_ALARM_TYPE_E
    {
        /*********************************************************************** */
        /*  Alarm                                                            */
        /*********************************************************************** */
        /*   Recoverable alarms */
        NETDEV_ALARM_MOVE_DETECT = 1,            /*  Motion detection alarm */
        NETDEV_ALARM_VIDEO_LOST = 2,            /*  Video loss alarm */
        NETDEV_ALARM_VIDEO_TAMPER_DETECT = 3,            /*   Tampering detection alarm */
        NETDEV_ALARM_INPUT_SWITCH = 4,            /*  boolean input alarm */
        NETDEV_ALARM_TEMPERATURE_HIGH = 5,            /*   High temperature alarm */
        NETDEV_ALARM_TEMPERATURE_LOW = 6,            /*   Low temperature alarm */
        NETDEV_ALARM_AUDIO_DETECT = 7,            /*   Audio detection alarm */
        NETDEV_ALARM_DISK_ABNORMAL = 8,            /*  Disk abnormal*/
        NETDEV_ALARM_DISK_OFFLINE = 9,            /*  Disk offline*/


        /*   Status report of NVR and access device 100~199 */
        NETDEV_ALARM_REPORT_DEV_ONLINE = 100,          /*   Device online */
        NETDEV_ALARM_REPORT_DEV_OFFLINE = 101,          /*   Device offline */
        NETDEV_ALARM_REPORT_DEV_VIDEO_LOSS = 102,          /*  Video loss */
        NETDEV_ALARM_REPORT_DEV_VIDEO_LOSS_RECOVER = 103,          /*   Video loss recover */
        NETDEV_ALARM_REPORT_DEV_REBOOT = 104,          /*   Device restart */
        NETDEV_ALARM_REPORT_DEV_SERVICE_REBOOT = 105,          /*   Service restart */
        NETDEV_ALARM_REPORT_DEV_DELETE_CHL = 106,          /*   Delete channel */

        /*   Live view exception report 200~299 */
        NETDEV_ALARM_NET_FAILED = 200,          /*  Network error */
        NETDEV_ALARM_NET_TIMEOUT = 201,          /*  Network timeout */
        NETDEV_ALARM_SHAKE_FAILED = 202,          /*  Interaction error */
        NETDEV_ALARM_STREAMNUM_FULL = 203,          /*  Stream full */
        NETDEV_ALARM_STREAM_THIRDSTOP = 204,          /*  Third party stream stopped */
        NETDEV_ALARM_FILE_END = 205,          /*  File ended */

        /*   Valid alarms within 24 hours without arming schedule */
        NETDEV_ALARM_ALLTIME_FLAG_START = 400,          /*   Start marker of alarm without arming schedule */
        NETDEV_ALARM_STOR_ERR = 401,          /*  Storage error */
        NETDEV_ALARM_STOR_DISOBEY_PLAN = 402,          /*   Not stored as planned */

        /*   Unrecoverable alarms */
        NETDEV_ALARM_NO_RECOVER_FLAG_START = 500,          /*   Start marker of unrecoverable alarm */
        NETDEV_ALARM_DISK_ERROR = 501,          /*   Disk error */
        NETDEV_ALARM_ILLEGAL_ACCESS = 502,          /*   Illegal access */

        NETDEV_ALARM_LINE_CROSS = 503,          /* Line cross */
        NETDEV_ALARM_OBJECTS_INSIDE = 504,          /* Objects inside */
        NETDEV_ALARM_FACE_RECOGNIZE = 505,          /* Face recognize */

        NETDEV_ALARM_ALLTIME_FLAG_END = 600,          /*   End marker of alarm without arming schedule */


        /*   Alarm recover */
        NETDEV_ALARM_RECOVER_BASE = 1000,         /*   Alarm recover base */
        NETDEV_ALARM_MOVE_DETECT_RECOVER = 1001,         /*   Motion detection alarm recover */
        NETDEV_ALARM_VIDEO_LOST_RECOVER = 1002,         /*  Video loss alarm recover */
        NETDEV_ALARM_VIDEO_TAMPER_RECOVER = 1003,         /*   Tampering detection alarm recover */
        NETDEV_ALARM_INPUT_SWITCH_RECOVER = 1004,         /*   Boolean input alarm recover */
        NETDEV_ALARM_TEMPERATURE_RECOVER = 1005,         /*   Temperature alarm recover */
        NETDEV_ALARM_AUDIO_DETECT_RECOVER = 1007,         /*   Audio detection alarm recover */
        NETDEV_ALARM_DISK_ABNORMAL_RECOVER = 1008,         /*  Disk abnormal recover */
        NETDEV_ALARM_DISK_OFFLINE_RECOVER = 1009,         /*  Disk online recover */

        NETDEV_ALARM_STOR_ERR_RECOVER = 1201,         /*   Storage error recover */
        NETDEV_ALARM_STOR_DISOBEY_PLAN_RECOVER = 1202,         /*  Not stored as planned recover */

        NETDEV_ALARM_INVALID = 0xFFFF        /*   Invalid value */
    };

    /**
 * @enum tagNETDEVCFGCmd
 * @brief   Parameter configuration command words Enumeration definition
 * @attention  None
 */
    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PARSE_VIDEO_DATA_S
    {
        public byte pucData;             /*   Pointer to video data */
        public Int32 dwDataLen;            /*   Video data length */
        public Int32 dwVideoFrameType;     /* NETDEV_VIDEO_FRAME_TYPE_E  Frame type, see enumeration #NETDEV_VIDEO_FRAME_TYPE_E */
        public Int32 dwVideoCodeFormat;    /* #NETDEV_VIDEO_CODE_TYPE_E  Video encoding format, see enumeration #NETDEV_VIDEO_CODE_TYPE_E */
        public Int32 dwHeight;             /*   Video image height */
        public Int32 dwWidth;              /*   Video image width */
        public Int64 tTimeStamp;           /* ）  Time stamp (ms) */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] byRes;              /*   Reserved field*/
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PICTURE_DATA_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] pucData;                /* pucData[0]: Y plane pointer, pucData[1]: U plane pointer, pucData[2]: V plane pointer */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public Int32[] dwLineSize;              /*  ulLineSize[0]: Y line spacing, ulLineSize[1]: U line spacing, ulLineSize[2]: V line spacing */
        public Int32 dwPicHeight;                /*   Picture height */
        public Int32 dwPicWidth;                 /*   Picture width */
        public Int32 dwRenderTimeType;           /*   Time data type for rendering */
        public Int64 tRenderTime;                /*  Time data for rendering */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_ALARM_INFO_S
    {
        public Int32 dwAlarmType;
        public Int64 tAlarmTime;
        public Int32 dwChannelID;
        public Int16 wIndex;
        String pszName;                       /* Alarm source name, alarm input/output name */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
        public byte[] szReserve;
    }



    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_CLOUD_DEV_LOGIN_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] szDeviceName;                   /* Device name */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] szDevicePassword;               /* Device password */
        public Int32 dwT2UTimeout;                                 /* T2U Time out,default 15s */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_CLOUD_DEV_INFO_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_IPV4_LEN_MAX)]
        public char[] szIPAddr;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szDevUserName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szDevName;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szDevModel;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szDevSerialNum;

        public Int32 dwOrgID;                                    /* Organization ID */
        public Int32 dwDevPort;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_DEVICE_INFO_S
    {
        public Int32 dwDevType;
        public Int16 wAlarmInPortNum;                   /* Number of alarm inputs */
        public Int16 wAlarmOutPortNum;                  /* Number of alarm outputs */
        public Int32 dwChannelNum;                      /* Number of Channels */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public byte[] szReserve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_VIDEO_CHL_DETAIL_INFO_S
    {
        public Int32 dwChannelID;
        public Int32 dwType;
        public Int32 enStatus;        /*NETDEV_CHANNEL_STATUS_E*/
        public Int32 dwStreamNum;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 68)]
        public byte[] szReserve;

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PREVIEWINFO_S
    {
        public Int32 dwChannelID;
        public Int32 dwStreamType;
        public Int32 dwLinkMode;
        public IntPtr hPlayWnd;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 264)]
        public byte[] szReserve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_FILECOND_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] szFileName;      /*   Recording file name */
        public Int32 dwChannelID;
        public Int32 dwFileType;
        public Int64 tBeginTime;
        public Int64 tEndTime;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public byte[] szReserve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_FINDDATA_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] szFileName;

        public Int64 tBeginTime;
        public Int64 tEndTime;

        public byte byFileType;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 171)]
        public byte[] szReserve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PLAYBACKINFO_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_260)]
        public char[] szFileName;

        public Int64 tBeginTime;
        public Int64 tEndTime;

        public Int32 dwLinkMode;
        public IntPtr hPlayWnd;

        public Int32 dwFileType;                     /* NETDEV_PLAN_STORE_TYPE_E  Recording storage type, see enumeration #NETDEV_PLAN_STORE_TYPE_E */
        public Int32 dwDownloadSpeed;                /* NETDEV_E_DOWNLOAD_SPEED_E  Download speed, see enumeration #NETDEV_E_DOWNLOAD_SPEED_E */

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] szReserve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PLAYBACKCOND_S
    {
        public Int32 dwChannelID;                  /*   Playback channel */
        public Int64 tBeginTime;                  /*   Playback start time */
        public Int64 tEndTime;                    /*   Playback end time */
        public Int32 dwLinkMode;                   /*  Transport protocol, see enumeration #NETDEV_PROTOCAL_E */
        public IntPtr hPlayWnd;                    /*   Play window handle */
        public Int32 dwFileType;                   /* #NETDEV_PLAN_STORE_TYPE_E  Recording storage type, see enumeration #NETDEV_PLAN_STORE_TYPE_E */
        public Int32 dwDownloadSpeed;               /*  #NETDEV_E_DOWNLOAD_SPEED_E */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] byRes;                 /*   Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_VIDEO_STREAM_INFO_S
    {
        public Int32 enStreamType;       /*  NETDEV_LIVE_STREAM_INDEX_E*/
        public Int32 bEnableFlag;
        public Int32 dwHeight;           /* -Height */
        public Int32 dwWidth;            /* -Width */
        public Int32 dwFrameRate;
        public Int32 dwBitRate;
        public Int32 enCodeType;         /*  NETDEV_VIDEO_CODE_TYPE_E*/
        public Int32 enQuality;          /*  UW_VIDEO_QUALITY_E*/
        public Int32 dwGop;              /* I */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] szReserve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PTZ_OPERATEAREA_S
    {
        public Int32 dwBeginPointX;                           /* X[0,10000]  Area start point X value [0,10000] */
        public Int32 dwBeginPointY;                           /* Y[0,10000]  Area start point Y value [0,10000] */
        public Int32 dwEndPointX;                             /* X[0,10000]  Area end point X value [0,10000] */
        public Int32 dwEndPointY;                             /* Y [0,10000]  Area end point Y value [0,10000] */
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PTZ_PRESET_S
    {
        public Int32 dwPresetID;                                 /* ID  Preset ID */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_32)]
        public byte[] szPresetName;                /*   Preset name */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PTZ_ALLPRESETS_S
    {
        public Int32 dwSize;                             /*   Total number of presets */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_MAX_PRESET_NUM)]
        public NETDEV_PTZ_PRESET_S[] astPreset;   /*   Structure of preset information */
    };
    /// <summary>
    /// 巡航点
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_CRUISE_POINT_S
    {
        /// <summary>
        /// 预置点id
        /// </summary>
        public Int32 dwPresetID;                     /* ID  Preset ID */
        /// <summary>
        /// 停留时间
        /// </summary>
        public Int32 dwStayTime;                     /*   Stay time */
        /// <summary>
        /// 巡航速度
        /// </summary>
        public Int32 dwSpeed;                        /*   Speed */
        /// <summary>
        /// 
        /// </summary>
        public Int32 dwReserve;                      /*   Reserved */
    };
    /// <summary>
    /// 巡航路径信息
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_CRUISE_INFO_S
    {
        /// <summary>
        /// 路径id
        /// </summary>
        public Int32 dwCuriseID;                                     /* ID  Route ID */
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_32)]
        //public char[] szCuriseName;
        /// <summary>
        /// 路经名称 设置时有效
        /// </summary>
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NETDEVSDK.NETDEV_LEN_32)]
        public string szCuriseName;                    /*   Route name */
        /// <summary>
        /// 巡航路径包含的巡航点数量 设置时有效
        /// </summary>
        public Int32 dwSize;                                         /*   Number of presets included in the route */
        /// <summary>
        /// 巡航点信息 设置时有效
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_MAX_CRUISEPOINT_NUM)]
        public NETDEV_CRUISE_POINT_S[] astCruisePoint;     /*    Information of presets included in the route */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_CRUISE_LIST_S
    {
        public Int32 dwSize;                                         /*   Number of patrol routes */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_MAX_CRUISEROUTE_NUM)]
        public NETDEV_CRUISE_INFO_S[] astCruiseInfo;      /*   Information of patrol routes */
    };

    /**
 * @struct tagNETDEVPtzTrackinfo
 * @brief   Route information of PTZ route patrol Structure definition
 * @attention  None
 */
    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PTZ_TRACK_INFO_S
    {
        public Int32 dwTrackNum;                                               /*   Number of existing patrol routes */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public byte[] aszTrackName;  /*   Route name */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_IMAGE_SETTING_S
    {
        public Int32 dwContrast;                   /*   Contrast */
        public Int32 dwBrightness;                 /*   Brightness */
        public Int32 dwSaturation;                 /*   Saturation */
        public Int32 dwSharpness;                  /*   Sharpness */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 252)]
        public byte[] byRes;                     /* Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_SYSTEM_IPADDR_S
    {
        public Int32 eIPType;                            /* #NETDEV_HOSTTYPE_E  Protocol type, see enumeration #NETDEV_HOSTTYPE_E */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_132)]
        public char[] szIPAddr;           /* IP  IP address */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_SYSTEM_NTP_INFO_S
    {
        public bool bSupportDHCP;                      /* DHCP  Support DHCP or not */
        public NETDEV_SYSTEM_IPADDR_S stAddr;          /* NTP   NTP information */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_NETWORKCFG_S
    {
        public Int32 dwMTU;                                         /* MTU value */
        public Int32 dwIPv4DHCP;                                    /* DHCP of IPv4 */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_32)]
        public char[] szIpv4Address;                                /* IP address of IPv4 */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_32)]
        public char[] szIPv4GateWay;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_32)]
        public char[] szIPv4SubnetMask;                          /*  Gateway of IPv4 */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 480)]
        public byte[] byRes;                                        /*   Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_ALARM_INPUT_INFO_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szName;                                                  /*    Name of input alarm */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_ALARM_INPUT_LIST_S
    {
        public Int32 dwSize;                                           /*   Number of input alarms */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_MAX_ALARM_IN_NUM)]
        public NETDEV_ALARM_INPUT_INFO_S[] astAlarmInputInfo;       /*   Configuration information of input alarms */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_ALARM_OUTPUT_INFO_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szName;                                           /*  Boolean name */
        public Int32 dwChancelId;                                       /*  Channel number */
        public Int32 enDefaultStatus;                                   /*  Default status of boolean output, see enumeration #NETDEV_BOOLEAN_MODE_E */
        public Int32 dwDurationSec;                                     /*  Alarm duration (s) */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_ALARM_OUTPUT_LIST_S
    {
        public Int32 dwSize;                                                 /*    Number of booleans  */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_MAX_ALARM_OUT_NUM)]
        public NETDEV_ALARM_OUTPUT_INFO_S[] astAlarmOutputInfo;           /*   Boolean configuration information */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_TRIGGER_ALARM_OUTPUT_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szName;          /*   Boolean name */
        public NETDEV_RELAYOUTPUT_STATE_E enOutputState;                  /* ,#NETDEV_RELAYOUTPUT_STATE_E  Trigger status, see enumeration #NETDEV_RELAYOUTPUT_STATE_E */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_AREA_SCOPE_S
    {
        public Int32 dwLocateX;             /** x[0,10000] * Coordinates of top point x [0,10000] */
        public Int32 dwLocateY;             /** y[0,10000] * Coordinates of top point y [0,10000] */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_OSD_TIME_S
    {
        public bool bEnableFlag;        /** OSD BOOL_TRUEBOOL_FALSE * Enable time OSD, BOOL_TRUE means enable and BOOL_FALSE means disable */
        public bool bWeekEnableFlag;    /** () * Display week or not (reserved) */
        public NETDEV_AREA_SCOPE_S stAreaScope;        /**  * Area coordinates */
        public Int32 udwTimeFormat;      /** OSDNETDEV_OSD_TIME_FORMAT_E * Time OSD format, see NETDEV_OSD_TIME_FORMAT_E */
        public Int32 udwDateFormat;      /** OSDNETDEV_OSD_DATE_FMT_E * Date OSD format, see NETDEV_OSD_TIME_FORMAT_E */

    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_OSD_TEXT_OVERLAY_S
    {
        public bool bEnableFlag;                /** OSD BOOL_TRUEBOOL_FALSE * Enable OSD text overlay, BOOL_TRUE means enable and BOOL_FALSE means disable */
        public NETDEV_AREA_SCOPE_S stAreaScope;                /** OSD * OSD text overlay area coordinates */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_OSD_TEXT_MAX_LEN)]
        public char[] szOSDText;    /** OSD * OSD text overlay name strings */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] byRes;                               /*   Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_VIDEO_OSD_CFG_S
    {
        public NETDEV_OSD_TIME_S stTimeOSD;        /* OSD  Information of channel time OSD */
        public NETDEV_OSD_TEXT_OVERLAY_S stNameOSD;        /* OSD  Information of channel name OSD */
        public Int16 wTextNum;         /* OSD  Text OSD exists or not */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_OSD_TEXTOVERLAY_NUM)]
        public NETDEV_OSD_TEXT_OVERLAY_S[] astTextOverlay;   /** OSD * Information of channel OSD text overlay */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_DEVICE_BASICINFO_S
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szDevModel;                     /*   Device model */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szSerialNum;                    /*   Hardware serial number */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szFirmwareVersion;              /*   Software version */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szMacAddress;                   /* IPv4Mac  MAC address of IPv4 */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public char[] szDeviceName;                   /* Device name */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 448)]
        public byte[] byRes;                                    /*   Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PRIVACY_MASK_AREA_INFO_S
    {
        public Int32 bIsEanbled;           /*   Enable or not. */
        public Int32 dwTopLeftX;           /* X [0, 10000]  Upper left corner X [0, 10000]  */
        public Int32 dwTopLeftY;           /* Y [0, 10000]  Upper left corner Y [0, 10000]  */
        public Int32 dwBottomRightX;       /* X [0, 10000]  Lower right corner x [0, 10000] */
        public Int32 dwBottomRightY;       /* Y [0, 10000]  Lower right corner y [0, 10000] */
        public Int32 dwIndex;              /* Index */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_PRIVACY_MASK_CFG_S
    {
        public Int32 dwSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_MAX_PRIVACY_MASK_AREA_NUM)]
        public NETDEV_PRIVACY_MASK_AREA_INFO_S[] astArea;  /*  *< Mask area parameters */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_VIDEO_EFFECT_S
    {
        public Int32 dwContrast;                   /* Contrast */
        public Int32 dwBrightness;                 /* Brightness */
        public Int32 dwSaturation;                 /* Saturation */
        public Int32 dwHue;                        /* Hue */
        public Int32 dwGamma;                      /* Gamma */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] byRes;                    /* Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_RECT_S
    {
        public Int32 dwLeft;                               /* X axis left point value [0,10000] */
        public Int32 dwTop;                                /* Y axis top point value [0,10000] */
        public Int32 dwRight;                              /* X axis right point value [0,10000] */
        public Int32 dwBottom;                             /* Y axis bottom point value [0,10000] */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct array
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_SCREEN_INFO_COLUMN)]
        public Int16[] wTemp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_MOTION_ALARM_INFO_S
    {
        public Int32 dwSensitivity;                                                     /* Sensitivity */
        public Int32 dwObjectSize;                                                      /* Objection Size */
        public Int32 dwHistory;                                                         /* History */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_SCREEN_INFO_ROW)]
        public array[] awScreenInfo;                                                       /* Screen Info */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public byte[] byRes;                                                             /* Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_TAMPER_ALARM_INFO_S
    {
        public Int32 dwSensitivity;                               /* Sensitivity */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] byRes;                                       /* Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_UPNP_PORT_STATE_S
    {
        public NETDEV_PROTOCOL_TYPE_E eType;
        public bool bEnbale;
        public Int32 dwPort;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] byRes;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_UPNP_NAT_STATE_S
    {
        public Int32 dwSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_16)]
        public NETDEV_UPNP_PORT_STATE_S[] astUpnpPort;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_TIME_S
    {
        public Int32 dwYear;                       /* Year */
        public Int32 dwMonth;                      /* Month */
        public Int32 dwDay;                        /* Day */
        public Int32 dwHour;                       /* Hour */
        public Int32 dwMinute;                     /* Minute */
        public Int32 dwSecond;                     /* Second */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_TIME_CFG_S
    {
        public NETDEV_TIME_ZONE_E dwTimeZone;                      /* see NETDEV_TIME_ZONE_E */
        public NETDEV_TIME_S stTime;                               /* Time */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
        public byte[] byRes;                                       /* Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_REV_TIMEOUT_S
    {
        public Int32 dwRevTimeOut;                /* Set receive time out */
        public Int32 dwFileReportTimeOut;         /* Set file report time out*/
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] byRes;                              /* Reserved */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_DISK_INFO_S
    {
        public Int32 dwDiskCabinetIndex;
        public Int32 dwSlotIndex;                                                      /*硬盘所在槽位索引 Slot Index */
        public Int32 dwTotalCapacity;                                                  /* 硬盘总容量 Total Capacity*/
        public Int32 dwUsedCapacity;                                                   /* 已经使用量 Used Capacity */
        public Int32 enStatus;                                                         /* 运行状态 Status */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_32)]
        public char[] szManufacturer;                                                 /* 厂商 Manufacturer */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct NETDEV_DISK_INFO_LIST_S
    {
        public Int32 dwSize;                                  /* 硬盘个数 */
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = NETDEVSDK.NETDEV_LEN_64)]
        public NETDEV_DISK_INFO_S[] astDisksInfo;             /* 硬盘信息 */
    };


    class NETDEVSDK
    {


        /**********************************  Commonly used numerical macros *************** */

        /*   Length of stream ID*/
        public const int NETDEV_STREAM_ID_LEN = 32;

        /*   Length of filename */
        public const uint NETDEV_FILE_NAME_LEN = (256u);

        /*   Maximum length of username */
        public const int NETDEV_USER_NAME_LEN = 32;

        /*   Maximum length of password */
        public const int NETDEV_PASSWD_LEN = 64;

        /*   Length of password and encrypted passcode for user login */
        public const int NETDEV_PASSWD_ENCRYPT_LEN = 64;

        /*   Length of resource code string */
        public const int NETDEV_RES_CODE_LEN = 48;

        /*   Maximum length of domain name */
        public const int NETDEV_DOMAIN_LEN = 64;

        /*   Maximum length of device name */
        public const int NETDEV_DEVICE_NAME_LEN = 32;

        /*   Maximum length of path */
        public const int NETDEV_PATH_LEN_WITHOUT_NAME = 64;

        /*   Maximum length of path, including filename */
        public const int NETDEV_PATH_LEN = 128;

        /*   Maximum length of email address */
        public const int NETDEV_EMAIL_NAME_ADDR = 32;

        /*   Length of MAC address */
        public const int NETDEV_MAC_ADDR_LEN = 6;

        /*   Length of endpoint called by gSOAP */
        public const int NETDEV_ENDPOINT_LEN = 96;

        /*   Maximum length of session ID */
        public const int NETDEV_SESSION_ID_LEN = 16;

        /*    Maximum length of URL */
        public const int NDE_MAX_URL_LEN = 260;

        /*   Common length */
        public const int NETDEV_LEN_4 = 4;
        public const int NETDEV_LEN_8 = 8;
        public const int NETDEV_LEN_16 = 16;
        public const int NETDEV_LEN_32 = 32;
        public const int NETDEV_LEN_64 = 64;
        public const int NETDEV_LEN_128 = 128;
        public const int NETDEV_LEN_132 = 132;
        public const int NETDEV_LEN_260 = 260;

        /*    Length of IP address string */
        public const uint NETDEV_IPADDR_STR_MAX_LEN = (64u);

        /*  Length of IPV4 address string */
        public const int NETDEV_IPV4_LEN_MAX = 16;

        /*   Length of common name string */
        public const uint NETDEV_NAME_MAX_LEN = (20u);

        /*    Length of common code */
        public const uint NETDEV_CODE_STR_MAX_LEN = (48u);

        /*  Maximum length of date string "2008-10-02 09:25:33.001 GMT" */
        public const uint NETDEV_MAX_DATE_STRING_LEN = (64u);

        /*  Length of time string "hh:mm:ss" */
        public const uint NETDEV_SIMPLE_TIME_LEN = (12u);

        /*  Length of date string "YYYY-MM-DD"*/
        public const uint NETDEV_SIMPLE_DATE_LEN = (12u);

        /*   Maximum number of alarm inputs */
        public const int NETDEV_MAX_ALARM_IN_NUM = 64;

        /*   Maximum number of alarm outputs */
        public const int NETDEV_MAX_ALARM_OUT_NUM = 64;

        /*   Number of scheduled time sections in a day */
        public const int NETDEV_PLAN_SECTION_NUM = 8;

        /*   Total number of plans allowed in a week, including Monday to Sunday, and holidays */
        public const int NETDEV_PLAN_NUM_AWEEK = 8;

        /*   Maximum number of motion detection areas allowed */
        public const int NETDEV_MAX_MOTION_DETECT_AREA_NUM = 4;

        /*   Maximum number of privacy mask areas allowed */
        public const int NETDEV_MAX_PRIVACY_MASK_AREA_NUM = 8;

        /*   Maximum number of tamper-proof areas allowed */
        public const int NETDEV_MAX_TAMPER_PROOF_AREA_NUM = 1;

        /*   Maximum number of text overlays allowed for a channel */
        public const int NETDEV_MAX_TEXTOVERLAY_NUM = 6;

        /*   Maximum number of video streams */
        public const int NETDEV_MAX_VIDEO_STREAM_NUM = 8;

        /*   Month of the year */
        public const int NETDEV_MONTH_OF_YEAR = 12;

        /*   Day of the month */
        public const int NETDEV_DAYS_OF_MONTH = 32;

        /*   Length of device ID */
        public const int NETDEV_DEV_ID_LEN = 64;

        /*   Length of device serial number */
        public const int NETDEV_SERIAL_NUMBER_LEN = 32;

        /*   Maximum number of queries allowed at a time */
        public const int NETDEV_MAX_QUERY_NUM = 200;

        /*   Total number of queries allowed */
        public const int NETDEV_MAX_QUERY_TOTAL_NUM = 2000;

        /*   Maximum number of IP cameras */
        public const int NETDEV_MAX_IPC_NUM = 128;

        /*   Maximum number of presets */
        public const int NETDEV_MAX_PRESET_NUM = 256;

        /*   Maximum number of presets for preset patrol */
        public const int NETDEV_MAX_CRUISEPOINT_NUM = 32;

        /*   Maximum number of routes for preset patrol */
        public const int NETDEV_MAX_CRUISEROUTE_NUM = 16;

        /*   PTZ rotating speed */
        public const int NETDEV_MIN_PTZ_SPEED_LEVEL = 1;
        public const int NETDEV_MAX_PTZ_SPEED_LEVEL = 9;

        /*  Maximum / Minimum values for image parameters (brightness, contrast, hue, saturation) */
        public const int NETDEV_MAX_VIDEO_EFFECT_VALUE = 255;
        public const int NETDEV_MIN_VIDEO_EFFECT_VALUE = 0;

        /*  Minimum values for image parameters (Gama) */
        public const int NETDEV_MAX_VIDEO_EFFECT_GAMMA_VALUE = 10;

        /*   Maximum connection timeout */
        public const int NETDEV_MAX_CONNECT_TIME_VALUE = 75000;

        /*   Minimum connection timeout */
        public const int NETDEV_MIN_CONNECT_TIME_VALUE = 300;

        /*   Maximum number of users */
        public const int NETDEV_MAX_USER_NUM = (256 + 32);

        /*   Maximum number of channels allowed for live preview */
        public const int NETDEV_MAX_REALPLAY_NUM = 128;

        /*   Maximum number of channels allowed for playback or download */
        public const int NETDEV_MAX_PALYBACK_NUM = 128;

        /*   Maximum number of alarm channels */
        public const int NETDEV_MAX_ALARMCHAN_NUM = 128;

        /*   Maximum number of channels allowed for formatting hard disk */
        public const int NETDEV_MAX_FORMAT_NUM = 128;

        /*   Maximum number of channels allowed for file search */
        public const int NETDEV_MAX_FILE_SEARCH_NUM = 2000;

        /*   Maximum number of channels allowed for log search */
        public const int NETDEV_MAX_LOG_SEARCH_NUM = 2000;

        /*   Maximum number of channels allowed for creating transparent channels */
        public const int NETDEV_MAX_SERIAL_NUM = 2000;

        /*   Maximum number of channels allowed for upgrade */
        public const int NETDEV_MAX_UPGRADE_NUM = 256;

        /*   Maximum number of channels allowed for audio forwarding */
        public const int NETDEV_MAX_VOICE_COM_NUM = 256;

        /*   Maximum number of channels allowed for audio broadcast */
        public const int NETDEV_MAX_VOICE_BROADCAST_NUM = 256;

        /*   Maximum timeout, unit: ms */
        public const int NETDEV_MAX_CONNECT_TIME = 75000;

        /*   Minimum timeout, unit: ms */
        public const int NETDEV_MIN_CONNECT_TIME = 300;

        /*   Default timeout, unit: ms */
        public const int NETDEV_DEFAULT_CONNECT_TIME = 3000;

        /*   Number of connection attempts */
        public const int NETDEV_CONNECT_TRY_TIMES = 1;

        /*   User keep-alive interval */
        public const int NETDEV_KEEPLIVE_TRY_TIMES = 3;

        /*   Number of OSD text overlays */
        public const int NETDEV_OSD_TEXTOVERLAY_NUM = 6;

        /*  Length of OSD texts */
        public const int NETDEV_OSD_TEXT_MAX_LEN = (64 + 4);

        /*   Maximum number of alarms a user can get */
        public const int NETDEV_PULL_ALARM_MAX_NUM = 8;

        /*   Maximum number of patrol routes allowed  */
        public const int NETDEV_TRACK_CRUISE_MAXNUM = 1;

        /*   Minimum volume */
        public const int NETDEV_AUDIO_SOUND_MIN_VALUE = 0;

        /*   Maximum volume */
        public const int NETDEV_AUDIO_SOUND_MAX_VALUE = 255;

        /*   Minimum volume */
        public const int NETDEV_MIC_SOUND_MIN_VALUE = 0;

        /*   Maximum volume */
        public const int NETDEV_MIC_SOUND_MAX_VALUE = 255;

        /*   Screen Info Row */
        public const int NETDEV_SCREEN_INFO_ROW = 18;

        /*   Screen Info Column */
        public const int NETDEV_SCREEN_INFO_COLUMN = 22;

        /*   Length of IP */
        public const int NETDEV_IP_LEN = 64;


        /* Maximum length of URL */
        public const int NETDEV_BUFFER_MAX_LEN = 1024;


        public const int TRUE = 1;

        public const int FALSE = 0;
        public const int NETDEV_E_NONSUPPORT = 38;

        public static int m_bRouteRecording;
        public static int m_bTracking;


        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_Init();

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_Cleanup();

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void NETDEV_AlarmMessCallBack_PF(IntPtr lpUserID, Int32 dwChannelID, NETDEV_ALARM_INFO_S stAlarmInfo, IntPtr lpBuf, Int32 dwBufLen, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetAlarmCallBack(IntPtr lpUserID, IntPtr cbAlarmMessCallBack, IntPtr lpUserData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void NETDEV_ExceptionCallBack_PF(IntPtr lpUserID, Int32 dwType, IntPtr stAlarmInfo, IntPtr lpExpHandle, IntPtr lpUserData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void NETDEV_SOURCE_DATA_CALLBACK_PF(IntPtr lpRealHandle, ref byte pucBuffer, IntPtr dwBufSize, Int32 dwMediaDataType, IntPtr lpUserParam);

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void NETDEV_DECODE_VIDEO_DATA_CALLBACK_PF(IntPtr lpRealHandle, ref NETDEV_PICTURE_DATA_S pstPictureData, IntPtr lpUserParam);

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void NETDEV_DISPLAY_CALLBACK_PF(IntPtr lpRealHandle, IntPtr hdc, IntPtr lpUserParam);

        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate void NETDEV_PARSE_VIDEO_DATA_CALLBACK_PF(IntPtr lpRealHandle, ref NETDEV_PARSE_VIDEO_DATA_S pstParseVideoData, IntPtr lpUserParam);


        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetExceptionCallBack(IntPtr cbExceptionCallBack, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetSDKVersion();

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_Login(String szDevIP, Int16 wDevPort, String szUserName, String szPassword, IntPtr pstDevInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_Logout(IntPtr lpUserID);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern void OutputDebugString(string message);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_QueryVideoChlDetailList(IntPtr lpUserID, ref int pdwChlCount, IntPtr pstVideoChlList);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_RealPlay(IntPtr lpUserID, ref NETDEV_PREVIEWINFO_S pstPreviewInfo, IntPtr cbPlayDataCallBack, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_StopRealPlay(IntPtr lpRealHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SaveRealData(IntPtr lpRealHandle, String szSaveFileName, Int32 dwFormat);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_StopSaveRealData(IntPtr lpRealHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PlaySound(IntPtr lpRealHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_StopPlaySound(IntPtr lpRealHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetBitRate(IntPtr lpRealHandle, ref int pdwBitRate);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetFrameRate(IntPtr lpRealHandle, ref int pdwFrameRate);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetVideoEncodeFmt(IntPtr lpRealHandle, ref int pdwVideoEncFmt);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetResolution(IntPtr lpRealHandle, ref int pdwWidth, ref int pdwHeight);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetLostPacketRate(IntPtr lpRealHandle, ref int pulRecvPktNum, ref int pulLostPktNum);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_ResetLostPacketRate(IntPtr lpRealHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_CapturePicture(IntPtr lpRealHandle, String szFileName, Int32 dwCaptureMode);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_CaptureNoPreview(IntPtr lpUserID, Int32 dwChannelID, Int32 dwStreamType, String szFileName, Int32 dwCaptureMode);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetRenderScale(IntPtr lpRealHandle, Int32 enRenderScale); /*NETDEV_RENDER_SCALE_E*/

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_FindFile(IntPtr lpUserID, ref NETDEV_FILECOND_S pFindCond);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_FindNextFile(IntPtr lpFindHandle, ref NETDEV_FINDDATA_S lpFindData); /*NETDEV_FINDDATA_S*/

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_FindClose(IntPtr lpFindHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_PlayBackByName(IntPtr lpUserID, ref NETDEV_PLAYBACKINFO_S pstPlayBackInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_PlayBackByTime(IntPtr lpUserID, ref NETDEV_PLAYBACKCOND_S pstPlayBackInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_StopPlayBack(IntPtr lpPlayHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_GetFileByName(IntPtr lpUserID, ref NETDEV_PLAYBACKINFO_S pstPlayBackInfo, String szSaveFileName, Int32 dwFormat);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_StopGetFile(IntPtr lpPlayHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PlayBackControl(IntPtr lpPlayHandle, Int32 dwControlCode, ref Int32 pdwBuffer);


        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZPreset(IntPtr lpPlayHandle, Int32 dwPTZPresetCmd, String pszPresetName, Int32 dwPresetID);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZControl(IntPtr lpPlayHandle, Int32 dwPTZCommand, Int32 dwSpeed);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, IntPtr lpOutBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, IntPtr lpInBuffer, ref int dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_Reboot(IntPtr lpUserID);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_OpenSound(IntPtr lpRealHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_CloseSound(IntPtr lpRealHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZControl_Other(IntPtr lpUserID, Int32 dwChannelID, Int32 dwPTZCommand, Int32 dwSpeed);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetLastError();

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZSelZoomIn_Other(IntPtr lpUserID, Int32 dwChannelID, ref NETDEV_PTZ_OPERATEAREA_S pstPtzOperateArea);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZPreset_Other(IntPtr lpUserID, Int32 dwChannelID, Int32 dwPTZPresetCmd, String pszPresetName, Int32 dwPresetID);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_PTZ_ALLPRESETS_S lpOutBuffer, Int32 dwOutBufferSize, ref Int32 pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZGetCruise(IntPtr lpUserID, Int32 dwChannelID, ref NETDEV_CRUISE_LIST_S pstCruiseList);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZCruise_Other(IntPtr lpUserID, Int32 dwChannelID, Int32 dwPTZCruiseCmd, ref NETDEV_CRUISE_INFO_S pstCruiseInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZGetTrackCruise(IntPtr lpUserID, Int32 dwChannelID, ref NETDEV_PTZ_TRACK_INFO_S pstTrackCruiseInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_PTZTrackCruise(IntPtr lpUserID, Int32 dwChannelID, Int32 dwPTZTrackCruiseCmd, ref byte pszTrackCruiseName);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_VIDEO_STREAM_INFO_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_VIDEO_STREAM_INFO_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_IMAGE_SETTING_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_IMAGE_SETTING_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_SYSTEM_NTP_INFO_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_SYSTEM_NTP_INFO_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_NETWORKCFG_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_NETWORKCFG_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_ALARM_OUTPUT_INFO_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_ALARM_OUTPUT_INFO_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_TRIGGER_ALARM_OUTPUT_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_TRIGGER_ALARM_OUTPUT_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_VIDEO_OSD_CFG_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_VIDEO_OSD_CFG_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_ALARM_INPUT_LIST_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_ALARM_OUTPUT_LIST_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_DEVICE_BASICINFO_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_DISK_INFO_LIST_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_PRIVACY_MASK_CFG_S lpInBuffer, Int32 dwOutBufferSize, ref int pdwBytesReturned);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDevConfig(IntPtr lpUserID, Int32 dwChannelID, Int32 dwCommand, ref NETDEV_PRIVACY_MASK_CFG_S lpInBuffer, Int32 dwInBufferSize);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_GetFileByTime(IntPtr lpUserID, ref NETDEV_PLAYBACKCOND_S pstPlayBackCond, String pszSaveFileName, Int32 dwFormat);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_RestoreConfig(IntPtr lpUserID);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetVideoEffect(IntPtr lpRealHandle, ref NETDEV_VIDEO_EFFECT_S pstImageInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetVideoEffect(IntPtr lpRealHandle, ref NETDEV_VIDEO_EFFECT_S pstImageInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetDigitalZoom(IntPtr lpRealHandle, IntPtr hWnd, IntPtr pstRect);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetUpnpNatState(IntPtr lpUserID, ref NETDEV_UPNP_NAT_STATE_S pstNatState);


        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_ModifyDeviceName(IntPtr lpUserID, String strDeviceName);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetLogPath(String strLogPath);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetSystemTimeCfg(IntPtr lpUserID, ref NETDEV_TIME_CFG_S pstSystemTimeInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetSystemTimeCfg(IntPtr lpUserID, ref NETDEV_TIME_CFG_S pstSystemTimeInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetRevTimeOut(ref NETDEV_REV_TIMEOUT_S pstRevTimeout);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetPlayDecodeVideoCB(IntPtr lpRealHandle, IntPtr cbPlayDecodeVideoCallBack, Int32 bContinue, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetPlayDataCallBack(IntPtr lpRealHandle, IntPtr cbPlayDataCallBack, Int32 bContinue, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetPlayDisplayCB(IntPtr lpRealHandle, IntPtr cbPlayDisplayCallBack, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_SetPlayParseCB(IntPtr lpRealHandle, IntPtr cbPlayParseCallBack, Int32 bContinue, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_StartVoiceCom(IntPtr lpUserID, Int32 dwChannelID, IntPtr cbPlayDataCallBack, IntPtr lpUserData);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_StopVoiceCom(IntPtr lpVoiceComHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_LoginCloud(String pszCloudSrvUrl, String pszUserName, String pszPassWord);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_LoginByDynamic(IntPtr lpUserID, ref NETDEV_CLOUD_DEV_LOGIN_S pCloudInfo, ref NETDEV_DEVICE_INFO_S pDevInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_LoginCloudDev(IntPtr lpUserID, ref NETDEV_CLOUD_DEV_LOGIN_S pCloudInfo, ref NETDEV_DEVICE_INFO_S pDevInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NETDEV_FindCloudDevList(IntPtr lpUserID);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_FindNextCloudDevInfo(IntPtr lpFindHandle, ref NETDEV_CLOUD_DEV_INFO_S pstDevInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_FindCloseCloudDevList(IntPtr lpFindHandle);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetCloudDevInfoByName(IntPtr lpUserID, String pszRegisterCode, ref NETDEV_CLOUD_DEV_INFO_S pstDevInfo);

        [DllImport(@"DLL\UnvDLL\NetDEVSDK.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern Int32 NETDEV_GetCloudDevInfoByRegCode(IntPtr lpUserID, String pszRegisterName, ref NETDEV_CLOUD_DEV_INFO_S pstDevInfo);
    }
}
