(declare-fun I0_8 () Int)
(declare-fun PCTEMP_LHS_3 () String)
(declare-fun T0_10 () String)
(declare-fun T2_8 () String)
(declare-fun T3_8 () String)
(declare-fun var_0xINPUT_202 () String)
(assert (= I0_8 (str.len PCTEMP_LHS_3)))
(assert (= T2_8 (str.++ PCTEMP_LHS_3 T3_8)))
(assert (= T0_10 PCTEMP_LHS_3))
(check-sat)
