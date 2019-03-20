ALTER TABLE skladisno_mjesto
ADD
mjesto NCHAR(20)
CONSTRAINT ck_provjera CHECK
(mjesto IN ('Zagreb' , 'Rijeka' , 'Sisak'))
GO