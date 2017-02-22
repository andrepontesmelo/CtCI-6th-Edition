#!/usr/bin/perl

use strict;
use warnings;

package ZeroMatrix;

use Exporter qw(import);

our @EXPORT_OK = qw(zero_matrix);

sub zero_matrix {
    my $matrix = shift;
    my $n      = @$matrix;
    my $m      = @{ $matrix->[0] };

    my $zerofirstrow = 0;
    for my $j ( 0 .. $m - 1 ) {
        $zerofirstrow |= $matrix->[0][$j] == 0;
    }

    my $zerofirstcolumn = 0;
    for my $i ( 0 .. $n - 1 ) {
        $zerofirstcolumn |= $matrix->[$i][0] == 0;
    }

    for my $i ( 1 .. $n - 1 ) {
        for my $j ( 1 .. $m - 1 ) {
            if ( $matrix->[$i][$j] == 0 ) {
                $matrix->[0][$j] = 0;
                $matrix->[$i][0] = 0;
            }
        }
    }

    for my $i ( 1 .. $n - 1 ) {
        for my $j ( 1 .. $m - 1 ) {
            if ( $matrix->[0][$j] == 0 || $matrix->[$i][0] == 0 ) {
                $matrix->[$i][$j] = 0;
            }
        }
    }

    if ($zerofirstrow) {
        for my $j ( 0 .. $m - 1 ) {
            $matrix->[0][$j] = 0;
        }
    }

    if ($zerofirstcolumn) {
        for my $i ( 0 .. $n - 1 ) {
            $matrix->[$i][0] = 0;
        }
    }

    return $matrix;
}

1;
