# Lern-Bericht
Popcorn : Lorenzo Lai, Tristan Evans, Rebecca Willi, Agachan Athputherasa. Timo Goedertier

## Einleitung

In unserem Projekt geht es um das Kindheitsspiel "Schiffe versenken".

## Was habe ich gelernt?

Wir haben gelernt Fenster zu öffnen und zu schliessen mit WinForms C#.

## Beschreibung

![74xfyz](https://user-images.githubusercontent.com/110893594/208612968-297f7ffd-c2ed-46eb-9b91-96547cecfeb4.gif)

In diesem gif kann man sehen, was wir genau meinten: Man muss zuerst bei der ersten Fenster eine Taste drücken (hier: Start Game), um dann Form2 zu öffnen. Um zurückzugehen, macht man genau das Gleiche.

### Textliche Beschreibung:

Wir haben uns zunächst mit der Struktur von Windows Forms auseinandergesetzt und verstanden, wie man Steuerelemente wie Buttons, Labels und Textboxen hinzufügt und anordnet, um eine Benutzeroberfläche zu erstellen. Dazu haben wir die Toolbox und den Designer in Visual Studio genutzt und uns verschiedene Beispiele angeschaut, um die Möglichkeiten von Windows Forms kennenzulernen. Anschliessend haben wir das Spielfeld für das Battleship-Spiel gestaltet und die benötigten Funktionalitäten implementiert, wie zum Beispiel das Setzen von Schiffen und das Abfeuern von Schüssen. Dabei haben wir auf Event-Handler und Eigenschaften von Steuerelementen zurückgegriffen, um die gewünschten Funktionen zu realisieren.



### Beschreibung eines Code-Fetzens:

![grafik](https://user-images.githubusercontent.com/110893008/208622002-47bb82d0-3bde-4e8b-b85b-99a61bca5ff3.png)

In diesem Beispiel werden drei Methoden namens «LoadGame, LoadHelp und QuitApplication» definiert, die jeweils das Öffnen und Schließen von Fenstern in einer Winforms-Anwendung steuern.

Die LoadGame-Methode öffnet das Fenster "inGameScreen" und versteckt das aktuelle Fenster mit «this.Hide». Die LoadHelp-Methode öffnet dann das Fenster "inHelpScreen". Die QuitApplication-Methode schließt das aktuelle Fenster «this.Close».

Diese Methoden werden als Event-Handler verwendet, um auf bestimmte Benutzeraktionen zu reagieren, z.B. wie auf das Klicken einer Schaltfläche. In diesem Code-Beispiel wird die Methode namens «QuitApplication» definiert, die als Event-Handler verwendet werden kann, um das aktuelle Fenster (this) zu schließen.

«QuitApplication» funktioniert in diesem Fall, dass das ganze Programm geschlossen wird, aber um ein Fenster sonst im Programm einzeln zu schliessen, braucht man die Methode btnClose_Click in diesem Fall. Diese Methode referenziert das Klicken des schliessen Buttons, welches dann das Fenster durch "this.Hide()" schliesst.


## Verifikation

Im ersten Medium sieht man, was der Codefetzen vom dritten Medium macht und im zweiten Medium ist die Erklärung zu unserem Vorgang, wie wir gelernt haben.

# Reflektion zum Arbeitsprozess

Wir haben uns schnell gefunden und geeinigt, was unser Projekt sein sollte. Wir haben am Anfang allen einen Teil des Projekts zugeteilt, aber weil nicht alle von anfang an arbeiten konnten, haben wir uns gegenseitig geholfen.

Es war schwierig das Projekt ins laufen zu bringen, weil wir am Anfang nichts über WinForms gewusst haben.

**VBV**: Von Anfang an gut informieren, um herauszufinden was man machen soll und kann. Vorallem wichtig bei neuen Arten des programmieren, wie jetzt WinForms.
