INSERT INTO answers (answer_id, question_id, answer_text, answer_image_id, is_correct)
VALUES 
	(default, 1,'Doubled', NULL, false),
    (default, 1,'Halved', NULL, false),
    (default, 1,'Remains Unchanged', NULL, true),
    (default, 1,'None of these', NULL, false),
	(default, 2,'\(Polarization\)', NULL, false),
    (default, 2,'\(Capacitance\)', NULL, false),
    (default, 2,'\(Dielectric \; strength\)', NULL, true),
    (default, 2,'\(Dielectric \;constant\)', NULL, false),
	(default, 3,'\(25\;\mu\)F', NULL, true),
    (default, 3,'\(20\;\mu\)F', NULL, false),
    (default, 3,'\(40\;\mu\)F', NULL, false),
    (default, 3,'\(5\;\mu\)F', NULL,false),
	(default, 4,'\( \sigma/2\varepsilon_o \;,\; \sigma/\varepsilon_o \)', NULL, false),
    (default, 4,'\( \sigma/\varepsilon_o \;,\; 0 \)', NULL, true),
    (default, 4,'\( \sigma/2\varepsilon_o \;,\; 0 \)', NULL, false),
    (default, 4,'\( 2\sigma/\varepsilon_o \;,\; \sigma/\varepsilon_o \)', NULL, false),
	(default, 5,'Increase', NULL, true),
    (default, 5,'Decrease', NULL, false),
    (default, 5,'Remains Same', NULL, false),
    (default, 5,'Depends on internal resistance of the cell', NULL, false);

INSERT INTO answers (answer_id, question_id, answer_text, answer_image_id, is_correct)
VALUES 
	(default, 6,'\large \( \sqrt{g / a}\)', NULL, false),
	(default, 6,'\large \(\sqrt{2g / a}\)', NULL, true),
	(default, 6,'\large \(\sqrt{g / 2a}\)', NULL, false),
	(default, 6,'\large \(\sqrt{ \sqrt{2} g / a}\)', NULL, false),
	(default, 7,'\(Zero\)', NULL, false),
	(default, 7,'\(\lambda \;\omega^2 R^2 /2\)', NULL, false),
	(default, 7,'\(\lambda \;\omega^2 R^2\)', NULL, true),
	(default, 7,'\(2\lambda \;\omega^2 R^2\)', NULL, false),
	(default, 8,'\large \(\lambda g \displaystyle \biggl( \frac{1}{2} + \frac{2}{\pi}\biggr)\)', NULL, true),
	(default, 8,'\large \(\lambda g \displaystyle \biggl( \frac{\pi}{2} + \frac{2}{\pi}\biggr)\)', NULL, false),
	(default, 8,'\large \(\lambda g \displaystyle \biggl( \frac{2}{\pi}\biggr)\)', NULL, false),
	(default, 8,'\large \(None \; of\; These\)', NULL, false),
	(default, 9,'\(\dfrac{1}{9}\) \vspace{0.2 cm}', NULL, true),
	(default, 9,'\(\dfrac{1}{8}\)', NULL, false),
	(default, 9,'\(\dfrac{1}{6}\)', NULL, false),
	(default, 9,'\(\dfrac{1}{5}\)', NULL, false),
	(default, 10,'\(10\;J\)', NULL, false),
	(default, 10,'\(2\;J\)', NULL, false),
	(default, 10,'\(9.5\;J\)', NULL, true),
	(default, 10,'\(0.5\;J\)', NULL, false);

