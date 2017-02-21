#!/usr/bin/perl

use strict;
use warnings;

use RotateMatrix qw(rotate_matrix);

use Test::More tests => 4;

my @m1x1 = (
    [ 1]
);

my @m1x1_rotated = (
    [ 1]
);

my @m2x2 = (
    [ 1, 2 ],
    [ 3, 4 ]
);

my @m2x2_rotated = (
    [ 3, 1 ],
    [ 4, 2 ]
);

my @m3x3 = (
    [ 1, 2, 3],
    [ 4, 5, 6],
    [ 7, 8, 9]
);

my @m3x3_rotated = (
    [ 7, 4, 1],
    [ 8, 5, 2],
    [ 9, 6, 3]
);

my @m4x4 = (
    [ 1,   2,  3,  4],
    [ 5,   6,  7,  8],
    [ 9,  10, 11, 12],
    [ 13, 14, 15, 16]
);

my @m4x4_rotated = (
    [ 13,  9,  5, 1],
    [ 14, 10,  6, 2],
    [ 15, 11,  7, 3],
    [ 16, 12,  8, 4]
);

ok( @{rotate_matrix(\@m1x1)} ~~ @m1x1_rotated, '1x1 matrix' );
ok( @{rotate_matrix(\@m2x2)} ~~ @m2x2_rotated, '2x2 matrix' );
ok( @{rotate_matrix(\@m3x3)} ~~ @m3x3_rotated, '3x3 matrix' );
ok( @{rotate_matrix(\@m4x4)} ~~ @m4x4_rotated, '4x4 matrix' );
