#!/usr/bin/perl

use strict;
use warnings;

use OneAway qw(one_away);

use Test::More tests => 4;

ok( one_away( 'pale',  'ple' ),  '1 insert' );
ok( one_away( 'pales', 'pale' ), '1 remove' );
ok( one_away( 'pale',  'bale' ), '1 replace' );
ok( !one_away( 'pale', 'bake' ), '2 replaces' );
