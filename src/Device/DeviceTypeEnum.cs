namespace EplanDevice
{
    /// Типы устройств.
    public enum DeviceType
    {
        NONE = -1, ///< Тип не определен.

        V = 0, ///< Клапан. 
        VC, ///< Управляемый клапан. 
        M, ///< Двигатель.
        LS, ///< Уровень (есть/нет).
        TE, ///< Температура.        
        FS, ///< Расход (есть/нет).
        GS, ///< Датчик положения. 
        FQT, ///< Счетчик.        
        LT, ///< Уровень (значение).        
        QT, ///< Концентрация.
        HA, ///< Звуковая сигнализация.
        HL, ///< Световая сигнализация.
        SB, ///< Кнопка.
        DI, ///< Дискретный входной сигнал.
        DO, ///< Дискретный выходной сигнал.
        AI, ///< Аналоговый входной сигнал.
        AO, ///< Аналоговый выходной сигнал.
        WT, ///< Датчик веса.
        PT, ///< Датчик давления.
        F, ///< Автоматический выключатель.
        C, ///< ПИД-регулятор
        HLA, ///< Сигнальная колонна.
        CAM, ///< Камера.
        PDS, ///< Сигнальный датчик перепада давления
        TS, ///< Сигнальный датчик температуры
        G, ///< Блок питания с автоматическим выключателем.

        // Эти устройства всегда в конце т.к их нет в контроллере.
        Y,       ///< Пневмоостров Festo
        DEV_VTUG,///< Пневмоостров Festo (совместимость со старыми проектами).
    };
}
