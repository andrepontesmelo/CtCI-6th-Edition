#!/usr/bin/perl
use strict;
use warnings;

package RemoveDups;

use Exporter qw(import);
our @EXPORT_OK = qw(remove_dups);

sub delete_values {
    my $list  = shift;
    my $value = shift;
    my $last  = $list;
    while ( $last->[0] ) {
        my $node = $last->[0];

        if ( $node->[1] == $value ) {
            $last->[0] = $node->[0];
        }
        else {
            $last = $node;
        }
    }

    return 0;
}

sub remove_dups {
    my $list = shift;
    my $last = $list;

    while ( $last->[0] ) {
        my $node = $last->[0];

        delete_values( $node, $node->[1] );
        $last = $node;
    }

    $list;
}

1;
