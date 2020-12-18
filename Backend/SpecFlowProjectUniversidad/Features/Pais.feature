Feature: Pais

@mytag
Scenario: Verificar si existe un pais
	Given si el pais es igual que null get
	When el pais no existe
	Then pais enseñar "No se Encontro el Pais"

@mytag
Scenario: Verificar si existe un Usuario en put
	Given si el pais igual que null en put
	When  el pais no existe en put
	Then put pais enseñar "No se Encontro el Pais"

@mytag
Scenario: Verificar si existe un Usuario en delete
	Given si el pais es igual que null en delete
	When  el pais no existe en delete
	Then delete pais enseñar "No se Encontro el Pais"