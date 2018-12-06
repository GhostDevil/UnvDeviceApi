using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnvDeviceApi.NETSDKHelper;

namespace UnvDeviceApi
{
    public class UnvPublicOperate
    {
        /// <summary>
        /// 初始化SDK
        /// </summary>
        /// <returns>TRUE：成功 FALSE：失败</returns>
        public static bool InitSDK()
        {
            int iRet = NETDEVSDK.NETDEV_Init();
            if (NETDEVSDK.TRUE != iRet)
                return false;
            return true;
        }
        /// <summary>
        /// 清理SDK
        /// </summary>
        /// <returns>TRUE：成功 FALSE：失败</returns>
        public static bool CleanupSDK()
        {
            int iRet = NETDEVSDK.NETDEV_Cleanup();
            if (NETDEVSDK.TRUE != iRet)
                return false;
            return true;
        }
        /// <summary>
        /// 设备登录
        /// </summary>
        /// <param name="deviceIp">设备ip</param>
        /// <param name="user">用户</param>
        /// <param name="pwd">密码</param>
        /// <param name="port">端口号</param>
        /// <param name="lpDevHandle">用户标识</param>
        /// <returns>TRUE：成功 FALSE：失败</returns>
        public static bool Login(string deviceIp, string user, string pwd,out IntPtr lpDevHandle, int port=80)
        {
            bool b = false;
            //then login
            lpDevHandle = IntPtr.Zero;
            IntPtr pstDevInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(NETDEV_DEVICE_INFO_S)));
            lpDevHandle = NETDEVSDK.NETDEV_Login(deviceIp, (Int16)port, user, pwd, pstDevInfo);
            if (lpDevHandle == IntPtr.Zero)
            {
                b = false;
            }
            else
            {
                b = true;
            }

            Marshal.FreeHGlobal(pstDevInfo);
            return b;
        }
        /// <summary>
        /// 设备登出
        /// </summary>
        /// <param name="lpDevHandle">用户标识</param>
        /// <returns>TRUE：成功 FALSE：失败</returns>
        public static bool LoginOut(IntPtr lpDevHandle)
        {
            int iRet = NETDEVSDK.NETDEV_Logout(lpDevHandle);
            if (NETDEVSDK.TRUE != iRet)
                return true;
            return false;
        }

        #region 巡航控制
        /// <summary>
        /// 巡航设置
        /// </summary>
        /// <param name="lpDevHandle">用户标识</param>
        /// <param name="channelId">通道</param>
        /// <param name="cmd">巡航命令</param>
        /// <param name="info">巡航信息</param>
        /// <returns>TRUE：成功 FALSE：失败</returns>
        public static bool PTZCruise(IntPtr lpDevHandle,int channelId, NETDEV_PTZ_CRUISECMD_E cmd,NETDEV_CRUISE_INFO_S info)
        {
            if (IntPtr.Zero == lpDevHandle) return false;
            switch (cmd)
            {
                case NETDEV_PTZ_CRUISECMD_E.NETDEV_PTZ_ADD_CRUISE:
                case NETDEV_PTZ_CRUISECMD_E.NETDEV_PTZ_MODIFY_CRUISE:
                    if (null != info.astCruisePoint)
                    {
                        NETDEV_CRUISE_POINT_S[] astCruisePoint = new NETDEV_CRUISE_POINT_S[32];
                        for (int i = 0; i < info.astCruisePoint.Length; i++)
                        {
                            astCruisePoint[i] = info.astCruisePoint[i];
                        }
                        info.astCruisePoint = astCruisePoint;
                    }
                    break;
                case NETDEV_PTZ_CRUISECMD_E.NETDEV_PTZ_RUN_CRUISE:
                case NETDEV_PTZ_CRUISECMD_E.NETDEV_PTZ_STOP_CRUISE:
                case NETDEV_PTZ_CRUISECMD_E.NETDEV_PTZ_DEL_CRUISE:
                    info.astCruisePoint = null;
                    info.szCuriseName = "";
                    info.dwSize = 0;
                    break;
                default:
                    return false;
            }
            int bRet = NETDEVSDK.NETDEV_PTZCruise_Other(lpDevHandle, channelId, (int)cmd, ref info);
            return NETDEVSDK.TRUE == bRet ? true : false;
        }

        #endregion
    }
}
