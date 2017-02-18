#!/usr/bin/perl

use strict;
use warnings;

package Urlify;

use Exporter qw(import);

our @EXPORT_OK = qw(urlify);

sub count_spaces {
  my $array = shift;
  my $count = 0;

  foreach my $char (@$array) {
    if ($char eq ' ') {
      $count++;
    }
  }

  return $count;
}

# Runtime Complexity:
# Space Complexity:
sub urlify {
    my $string = shift;
    my @array = split '', $string;
    my $space_count = count_spaces(\@array);

    # space -> %20
    my $write_idx = $#array + ($space_count  * 2);
    foreach my $read_idx (reverse 0..$#array) {
      my $char = $array[$read_idx];

      if ($char eq ' ') {
        $array[$write_idx] = '0';
        $array[$write_idx - 1] = '2';
        $array[$write_idx - 2] = '%';
        $write_idx -= 3;
      } else
      {
        $array[$write_idx] = $char;
        $write_idx--;
      }

    }

    return join '', @array;
}

1;
