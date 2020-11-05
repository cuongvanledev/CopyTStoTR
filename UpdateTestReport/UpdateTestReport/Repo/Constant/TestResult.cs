using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateTestReport.Repo.Constant
{
    class TestResult
    {
        public readonly Dictionary<string, Dictionary<string, string>> TestRe = new Dictionary<string, Dictionary<string, string>>()
        {
            { "can", new Dictionary<string, string>() {
                { "RH850_X2x_CAN_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257409" },
                { "RH850_X2x_CAN_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257410" },
                { "RH850_X2x_CAN_TUT_TR_Common_Util_U2A8_Beta.xlsm", "D-RHA-257414" },
                { "RH850_X2x_CAN_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257418" },
                { "RH850_X2x_CAN_TUT_TR_E2x_Generation_U2A8_Beta.xlsx", "D-RHA-257419" },
                { "RH850_X2x_CAN_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257420" },
                { "RH850_X2x_CAN_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257421" },
                { "RH850_X2x_CAN_TUT_TR_U2x_Generation_U2A8_Beta.xlsx", "D-RHA-257422" },
                { "RH850_X2x_CAN_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257423" },
                { "RH850_X2x_CAN_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257425" }
            } },
            { "dio", new Dictionary<string, string>() {
                { "RH850_X2x_DIO_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257445" },
                { "RH850_X2x_DIO_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257456" },
                { "RH850_X2x_DIO_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257446" },
                { "RH850_X2x_DIO_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257448" },
                { "RH850_X2x_DIO_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257450" },
                { "RH850_X2x_DIO_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257451" },
                { "RH850_X2x_DIO_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257452" },
                { "RH850_X2x_DIO_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257453" },
                { "RH850_X2x_DIO_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257454" },
                { "RH850_X2x_DIO_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257455" }
            } },
            { "eth", new Dictionary<string, string>() {
                { "RH850_X2x_ETH_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257026" },
                { "RH850_X2x_ETH_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257028" },
                { "RH850_X2x_ETH_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257027" },
                { "RH850_X2x_ETH_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257029" },
                { "RH850_X2x_ETH_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257030" },
                { "RH850_X2x_ETH_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257031" },
                { "RH850_X2x_ETH_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257032" },
                { "RH850_X2x_ETH_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257033" },
                { "RH850_X2x_ETH_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257034" },
                { "RH850_X2x_ETH_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257036" }
              } },
            { "fls", new Dictionary<string, string>() {
                 { "RH850_X2x_FLS_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257060" },
                 { "RH850_X2x_FLS_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257061" },
                 { "RH850_X2x_FLS_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257058" },
                 { "RH850_X2x_FLS_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257059" },
                 { "RH850_X2x_FLS_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257062" },
                 { "RH850_X2x_FLS_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257065" },
                 { "RH850_X2x_FLS_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257064" },
                 { "RH850_X2x_FLS_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257063" },
                 { "RH850_X2x_FLS_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257066" },
                 { "RH850_X2x_FLS_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257067" }
               } },
            { "fr", new Dictionary<string, string>() {
                  { "RH850_X2x_FR_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257090" },
                  { "RH850_X2x_FR_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257093" },
                  { "RH850_X2x_FR_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257092" },
                  { "RH850_X2x_FR_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257098" },
                  { "RH850_X2x_FR_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257094" },
                  { "RH850_X2x_FR_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257096" },
                  { "RH850_X2x_FR_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257097" },
                  { "RH850_X2x_FR_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257099" },
                  { "RH850_X2x_FR_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257100" },
                  { "RH850_X2x_FR_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257101" }
                } },
            { "generic", new Dictionary<string, string>() {
                  { "RH850_X2x_Generic_TUT_TR_Business_U2A8_Beta.xlsm", "D-RHA-257116" },
                  { "RH850_X2x_Generic_TUT_TR_CrossCutting_U2A8_Beta.xlsm", "D-RHA-257113" },
                  { "RH850_X2x_Generic_TUT_TR_Data_U2A8_Beta.xlsm", "D-RHA-257115" }
                } },
            { "gpt", new Dictionary<string, string>() {
                  { "RH850_X2x_Generic_TUT_TR_Presentation_U2A8_Beta.xlsm", "D-RHA-257114" },
                  { "RH850_X2x_GPT_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257138" },
                  { "RH850_X2x_GPT_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257146" },
                  { "RH850_X2x_GPT_TUT_TR_Common_Util_U2A8_Beta.xlsm", "D-RHA-257143" },
                  { "RH850_X2x_GPT_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257145" },
                  { "RH850_X2x_GPT_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257148" },
                  { "RH850_X2x_GPT_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257149" },
                  { "RH850_X2x_GPT_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257150" },
                  { "RH850_X2x_GPT_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257151" },
                  { "RH850_X2x_GPT_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257154" },
                  { "RH850_X2x_GPT_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257155" }
                } },
            { "icu", new Dictionary<string, string>() {
                  { "RH850_X2x_ICU_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257171" },
                  { "RH850_X2x_ICU_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257174"},
                  { "RH850_X2x_ICU_TUT_TR_Common_Utilities_U2A8_Beta.xlsm", "D-RHA-257172"},
                  { "RH850_X2x_ICU_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257173" },
                  { "RH850_X2x_ICU_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257175" },
                  { "RH850_X2x_ICU_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257181" },
                  { "RH850_X2x_ICU_TUT_TR_E2x_Utilities_U2A8_Beta.xlsm", "D-RHA-257176" },
                  { "RH850_X2x_ICU_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257178" },
                  { "RH850_X2x_ICU_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257177" },
                  { "RH850_X2x_ICU_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257180" },
                  { "RH850_X2x_ICU_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257179" }
                } },
            { "lin", new Dictionary<string, string>() {
                  {"RH850_X2x_LIN_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257204" },
                  {"RH850_X2x_LIN_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257205" },
                  {"RH850_X2x_LIN_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257206" },
                  {"RH850_X2x_LIN_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257207" },
                  {"RH850_X2x_LIN_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257213" },
                  {"RH850_X2x_LIN_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257208" },
                  {"RH850_X2x_LIN_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257209" },
                  {"RH850_X2x_LIN_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257210" },
                  {"RH850_X2x_LIN_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257211" },
                  { "RH850_X2x_LIN_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257212" }
                } },
            { "mcu", new Dictionary<string, string>() {
                  { "RH850_X2x_MCU_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257239" },
                  { "RH850_X2x_MCU_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257241" },
                  { "RH850_X2x_MCU_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257240" },
                  { "RH850_X2x_MCU_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257244" },
                  { "RH850_X2x_MCU_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257243" },
                  { "RH850_X2x_MCU_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257245" },
                  { "RH850_X2x_MCU_TUT_TR_E2x_Utils_U2A8_Beta.xlsm", "D-RHA-257246" },
                  { "RH850_X2x_MCU_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257249" },
                  { "RH850_X2x_MCU_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257247" },
                  { "RH850_X2x_MCU_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257250" },
                  { "RH850_X2x_MCU_TUT_TR_U2x_Utils_U2A8_Beta.xlsm", "D-RHA-257248" },
                  { "RH850_X2x_MCU_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257251" }
                } },
            { "port", new Dictionary<string, string>() {
                  {"RH850_X2x_PORT_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257271" },
                  {"RH850_X2x_PORT_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257273" },
                  {"RH850_X2x_PORT_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257272" },
                  {"RH850_X2x_PORT_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257274" },
                  {"RH850_X2x_PORT_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257275" },
                  {"RH850_X2x_PORT_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257276" },
                  {"RH850_X2x_PORT_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257277" },
                  {"RH850_X2x_PORT_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257279" },
                  { "RH850_X2x_PORT_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257278" }
                } },
            { "pwm", new Dictionary<string, string>() {
                 {"RH850_X2x_PWM_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257304" },
                 {"RH850_X2x_PWM_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257306" },
                 {"RH850_X2x_PWM_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257305" },
                 {"RH850_X2x_PWM_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257307" },
                 {"RH850_X2x_PWM_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257309" },
                 {"RH850_X2x_PWM_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257311" },
                 {"RH850_X2x_PWM_TUT_TR_E2x_Utils_U2A8_Beta.xlsm", "D-RHA-257310" },
                 {"RH850_X2x_PWM_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257313" },
                 {"RH850_X2x_PWM_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257314" },
                 {"RH850_X2x_PWM_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257317" },
                 {"RH850_X2x_PWM_TUT_TR_U2x_Utils_U2A8_Beta.xlsm", "D-RHA-257315" },
                    { "RH850_X2x_PWM_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257316" }
                } },
            { "spi", new Dictionary<string, string>() {
                  {"RH850_X2x_SPI_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257338" },
                  {"RH850_X2x_SPI_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257344" },
                  {"RH850_X2x_SPI_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257339" },
                  {"RH850_X2x_SPI_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257340" },
                  {"RH850_X2x_SPI_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257341" },
                  {"RH850_X2x_SPI_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257343" },
                  {"RH850_X2x_SPI_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257342" },
                  {"RH850_X2x_SPI_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257345" },
                  {"RH850_X2x_SPI_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257347" },
                    { "RH850_X2x_SPI_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257346" }
                } },
            { "wdg", new Dictionary<string, string>() {
                  {"RH850_X2x_WDG_TUT_TR_Common_Generation_U2A8_Beta.xlsm", "D-RHA-257373" },
                  {"RH850_X2x_WDG_TUT_TR_Common_Intermediate_U2A8_Beta.xlsm", "D-RHA-257374" },
                  {"RH850_X2x_WDG_TUT_TR_Common_Utils_U2A8_Beta.xlsm", "D-RHA-257372" },
                  {"RH850_X2x_WDG_TUT_TR_Common_Validation_U2A8_Beta.xlsm", "D-RHA-257375" },
                  {"RH850_X2x_WDG_TUT_TR_E2x_Generation_U2A8_Beta.xlsm", "D-RHA-257376" },
                  {"RH850_X2x_WDG_TUT_TR_E2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257379" },
                  {"RH850_X2x_WDG_TUT_TR_E2x_Utils_U2A8_Beta.xlsm", "D-RHA-257378" },
                  {"RH850_X2x_WDG_TUT_TR_E2x_Validation_U2A8_Beta.xlsm", "D-RHA-257377" },
                  {"RH850_X2x_WDG_TUT_TR_U2x_Generation_U2A8_Beta.xlsm", "D-RHA-257380" },
                  {"RH850_X2x_WDG_TUT_TR_U2x_Intermediate_U2A8_Beta.xlsm", "D-RHA-257381" },
                  {"RH850_X2x_WDG_TUT_TR_U2x_Utils_U2A8_Beta.xlsm", "D-RHA-257382" },
                  { "RH850_X2x_WDG_TUT_TR_U2x_Validation_U2A8_Beta.xlsm", "D-RHA-257383" }
                } }
        };

        public readonly string DocumentNameStart = "RH850/X2x MCAL ";
        public readonly string DocumentNameEnd = " Unit Test Report for Generation Tool";
    }
}
