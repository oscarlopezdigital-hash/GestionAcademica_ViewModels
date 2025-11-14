# GestionAcademica_ViewModels

## 🎓 Proyecto de Práctica: View Models en ASP.NET MVC

### Descripción General

Este proyecto implementa una práctica esencial de la arquitectura **Model-View-Controller (MVC)** en C# para demostrar la correcta implementación de un **View Model**.

El objetivo principal es resolver el problema de presentar datos provenientes de **múltiples entidades de dominio** (`Alumno`, `Curso`, `Profesor`) en una **única vista** de manera eficiente y desacoplada, utilizando la lógica de unión (JOIN) en el controlador mediante **LINQ**.

### 🎯 Objetivos de la Práctica

* **Diseño de View Model:** Creación de una clase (`AlumnoCursoProfesorViewModel`) específica para la vista que contiene solo los datos necesarios (nombre del alumno, nombre del curso, nombre del profesor).
* **Unión de Datos (LINQ):** Realización de un `JOIN` de tres colecciones de datos en memoria (`Alumnos`, `Cursos`, `Profesores`) dentro del Controlador.
* **Desacoplamiento:** Asegurar que la vista (`Index.cshtml`) no tenga que manejar la lógica de búsqueda o unión de datos.
* **Maquetación Web:** Aplicación de estilos de **Bootstrap 5** a la tabla para una presentación profesional de la información.

### 🛠️ Tecnología Utilizada

* **Lenguaje:** C#
* **Framework:** ASP.NET MVC 5
* **Consulta de Datos:** LINQ (Language Integrated Query)
* **Frontend/Estilos:** HTML, Razor Syntax, Bootstrap 5 (a través de CDN)

### 📂 Estructura del Proyecto

| Archivo/Carpeta | Rol | Propósito |
| :--- | :--- | :--- |
| **`Models/AlumnoCursoProfesorViewModel.cs`** | **ViewModel** | La estructura de datos final que la vista consume. |
| **`Controllers/AlumnosController.cs`** | Controlador | Contiene la lógica LINQ para unir los 3 modelos y enviar el ViewModel. |
