	#!/usr/bin/perl
	use strict;
	use warnings;
	use Benchmark qw(cmpthese);
	use StringCompressionConcat qw(string_compression);
	use StringCompressionJoin qw(string_compression);
	use StringCompressionList qw(string_compression);

	my $input;
	$input .= [qw(G A T C)]->[rand 4] for 1 .. 10000;

	sub frequency_concat {
		return StringCompressionConcat::string_compression($input);
	}

	sub frequency_join {
		return StringCompressionJoin::string_compression($input);
	}

	sub frequency_list {
		return StringCompressionList::string_compression($input);
	}

	cmpthese(-5, # Run each for at least 5 second(s)
		{
			concat => \&frequency_concat,
			join => \&frequency_join,
			list => \&frequency_list
		}
	);
