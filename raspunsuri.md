## Laborator 2 (temă)

### Exercițiul 1
   Dacă modifici constanta MatrixMode.Projection în altă valoare (de exemplu, MatrixMode.Modelview), vei observa că proiecția scenei nu mai este configurată corect, ceea ce va afecta modul în care obiectele sunt desenate și afișate pe ecran.
   
### Exercițiul 3

1. **Ce este un viewport?**  
   Viewport-ul în OpenGL reprezintă regiunea de pe ecran în care sunt desenate obiectele. Este definit prin coordonatele stânga-jos și dimensiunile lățimii și înălțimii. Viewport-ul mapează coordonatele de randare ale scenei la coordonatele fizice ale ecranului. Este configurat cu funcția `glViewport(x, y, width, height)`.

2. **Ce reprezintă conceptul de frames per second (FPS) din punctul de vedere al bibliotecii OpenGL?**  
   Frames per second (FPS) în OpenGL reprezintă numărul de cadre (imagini) pe care le poate genera și reda sistemul într-o secundă. FPS-ul este important deoarece influențează fluiditatea animațiilor și a interacțiunilor vizuale. Un FPS ridicat asigură o experiență vizuală mai lină, în timp ce un FPS scăzut poate duce la sacadări. OpenGL nu gestionează direct FPS-ul, dar acesta poate fi monitorizat și optimizat în funcție de performanța hardware-ului și a algoritmilor de randare.

3. **Când este rulată metoda OnUpdateFrame()?**  
   Metoda `OnUpdateFrame()` este apelată în fiecare cadru pentru a actualiza logica jocului sau a aplicației. Aceasta este utilizată pentru a face calcule care nu implică direct randarea, cum ar fi mișcarea obiectelor, coliziuni, procesarea intrărilor de la utilizator sau alte actualizări necesare în timpul execuției aplicației. Este parte din ciclul de actualizare și randare.

4. **Ce este modul imediat de randare?**  
   Modul imediat de randare (immediate mode) în OpenGL este un mod mai vechi în care aplicația specifică direct fiecare vertex și fiecare primitiv grafic care urmează să fie desenat. Acest mod folosește funcții precum `glBegin()` și `glEnd()` pentru a specifica geometria obiectelor de randat. Deși este mai simplu de înțeles pentru începători, acest mod este ineficient pentru randări complexe, deoarece fiecare apel de funcție trimite datele către placa grafică imediat.

5. **Care este ultima versiune de OpenGL care acceptă modul imediat?**  
   Ultima versiune majoră de OpenGL care suportă pe deplin modul imediat de randare este OpenGL **3.0**. Cu toate acestea, modul imediat este considerat depășit (deprecated) în versiunile moderne ale OpenGL și este înlocuit de metode mai eficiente, cum ar fi randarea folosind **vertex buffer objects (VBO)** și **vertex array objects (VAO)**, care optimizează fluxul de date către GPU.

6. **Când este rulată metoda OnRenderFrame()?**  
   Metoda `OnRenderFrame()` este apelată de fiecare dată când trebuie să fie redat un nou cadru. Aceasta gestionează partea de randare a aplicației, desenând toate obiectele pe care utilizatorul le vede. De obicei, aceasta este rulat de mai multe ori pe secundă, sincronizându-se cu ratele de refresh ale monitorului sau cu dorința de FPS a aplicației.

7. **De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?**  
   Metoda `OnResize()` trebuie executată cel puțin o dată pentru a configura corect viewport-ul și proiecția 3D a scenei, în funcție de dimensiunea ferestrei sau a ecranului. Dacă dimensiunea ferestrei se schimbă, proiecția și viewport-ul trebuie să fie actualizate pentru a asigura o redare corectă a scenei. Fără aceasta, obiectele ar putea fi desenate incorect sau ar putea apărea deformări.

8. **Ce reprezintă parametrii metodei CreatePerspectiveFieldOfView() și care este domeniul de valori pentru aceștia?**  
   Metoda `CreatePerspectiveFieldOfView()` este folosită pentru a crea o matrice de proiecție în perspectivă, care definește modul în care obiectele 3D sunt proiectate pe ecranul 2D. Parametrii săi sunt:
   
   - **Field of view (FOV)** – reprezintă unghiul câmpului vizual în planul vertical, măsurat în grade. Un domeniu tipic este între **30** și **90** de grade, deși poate varia în funcție de scenă și aplicație.
   - **Aspect ratio** – raportul dintre lățimea și înălțimea ferestrei de vizualizare, necesar pentru a preveni deformarea imaginii.
   - **Near clip** – distanța până la planul de tăiere apropiat, orice obiect mai aproape de această valoare nu va fi redat. De obicei, are valori pozitive mici, cum ar fi **0.1**.
   - **Far clip** – distanța până la planul de tăiere îndepărtat, orice obiect dincolo de această distanță nu va fi redat. De obicei, are valori mari, cum ar fi **1000**.
