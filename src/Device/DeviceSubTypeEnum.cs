namespace EplanDevice
{
    /// Подтипы устройств.
    public enum DeviceSubType
    {
        NONE = -1, ///< Подтип не определен.

        //V
        V_DO1 = 1, ///< Клапан с одним каналом управления.
        V_DO2, ///< Клапан с двумя каналами управления.
        V_DO1_DI1_FB_OFF, ///< Клапан с одним каналом управления и одной обратной связью (выключенное состояние).
        V_DO1_DI1_FB_ON, ///< Клапан с одним каналом управления и одной обратной связью (включенное состояние).
        V_DO1_DI2, ///< Клапан с одним каналом управления и двумя обратными связями.
        V_DO2_DI2, ///< Клапан с двумя каналами управления и двумя обратными связями.
        V_MIXPROOF, ///< Клапан микспруф.
        V_AS_MIXPROOF, ///< Клапан с двумя каналами управления и двумя обратными связями с AS интерфейсом (микспруф).
        V_BOTTOM_MIXPROOF, ///< Клапан с промывкой и двумя обратными связями (донный).
        V_AS_DO1_DI2, ///< Клапан с одним каналом управления и двумя обратными связями с AS интерфейсом.
        V_DO2_DI2_BISTABLE, ///< Клапан с двумя каналами управления и двумя обратными связями бистабильный.
        V_IOLINK_VTUG_DO1, ///< IO-Link VTUG клапан с одним каналом управления.
        V_IOLINK_VTUG_DO1_FB_OFF, ///< IO-Link VTUG клапан с одним каналом управления и одной обратной связью (выключенное состояние).
        V_IOLINK_VTUG_DO1_FB_ON, ///< IO-Link VTUG клапан с одним каналом управления и одной обратной связью (включенное состояние).
        V_IOLINK_MIXPROOF, ///< Клапан микспруф с IO-Link.
        V_IOLINK_DO1_DI2, ///< Клапан с одним каналом управления и двумя обратными связями с IO-Link интерфейсом.
        V_IOLINK_VTUG_DO1_DI2, ///< IO-Link VTUG клапан с одним каналом управления и двумя обратными связями (включенное и выключенное состояния).
        V_VIRT, ///< Виртуальный клапан (без привязки к модулям).
        V_MINI_FLUSHING, ///< Клапан с мини-клапаном промывки.
        V_IOL_TERMINAL_MIXPROOF_DO3, ///< Противосмешивающий клапан с управление от пневмоострова IO-Link

        //LS
        LS_MIN = 1, ///< Подключение по схеме минимум.
        LS_MAX, ///< Подключение по схеме максимум.
        LS_IOLINK_MIN, ///< IO-Link уровень. Подключение по схеме минимум.
        LS_IOLINK_MAX, ///< IO-Link уровень. Подключение по схеме максимум.
        LS_VIRT, ///< Виртуальный датчик уровня (без привязки к модулям).

        //M,
        M = 1, ///< Мотор без управления частотой вращения.
        M_FREQ, ///< Мотор с управлением частотой вращения.
        M_REV, ///< Мотор с реверсом без управления частотой вращения. Реверс включается совместно.
        M_REV_FREQ, ///< Мотор с реверсом с управлением частотой вращения. Реверс включается совместно.
        M_REV_2, ///< Мотор с реверсом без управления частотой вращения. Реверс включается отдельно.
        M_REV_FREQ_2, ///< Мотор с реверсом с управлением частотой вращения. Реверс включается отдельно.
        M_REV_2_ERROR, ///< Мотор с реверсом. Реверс включается отдельно. Отдельный сигнал аварии.
        M_REV_FREQ_2_ERROR, ///< Мотор с реверсом с управлением частотой вращения. Реверс включается отдельно. Отдельный сигнал аварии.
        M_ATV, ///< Мотор управляемый частотником Altivar. Связь с частотником по Ethernet. Реверс и аварии опционально.
        M_VIRT, ///< Виртуальный мотор (без привязки к модулям).
        M_ATV_LINEAR,///<< Аналогично M_ATV, только есть параметры для расчета линейной скорости.

        //FQT
        FQT = 1, ///< Счетчик.
        FQT_F, ///< Счетчик с расходом.
        FQT_F_OK_LEGACY_DELETED, ///< Удаленный подтип
        FQT_VIRT, ///< Виртуальный счётчик (без привязки к модулям).
        FQT_IOLINK, ///< Счетчик IO-Link

        //QT
        QT = 1, ///< Концентратомер.
        QT_OK, ///< Концентратомер c диагностикой.
        QT_IOLINK, ///< IO-Link концентратомер.
        QT_VIRT, ///< Виртуальный концентратомер (без привязки к модулям).

        //DO
        DO = 1, ///< Дискретный выход с привязкой к модулям.
        DO_VIRT, ///< Виртуальный дискретный выход(без привязки к модулям).

        //DI
        DI = 1, ///< Дискретный вход с привязкой к модулям.
        DI_VIRT, ///< Виртуальный дискретный вход (без привязки к модулям).

        //AO
        AO = 1, ///< Аналоговый выход с привязкой к модулям ввода-вывода.
        AO_VIRT, ///< Виртуальный аналоговый выход (без привязки к модулям).

        //AI
        AI = 1, ///< Аналоговый вход с привязкой к модулям ввода-вывода.
        AI_VIRT, ///< Виртуальный аналоговый вход (без привязки к модулям).

        //LT
        LT = 1, ///< Текущий уровень без дополнительных параметров.
        LT_CYL, ///< Текущий уровень для цилиндрического танка.
        LT_CONE, ///< Текущий уровень для танка с конусом.
        LT_TRUNC, ///< Текущий уровень для танка с усеченным цилиндром.
        LT_IOLINK, ///< IO-Link текущий уровень без дополнительных параметров.
        LT_VIRT, ///< Виртуальный текущий уровень (без привязки к модулям).

        //Y
        Y = 1, ///< Обычный пневмоостров Festo.
        DEV_VTUG_8, ///< Festo 16 каналов.
        DEV_VTUG_16, ///< Festo 32 канала.
        DEV_VTUG_24, ///< Festo 48 каналов.

        //TE
        TE = 1, ///< Текущая температура.
        TE_IOLINK, ///< IO-Link текущая температура.
        TE_VIRT, ///< Виртуальный датчик температуры (без привязки к модулям).
        TE_ANALOG, ///< Аналоговый датчик температуры 4-20 мА.

        //PT
        PT = 1, ///< Датчик давления.
        PT_IOLINK, ///< IO-Link датчик давления.
        PT_VIRT, ///< Виртуальный датчик давления (без привязки к модулям).

        //F
        F = 1, ///< IO-Link автоматический выключатель.
        F_VIRT, ///< Виртуальный автоматический выключатель (без привязки к модулям).

        //VC
        VC = 1, ///< Аналоговый клапан.
        VC_IOLINK, ///< IO-Link аналоговый клапан.
        VC_VIRT, ///< Виртуальный аналоговый клапан (без привязки к модулям).

        //HLA
        HLA = 1, ///< Сигнальная колонна (красный, желтый, зеленый и сирена).
        HLA_VIRT, ///< Виртуальная сигнальная колонна (без привязки к модулям).
        HLA_IOLINK, ///< Сигнальная колонна IO-Link (настраиваемая)

        //G
        /// <summary> Phoenix Contact 4 канала.
        G_IOL_4 = 1,
        /// <summary>  Phoenix Contact 8 каналов.
        G_IOL_8, 

        //GS
        /// <summary> Датчик положения. </summary>
        GS = 1,
        /// <summary> Виртуальный датчик положения (без привязки к модулям). </summary>
        GS_VIRT, 
        /// <summary> Датчик положения инверсный (0 - активное значение). </summary>
        GS_INVERSE,

        //HA
        HA = 1, ///< Сирена.
        HA_VIRT, ///< Виртуальная сирена (без привязки к модулям).

        //HL
        HL = 1, ///< Лампа.
        HL_VIRT, ///< Виртуальная лампа (без привязки к модулям).

        //FS
        FS = 1, ///< Датчик наличия расхода.
        FS_VIRT, ///< Виртуальный датчик наличия расхода (без привязки к модулям).

        //SB
        SB = 1, ///< Кнопка.
        SB_VIRT, ///< Виртуальная кнопка (без привязки к модулям).

        //WT
        WT = 1, ///< Весы.
        WT_VIRT, ///< Виртуальные весы.
        WT_RS232, ///< Весы с интерфейсом RS-232
        WT_ETH, ///< Весы с ethernet
        WT_PXC_AXL, ///< Весы Axioline F (для модулей Phoenix Contact)

        ///CAM
        CAM_DO1_DI2 = 1, ///< Камера с готовностью, результатом обработки и сигналом активации.
        CAM_DO1_DI1, ///< Камера с результатом обработки, сигналом активации.
        CAM_DO1_DI3, ///< Камера с готосностью, 2-мя результатами обработки и сигналом активации.
    
        ///PDS
        PDS = 1, ///< Сигнальный датчик разницы давления
        PDS_VIRT, ///< Виртуальный сигнальный датчик разницы давления

        ///TS
        TS = 1, ///< Сигнальный датчик температуры
        TS_VIRT, ///< Виртуальный сигнальный датчик температуры

        //C
        C_PID = 1, ///< Пид-регулятор
        C_THLD, ///< Пороговый регулятор
    };
}
