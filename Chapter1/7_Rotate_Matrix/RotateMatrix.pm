#!/usr/bin/perl

use strict;
use warnings;

package RotateMatrix;

use Exporter qw(import);

our @EXPORT_OK = qw(rotate_matrix);

sub rotate_pos {
    my $i           = shift;
    my $j           = shift;
    my $matrix_size = shift;

    return ( 'i' => $j, 'j' => $matrix_size - $i - 1 );
}

sub rotate_matrix {
    my $matrix      = shift;
    my $matrix_size = ( scalar @$matrix );
    my @new_matrix  = ();

    foreach my $i ( 0 .. $matrix_size - 1 ) {
        foreach my $j ( 0 .. $matrix_size - 1 ) {
            my %new_pos = rotate_pos( $i, $j, $matrix_size );
            $new_matrix[ $new_pos{'i'}][ $new_pos{'j'} ] = $matrix->[$i][$j];
        }
    }

    return \@new_matrix;
}

1;
