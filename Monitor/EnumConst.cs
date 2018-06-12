namespace Monitor
{
    /// <summary>
    /// 门限取值
    /// </summary>
    public class PreThreshold
    {
        public const int SupportTime = -1;    //支撑时间无法计算是默认值

        public const double BatterySupportTimeWarning = 0.5;    //蓄电池支撑时间预警值 30分钟
        public const double BatterySupportTimeAlarm = 0.25;    //蓄电池支撑时间告警值 15分钟
        public const double GeneratorSupportTimeWarning = 1;    //发电机支撑时间预警值 60分钟
        public const double GeneratorSupportTimeAlarm = 0.5;    //发电机支撑时间告警值 30分钟
        public const double WithLoadWarning = 0.4;    //带载冗余量预警值 40%
        public const double WithLoadAlarm = 0.2;    //带载冗余量告警值 20%
        public const double UPSFilterWarning = 0.4;    //UPS滤波预警值 40%
        public const double UPSFilterAlarm = 0.2;    //UPS滤波告警值 20%
        public const double HealthWarning = 0.4;    //健康状态预警值 40%
        public const double HealthAlarm = 0.2;    //健康状态告警值 20%
        public const double ResistanceWarning = 0.6;    //接地电阻预警值
        public const double ResistanceAlarm = 0.8;    //接地电阻告警值
        public const double PowerCutWarning = 2;    //市电停电预警值 2h
        public const double PowerCutAlarm = 0.5;    //市电停电告警值 30分钟
    }

    /// <summary>
    /// 值勤大表周期
    /// </summary>
    public enum MaintenanceCycleEnum
    {
        天 = 0,
        周 = 1,
        月 = 2,
        季度 = 3,
        半年 = 4,
        年 = 5
    }

    /// <summary>
    /// 值勤任务状态
    /// </summary>
    public enum MaintenanceTaskStatusEnum
    {
        待办 = 0,
        已办 = 1,
        超时 = 2
    }

    /// <summary>
    /// 设备类型枚举
    /// </summary>
    public enum EquipmentTypeEnum
    {
        设备列表 = -1,
        ATS = 0,
        交流配电柜 = 1,
        直流配电柜 = 2,
        交流列头柜 = 3,
        直流列头柜 = 4,
        UPS蓄电池组 = 5,
        开关电源蓄电池组 = 6,
        发电机组 = 7,
        开关电源 = 8,
        高频开关 = 9,
        主输出断路器 = 10,
        逆变电源 = 11,
        AS03 = 12,
        AS05 = 13,
        UPS设备 = 14,
        其它 = 15,
        接地电阻 = 16
    }

    /// <summary>
    /// 预警状态枚举
    /// </summary>
    public enum EWarnStatusEnum
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 1,

        /// <summary>
        /// 预警
        /// </summary>
        Warning = 2,

        /// <summary>
        /// 告警
        /// </summary>
        Alarm
    }

    /// <summary>
    /// 评分等级
    /// </summary>
    public enum GradeEnum
    {
        优 = 0,
        良 = 1,
        中 = 2,
        差 = 3
    }

    /// <summary>
    /// 预警类型
    /// </summary>
    public enum EWarnTypeEnum
    {
        市电停电 = 0,
        支撑时间 = 1,
        接地电阻 = 2,
        主开关温度 = 3,
        带载冗余量 = 4,
        健康状态 = 5,
        滤波寿命 = 6
    }

    public enum EqSignalTypeEnum
    {
        剩余容量 = 0,    //蓄电池容量or发电机油量
        负载电流 = 1,
        采集时间 = 2,    //UPS采集时间
        运行状态 = 3,
        接地电阻 = 4,
        环境温度 = 5
    }

    /// <summary>
    /// 紧急程度
    /// </summary>
    public enum EmergencyLevelEnum
    {
        紧急 = 0,
        重要 = 1,
        一般 = 2
    }

    public enum EngineScoreItem
    {
    	支撑时间 = 1,
    	健康状态 =2,
    	供电质量 = 3,
    	设备容量富裕量 = 4,
        值勤维护 = 12
    }
}