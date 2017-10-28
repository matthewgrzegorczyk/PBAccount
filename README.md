# PBAccount

50% 
Napisz klasę Konto pozwalającą na operacje wpłaty, wypłaty oraz sprawdzenie salda. O niedozwolonych operacjach (np. nieprawidłowej kwocie lub przekroczeniu salda przy wypłacie) informuj przy użyciu mechanizmu wyjątków.

+25% 
Napisz klasę KontoHis dziedziczącą z klasy Konto, która będzie przechowywać historię z 20 ostatnich operacji - w momencie dokonywania każdej wpłaty lub wypłaty zapamiętywany będzie aktualny stan konta. Dodaj metody pozwalające na przeglądanie historii.

+25% 
Napisz klasę KontoDeb dziedziczącą z klasy KontoHis, która będzie pozwalać na dokonanie debetu - umożliwi wypłacenie większej kwoty niż suma zgromadzonych środków. Maksymalna kwota debetu powinna wynosić 50% średniego stanu z całej historii konta.