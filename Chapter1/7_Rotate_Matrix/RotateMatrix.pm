#!/usr/bin/perl
use strict;
use warnings;

package RotateMatrix;

use Exporter qw(import);

our @EXPORT_OK = qw(rotate_matrix);

sub get_next_pos {
    my $pos = shift;
    my $n   = shift;

    my @next_pos = ( $pos->[1], $n - $pos->[0] - 1 );
    return \@next_pos;
}

sub ceil {
    my $number = shift;
    return sprintf( "%.0f", $number );
}

sub rotate_matrix {
    my $matrix = shift;
    my $n      = ( scalar @$matrix );

    foreach my $i ( 0 .. int( $n / 2 ) - 1 ) {
        foreach my $j ( $i .. $n - 2 - $i ) {
            my @pos = ( $i, $j );
            rotate_pos( $matrix, \@pos );
        }
    }

    return $matrix;
}

sub rotate_pos {
    my $matrix = shift;
    my $pos    = shift;
    my $n      = ( scalar @$matrix );

    # Queue will hold at most 2 items.
    my @queue = ( $matrix->[ $pos->[0] ][ $pos->[1] ] );

    for my $iteration ( 1 .. 4 ) {
        my $next_pos = get_next_pos( $pos, $n );
        push @queue, $matrix->[ $next_pos->[0] ][ $next_pos->[1] ];
        $matrix->[ $next_pos->[0] ][ $next_pos->[1] ] = shift @queue;
        $pos = $next_pos;
    }
}

1;
