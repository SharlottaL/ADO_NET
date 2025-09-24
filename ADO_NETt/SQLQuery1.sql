﻿SELECT 
	 movie_name,
	 release_date,
	 last_name,
	 first_name
FROM Movies,Directors WHERE director=director_id; DROP TABLE Actors;
SELECT * FROM Directors
WHERE director=director_id
AND	 last_name=N'Cameron';