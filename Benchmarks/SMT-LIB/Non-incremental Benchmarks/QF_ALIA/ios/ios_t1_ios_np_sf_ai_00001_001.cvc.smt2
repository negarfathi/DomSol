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
(declare-fun earray_3 () (Array Int Int))
(declare-fun elem_0 () Int)
(declare-fun elem_2 () Int)
(declare-fun elem_4 () Int)
(declare-fun a () (Array Int Int))
(assert (= earray_3 (store a elem_0 elem_2)))
(assert (not (= elem_2 elem_4)))
(check-sat)
(exit)
