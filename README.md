![shooterIsland-gewonnen](https://user-images.githubusercontent.com/28704310/133208758-ee840ab7-8346-4a31-a1d9-63d2d352ddc7.JPG)
# IslandShooting

https://hs-teaching.github.io/IslandShooting/

Background: <a href='https://de.freepik.com/vektoren/baum'>Baum Vektor erstellt von upklyak - de.freepik.com</a>
https://pixabay.com/de/vectors/ziel-pfeil-bogen-sport-schlag-36797/
https://pixabay.com/de/vectors/fadenkreuz-anvisieren-zielen-467258/
https://freesound.org/s/435417/


Cursor clickpoint in WebGl build not center (crosshair) -->  set cursor hotspot

Sprite gewonnen disapear in full screen mode Webgl --> use image

### Anforderungen:  
- [ ] 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen
- [ ] In Assets Folder MyGame anlegen.
- [ ] Den Ordner Scenes in Assets > MyGame ziehen
- [ ] Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene
- [ ] Ein Canvas GameObject anlegen.
- [ ] Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, 
das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.
- [ ] In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.
- [ ] In Asstets > MyGame den Folder Sprites anlegen. 
- [ ] Ein Hintergrund Sprite reinladen.
- [ ] In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.
- [ ] Das Image ggf. positionieren und größentechnisch anpassen.
- [ ] Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen. 
- [ ] Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag. 
- [ ] Das empty GameObject umbenennen in ParentTargets.
- [ ] in Assets > MyGame > Prefabs Folder anlegen.
- [ ] Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.
- [ ] Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen. 
- [ ] Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die 
- [ ] Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen. 
- [ ] In Assets > MyGame einen neuen Ordner anlegen Scripts
- [ ] In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit doppelklick öffnen in Visual Studio (TODO: Link zum Einstellen von VS als Default IDE).
- [ ] Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop). 
- [ ] Einen 2D Collider als Komponente dem Target hinzufügen. 
- [ ] Dem Script Target eine Methode OnMouseDown() hinzufügen. 
- [ ] In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen
- [ ] Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen. 
- [ ] In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen. 
- [ ] Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.
- [ ] Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.
