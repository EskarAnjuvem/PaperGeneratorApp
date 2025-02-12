-- Subjects Table
DROP TABLE IF EXISTS subjects;
CREATE TABLE subjects (
    subject_id SERIAL PRIMARY KEY,
    subject_name VARCHAR(50) NOT NULL
);

-- Difficulty Levels Table
DROP TABLE IF EXISTS difficultylevels;
CREATE TABLE difficultylevels (
    difficulty_level_id SERIAL PRIMARY KEY,
    level VARCHAR(10) NOT NULL
);

-- Images Table
DROP TABLE IF EXISTS images;
CREATE TABLE images (
    image_id SERIAL PRIMARY KEY,
    image_path VARCHAR(255) NOT NULL
);

-- Tags Table
DROP TABLE IF EXISTS tags;
CREATE TABLE tags (
    tag_id SERIAL PRIMARY KEY,
    tag_name VARCHAR(45) NOT NULL UNIQUE,
	CHECK (tag_name = LOWER(tag_name))
);

-- Questions Table
DROP TABLE IF EXISTS questions;
CREATE TABLE questions (
    question_id SERIAL PRIMARY KEY,
    question_text TEXT NOT NULL,
    difficulty_level_id INT,
    subject_id INT,
    image_id INT,
    FOREIGN KEY (difficulty_level_id) 
        REFERENCES difficultylevels(difficulty_level_id)
        ON UPDATE CASCADE
        ON DELETE SET NULL,
    FOREIGN KEY (subject_id) 
        REFERENCES subjects(subject_id)
        ON UPDATE CASCADE
        ON DELETE SET NULL,
    FOREIGN KEY (image_id) 
        REFERENCES images(image_id)
        ON UPDATE CASCADE
        ON DELETE SET NULL
);

-- Question-Tags Junction Table
DROP TABLE IF EXISTS question_tags;
CREATE TABLE question_tags (
    question_id INT NOT NULL,
    tag_id INT NOT NULL,
    PRIMARY KEY (question_id, tag_id),
    FOREIGN KEY (question_id) 
        REFERENCES questions(question_id)
		ON UPDATE CASCADE
        ON DELETE CASCADE,
    FOREIGN KEY (tag_id) 
        REFERENCES tags(tag_id)
		ON UPDATE CASCADE
        ON DELETE CASCADE
);

-- Answers Table
DROP TABLE IF EXISTS answers;
CREATE TABLE answers (
    answer_id SERIAL PRIMARY KEY,
    question_id INT NOT NULL,
    answer_text TEXT,
    answer_image_id INT,
	is_correct BOOLEAN NOT NULL DEFAULT FALSE,
    CHECK (
        (answer_text IS NOT NULL AND answer_image_id IS NULL) OR 
        (answer_text IS NULL AND answer_image_id IS NOT NULL)
    ),
    FOREIGN KEY (question_id) 
        REFERENCES questions(question_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    FOREIGN KEY (answer_image_id) 
        REFERENCES images(image_id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);