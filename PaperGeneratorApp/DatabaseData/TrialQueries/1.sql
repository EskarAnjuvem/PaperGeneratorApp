SELECT * FROM answers;
SELECT * FROM questions ORDER BY question_id;
SELECT * FROM images;
SELECT * FROM question_tags;

SELECT q.question_text, i.image_path, a.answer_text FROM questions q
JOIN answers a
ON q.question_id = a.question_id
LEFT JOIN images i
ON q.image_id = i.image_id
WHERE q.difficulty_level_id = 1
ORDER BY q.question_id , a.answer_id;

SELECT * FROM questions q
JOIN answers a
ON q.question_id = a.question_id
ORDER BY q.question_id , a.answer_id;

SELECT * FROM images;