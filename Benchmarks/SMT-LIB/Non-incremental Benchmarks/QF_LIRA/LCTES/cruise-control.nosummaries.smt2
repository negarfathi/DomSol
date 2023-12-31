(set-info :smt-lib-version 2.6)
(set-logic QF_LIRA)
(set-info :source |Submitted by David Monniaux <David.Monniaux@imag.fr>|)
(set-info :category "industrial")
(set-info :status sat)
(declare-fun x_CarSpeed_ () Real)
(declare-fun x_conv138_ () Int)
(declare-fun x_conv142_ () Int)
(declare-fun x_sub_ () Real)
(assert (= x_sub_ (- x_CarSpeed_ 2.5)))
(assert (= x_conv138_ x_conv142_))
(check-sat)
(exit)
