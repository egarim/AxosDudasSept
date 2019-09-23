;#DropDB AxosDudasSeptEasyTest

#Application AxosDudasSept.Win
#Application AxosDudasSept.Web
#IfDef AxosDudasSept.Win

*Action About...
 
*Action OK

#EndIf

#IfDef AxosDudasSept.Web
!Action Navigation(My Details)
#EndIf
