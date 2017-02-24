#!/usr/bin/perl

use strict;
use warnings;


package ReturnKthToLast;

use Exporter qw(import);

our @EXPORT_OK = qw(return_kth_to_last);

sub return_kth_to_last {
    my $list = shift;
    my $k = shift;
    my $last = $list;

    my $counter = 1;
    my $p2;

    while ($last->[0]) {
      my $node = $last->[0];

      if ($counter == $k) {
        $p2 = $list->[0];
      } elsif ($counter > $k) {
        $p2 = $p2->[0];
      }

      $last = $node;
      $counter++;
    }

    return $p2->[1];
}

1;
