--SQLite Maestro 14.3.0.1
------------------------------------------
--Host     : localhost
--Database : HistoryCardsDB


CREATE TABLE tblCardsCategories (
  idCard      bigint NOT NULL,
  idCategory  bigint NOT NULL,
  /* Foreign keys */
  CONSTRAINT fkCategory
    FOREIGN KEY (idCategory)
    REFERENCES tblCategories(idCategory), 
  CONSTRAINT fkCard
    FOREIGN KEY (idCard)
    REFERENCES tblHistoricalCards(idCard)
);

CREATE TABLE tblCardsImages (
  idCard   bigint,
  idImage  bigint,
  /* Foreign keys */
  CONSTRAINT fkImage
    FOREIGN KEY (idImage)
    REFERENCES tblImages(idImage), 
  CONSTRAINT fkCard
    FOREIGN KEY (idCard)
    REFERENCES tblHistoricalCards(idCard)
);

CREATE TABLE tblCardsSourcesURL (
  idCard       bigint,
  idSourceURL  bigint,
  /* Foreign keys */
  CONSTRAINT fkSouceURL
    FOREIGN KEY (idSourceURL)
    REFERENCES tblSourcesURL(idSourceURL), 
  CONSTRAINT fkCard
    FOREIGN KEY (idCard)
    REFERENCES tblHistoricalCards(idCard)
);

CREATE TABLE tblCategories (
  idCategory   bigint NOT NULL,
  name         varchar(255) NOT NULL,
  discription  text,
  idParent     bigint DEFAULT NULL,
  /* Keys */
  PRIMARY KEY (idCategory)
);

CREATE TABLE tblHistoricalCards (
  fromDatetime  datetime,
  idCard        bigint NOT NULL,
  toDatetime    datetime,
  discription   text,
  nameCard      text NOT NULL,
  addDatetime   datetime DEFAULT CURRENT_DATE,
  /* Keys */
  PRIMARY KEY (idCard)
);

CREATE TABLE tblImages (
  image        blob,
  idImage      bigint NOT NULL,
  discription  text,
  /* Keys */
  PRIMARY KEY (idImage)
);

CREATE TABLE tblSourcesURL (
  idSourceURL  bigint NOT NULL,
  URL          text NOT NULL,
  /* Keys */
  PRIMARY KEY (idSourceURL)
);

/* Data for table tblCardsCategories */




/* Data for table tblCardsImages */




/* Data for table tblCardsSourcesURL */




/* Data for table tblCategories */




/* Data for table tblHistoricalCards */




/* Data for table tblImages */




/* Data for table tblSourcesURL */