INSERT INTO answers (answer_id, question_id, answer_text, answer_image_id, is_correct)
VALUES
	(default, 11,'\( \dfrac{4}{3} \pi R^3 S \)', NULL, false),
	(default, 11,'\(\pi R^2 S \)', NULL, false),
	(default, 11,'\(8\pi R^2 S \)', NULL, false),
	(default, 11,'\( 4\pi R^2 S \)', NULL, true),
	(default, 12,'energy released in the process will be \(E(n-n^{1/3})\)', NULL, false),
	(default, 12,'energy absorbed in the process will be \(E(n-n^{1/3})\)', NULL, false),
	(default, 12,'energy released in the process will be \(E(n-n^{2/3})\)', NULL, true),
	(default, 12,'energy absorbed in the process will be \(E(n-n^{2/3})\)', NULL, false),
	(default, 13,'\(4S/R\)', NULL, false),
	(default, 13,'\(3S/R\)', NULL, false),
	(default, 13,'\(6S/R\)', NULL, true),
	(default, 13,'\(None \; of \; these\)', NULL, false),
	(default, 14,'\(4\;cm\)', NULL, false),
	(default, 14,'\(20\;cm\)', NULL, true),
	(default, 14,'\(5\;cm\)', NULL, false),
	(default, 14,'\(4.5\; cm\)', NULL, false),
	(default, 15,NULL,7, false),
	(default, 15,NULL,8, false),
	(default, 15,NULL,9, true),
	(default, 15,NULL,10, false),
	(default, 16,'The motion continues along \(+x\)-direction only', NULL, false),
	(default, 16,'The graph of \(v\) versus \(x\) would be a straight line', NULL, false),
	(default, 16,'The angular frequency of oscillation is \(4\) rad/s', NULL, false),
	(default, 16,'The total energy of oscillation is \(3\;J\)', NULL, true),
	(default, 17,'The motion of the particle is SHM with mean position at \(z = 12\;cm\)', NULL, false),
	(default, 17,'The motion of the particle is SHM with one extreme position as \(-7\;cm\)', NULL, true),
	(default, 17,'The motion of the particle is Oscillatory but not SHM', NULL, false),
	(default, 17,'Amplitude of SHM is \(17\;cm\)', NULL, false),
	(default, 18,'8', NULL, true),
	(default, 18,'12', NULL, false),
	(default, 18,'2', NULL, false),
	(default, 18,'16', NULL, false),
	(default, 19,'\(A/2\)', NULL, true),
	(default, 19,'\(\sqrt{3}A/2\)', NULL, false),
	(default, 19,'\(A/\sqrt{2}\)', NULL, false),
	(default, 19,'\(\sqrt{2}A\)', NULL, false),
	(default, 20,'\(v_o/2\)', NULL, false),
	(default, 20,'\(v_o\)', NULL, false),
	(default, 20,'\(v_o \sqrt{3/2}\)', NULL, false),
	(default, 20,'\(v_o\sqrt{3}/2\)', NULL, true),
	(default, 21,'25', NULL, false),
	(default, 21,'21', NULL, false),
	(default, 21,'17', NULL, true),
	(default, 21,'13', NULL, false),
	(default, 22,'\(D\)', NULL, false),
	(default, 22,'\(\sqrt{3}D\)', NULL, false),
	(default, 22,'\(\sqrt{5}D/2\)', NULL, true),
	(default, 22,'\(2\sqrt{2}D\)', NULL, false),
	(default, 23,'\( \displaystyle 2\pi \sqrt{\frac{m}{k}} \)', NULL, false),
	(default, 23,'\(\displaystyle \pi \sqrt{\frac{m}{k}} \)', NULL, true),
	(default, 23,'\( \displaystyle2\pi \sqrt{\frac{m}{2k}} \)', NULL, false),
	(default, 23,'\( \displaystyle4\pi \sqrt{\frac{m}{k}} \)', NULL, false),
	(default, 24,'\(\displaystyle 2\pi \sqrt{\frac{m}{k}} \)', NULL, false),
	(default, 24,'\(\displaystyle 4\pi \sqrt{\frac{m}{k}} \)', NULL, false),
	(default, 24,'\(\displaystyle \frac{3\pi}{2} \sqrt{\frac{m}{k}} \)', NULL, true),
	(default, 24,'\(\displaystyle \frac{5\pi}{2} \sqrt{\frac{m}{k}} \)', NULL, false),
	(default, 25,'\(\displaystyle \frac{2L}{3} \)', NULL, false),
	(default, 25,'\(\displaystyle \frac{11L}{12} \)', NULL, true),
	(default, 25,'\(\displaystyle \frac{L}{3} \)', NULL, false),
	(default, 25,'\(\displaystyle \frac{13L}{12} \)', NULL, false),
	(default, 26,'\(\sqrt{2}\)', NULL, false),
	(default, 26,'\(4 \)', NULL, false),
	(default, 26,'\(4\sqrt{2}\)', NULL, true),
	(default, 26,'\(2 \)', NULL, false),
	(default, 27,'\(\displaystyle\frac{3}{4}\)', NULL, false),
	(default, 27,'\(\displaystyle\frac{3}{5}\)', NULL, false),
	(default, 27,'\(\displaystyle\frac{1}{4}\)', NULL, true),
	(default, 27,'\(\displaystyle\frac{1}{2} \)', NULL, false),
	(default, 28,'\(v\)', NULL, false),
	(default, 28,'\(v\cos\theta\)', NULL, false),
	(default, 28,'\(\sqrt{2}v\)', NULL, false),
	(default, 28,'\(v\sec\theta \)', NULL, true),
	(default, 29,'\(20\;J\)', NULL, false),
	(default, 29,'\(100/7\;J\)', NULL, false),
	(default, 29,'\(10\;J\)', NULL, true),
	(default, 29,'\(15\;J\)', NULL, false),
	(default, 30,'\( \displaystyle\omega_0 \)', NULL, false),
	(default, 30,'\( \displaystyle\frac{3\omega_0}{4} \)', NULL, false),
	(default, 30,'\( \displaystyle\frac{\omega_0}{2} \)', NULL, false),
	(default, 30,'\( \displaystyle\frac{\omega_0}{4} \)', NULL, true);

































	
	

	











































































































































































