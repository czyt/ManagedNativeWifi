using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static ManagedNativeWifi.Win32.NativeMethod;

namespace ManagedNativeWifi
{
    /// <summary>
    /// PHY and media type
    /// </summary>
    /// <remarks>
    /// Equivalent to DOT11_PHY_TYPE:
    /// https://docs.microsoft.com/en-us/windows/win32/nativewifi/dot11-phy-type
    /// https://docs.microsoft.com/en-us/windows-hardware/drivers/ddi/windot11/ne-windot11-_dot11_phy_type
    /// </remarks>
    public enum PhyType
    {
        /// <summary>
        /// Unknown or uninitialized PHY
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Unknown or uninitialized PHY
        /// </summary>
        Any,

        /// <summary>
        /// Frequency-hopping spread spectrum (FHSS) PHY
        /// </summary>
        Fhss,

        /// <summary>
        /// Direct-sequence spread spectrum (DSSS) PHY
        /// </summary>
        Dsss,

        /// <summary>
        /// Infrared (IR) baseband PHY
        /// </summary>
        IrBaseband,

        /// <summary>
        /// Orthogonal frequency division multiplexing (OFDM) 802.11a PHY
        /// </summary>
        Ofdm,

        /// <summary>
        /// High-rate DSSS (HRDSSS) 802.11b PHY
        /// </summary>
        HrDsss,

        /// <summary>
        /// Extended-rate (ERP) 802.11g PHY
        /// </summary>
        Erp,

        /// <summary>
        /// High-throughput (HT) 802.11n PHY
        /// Each 802.11n PHY, whether dual-band or not, is specified as this PHY type.
        /// </summary>
        Ht,

        /// <summary>
        /// Very high-throughput (VHT) 802.11ac PHY
        /// </summary>
        Vht,

        /// <summary>
        /// Directional Multi-Gigabit (DMG) 802.11ad PHY
        /// </summary>
        Dmg,

        /// <summary>
        /// High Efficiency (HE) 802.11ax PHY
        /// </summary>
        He,

        /// <summary>
        /// Extremely high-throughput (EHT) 802.11be PHY
        /// </summary>
        Eht,

        /// <summary>
        /// The start of the range that is used to define proprietary PHY types that are developed by
        /// an independent hardware vendor (IHV)
        /// </summary>
        IhvStart,

        /// <summary>
        /// The end of the range that is used to define proprietary PHY types that are developed by
        /// an IHV
        /// </summary>
        IhvEnd
    }

    internal static class PhyTypeConverter
    {
        public static PhyType Convert(DOT11_PHY_TYPE source)
        {
            switch (source)
            {

                case DOT11_PHY_TYPE.dot11_phy_type_any:
                    return PhyType.Any;
                case DOT11_PHY_TYPE.dot11_phy_type_fhss:
                    return PhyType.Fhss;
                case DOT11_PHY_TYPE.dot11_phy_type_dsss:
                    return PhyType.Dsss;
                case DOT11_PHY_TYPE.dot11_phy_type_irbaseband:
                    return PhyType.IrBaseband;
                case DOT11_PHY_TYPE.dot11_phy_type_ofdm:
                    return PhyType.Ofdm;
                case DOT11_PHY_TYPE.dot11_phy_type_hrdsss:
                    return PhyType.HrDsss;
                case DOT11_PHY_TYPE.dot11_phy_type_erp:
                    return PhyType.Erp;
                case DOT11_PHY_TYPE.dot11_phy_type_ht:
                    return PhyType.Ht;
                case DOT11_PHY_TYPE.dot11_phy_type_vht:
                    return PhyType.Vht;
                case DOT11_PHY_TYPE.dot11_phy_type_dmg:
                    return PhyType.Dmg;
                case DOT11_PHY_TYPE.dot11_phy_type_he:
                    return PhyType.He;
                case DOT11_PHY_TYPE.dot11_phy_type_eht:
                    return PhyType.Eht;
                case DOT11_PHY_TYPE.dot11_phy_type_IHV_start:
                    return PhyType.IhvStart;
                case DOT11_PHY_TYPE.dot11_phy_type_IHV_end:
                    return PhyType.IhvEnd;
                default:
                    return PhyType.Unknown;
            }

        }

        public static DOT11_PHY_TYPE ConvertBack(PhyType source)
        {
            switch (source)
            {

                case PhyType.Any:
                    return DOT11_PHY_TYPE.dot11_phy_type_any;
                case PhyType.Fhss:
                    return DOT11_PHY_TYPE.dot11_phy_type_fhss;
                case PhyType.Dsss:
                    return DOT11_PHY_TYPE.dot11_phy_type_dsss;
                case PhyType.IrBaseband:
                    return DOT11_PHY_TYPE.dot11_phy_type_irbaseband;
                case PhyType.Ofdm:
                    return DOT11_PHY_TYPE.dot11_phy_type_ofdm;
                case PhyType.HrDsss:
                    return DOT11_PHY_TYPE.dot11_phy_type_hrdsss;
                case PhyType.Erp:
                    return DOT11_PHY_TYPE.dot11_phy_type_erp;
                case PhyType.Ht:
                    return DOT11_PHY_TYPE.dot11_phy_type_ht;
                case PhyType.Vht:
                    return DOT11_PHY_TYPE.dot11_phy_type_vht;
                case PhyType.Dmg:
                    return DOT11_PHY_TYPE.dot11_phy_type_dmg;
                case PhyType.He:
                    return DOT11_PHY_TYPE.dot11_phy_type_he;
                case PhyType.Eht:
                    return DOT11_PHY_TYPE.dot11_phy_type_eht;
                case PhyType.IhvStart:
                    return DOT11_PHY_TYPE.dot11_phy_type_IHV_start;
                case PhyType.IhvEnd:
                    return DOT11_PHY_TYPE.dot11_phy_type_IHV_end;
                default:
                    return DOT11_PHY_TYPE.dot11_phy_type_unknown;
            }
        }
    }

    /// <summary>
    /// PHY and media type extension methods
    /// </summary>
    public static class PhyTypeExtension
    {
        /// <summary>
        /// Converts the value of this instance to its equivalent protocol name.
        /// </summary>
        /// <param name="phyType">PhyType</param>
        /// <returns>Protocol name</returns>
        public static string ToProtocolName(this PhyType phyType)
        {
            switch (phyType)
            {


                case PhyType.Ofdm:
                    return "a";
                case PhyType.HrDsss:
                    return "b";
                case PhyType.Erp:
                    return "g";
                case PhyType.Ht:
                    return "n";
                case PhyType.Vht:
                    return "ac";
                case PhyType.Dmg:
                    return "ad";
                case PhyType.He:
                    return "ax";
                case PhyType.Eht:
                    return "be";

                default:
                    return null;
            }
        }
    }
}