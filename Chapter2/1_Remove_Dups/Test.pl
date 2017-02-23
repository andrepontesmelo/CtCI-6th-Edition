#!/usr/bin/perl

use strict;
use warnings;

use RemoveDups qw(remove_dups);
use Data::Dumper qw( Dumper );

use Test::More tests => 6;

local $Data::Dumper::Indent = 0;
local $Data::Dumper::Terse  = 1;

is(Dumper(remove_dups([[[undef,2],1]])), '[[[undef,2],1]]', 'two items without dup' );
is(Dumper(remove_dups([[[undef,2],2]])), '[[undef,2]]', 'two items with dup' );
is(Dumper(remove_dups([[undef,5]])), '[[undef,5]]', 'one item' );
is(Dumper(remove_dups([undef])), '[undef]', 'empty list' );
is(Dumper(remove_dups([[[[[[[[undef, 5], 5], 9], 3], 4], 2], 1]])), '[[[[[[[undef,5],9],3],4],2],1]]', '1-5 and 9 with dup' );
is(Dumper(remove_dups([[[[[[[[undef, 5], 5], 9], 3], 4], 9], 1]])), '[[[[[[undef,5],3],4],9],1]]', '1-5 with dup' );
