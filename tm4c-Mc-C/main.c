#include <stdint.h>
#include <stdio.h>
#include <stdbool.h>
#include "inc/hw_types.h"
#include "inc/hw_memmap.h"
#include "inc/hw_ints.h"
#include "driverlib/sysctl.h"
#include "driverlib/gpio.h"
#include "inc/hw_gpio.h"
#include "driverlib/sysctl.c"
#include "driverlib/timer.h"
#include "driverlib/timer.c"
#include "driverlib/interrupt.h"
#include "driverlib/adc.h"
#include "driverlib/adc.c"
#include "inc/tm4c123gh6pm.h"
#include "math.h"
#include "lcd.h"
#include "driverlib/pin_map.h"
#include "driverlib/uart.h"
 unsigned char saat[2]={0x30,0x30};
 unsigned char   dk[2]={0x30,0x30};
 unsigned char   sn[2]={0x30,0x30};
 unsigned char satirr=1;
 int bin;
int on;
int bir;
int yuz;
 char asd='a';
 int timerac=0;
 int i;
 int tek=0;
 int hex1;
 int dongu=0;
 int vol[];
 uint32_t ortalama ;
 uint32_t gelendata[4];
 extern unsigned char satirsayisi;
 void SetInitSettings();
int main(void)
{

    SYSCTL_RCGCGPIO_R|=0x20; // portf saat aktif

          GPIO_PORTF_LOCK_R = 0x4C4F434B; // commit aç
          GPIO_PORTF_CR_R = 0x01;   // pf0 da artýk konfigurasyn yapýlabilir. 0000 0001
                                    // 0000 0001 -> pf0 artýk konfigure edilebilir

          GPIO_PORTF_DIR_R |=0x0E; // 0b 0000 1110 yönlendirme
          GPIO_PORTF_DEN_R |=0x1F; // 0b 0001 1111 pin aktifliði

          GPIO_PORTF_PUR_R = 0x11; // pf0 he pf4 pull-up aktif 0001 0001

          SYSCTL_RCGCTIMER_R |=0x01; //(1<<0)


          TIMER0_CTL_R &=0xFE; // 1

          TIMER0_CFG_R=0x00;

          TIMER0_TAMR_R |=0x02; // 0000 0010 |(1<<1)  PERÝODÝK

          TIMER0_TAMR_R &=0xEF;// 1110 1111   ~(1<<4) COUNT DOWN


          TIMER0_TAILR_R= 0x02DC6C00; // 16000000 1 sn istedim // ilk deger

           // zamanlayýcý baþladý


    int sifirlama=0;










    SetInitSettings();
    lcdilkayarlar();

    while(1){




        unsigned char gelenveri;
                if(UARTCharsAvail(UART0_BASE)){
                    gelenveri=UARTCharGet(UART0_BASE);
                    dongu++;
                    if(dongu==1){
                        saat[1]=ceviri(gelenveri);
                    }
                    else if(dongu==2){
                        saat[0]=ceviri(gelenveri);
                    }
                    else if(dongu==3){
                        dk[1]=ceviri(gelenveri);
                                        }
                    else if(dongu==4){
                        dk[0]=ceviri(gelenveri);
                                        }
                    else if(dongu==5){
                        sn[1]=ceviri(gelenveri);
                                        }
                    else if(dongu==6){
                        sn[0]=ceviri(gelenveri);
                                        }
                    else if(dongu==7){
                            timerac=1;
                       lcdgotoxy(0xC3);
                      lcdyaz(ceviri(gelenveri));

                        }
                        else if(dongu==8){
                        lcdgotoxy(0xC4);
                        lcdyaz(ceviri(gelenveri));
                                                }
                        else if(dongu==9){
                        lcdgotoxy(0xC5);
                        lcdyaz(ceviri(gelenveri));
                                                }
                        else if(dongu==10){
                        lcdgotoxy(0xC6);
                        lcdyaz(ceviri(gelenveri));
                                                }
                        else if(dongu==11){
                        lcdgotoxy(0xC7);
                        lcdyaz(ceviri(gelenveri));
                                                }
                        else if(dongu==12){
                        lcdgotoxy(0xC8);
                        lcdyaz(ceviri(gelenveri));
                                                }

                        else if(dongu==13){
                        lcdgotoxy(0xC1);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC2);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC3);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC4);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC5);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC6);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC7);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC8);
                        lcdyaz(0x20);
                        lcdgotoxy(0xC9);
                        lcdyaz(0x20);

                                                }







                }



        if(timerac==1){
            TIMER0_CTL_R |=0x01;
            timerac=0;
        }

        if (sifirlama==1){
                    saat[1]=0x30;
                    saat[0]=0x30;
                    dk[1]=0x30;
                    dk[0]=0x30;
                    sn[1]=0x30;
                    sn[0]=0x30;

                    sifirlama=0;

                }

        if ((TIMER0_RIS_R & 0x01)==1) // kesme bayragýný kontrol ediorum
                       {
                           // buraya girmiþse timeout olmuþtur
                           TIMER0_ICR_R |=0x01; // clear flag




                           int a=GPIOPinRead(GPIO_PORTF_BASE,GPIO_PIN_4);
                                           if (a==0) // pf4 týklanmýþtýr
                                           {

                                               UARTCharPut(UART0_BASE,  '#');
                                               UARTCharPut(UART0_BASE,  'M');
                                               UARTCharPut(UART0_BASE,  'E');
                                               UARTCharPut(UART0_BASE,  'R');
                                               UARTCharPut(UART0_BASE,  'H');
                                               UARTCharPut(UART0_BASE,  'A');
                                               UARTCharPut(UART0_BASE,  'B');
                                               UARTCharPut(UART0_BASE,  'A');











                                           }
                                           else{
                                               UARTCharPut(UART0_BASE,  ceviri(bin));
                                               UARTCharPut(UART0_BASE,  ceviri(yuz));
                                               UARTCharPut(UART0_BASE,  ceviri(on));
                                               UARTCharPut(UART0_BASE,  ceviri(bir));


                                           }








                           if(saat[1]==0x32 && saat[0] == 0x33 && dk[1] == 0x35 && dk[0] == 0x39 && sn[1] == 0x35 && sn[0] == 0x39){
                               saat[1]=0x30;
                               saat[0]=0x30;
                               dk[1]=0x30;
                               dk[0]=0x30;
                               sn[1]=0x30;
                               sn[0]=0x30;
                               sifirlama=1;

                                                                  }
                           if (sifirlama==0){

                           if (sn[0]<0x39)
                           {sn[0]++;}
                           else
                           {
                               sn[0]=0x30;
                               if(sn[1]<0x35){
                                   sn[1]++;}
                               else {

                                   sn[1]=0x30;
                                   if(dk[0]<0x39){
                                       dk[0]++;
                                   }
                                   else{
                                       dk[0]=0x30;
                                       if(dk[1]<0x35){
                                           dk[1]++;}
                                       else{
                                           dk[1]=0x30;
                                           if(saat[0]<0x39)

                                           {saat[0]++;}
                                           else{
                                               saat[0]=0x30;


                                               if(saat[1]<0x32) {
                                                   saat[1]++;
                                               }
                                           }
                                       }
                                   }
                               }
                               }
                           }






                                lcdgotoxy(0x80);
                                lcdyaz(saat[1]);
                                 lcdgotoxy(0x81);
                                 lcdyaz(saat[0]);
                                lcdgotoxy(0x82);
                                lcdyaz(':');
                                lcdgotoxy(0x83);
                                lcdyaz(dk[1]);
                                 lcdgotoxy(0x84);
                                 lcdyaz(dk[0]);
                                lcdgotoxy(0x85);
                                lcdyaz(':');
                                lcdgotoxy(0x86);
                                lcdyaz(sn[1]);
                                 lcdgotoxy(0x87);
                                 lcdyaz(sn[0]);






                            ADCIntClear(ADC0_BASE,1);
                       }



        ADCProcessorTrigger(ADC0_BASE, 1);
     // yazýlýmal tetikleme () adc örnekleri almaya baþladý
    while (!ADCIntStatus(ADC0_BASE, 1, false)){ //1 gelirse adc çevrim iþlemini bitirmiþ olur

       ADCSequenceDataGet(ADC0_BASE, 1, gelendata) ;
     ortalama = (gelendata[0]+gelendata[1]+gelendata[2]+gelendata[3])/4;





    }

          bin=ortalama/1000;
          on=(ortalama%100)/10;
          bir=(ortalama%10);
          yuz=(ortalama%1000)/100;





          lcdgotoxy(0x8C);
          lcdyaz(ceviri(bin));
          lcdgotoxy(0x8D);
          lcdyaz(ceviri(yuz));
          lcdgotoxy(0x8E);
          lcdyaz(ceviri(on));
          lcdgotoxy(0x8F);
          lcdyaz(ceviri(bir));












}
}

