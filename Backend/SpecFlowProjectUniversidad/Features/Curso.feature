Feature: Curso

@mytag
Scenario: Verificar si existe un curso
	Given si el curso es igual que null get
	When el curso no existe
	Then curso enseñar "No se Encontro el Curso"

@mytag
Scenario: Verificar si existe una materia en post Curso
	Given si la materia igual que null en post Curso
	When  el materia no existe en post Curso
	Then materia post Curso enseñar "No se Encontro la Materia"

@mytag
Scenario: Verificar si existe un curso en put
	Given si el curso igual que null en put
	When  el curso no existe en put
	Then put curso enseñar "No se Encontro el Curso"

@mytag
Scenario: Verificar si existe una materia en put Curso
	Given si la materia igual que null en put Curso
	When  el materia no existe en put Curso
	Then materia put Curso enseñar "No se Encontro la Materia"

@mytag
Scenario: Verificar si existe un curso en delete
	Given si el curso es igual que null en delete
	When  el curso no existe en delete
	Then delete curso enseñar "No se Encontro el Curso"