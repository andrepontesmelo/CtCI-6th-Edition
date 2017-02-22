#!/usr/bin/perl

use strict;
use warnings;

use ZeroMatrix qw(zero_matrix);

use Test::More tests => 4;

my @m1x1 = (
    [ 1]
);

my @m1x1_after = (
    [ 1]
);

my @m2x2 = (
    [ 1, 0 ],
    [ 3, 4 ]
);

my @m2x2_after = (
    [ 0, 0 ],
    [ 3, 0 ]
);

my @m3x3 = (
    [ 1, 2, 3],
    [ 0, 5, 6],
    [ 7, 8, 9]
);

my @m3x3_after = (
    [ 0, 2, 3],
    [ 0, 0, 0],
    [ 0, 8, 9]
);

my @m4x4 = (
    [ 1,   2,  3,  4],
    [ 5,   6,  7,  8],
    [ 9,   0, 0,  12],
    [ 13, 14, 15, 16]
);

my @m4x4_after = (
    [  1, 0, 0,  4],
    [  5, 0, 0,  8],
    [  0, 0, 0,  0],
    [ 13, 0, 0, 16]
);

ok( @{zero_matrix(\@m1x1)} ~~ @m1x1_after, '1x1 matrix' );
ok( @{zero_matrix(\@m2x2)} ~~ @m2x2_after, '2x2 matrix' );
ok( @{zero_matrix(\@m3x3)} ~~ @m3x3_after, '3x3 matrix' );
ok( @{zero_matrix(\@m4x4)} ~~ @m4x4_after, '4x4 matrix' );
