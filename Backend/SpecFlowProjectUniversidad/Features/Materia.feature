Feature: Materia

@mytag
Scenario: Verificar si existe un materia
	Given si el materia es igual que null get
	When el materia no existe
	Then materia enseñar "No se Encontro la Materia"

@mytag
Scenario: Verificar si existe un materia en put
	Given si el materia igual que null en put
	When  el materia no existe en put
	Then put materia enseñar "No se Encontro la Materia"

@mytag
Scenario: Verificar si existe un materia en delete
	Given si el materia es igual que null en delete
	When  el materia no existe en delete
	Then delete materia enseñar "No se Encontro la Materia"