-- Database: quizmaster_db
DROP DATABASE IF EXISTS quizmaster_db;

CREATE DATABASE quizmaster_db
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'English_United States.1252'
    LC_CTYPE = 'English_United States.1252'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

COMMENT ON DATABASE quizmaster_db
    IS 'Collection of Questions, Answers, Images to generate questions';
