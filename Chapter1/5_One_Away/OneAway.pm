#!/usr/bin/perl

use strict;
use warnings;

package OneAway;

use Exporter qw(import);

our @EXPORT_OK = qw(one_away);

sub one_away {
    my $a = shift;
    my $b = shift;

    return 0 if abs( length($a) - length($b) ) > 1;

    my $diff_count = 0;
    my $idx_b      = 0;
    for my $idx_a ( 0 .. length($a) - 1 ) {

        my $same = substr( $a, $idx_a, 1 ) eq substr( $b, $idx_b, 1 );
        $idx_b++;

        next if $same;

        $diff_count++;

        if ( length($a) > length($b) ) {
            $idx_b--;
        }
        elsif ( length($a) < length($b) ) {
            $idx_b++;
        }

        return 0 if $diff_count > 1;
    }

    return 1;
}

1;
