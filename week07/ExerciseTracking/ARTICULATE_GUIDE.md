# W07 Articulate - Guía de Referencia
## Exercise Tracking Program

> ⚠️ IMPORTANTE: Esta guía es para que ENTIENDAS las ideas y las escribas
> CON TUS PROPIAS PALABRAS. No copies este texto directamente en Canvas.
> Úsalo para comprender el concepto y luego explícalo como lo harías en
> una entrevista de trabajo.

---

## 1. Abstraction (Abstracción)

### ¿Qué es?
Abstraction significa mostrar solo lo que importa y ocultar los detalles
internos. En lugar de exponer CÓMO funciona algo, solo muestras QUÉ hace.
Es como usar un control remoto sin saber cómo funciona por dentro.

### ¿Cómo la usaste en el proyecto?
La clase `Activity` es un ejemplo perfecto. Cuando llamas `GetSummary()`,
no necesitas saber si el objeto es un Running, Cycling o Swimming. Solo
llamas al método y obtienes el resultado. Los detalles de cómo se calcula
la distancia para natación (laps × 50m ÷ 1000 × 0.62) quedan ocultos
dentro de la clase `Swimming`.

### ¿Cómo permite cambios futuros?
Si el fitness center decide agregar yoga o pesas, solo creas una nueva clase
derivada de `Activity` sin tocar el código existente. El programa principal
no necesita cambiar porque trabaja con la abstracción (`Activity`), no con
los tipos concretos.

---

## 2. Encapsulation (Encapsulación)

### ¿Qué es?
Encapsulation significa proteger los datos de una clase guardándolos como
privados, y controlar el acceso a ellos a través de métodos públicos.
Evita que código externo modifique directamente los datos internos.

### ¿Cómo la usaste en el proyecto?
Todas las variables miembro usan `private`: `_date`, `_minutes`, `_distance`,
`_speed`, `_laps`. Nadie puede cambiarlas directamente desde afuera.
Para leer la fecha se usa `GetDate()` y para los minutos `GetMinutes()`.
Esto protege la integridad de los datos.

### ¿Cómo permite cambios futuros?
Si en el futuro necesitas validar que los minutos no sean negativos, solo
modificas el constructor de `Activity` en un solo lugar. Cualquier código
que use la clase automáticamente se beneficia de esa validación sin
necesitar cambios.

---

## 3. Inheritance (Herencia)

### ¿Qué es?
Inheritance permite que una clase "hija" reutilice el código de una clase
"padre", evitando duplicación. La clase hija hereda atributos y métodos de
la clase padre, y puede agregar o modificar comportamiento.

### ¿Cómo la usaste en el proyecto?
`Running`, `Cycling` y `Swimming` todas heredan de `Activity`. Ninguna de
las tres necesita redefinir `_date`, `_minutes`, `GetDate()`, `GetMinutes()`
ni `GetSummary()`. Solo agregan lo que es único para cada actividad:
`_distance` para Running, `_speed` para Cycling, `_laps` para Swimming.

### ¿Cómo permite cambios futuros?
Si el fitness center quiere agregar un campo de "notas del entrenador" a
todas las actividades, solo se modifica la clase base `Activity`. Las tres
clases derivadas lo heredan automáticamente. Sin herencia, habría que
cambiar 3 clases por separado con riesgo de inconsistencias.

---

## 4. Polymorphism (Polimorfismo)

### ¿Qué es?
Polymorphism significa que objetos de diferentes tipos pueden responder al
mismo mensaje de maneras distintas. Un mismo método (`GetDistance()`) hace
cosas diferentes dependiendo del tipo real del objeto. "Muchas formas, un
nombre".

### ¿Cómo la usaste en el proyecto?
En `Program.cs` tienes una lista `List<Activity>` que contiene Running,
Cycling y Swimming mezclados. Cuando llamas `activity.GetSummary()` en el
`foreach`, C# automáticamente usa la versión correcta de `GetDistance()`,
`GetSpeed()` y `GetPace()` para cada tipo. El código del `foreach` no
necesita saber qué tipo específico es.

### ¿Cómo permite cambios futuros?
Si agregas una clase `Hiking` que hereda de `Activity` y hace override de
los 3 métodos, automáticamente funciona con el mismo `foreach` sin cambiar
nada en `Program.cs`. El polimorfismo hace que el código sea extensible
sin modificar el código existente (principio Open/Closed).

---

## Ejemplo de respuesta completa para escribir en Canvas:

Toma estas ideas y redacta algo así (en tus palabras):

"**Abstraction** is the principle of... In my Exercise Tracking program,
I used abstraction when... This helps the program change in the future
because..."

Repite el mismo formato para los 4 principios. Apunta a al menos 3-4
oraciones por principio para cumplir el requisito de +100 palabras total.
