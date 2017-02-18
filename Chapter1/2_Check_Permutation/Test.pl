#!/usr/bin/perl

use strict;
use warnings;

use CheckPermutation qw(check_permutation);

use Test::More tests => 5;

ok( check_permutation( 'abc', 'bca' ), 'small permutation' );
ok( !check_permutation( 'abc', 'bcaw' ), 'small non permutation' );
ok( check_permutation( '', '' ), 'both empty strings' );
ok( !check_permutation( 'abc', '' ), 'one empty string only' );
ok( check_permutation( 'i am a test', '  iaam sett' ),
    'i am a test permutation' );
