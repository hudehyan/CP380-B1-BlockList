using System;
using System.Collections.Generic;

namespace CP380_B1_BlockList.Models
{
    public class BlockList
    {
        public IList<Block> Chain { get; set; }

        public int Difficulty { get; set; } = 2;

        public BlockList()
        {
            Chain = new List<Block>();
            MakeFirstBlock();
        }

        public void MakeFirstBlock()
        {
            var block = new Block(DateTime.Now, null, new List<Payload>());
            block.Mine(Difficulty);
            Chain.Add(block);
        }

        public void AddBlock(Block block)
        {
            // TODO
             Block latestBlock = Chain[Chain.Count - 1];
            block.Nonce = latestBlock.Nonce + 1;
            block.PreviousHash = latestBlock.Hash;
            block.Mine(this.Difficulty);
            Chain.Add(block);
        }

        public bool IsValid()
        {
            // TODO
            for (int i = 1; i < Chain.Count; i++)
            {
                Block c= Chain[i];
                Block p= Chain[i - 1];

                if (c.Hash != c.CalculateHash())
                {
                    return false;
                }

                if (c.PreviousHash != p.Hash)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
