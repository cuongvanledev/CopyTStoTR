using System;
using System.Collections.Generic;

namespace UpdateTestReport.Repo.Constant
{
    class TestPlan
    {
        public readonly Dictionary<string, List<string>> TestSpec = new Dictionary<string, List<string>>() {
            {"adc", new List<string>() {"RH850_X2x_ADC_TUT_TS_Common_Generation.xlsm",
                      "RH850_X2x_ADC_TUT_TS_Common_Intermediate.xlsm",
                      "RH850_X2x_ADC_TUT_TS_Common_Validation.xlsm",
                      "RH850_X2x_ADC_TUT_TS_E2x_Generation.xlsm",
                      "RH850_X2x_ADC_TUT_TS_E2x_Intermediate.xlsm",
                      "RH850_X2x_ADC_TUT_TS_E2x_Validation.xlsm",
                      "RH850_X2x_ADC_TUT_TS_U2x_Generation.xlsm",
                      "RH850_X2x_ADC_TUT_TS_U2x_Intermediate.xlsm",
                      "RH850_X2x_ADC_TUT_TS_U2x_Validation.xlsm" }
            },
            { "can", new List<string>() {
               "RH850_X2x_CAN_TUT_TS_Common_Generation.xlsm",
               "RH850_X2x_CAN_TUT_TS_Common_Intermediate.xlsm",
               "RH850_X2x_CAN_TUT_TS_Common_Util.xlsm",
               "RH850_X2x_CAN_TUT_TS_Common_Validation.xlsm",
               "RH850_X2x_CAN_TUT_TS_E2x_Generation.xlsx",
               "RH850_X2x_CAN_TUT_TS_E2x_Intermediate.xlsm",
               "RH850_X2x_CAN_TUT_TS_E2x_Validation.xlsm",
               "RH850_X2x_CAN_TUT_TS_U2x_Generation.xlsx",
               "RH850_X2x_CAN_TUT_TS_U2x_Intermediate.xlsm",
               "RH850_X2x_CAN_TUT_TS_U2x_Validation.xlsm"
            } },
            {  "dio", new List<string>() {
                "RH850_X2x_DIO_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_DIO_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_DIO_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_DIO_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_DIO_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_DIO_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_DIO_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_DIO_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_DIO_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_DIO_TUT_TS_U2x_Validation.xlsm"
            } },
            {  "eth", new List<string>() {
                "RH850_X2x_ETH_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_ETH_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_ETH_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_ETH_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_ETH_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_ETH_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_ETH_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_ETH_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_ETH_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_ETH_TUT_TS_U2x_Validation.xlsm"
            } },
            {  "fls", new List<string>() {
                "RH850_X2x_FLS_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_FLS_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_FLS_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_FLS_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_FLS_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_FLS_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_FLS_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_FLS_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_FLS_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_FLS_TUT_TS_U2x_Validation.xlsm"
            } },
            {  "fr", new List<string>() {
                "RH850_X2x_FR_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_FR_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_FR_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_FR_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_FR_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_FR_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_FR_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_FR_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_FR_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_FR_TUT_TS_U2x_Validation.xlsm"
            } },
            {  "generic", new List<string>() {
                 "RH850_X2x_Generic_TUT_TS_Business.xlsm",
                 "RH850_X2x_Generic_TUT_TS_CrossCutting.xlsm",
                 "RH850_X2x_Generic_TUT_TS_Data.xlsm"
            } },
            {  "gpt", new List<string>() {
                "RH850_X2x_Generic_TUT_TS_Presentation.xlsm",
                "RH850_X2x_GPT_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_GPT_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_GPT_TUT_TS_Common_Util.xlsm",
                "RH850_X2x_GPT_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_GPT_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_GPT_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_GPT_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_GPT_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_GPT_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_GPT_TUT_TS_U2x_Validation.xlsm"
            } },
            {  "icu", new List<string>() {
                "RH850_X2x_ICU_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_ICU_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_ICU_TUT_TS_Common_Utilities.xlsm",
                "RH850_X2x_ICU_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_ICU_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_ICU_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_ICU_TUT_TS_E2x_Utilities.xlsm",
                "RH850_X2x_ICU_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_ICU_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_ICU_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_ICU_TUT_TS_U2x_Validation.xlsm"
            } },
            { "lin", new List<string>() {
                "RH850_X2x_LIN_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_LIN_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_LIN_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_LIN_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_LIN_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_LIN_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_LIN_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_LIN_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_LIN_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_LIN_TUT_TS_U2x_Validation.xlsm"
            } },
            { "mcu", new List<string>() {
                "RH850_X2x_MCU_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_MCU_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_MCU_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_MCU_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_MCU_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_MCU_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_MCU_TUT_TS_E2x_Utils.xlsm",
                "RH850_X2x_MCU_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_MCU_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_MCU_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_MCU_TUT_TS_U2x_Utils.xlsm",
                "RH850_X2x_MCU_TUT_TS_U2x_Validation.xlsm"
            } },
            { "port", new List<string>() {
                "RH850_X2x_PORT_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_PORT_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_PORT_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_PORT_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_PORT_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_PORT_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_PORT_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_PORT_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_PORT_TUT_TS_U2x_Validation.xlsm"
            } },
            { "pwm", new List<string>() {
                "RH850_X2x_PWM_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_PWM_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_PWM_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_PWM_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_PWM_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_PWM_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_PWM_TUT_TS_E2x_Utils.xlsm",
                "RH850_X2x_PWM_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_PWM_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_PWM_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_PWM_TUT_TS_U2x_Utils.xlsm",
                "RH850_X2x_PWM_TUT_TS_U2x_Validation.xlsm"
            } },
            { "spi", new List<string>() {
                "RH850_X2x_SPI_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_SPI_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_SPI_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_SPI_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_SPI_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_SPI_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_SPI_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_SPI_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_SPI_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_SPI_TUT_TS_U2x_Validation.xlsm"
            } },
            { "wdg", new List<string>() {
                "RH850_X2x_WDG_TUT_TS_Common_Generation.xlsm",
                "RH850_X2x_WDG_TUT_TS_Common_Intermediate.xlsm",
                "RH850_X2x_WDG_TUT_TS_Common_Utils.xlsm",
                "RH850_X2x_WDG_TUT_TS_Common_Validation.xlsm",
                "RH850_X2x_WDG_TUT_TS_E2x_Generation.xlsm",
                "RH850_X2x_WDG_TUT_TS_E2x_Intermediate.xlsm",
                "RH850_X2x_WDG_TUT_TS_E2x_Utils.xlsm",
                "RH850_X2x_WDG_TUT_TS_E2x_Validation.xlsm",
                "RH850_X2x_WDG_TUT_TS_U2x_Generation.xlsm",
                "RH850_X2x_WDG_TUT_TS_U2x_Intermediate.xlsm",
                "RH850_X2x_WDG_TUT_TS_U2x_Utils.xlsm",
                "RH850_X2x_WDG_TUT_TS_U2x_Validation.xlsm"
            } }
        };
    }
}
