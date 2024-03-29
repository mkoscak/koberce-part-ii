-- skript na vytvorenie tabuliek pre novy system global

-- hlavna tabulka
DROP TABLE IF EXISTS T_PRODUCT;
CREATE TABLE T_PRODUCT (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"PRODUCT_NR" TEXT,
	"DESCRIPTION" TEXT,
	"HOCHFLOR" INTEGER,
	"KNOTS" INTEGER,
	"WEIGHT" REAL,
	"BUY_PRICE" REAL,
	"COLOR" TEXT,
	"MATERIAL" TEXT,
	"MAT_INSIDE" TEXT,
	"FORM" TEXT,
	"SUPPLIER_ID" INTEGER,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);

-- sklady
DROP TABLE IF EXISTS T_STORAGE;
CREATE TABLE T_STORAGE (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"NAME" TEXT,
	"ADDRESS" TEXT,
	"ADDRESS2" TEXT,
	"PHONE" TEXT,
	"EMAIL" TEXT,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);

-- prepojenie sklad-global - stav kobercov na skladoch
DROP TABLE IF EXISTS T_STORAGE_STATE;
CREATE TABLE T_STORAGE_STATE (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"PRODUCT_ID" INTEGER,
	"STORAGE_ID" INTEGER,
	"LENGTH" INTEGER,
	"WIDTH" INTEGER,
	"COUNT" INTEGER,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);

-- ciselne serie
DROP TABLE IF EXISTS T_NUMBER_SERIE;
CREATE TABLE T_NUMBER_SERIE (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"NAME" TEXT,
	"PREFIX" TEXT,
	"LAST_NR" INTEGER NOT NULL,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);

-- dodavatel
DROP TABLE IF EXISTS T_SUPPLIER;
CREATE TABLE T_SUPPLIER (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"NAME" TEXT,
	"ADDRESS" TEXT,
	"ADDRESS2" TEXT,
	"PHONE" TEXT,
	"EMAIL" TEXT,
	"NR_SERIE_ID" INTEGER NOT NULL,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);

-- odberatel
DROP TABLE IF EXISTS T_CUSTOMER;
CREATE TABLE T_CUSTOMER (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"NAME" TEXT,
	"ADDRESS" TEXT,
	"ADDRESS2" TEXT,
	"PHONE" TEXT,
	"EMAIL" TEXT,
-- typ odberatela - 0 velkoodberatel 1 maloodber
	"CUSTOMER_TYPE" INTEGER DEFAULT 0,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);

-- faktura
DROP TABLE IF EXISTS T_INVOICE;
CREATE TABLE T_INVOICE (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"CUSTOMER_ID" INTEGER,
	"INVOICE_DATE" TEXT,
	"TOTAL_PRICE" REAL,
	"TAX" REAL,
	"PRICE_NO_TAX" REAL,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);

-- polozka faktury
DROP TABLE IF EXISTS T_SOLD_ITEM;
CREATE TABLE T_SOLD_ITEM (
	"ID" INTEGER PRIMARY KEY AUTOINCREMENT,
	"STORAGE_STATE_ID" INTEGER,
	"BUY_PRICE" REAL,
	"COUNT" INTEGER,
	"PRICE_COEF" REAL,
	"RESULT_PRICE" REAL,
	"INVOICE_ID" INTEGER,
	"COMMENT" TEXT,
	"VALID" INTEGER DEFAULT 1
);
