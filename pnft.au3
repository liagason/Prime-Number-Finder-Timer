#NoTrayIcon
Local $x = Null
Local $i = Null
Local $j = Null

Local $quit = Null

ConsoleWrite("Prime Number Finder & Timer [Version: 1.0.0.1, Compiled: Tuesday, 13 Nov 2018]" & @CRLF & "Copyright (c) 2018, Sotiris Liagas. All rights reserved." & @CRLF & @CRLF & "Primality test algorithm is based on trial division and is NOT optimized for speed." & @CRLF & "Source code & documentation are available at https://github.com/liagason" & @CRLF & @CRLF)

ConsoleWrite("Find all prime numbers up to (e.g.: 500000): ")
$x = ConsoleRead()
While True
	$x = ConsoleRead()
	If $x >= 2 And Number($x) >= 2 Then ExitLoop
	If Number($x) == 0 Then $x = Null
	Sleep(64)
WEnd

Local $y = TimerInit()
For $i = 2 To $x Step 1
	For $j = 2 To $x Step 1
		If Mod($i, $j) == 0 Then
			ExitLoop
		Else
			ConsoleWrite($i & @CRLF)
			ExitLoop
		EndIf
	Next
Next
$y = TimerDiff($y)
While StringRegExp(StringRight($x, 1), "[\r\n]")
	$x = StringTrimRight($x, 1)
WEnd
ConsoleWrite("==> Needed " & $y / 1000 & " SECONDS to VERIFY AND PRINT all prime numbers up to " & $x & "." & @CRLF)

Local $z = TimerInit()
For $i = 2 To $x Step 1
	For $j = 2 To $x Step 1
		If Mod($i, $j) == 0 Then
			ExitLoop
		Else
			ExitLoop
		EndIf
	Next
Next
$z = TimerDiff($z)
While StringRegExp(StringRight($x, 1), "[\r\n]")
	$x = StringTrimRight($x, 1)
WEnd
ConsoleWrite("==> Needed " & $z / 1000 & " SECONDS to JUST VERIFY all prime numbers up to " & $x & "." & @CRLF)

ConsoleWrite("Press ENTER to quit...")
While True
	$quit = ConsoleRead()
	If $quit <> '' Then ExitLoop
	Sleep(32)
WEnd
