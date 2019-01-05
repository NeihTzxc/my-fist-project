library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.STD_LOGIC_UNSIGNED.ALL;

entity bocong8bit is
	port(
		a, b: in std_logic_vector(7 downto 0);
		cin: in std_logic;
		sum: out std_logic_vector(7 downto 0);
		cout: out std_logic
	);
end entity;

architecture bocong8bit of bocong8bit is
	signal a_temp: std_logic_vector(8 downto 0);
	signal b_temp: std_logic_vector(8 downto 0);
	signal sum_temp: std_logic_vector(8 downto 0);
	begin
		a_temp <= '0' & a;
		b_temp <= '0' & b;
		sum_temp <= a_temp + b_temp + cin;
		sum <= sum_temp(7 downto 0);
		cout <= sum_temp(8);
	end bocong8bit;
	