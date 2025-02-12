SELECT question_text, i.image_path AS question_image FROM questions
LEFT JOIN images i
ON questions.image_id = i.image_id
LIMIT 5;

SELECT q.question_id, q.question_text, i.image_path AS question_image, a.answer_text , a.is_correct FROM questions q
LEFT JOIN images i
ON q.image_id = i.image_id
LEFT JOIN answers a
ON q.question_id = a.question_id
ORDER BY q.question_id, answer_id
LIMIT 28;


