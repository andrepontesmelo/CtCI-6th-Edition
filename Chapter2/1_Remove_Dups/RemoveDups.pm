#!/usr/bin/perl
use strict;
use warnings;

package RemoveDups;

use Exporter qw(import);
our @EXPORT_OK = qw(remove_dups);

sub remove_dups {
    my $list = shift;
    my $last = $list;
    my %set;

    while ($last->[0]) {
        my $node = $last->[0];

        if ( exists $set{ $node->[1] } ) {
            $last->[0] = $node->[0];
        }
        else {
            $set{ $node->[1] } = undef;
            $last = $node;
        }

        $last = $node;
    }

    $list;
}

1;
