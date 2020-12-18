Feature: Estudiante

@mytag
Scenario: Verificar si existe un estudiante
	Given si el estudiante es igual que null get
	When el estudiante no existe
	Then estudiante enseñar "No se Encontro el Estudiante"

@mytag
Scenario: Verificar si existe un curso en post Estudiante
	Given si el curso igual que null en post Estudiante
	When  el curso no existe en post Estudiante
	Then curso post Estudiante enseñar "No se Encontro el Curso"

@mytag
Scenario: Verificar si existe un pais en post Estudiante
	Given si el pais igual que null en post Estudiante
	When  el pais no existe en post Estudiante
	Then pais post Estudiante enseñar "No se Encontro el Pais"

@mytag
Scenario: Verificar si existe un profesor en post Estudiante
	Given si el profesor igual que null en post Estudiante
	When  el profesor no existe en post Estudiante
	Then profesor post Estudiante enseñar "No se Encontro el Profesor"

@mytag
Scenario: Verificar si existe un estudiante en put
	Given si el estudiante igual que null en put
	When  el estudiante no existe en put
	Then put estudiante enseñar "No se Encontro el Estudiante"

@mytag
Scenario: Verificar si existe un curso en put Estudiante
	Given si el curso igual que null en put Estudiante
	When  el curso no existe en put Estudiante
	Then curso put Estudiante enseñar "No se Encontro el Curso"

@mytag
Scenario: Verificar si existe un pais en put Estudiante
	Given si el pais igual que null en put Estudiante
	When  el pais no existe en put Estudiante
	Then pais put Estudiante enseñar "No se Encontro el Pais"

@mytag
Scenario: Verificar si existe un profesor en put Estudiante
	Given si el profesor igual que null en put Estudiante
	When  el profesor no existe en put Estudiante
	Then profesor put Estudiante enseñar "No se Encontro el Profesor"


@mytag
Scenario: Verificar si existe un estudiante en delete
	Given si el estudiante es igual que null en delete
	When  el estudiante no existe en delete
	Then delete estudiante enseñar "No se Encontro el Estudiante"