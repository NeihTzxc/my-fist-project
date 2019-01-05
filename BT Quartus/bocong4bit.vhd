library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.STD_LOGIC_UNSIGNED.ALL;

entity bocong4bit is
	port(
		a: in std_logic_vector(3 downto 0);
		b: in std_logic_vector(3 downto 0);
		cin: in std_logic;
		sum: out std_logic_vector(3 downto 0);
		cout: out std_logic
	);
end entity;

architecture bocong4bit of bocong4bit is
	signal a_temp: std_logic_vector(4 downto 0);
	signal b_temp: std_logic_vector(4 downto 0);
	signal sum_temp: std_logic_vector(4 downto 0);
	begin
		a_temp <= '0' & a;
		b_temp <= '0' & b;
		sum_temp <= a_temp + b_temp + cin;
		sum <= sum_temp(1 downto 0);
		cout <= sum_temp(2);
	end bocong4bit;
	