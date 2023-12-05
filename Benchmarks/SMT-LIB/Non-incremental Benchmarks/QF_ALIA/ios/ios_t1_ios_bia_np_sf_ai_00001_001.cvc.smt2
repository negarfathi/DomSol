(set-info :smt-lib-version 2.6)
(set-logic QF_ALIA)
(set-info :source |
Benchmarks used in the followin paper:
Big proof engines as little proof engines: new results on rewrite-based satisfiability procedure
Alessandro Armando, Maria Paola Bonacina, Silvio Ranise, Stephan Schulz. 
PDPAR'05
http://www.ai.dist.unige.it/pdpar05/


|)
(set-info :category "crafted")
(set-info :status sat)
(declare-fun a_3 () (Array Int Int))
(declare-fun e_0 () Int)
(declare-fun e_2 () Int)
(declare-fun e_5 () Int)
(declare-fun a () (Array Int Int))
(assert (= a_3 (store a e_0 e_2)))
(assert (not (= e_2 e_5)))
(check-sat)
(exit)
