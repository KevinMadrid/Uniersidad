Feature: Profesor

@mytag
Scenario: Verificar si existe un profesor
	Given si el profesor es igual que null get
	When el profesor no existe
	Then profesor enseñar "No se Encontro el Profesor"

@mytag
Scenario: Verificar si existe un profesor en put
	Given si el profesor igual que null en put
	When  el profesor no existe en put
	Then put profesor enseñar "No se Encontro el Profesor"

@mytag
Scenario: Verificar si existe un profesor en delete
	Given si el profesor es igual que null en delete
	When  el profesor no existe en delete
	Then delete profesor enseñar "No se Encontro el Profesor"