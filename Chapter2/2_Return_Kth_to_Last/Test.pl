#!/usr/bin/perl

use strict;
use warnings;

use ReturnKthToLast qw(return_kth_to_last);
use Data::Dumper qw( Dumper );

local $Data::Dumper::Indent = 0;
local $Data::Dumper::Terse  = 1;

use Test::More tests => 4;

is(Dumper(return_kth_to_last([[[undef,2],1]], 1)), 2, 'returing last item' );
is(Dumper(return_kth_to_last([[[undef,2],1]], 2)), 1, 'returing 2nd to last item' );
is(Dumper(return_kth_to_last([[[[undef,1],2],3]], 3)), 3, 'returing 3th to last item' );
is(Dumper(return_kth_to_last([[[[[[[[undef,7],8],9],4],3],2],1]], 3)), 9, 'returing 3th to last item in a big list' );
