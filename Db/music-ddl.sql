-- DML: Data Manipulation Language
-- DDL: Data Definition Language

CREATE TABLE DatosDeContacto (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    PaisDeOrigen TEXT NOT NULL,
    Ciudad TEXT NOT NULL,
    CorreoElectronico TEXT NOT NULL,
    CodigoPostal TEXT NOT NULL,
    ArtistaId INTEGER NOT NULL
);

-- DML
INSERT INTO DatosDeContacto (PaisDeOrigen,Ciudad,CorreoElectronico,CodigoPostal,ArtistaId)
SELECT country, city, email, zip_code, artist_id FROM music GROUP BY artist_id;

CREATE TABLE Artista (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    NombreReal TEXT NOT NULL,
    NombreArtistico TEXT,
    RolMusical TEXT NOT NULL,
    AnioDeNacimiento INTEGER NOT NULL,
    DatosDeContactoId INTEGER NOT NULL
);

-- DML
INSERT INTO Artista (NombreReal,NombreArtistico,RolMusical,AnioDeNacimiento,DatosDeContactoId)
SELECT artist_real_name,
       art_name,
       role,
       year_of_birth,
       (SELECT Id FROM DatosDeContacto WHERE ArtistaId=artist_id)
  FROM music GROUP BY artist_id;

CREATE TABLE Critica (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    RollingStone REAL NOT NULL,
    Mtv REAL NOT NULL,
    MusicManiac REAL NOT NULL,
    AlbumId INTEGER NOT NULL
);

-- DML
INSERT INTO Critica (RollingStone,Mtv,MusicManiac,AlbumId)
SELECT rolling_stone_critic,
       mtv_critic,
       music_maniac_critic,
       album_id
  FROM music
 GROUP BY album_id;

CREATE TABLE Album (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Titulo TEXT NOT NULL,
    GeneroMusical TEXT NOT NULL,
    AnioDePublicacion INTEGER NOT NULL,
    NumeroDePistas INTEGER NOT NULL,
    NumeroDeVentas INTEGER NOT NULL,
    ArtistaId INTEGER NOT NULL,
    CriticaId INTEGER NOT NULL
);

INSERT INTO Album (Titulo,GeneroMusical,AnioDePublicacion,NumeroDePistas,NumeroDeVentas,ArtistaId,CriticaId)
SELECT album_title,
       genre,
       year_of_pub,
       num_of_tracks,
       num_of_sales,
       artist_id,
       (SELECT Id FROM Critica WHERE AlbumId=album_id)
  FROM music;