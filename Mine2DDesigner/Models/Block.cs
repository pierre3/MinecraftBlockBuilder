﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mine2DDesigner.Models
{
    public class Block
    {
        public static IReadOnlyList<Block> Definitions { get; }

        public ushort Index { get; }
        public string Name { get; init; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Textures Textures { get; init; }

        public Block(ushort index, string name)
        {
            Index = index;
            Name = name;
            Textures = name == "air" ? new Textures() : new Textures(name);
        }

        static Block()
        {
            var items = new List<Block>();
            ushort key = 0;
            items.Add(new Block(key++, "air"));
            items.Add(new Block(key++, "stone"));
            items.Add(new Block(key++, "granite"));
            items.Add(new Block(key++, "polished_granite"));
            items.Add(new Block(key++, "diorite"));
            items.Add(new Block(key++, "polished_diorite")); 
            items.Add(new Block(key++, "andesite"));
            items.Add(new Block(key++, "polished_andesite"));
            items.Add(new Block(key++, "deepslate"));
            items.Add(new Block(key++, "polished_deepslate"));
            items.Add(new Block(key++, "calcite"));
            items.Add(new Block(key++, "tuff"));
            items.Add(new Block(key++, "grass_block"));
            items.Add(new Block(key++, "dirt"));
            items.Add(new Block(key++, "coarse_dirt"));
            items.Add(new Block(key++, "podzol"));
            items.Add(new Block(key++, "rooted_dirt"));
            items.Add(new Block(key++, "mud"));
            items.Add(new Block(key++, "crimson_nylium"));
            items.Add(new Block(key++, "warped_nylium"));
            items.Add(new Block(key++, "cobblestone"));
            items.Add(new Block(key++, "oak_planks"));
            items.Add(new Block(key++, "spruce_planks"));
            items.Add(new Block(key++, "birch_planks"));
            items.Add(new Block(key++, "jungle_planks"));
            items.Add(new Block(key++, "acacia_planks"));
            items.Add(new Block(key++, "dark_oak_planks"));
            items.Add(new Block(key++, "mangrove_planks"));
            items.Add(new Block(key++, "crimson_planks"));
            items.Add(new Block(key++, "warped_planks"));
            items.Add(new Block(key++, "bedrock"));
            items.Add(new Block(key++, "sand"));
            items.Add(new Block(key++, "red_sand"));
            items.Add(new Block(key++, "gravel"));
            items.Add(new Block(key++, "coal_ore"));
            items.Add(new Block(key++, "deepslate_coal_ore"));
            items.Add(new Block(key++, "iron_ore"));
            items.Add(new Block(key++, "deepslate_iron_ore"));
            items.Add(new Block(key++, "copper_ore"));
            items.Add(new Block(key++, "deepslate_copper_ore"));
            items.Add(new Block(key++, "gold_ore"));
            items.Add(new Block(key++, "deepslate_gold_ore"));
            items.Add(new Block(key++, "redstone_ore"));
            items.Add(new Block(key++, "deepslate_redstone_ore"));
            items.Add(new Block(key++, "emerald_ore"));
            items.Add(new Block(key++, "deepslate_emerald_ore"));
            items.Add(new Block(key++, "lapis_ore"));
            items.Add(new Block(key++, "deepslate_lapis_ore"));
            items.Add(new Block(key++, "diamond_ore"));
            items.Add(new Block(key++, "deepslate_diamond_ore"));
            items.Add(new Block(key++, "nether_gold_ore"));
            items.Add(new Block(key++, "nether_quartz_ore"));
            items.Add(new Block(key++, "ancient_debris"));
            items.Add(new Block(key++, "coal_block"));
            items.Add(new Block(key++, "raw_iron_block"));
            items.Add(new Block(key++, "raw_copper_block"));
            items.Add(new Block(key++, "raw_gold_block"));
            items.Add(new Block(key++, "amethyst_block"));
            items.Add(new Block(key++, "budding_amethyst"));
            items.Add(new Block(key++, "iron_block"));
            items.Add(new Block(key++, "copper_block"));
            items.Add(new Block(key++, "gold_block"));
            items.Add(new Block(key++, "diamond_block"));
            items.Add(new Block(key++, "netherite_block"));
            items.Add(new Block(key++, "exposed_copper"));
            items.Add(new Block(key++, "weathered_copper"));
            items.Add(new Block(key++, "weathered_copper"));
            items.Add(new Block(key++, "cut_copper"));
            items.Add(new Block(key++, "exposed_cut_copper"));
            items.Add(new Block(key++, "weathered_cut_copper"));
            items.Add(new Block(key++, "oxidized_cut_copper"));
            items.Add(new Block(key++, "oak_log"));
            items.Add(new Block(key++, "spruce_log"));
            items.Add(new Block(key++, "birch_log"));
            items.Add(new Block(key++, "jungle_log"));
            items.Add(new Block(key++, "acacia_log"));
            items.Add(new Block(key++, "dark_oak_log"));
            items.Add(new Block(key++, "mangrove_log"));
            items.Add(new Block(key++, "mangrove_roots"));
            items.Add(new Block(key++, "muddy_mangrove_roots"));
            items.Add(new Block(key++, "crimson_stem"));
            items.Add(new Block(key++, "warped_stem"));
            items.Add(new Block(key++, "stripped_oak_log"));
            items.Add(new Block(key++, "stripped_spruce_log"));
            items.Add(new Block(key++, "stripped_birch_log"));
            items.Add(new Block(key++, "stripped_jungle_log"));
            items.Add(new Block(key++, "stripped_acacia_log"));
            items.Add(new Block(key++, "stripped_dark_oak_log"));
            items.Add(new Block(key++, "stripped_mangrove_log"));
            items.Add(new Block(key++, "stripped_crimson_stem"));
            items.Add(new Block(key++, "stripped_warped_stem"));
            items.Add(new Block(key++, "sponge"));
            items.Add(new Block(key++, "wet_sponge"));
            items.Add(new Block(key++, "glass"));
            items.Add(new Block(key++, "tinted_glass"));
            items.Add(new Block(key++, "lapis_block"));
            items.Add(new Block(key++, "sandstone"));
            items.Add(new Block(key++, "chiseled_sandstone"));
            items.Add(new Block(key++, "cut_sandstone"));
            items.Add(new Block(key++, "white_wool"));
            items.Add(new Block(key++, "orange_wool"));
            items.Add(new Block(key++, "magenta_wool"));
            items.Add(new Block(key++, "light_blue_wool"));
            items.Add(new Block(key++, "yellow_wool"));
            items.Add(new Block(key++, "lime_wool"));
            items.Add(new Block(key++, "pink_wool"));
            items.Add(new Block(key++, "gray_wool"));
            items.Add(new Block(key++, "light_gray_wool"));
            items.Add(new Block(key++, "cyan_wool"));
            items.Add(new Block(key++, "purple_wool"));
            items.Add(new Block(key++, "blue_wool"));
            items.Add(new Block(key++, "brown_wool"));
            items.Add(new Block(key++, "green_wool"));
            items.Add(new Block(key++, "red_wool"));
            items.Add(new Block(key++, "black_wool"));
            items.Add(new Block(key++, "smooth_stone"));
            items.Add(new Block(key++, "bricks"));
            items.Add(new Block(key++, "bookshelf"));
            items.Add(new Block(key++, "mossy_cobblestone"));
            items.Add(new Block(key++, "obsidian"));
            items.Add(new Block(key++, "purpur_pillar"));
            items.Add(new Block(key++, "ice"));
            items.Add(new Block(key++, "clay"));
            items.Add(new Block(key++, "pumpkin"));
            items.Add(new Block(key++, "jack_o_lantern"));
            items.Add(new Block(key++, "netherrack"));
            items.Add(new Block(key++, "soul_sand"));
            items.Add(new Block(key++, "soul_soil"));
            items.Add(new Block(key++, "basalt"));
            items.Add(new Block(key++, "polished_basalt"));
            items.Add(new Block(key++, "smooth_basalt"));
            items.Add(new Block(key++, "glowstone"));
            items.Add(new Block(key++, "stone_bricks"));
            items.Add(new Block(key++, "mossy_stone_bricks"));
            items.Add(new Block(key++, "cracked_stone_bricks"));
            items.Add(new Block(key++, "chiseled_stone_bricks"));
            items.Add(new Block(key++, "packed_mud"));
            items.Add(new Block(key++, "mud_bricks"));
            items.Add(new Block(key++, "deepslate_bricks"));
            items.Add(new Block(key++, "cracked_deepslate_bricks"));
            items.Add(new Block(key++, "deepslate_tiles"));
            items.Add(new Block(key++, "cracked_deepslate_tiles"));
            items.Add(new Block(key++, "chiseled_deepslate"));
            items.Add(new Block(key++, "reinforced_deepslate"));
            items.Add(new Block(key++, "melon"));
            items.Add(new Block(key++, "mycelium"));
            items.Add(new Block(key++, "nether_bricks"));
            items.Add(new Block(key++, "cracked_nether_bricks"));
            items.Add(new Block(key++, "chiseled_nether_bricks"));
            items.Add(new Block(key++, "end_stone"));
            items.Add(new Block(key++, "end_stone_bricks"));
            items.Add(new Block(key++, "emerald_block"));
            items.Add(new Block(key++, "chiseled_quartz_block"));
            items.Add(new Block(key++, "quartz_block"));
            items.Add(new Block(key++, "quartz_pillar"));
            items.Add(new Block(key++, "white_terracotta"));
            items.Add(new Block(key++, "orange_terracotta"));
            items.Add(new Block(key++, "magenta_terracotta"));
            items.Add(new Block(key++, "light_blue_terracotta"));
            items.Add(new Block(key++, "yellow_terracotta"));
            items.Add(new Block(key++, "lime_terracotta"));
            items.Add(new Block(key++, "pink_terracotta"));
            items.Add(new Block(key++, "gray_terracotta"));
            items.Add(new Block(key++, "light_gray_terracotta"));
            items.Add(new Block(key++, "cyan_terracotta"));
            items.Add(new Block(key++, "purple_terracotta"));
            items.Add(new Block(key++, "blue_terracotta"));
            items.Add(new Block(key++, "brown_terracotta"));
            items.Add(new Block(key++, "green_terracotta"));
            items.Add(new Block(key++, "red_terracotta"));
            items.Add(new Block(key++, "black_terracotta"));
            items.Add(new Block(key++, "hay_block"));
            items.Add(new Block(key++, "terracotta"));
            items.Add(new Block(key++, "packed_ice"));
            items.Add(new Block(key++, "white_stained_glass"));
            items.Add(new Block(key++, "orange_stained_glass"));
            items.Add(new Block(key++, "magenta_stained_glass"));
            items.Add(new Block(key++, "light_blue_stained_glass"));
            items.Add(new Block(key++, "yellow_stained_glass"));
            items.Add(new Block(key++, "lime_stained_glass"));
            items.Add(new Block(key++, "pink_stained_glass"));
            items.Add(new Block(key++, "gray_stained_glass"));
            items.Add(new Block(key++, "light_gray_stained_glass"));
            items.Add(new Block(key++, "cyan_stained_glass"));
            items.Add(new Block(key++, "purple_stained_glass"));
            items.Add(new Block(key++, "blue_stained_glass"));
            items.Add(new Block(key++, "brown_stained_glass"));
            items.Add(new Block(key++, "green_stained_glass"));
            items.Add(new Block(key++, "red_stained_glass"));
            items.Add(new Block(key++, "black_stained_glass"));
            items.Add(new Block(key++, "prismarine"));
            items.Add(new Block(key++, "prismarine_bricks"));
            items.Add(new Block(key++, "dark_prismarine"));
            items.Add(new Block(key++, "sea_lantern"));
            items.Add(new Block(key++, "red_sandstone"));
            items.Add(new Block(key++, "chiseled_red_sandstone"));
            items.Add(new Block(key++, "cut_red_sandstone"));
            items.Add(new Block(key++, "nether_wart_block"));
            items.Add(new Block(key++, "warped_wart_block"));
            items.Add(new Block(key++, "red_nether_bricks"));
            items.Add(new Block(key++, "nether_wart_block"));
            items.Add(new Block(key++, "warped_wart_block"));
            items.Add(new Block(key++, "red_nether_bricks"));
            items.Add(new Block(key++, "bone_block"));
            items.Add(new Block(key++, "white_concrete"));
            items.Add(new Block(key++, "orange_concrete"));
            items.Add(new Block(key++, "magenta_concrete"));
            items.Add(new Block(key++, "light_blue_concrete"));
            items.Add(new Block(key++, "yellow_concrete"));
            items.Add(new Block(key++, "lime_concrete"));
            items.Add(new Block(key++, "pink_concrete"));
            items.Add(new Block(key++, "gray_concrete"));
            items.Add(new Block(key++, "light_gray_concrete"));
            items.Add(new Block(key++, "cyan_concrete"));
            items.Add(new Block(key++, "purple_concrete"));
            items.Add(new Block(key++, "blue_concrete"));
            items.Add(new Block(key++, "brown_concrete"));
            items.Add(new Block(key++, "green_concrete"));
            items.Add(new Block(key++, "red_concrete"));
            items.Add(new Block(key++, "black_concrete"));
            items.Add(new Block(key++, "white_concrete_powder"));
            items.Add(new Block(key++, "orange_concrete_powder"));
            items.Add(new Block(key++, "magenta_concrete_powder"));
            items.Add(new Block(key++, "light_blue_concrete_powder"));
            items.Add(new Block(key++, "yellow_concrete_powder"));
            items.Add(new Block(key++, "lime_concrete_powder"));
            items.Add(new Block(key++, "pink_concrete_powder"));
            items.Add(new Block(key++, "gray_concrete_powder"));
            items.Add(new Block(key++, "light_gray_concrete_powder"));
            items.Add(new Block(key++, "cyan_concrete_powder"));
            items.Add(new Block(key++, "purple_concrete_powder"));
            items.Add(new Block(key++, "blue_concrete_powder"));
            items.Add(new Block(key++, "brown_concrete_powder"));
            items.Add(new Block(key++, "green_concrete_powder"));
            items.Add(new Block(key++, "red_concrete_powder"));
            items.Add(new Block(key++, "black_concrete_powder"));
            items.Add(new Block(key++, "dead_tube_coral_block"));
            items.Add(new Block(key++, "dead_brain_coral_block"));
            items.Add(new Block(key++, "dead_bubble_coral_block"));
            items.Add(new Block(key++, "dead_fire_coral_block"));
            items.Add(new Block(key++, "dead_horn_coral_block"));
            items.Add(new Block(key++, "tube_coral_block"));
            items.Add(new Block(key++, "brain_coral_block"));
            items.Add(new Block(key++, "bubble_coral_block"));
            items.Add(new Block(key++, "fire_coral_block"));
            items.Add(new Block(key++, "horn_coral_block"));
            items.Add(new Block(key++, "blue_ice"));
            items.Add(new Block(key++, "crying_obsidian"));
            items.Add(new Block(key++, "blackstone"));
            items.Add(new Block(key++, "gilded_blackstone"));
            items.Add(new Block(key++, "polished_blackstone"));
            items.Add(new Block(key++, "chiseled_polished_blackstone"));
            items.Add(new Block(key++, "polished_blackstone_bricks"));
            items.Add(new Block(key++, "cracked_polished_blackstone_bricks"));
            Definitions = new ReadOnlyCollection<Block>(items);
       
        }

    }

}