void SetInitSettings()
{
    SysCtlClockSet(SYSCTL_SYSDIV_5|SYSCTL_USE_PLL|SYSCTL_XTAL_16MHZ|SYSCTL_OSC_MAIN); // 40mhz

    SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOF);

    SysCtlPeripheralEnable(SYSCTL_PERIPH_ADC0); //adc aktif
    ADCSequenceConfigure(ADC0_BASE, 1, ADC_TRIGGER_PROCESSOR, 0); // adc0 kullan ve seq 1 seç
    ADCSequenceStepConfigure(ADC0_BASE, 1, 0, ADC_CTL_CH0);
    ADCSequenceStepConfigure(ADC0_BASE, 1, 1, ADC_CTL_CH1);
    ADCSequenceStepConfigure(ADC0_BASE, 1, 2, ADC_CTL_CH2);
    ADCSequenceStepConfigure(ADC0_BASE, 1, 3, ADC_CTL_CH3|ADC_CTL_IE|ADC_CTL_END);  // kanal 0 123 okunuyor
    ADCSequenceEnable(ADC0_BASE,1);  // adc ayarlamasý bitti (daha adc çalýþmaya baþlamadý)
    SysCtlPeripheralEnable(SYSCTL_PERIPH_UART0);
         SysCtlPeripheralEnable(SYSCTL_PERIPH_GPIOA); //PA0 VE PA1 KULLANILACAK
         GPIOPinConfigure(GPIO_PA0_U0RX); //kulak
         GPIOPinConfigure(GPIO_PA1_U0TX); //aðýz
         GPIOPinTypeUART(GPIO_PORTA_BASE, GPIO_PIN_0|GPIO_PIN_1);
         UARTConfigSetExpClk(UART0_BASE, SysCtlClockGet(), 115200, UART_CONFIG_WLEN_8|UART_CONFIG_STOP_ONE|UART_CONFIG_PAR_NONE);
         UARTEnable(UART0_BASE);
         GPIOPinTypeGPIOInput(GPIO_PORTF_BASE,GPIO_PIN_4);
         GPIOPadConfigSet(GPIO_PORTF_BASE,GPIO_PIN_4, GPIO_STRENGTH_4MA, GPIO_PIN_TYPE_STD_WPU);

}

void ceviri(char deger){


    if(deger==0){
    hex1=0x30;
    }
    else if(deger==1){
    hex1=0x31;
        }
    else if(deger==2){
    hex1=0x32;
        }
    else if(deger==3){
    hex1=0x33;
        }
    else if(deger==4){
    hex1=0x34;
        }
    else if(deger==5){
    hex1=0x35;
        }
    else if(deger==6){
    hex1=0x36;
        }
    else if(deger==7){
    hex1=0x37;
        }
    else if(deger==8){
    hex1=0x38;
        }
    else if(deger==9){
    hex1=0x39;
        }
    else{
        return deger;
    }

}
